// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for the cache expiration action. </summary>
    public partial class CacheExpirationActionProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CacheExpirationActionProperties"/>. </summary>
        /// <param name="actionType"></param>
        /// <param name="cacheBehavior"> Caching behavior for the requests. </param>
        /// <param name="cacheType"> The level at which the content needs to be cached. </param>
        public CacheExpirationActionProperties(CacheExpirationActionType actionType, CacheBehaviorSetting cacheBehavior, CdnCacheLevel cacheType)
        {
            ActionType = actionType;
            CacheBehavior = cacheBehavior;
            CacheType = cacheType;
        }

        /// <summary> Initializes a new instance of <see cref="CacheExpirationActionProperties"/>. </summary>
        /// <param name="actionType"></param>
        /// <param name="cacheBehavior"> Caching behavior for the requests. </param>
        /// <param name="cacheType"> The level at which the content needs to be cached. </param>
        /// <param name="cacheDuration"> The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CacheExpirationActionProperties(CacheExpirationActionType actionType, CacheBehaviorSetting cacheBehavior, CdnCacheLevel cacheType, TimeSpan? cacheDuration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionType = actionType;
            CacheBehavior = cacheBehavior;
            CacheType = cacheType;
            CacheDuration = cacheDuration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CacheExpirationActionProperties"/> for deserialization. </summary>
        internal CacheExpirationActionProperties()
        {
        }

        /// <summary> Gets or sets the action type. </summary>
        public CacheExpirationActionType ActionType { get; set; }
        /// <summary> Caching behavior for the requests. </summary>
        public CacheBehaviorSetting CacheBehavior { get; set; }
        /// <summary> The level at which the content needs to be cached. </summary>
        public CdnCacheLevel CacheType { get; set; }
        /// <summary> The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss. </summary>
        public TimeSpan? CacheDuration { get; set; }
    }
}
