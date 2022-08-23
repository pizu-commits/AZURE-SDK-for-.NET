// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.Data.Batch.Models
{
    public partial class Task
    {
        public List<IFileStagingProvider> FilesToStage { get; } = new List<IFileStagingProvider>();

        public Task(string taskId) : this()
        {
            Id = taskId;
        }
    }
}
