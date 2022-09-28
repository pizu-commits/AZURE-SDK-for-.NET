// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cosmos DB MongoDB collection resource object
    /// </summary>
    public partial class MongoDBCollectionResource
    {
        /// <summary>
        /// Initializes a new instance of the MongoDBCollectionResource class.
        /// </summary>
        public MongoDBCollectionResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDBCollectionResource class.
        /// </summary>
        /// <param name="id">Name of the Cosmos DB MongoDB collection</param>
        /// <param name="shardKey">A key-value pair of shard keys to be applied
        /// for the request.</param>
        /// <param name="indexes">List of index keys</param>
        /// <param name="analyticalStorageTtl">Analytical TTL.</param>
        /// <param name="restoreParameters">Parameters to indicate the
        /// information about the restore</param>
        /// <param name="createMode">Enum to indicate the mode of resource
        /// creation. Possible values include: 'Default', 'Restore'</param>
        public MongoDBCollectionResource(string id, IDictionary<string, string> shardKey = default(IDictionary<string, string>), IList<MongoIndex> indexes = default(IList<MongoIndex>), int? analyticalStorageTtl = default(int?), ResourceRestoreParameters restoreParameters = default(ResourceRestoreParameters), string createMode = default(string))
        {
            Id = id;
            ShardKey = shardKey;
            Indexes = indexes;
            AnalyticalStorageTtl = analyticalStorageTtl;
            RestoreParameters = restoreParameters;
            CreateMode = createMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB MongoDB collection
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a key-value pair of shard keys to be applied for the
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "shardKey")]
        public IDictionary<string, string> ShardKey { get; set; }

        /// <summary>
        /// Gets or sets list of index keys
        /// </summary>
        [JsonProperty(PropertyName = "indexes")]
        public IList<MongoIndex> Indexes { get; set; }

        /// <summary>
        /// Gets or sets analytical TTL.
        /// </summary>
        [JsonProperty(PropertyName = "analyticalStorageTtl")]
        public int? AnalyticalStorageTtl { get; set; }

        /// <summary>
        /// Gets or sets parameters to indicate the information about the
        /// restore
        /// </summary>
        [JsonProperty(PropertyName = "restoreParameters")]
        public ResourceRestoreParameters RestoreParameters { get; set; }

        /// <summary>
        /// Gets or sets enum to indicate the mode of resource creation.
        /// Possible values include: 'Default', 'Restore'
        /// </summary>
        [JsonProperty(PropertyName = "createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
