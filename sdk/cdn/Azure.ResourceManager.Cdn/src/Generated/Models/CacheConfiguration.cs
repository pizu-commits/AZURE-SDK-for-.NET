// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object. </summary>
    public partial class CacheConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CacheConfiguration"/>. </summary>
        public CacheConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CacheConfiguration"/>. </summary>
        /// <param name="queryStringCachingBehavior"> Defines how Frontdoor caches requests that include query strings. You can ignore any query strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query strings. </param>
        /// <param name="queryParameters"> query parameters to include or exclude (comma separated). </param>
        /// <param name="isCompressionEnabled"> Indicates whether content compression is enabled. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB. </param>
        /// <param name="cacheBehavior"> Caching behavior for the requests. </param>
        /// <param name="cacheDuration"> The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CacheConfiguration(RuleQueryStringCachingBehavior? queryStringCachingBehavior, string queryParameters, RuleIsCompressionEnabled? isCompressionEnabled, RuleCacheBehavior? cacheBehavior, TimeSpan? cacheDuration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            QueryStringCachingBehavior = queryStringCachingBehavior;
            QueryParameters = queryParameters;
            IsCompressionEnabled = isCompressionEnabled;
            CacheBehavior = cacheBehavior;
            CacheDuration = cacheDuration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Defines how Frontdoor caches requests that include query strings. You can ignore any query strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query strings. </summary>
        public RuleQueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }
        /// <summary> query parameters to include or exclude (comma separated). </summary>
        public string QueryParameters { get; set; }
        /// <summary> Indicates whether content compression is enabled. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB. </summary>
        public RuleIsCompressionEnabled? IsCompressionEnabled { get; set; }
        /// <summary> Caching behavior for the requests. </summary>
        public RuleCacheBehavior? CacheBehavior { get; set; }
        /// <summary> The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss. </summary>
        public TimeSpan? CacheDuration { get; set; }
    }
}
