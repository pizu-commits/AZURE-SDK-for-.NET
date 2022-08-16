// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The default value is Pool. If the pool is running Windows a value of Task should be specified if stricter isolation between tasks is required. For example, if the task mutates the registry in a way which could impact other tasks, or if certificates have been specified on the pool which should not be accessible by normal tasks but should be accessible by start tasks. </summary>
    public enum BatchAutoUserScope
    {
        /// <summary> Specifies that the service should create a new user for the task. </summary>
        Task,
        /// <summary> Specifies that the task runs as the common auto user account which is created on every node in a pool. </summary>
        Pool
    }
}
