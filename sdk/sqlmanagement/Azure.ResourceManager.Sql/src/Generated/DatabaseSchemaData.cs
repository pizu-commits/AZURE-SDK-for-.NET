// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the DatabaseSchema data model. </summary>
    public partial class DatabaseSchemaData : Resource
    {
        /// <summary> Initializes a new instance of DatabaseSchemaData. </summary>
        public DatabaseSchemaData()
        {
        }

        /// <summary> Initializes a new instance of DatabaseSchemaData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        internal DatabaseSchemaData(ResourceIdentifier id, string name, ResourceType type) : base(id, name, type)
        {
        }
    }
}
