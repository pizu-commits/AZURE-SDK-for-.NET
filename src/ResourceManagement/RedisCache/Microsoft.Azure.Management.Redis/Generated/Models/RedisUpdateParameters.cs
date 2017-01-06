// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Models
{
    using System;		
    using System.Linq;
    using System.Collections.Generic;		
    using Newtonsoft.Json;		
    using Rest;		
    using Rest.Serialization;		
    using Rest.Azure;		

    /// <summary>
    /// Parameters supplied to the Update Redis operation.
    /// </summary>
    [JsonTransformation]
    public partial class RedisUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RedisUpdateParameters class.
        /// </summary>
        public RedisUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the RedisUpdateParameters class.
        /// </summary>
        /// <param name="redisConfiguration">All Redis Settings. Few possible
        /// keys:
        /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
        /// etc.</param>
        /// <param name="enableNonSslPort">If the value is true, then the
        /// non-ssl redis server port (6379) will be enabled.</param>
        /// <param name="tenantSettings">tenantSettings</param>
        /// <param name="shardCount">The number of shards to be created on a
        /// Premium Cluster Cache.</param>
        /// <param name="subnetId">The full resource ID of a subnet in a
        /// virtual network to deploy the redis cache in. Example format:
        /// /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1</param>
        /// <param name="staticIP">Required when deploying a redis cache
        /// inside an existing Azure Virtual Network.</param>
        /// <param name="sku">What sku of redis cache to deploy.</param>
        /// <param name="tags">Resource tags</param>
        public RedisUpdateParameters(IDictionary<string, string> redisConfiguration = default(IDictionary<string, string>), bool? enableNonSslPort = default(bool?), IDictionary<string, string> tenantSettings = default(IDictionary<string, string>), int? shardCount = default(int?), string subnetId = default(string), string staticIP = default(string), Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            RedisConfiguration = redisConfiguration;
            EnableNonSslPort = enableNonSslPort;
            TenantSettings = tenantSettings;
            ShardCount = shardCount;
            SubnetId = subnetId;
            StaticIP = staticIP;
            Sku = sku;
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets all Redis Settings. Few possible keys:
        /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
        /// etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.redisConfiguration")]
        public IDictionary<string, string> RedisConfiguration { get; set; }

        /// <summary>
        /// Gets or sets if the value is true, then the non-ssl redis server
        /// port (6379) will be enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enableNonSslPort")]
        public bool? EnableNonSslPort { get; set; }

        /// <summary>
        /// Gets or sets tenantSettings
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tenantSettings")]
        public IDictionary<string, string> TenantSettings { get; set; }

        /// <summary>
        /// Gets or sets the number of shards to be created on a Premium
        /// Cluster Cache.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.shardCount")]
        public int? ShardCount { get; set; }

        /// <summary>
        /// Gets or sets the full resource ID of a subnet in a virtual network
        /// to deploy the redis cache in. Example format:
        /// /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets required when deploying a redis cache inside an
        /// existing Azure Virtual Network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.staticIP")]
        public string StaticIP { get; set; }

        /// <summary>
        /// Gets or sets what sku of redis cache to deploy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SubnetId != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(SubnetId, "^/subscriptions/[^/]*/resourceGroups/[^/]*/providers/Microsoft.(ClassicNetwork|Network)/virtualNetworks/[^/]*/subnets/[^/]*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "SubnetId", "^/subscriptions/[^/]*/resourceGroups/[^/]*/providers/Microsoft.(ClassicNetwork|Network)/virtualNetworks/[^/]*/subnets/[^/]*$");
                }
            }
            if (StaticIP != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(StaticIP, "^\\d+\\.\\d+\\.\\d+\\.\\d+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "StaticIP", "^\\d+\\.\\d+\\.\\d+\\.\\d+$");
                }
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
