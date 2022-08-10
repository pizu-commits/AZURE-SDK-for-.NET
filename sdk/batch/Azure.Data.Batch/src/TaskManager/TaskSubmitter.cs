// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Azure.Data.Batch.Models;

namespace Azure.Data.Batch
{
    internal class TaskSubmitter
    {
        private TaskClient taskClient;
        private string jobId;

        private List<Task> pendingTasks = new List<Task>();

        public TaskSubmitter(TaskClient taskClient, string jobId, IEnumerable<Task> pendingTasks)
        {
            this.taskClient = taskClient;
            this.jobId = jobId;
            this.pendingTasks = pendingTasks.ToList();

            new System.Threading.Thread(() =>
            {
                AddTasks(this.pendingTasks.Count);
            }).Start();
        }

        public void AddTasks(int numberToAdd)
        {
            try
            {
                IEnumerable<Task> tasksToAdd = pendingTasks.Take(numberToAdd);
                taskClient.AddTasks(jobId, tasksToAdd);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception: {exception.Message}");
                throw;
            }

            pendingTasks.RemoveRange(0, numberToAdd);
        }

        public bool IsFinished()
        {
            return pendingTasks.Count == 0;
        }
    }
}
