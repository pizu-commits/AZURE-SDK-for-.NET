// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create a notebook workspace resource. </summary>
    public partial class NotebookWorkspaceCreateUpdateParameters : ARMProxyResource
    {
        /// <summary> Initializes a new instance of NotebookWorkspaceCreateUpdateParameters. </summary>
        public NotebookWorkspaceCreateUpdateParameters()
        {
        }

        /// <summary> Initializes a new instance of NotebookWorkspaceCreateUpdateParameters. </summary>
        /// <param name="id"> The unique resource identifier of the database account. </param>
        /// <param name="name"> The name of the database account. </param>
        /// <param name="type"> The type of Azure resource. </param>
        internal NotebookWorkspaceCreateUpdateParameters(string id, string name, string type) : base(id, name, type)
        {
        }
    }
}
