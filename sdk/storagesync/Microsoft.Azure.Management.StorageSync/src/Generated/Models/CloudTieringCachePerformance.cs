// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Server endpoint cloud tiering status object.
    /// </summary>
    public partial class CloudTieringCachePerformance
    {
        /// <summary>
        /// Initializes a new instance of the CloudTieringCachePerformance
        /// class.
        /// </summary>
        public CloudTieringCachePerformance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudTieringCachePerformance
        /// class.
        /// </summary>
        /// <param name="lastUpdatedTimestamp">Last updated timestamp</param>
        /// <param name="cacheHitBytes">Count of bytes that were served from
        /// the local server</param>
        /// <param name="cacheMissBytes">Count of bytes that were served from
        /// the cloud</param>
        /// <param name="cacheHitBytesPercent">Percentage of total bytes (hit +
        /// miss) that were served from the local server</param>
        public CloudTieringCachePerformance(System.DateTime? lastUpdatedTimestamp = default(System.DateTime?), long? cacheHitBytes = default(long?), long? cacheMissBytes = default(long?), int? cacheHitBytesPercent = default(int?))
        {
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            CacheHitBytes = cacheHitBytes;
            CacheMissBytes = cacheMissBytes;
            CacheHitBytesPercent = cacheHitBytesPercent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets last updated timestamp
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTimestamp")]
        public System.DateTime? LastUpdatedTimestamp { get; private set; }

        /// <summary>
        /// Gets count of bytes that were served from the local server
        /// </summary>
        [JsonProperty(PropertyName = "cacheHitBytes")]
        public long? CacheHitBytes { get; private set; }

        /// <summary>
        /// Gets count of bytes that were served from the cloud
        /// </summary>
        [JsonProperty(PropertyName = "cacheMissBytes")]
        public long? CacheMissBytes { get; private set; }

        /// <summary>
        /// Gets percentage of total bytes (hit + miss) that were served from
        /// the local server
        /// </summary>
        [JsonProperty(PropertyName = "cacheHitBytesPercent")]
        public int? CacheHitBytesPercent { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CacheHitBytes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "CacheHitBytes", 0);
            }
            if (CacheMissBytes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "CacheMissBytes", 0);
            }
            if (CacheHitBytesPercent > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "CacheHitBytesPercent", 100);
            }
            if (CacheHitBytesPercent < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "CacheHitBytesPercent", 0);
            }
        }
    }
}
