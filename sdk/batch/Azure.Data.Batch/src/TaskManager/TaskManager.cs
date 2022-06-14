// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Azure.Data.Batch.Models;

namespace Azure.Data.Batch
{
    public class TaskManager
    {
        private JobClient jobClient;
        private TaskClient taskClient;
        private string jobId;
        private Queue<Task> pendingTasks = new Queue<Task>();
        private List<Task> activeTasks = new List<Task>();
        private List<Task> completedTasks = new List<Task>();
        private int maxParrelelTasks;

        public TaskManager(JobClient jobClient, TaskClient taskClient, string jobId, IEnumerable<Task> tasks, int maxParrelelTasks = 0)
        {
            this.jobClient = jobClient;
            this.taskClient = taskClient;
            this.jobId = jobId;
            this.maxParrelelTasks = maxParrelelTasks;

            foreach (var task in tasks)
            {
                pendingTasks.Enqueue(task);
            }
        }

        public async System.Threading.Tasks.Task Start()
        {
            StartTasks();

            while (IsFinished() == false)
            {
                await System.Threading.Tasks.Task.Delay(5000).ConfigureAwait(false);

                UpdateTasks();
                StartTasks();
            }

            return;
        }

        private void UpdateTasks()
        {
            var tasks = taskClient.ListTasks(jobId);

            foreach (Task task in tasks)
            {
                Task activeTask = activeTasks.FirstOrDefault(t => t.Id == task.Id);

                if (activeTask != null && task.State == TaskState.Completed)
                {
                    CompleteTask(activeTask);
                }
            }
        }

        private void StartTasks()
        {
            while (pendingTasks.Count > 0 && (maxParrelelTasks == 0 || activeTasks.Count < maxParrelelTasks))
            {
                Task task = pendingTasks.Dequeue();
                StartTask(task);
            }
        }

        private void StartTask(Task task)
        {
            activeTasks.Add(task);
            taskClient.AddTask(jobId, task);
        }

        private void CompleteTask(Task task)
        {
            completedTasks.Add(task);
            activeTasks.Remove(task);
        }

        private bool IsFinished()
        {
            return pendingTasks.Count == 0 && activeTasks.Count == 0;
        }
    }
}
