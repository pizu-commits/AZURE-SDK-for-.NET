// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class representing a read write database.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ReadWrite")]
    [Rest.Serialization.JsonTransformation]
    public partial class ReadWriteDatabase : Database
    {
        /// <summary>
        /// Initializes a new instance of the ReadWriteDatabase class.
        /// </summary>
        public ReadWriteDatabase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReadWriteDatabase class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="location">Resource location.</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Running', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Moving'</param>
        /// <param name="softDeletePeriod">The time the data should be kept
        /// before it stops being accessible to queries in TimeSpan.</param>
        /// <param name="hotCachePeriod">The time the data should be kept in
        /// cache for fast queries in TimeSpan.</param>
        /// <param name="statistics">The statistics of the database.</param>
        /// <param name="isFollowed">Indicates whether the database is
        /// followed.</param>
        public ReadWriteDatabase(string id = default(string), string name = default(string), string type = default(string), string location = default(string), string provisioningState = default(string), System.TimeSpan? softDeletePeriod = default(System.TimeSpan?), System.TimeSpan? hotCachePeriod = default(System.TimeSpan?), DatabaseStatistics statistics = default(DatabaseStatistics), bool? isFollowed = default(bool?))
            : base(id, name, type, location)
        {
            ProvisioningState = provisioningState;
            SoftDeletePeriod = softDeletePeriod;
            HotCachePeriod = hotCachePeriod;
            Statistics = statistics;
            IsFollowed = isFollowed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioned state of the resource. Possible values
        /// include: 'Running', 'Creating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Moving'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the time the data should be kept before it stops being
        /// accessible to queries in TimeSpan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.softDeletePeriod")]
        public System.TimeSpan? SoftDeletePeriod { get; set; }

        /// <summary>
        /// Gets or sets the time the data should be kept in cache for fast
        /// queries in TimeSpan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hotCachePeriod")]
        public System.TimeSpan? HotCachePeriod { get; set; }

        /// <summary>
        /// Gets or sets the statistics of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statistics")]
        public DatabaseStatistics Statistics { get; set; }

        /// <summary>
        /// Gets indicates whether the database is followed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isFollowed")]
        public bool? IsFollowed { get; private set; }

    }
}
