// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Transactions;
using Azure.Data.Batch.Models;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;

namespace Azure.Data.Batch
{
    public class TaskManager
    {
        private const int maxTaskCount = 100;

        private TaskClient taskClient;
        private string jobId;
        private Queue<Task> pendingTasks;
        private List<TaskSubmitter> activeSubmitters = new List<TaskSubmitter>();
        private int maxSubmitters;

        public string NamingFragment { get; set; }

        public TaskManager(TaskClient taskClient, string jobId, IEnumerable<Task> tasks, int maxParralelSubmitters = 1)
        {
            this.taskClient = taskClient;
            this.jobId = jobId;
            this.maxSubmitters = maxParralelSubmitters;
            this.pendingTasks = new Queue<Task>(tasks);
        }

        public async System.Threading.Tasks.Task Start()
        {
            await UploadFilesAsync().ConfigureAwait(false);
            AddSubmitters();

            while (IsFinished() == false)
            {
                AddSubmitters();
            }
        }

        #region

        private async System.Threading.Tasks.Task StageFilesAsync()
        {
            IEnumerable<IFileStagingProvider> allFileProviders = pendingTasks.SelectMany(t => t.FilesToStage);

            await StageFilesAsync(allFileProviders, NamingFragment).ConfigureAwait(false);
        }

        protected async System.Threading.Tasks.Task StageFilesAsync(IEnumerable<IFileStagingProvider> fileProviders, string namingFragment)
        {
            foreach (IFileStagingProvider fileProvider in fileProviders)
            {

            }
        }

        private async System.Threading.Tasks.Task UploadFilesAsync()
        {
            IEnumerable<ResourceFile> allFiles = pendingTasks.SelectMany(t => t.ResourceFiles);

            BlobServiceClient serviceClient = new("CONNECTIONSTRING");
            foreach (ResourceFile file in allFiles)
            {
                await UploadFileAsync(serviceClient, file).ConfigureAwait(false);
            }
        }

        public async System.Threading.Tasks.Task UploadFileAsync(BlobServiceClient serviceClient, ResourceFile file)
        {
            string containerName = "filecon";
            BlobContainerClient containerClient = serviceClient.GetBlobContainerClient(containerName);
            containerClient.CreateIfNotExists();
            if (string.IsNullOrEmpty(file.HttpUrl))
            {
                BlobClient blobClient = containerClient.GetBlobClient(containerName);
                await blobClient.UploadAsync(file.FilePath).ConfigureAwait(false);
            }
            else
            {
                using WebClient webClient = new WebClient();
                using Stream stream = webClient.OpenRead(file.HttpUrl);
                BlockBlobClient blockBlobClient = containerClient.GetBlockBlobClient(containerName);
                await blockBlobClient.UploadAsync(stream).ConfigureAwait(false);
                stream.Close();
            }
        }

#endregion

        private void AddSubmitters()
        {
            while (pendingTasks.Count > 0 && activeSubmitters.Where(s => s.IsFinished() == false).Count() < maxSubmitters)
            {
                AddSubmitter();
            }
        }

        private void AddSubmitter()
        {
            List<Task> tasksToAdd = new List<Task>();
            while (tasksToAdd.Count < maxTaskCount && pendingTasks.Count > 0)
            {
                Task task = pendingTasks.Dequeue();
                tasksToAdd.Add(task);
                //Console.WriteLine($"Adding task {task.Id}");
            }
            activeSubmitters.Add(new TaskSubmitter(taskClient, jobId, tasksToAdd));
        }

        private bool IsFinished()
        {
            return pendingTasks.Count == 0 && activeSubmitters.Any(s => s.IsFinished() == false);
        }
    }
}
