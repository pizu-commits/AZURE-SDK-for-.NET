// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Response for a migration of app content request. </summary>
    public partial class StorageMigrationResponse : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of StorageMigrationResponse. </summary>
        public StorageMigrationResponse()
        {
        }

        /// <summary> Initializes a new instance of StorageMigrationResponse. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="operationId"> When server starts the migration process, it will return an operation ID identifying that particular migration operation. </param>
        internal StorageMigrationResponse(string id, string name, string kind, string type, string operationId) : base(id, name, kind, type)
        {
            OperationId = operationId;
        }

        /// <summary> When server starts the migration process, it will return an operation ID identifying that particular migration operation. </summary>
        public string OperationId { get; }
    }
}
