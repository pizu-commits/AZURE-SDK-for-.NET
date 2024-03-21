// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A class representing the StreamingJobTransformation data model.
    /// A transformation object, containing all information associated with the named transformation. All transformations are contained under a streaming job.
    /// </summary>
    public partial class StreamingJobTransformationData : StreamAnalyticsSubResource
    {
        /// <summary> Initializes a new instance of <see cref="StreamingJobTransformationData"/>. </summary>
        public StreamingJobTransformationData()
        {
            ValidStreamingUnits = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingJobTransformationData"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="streamingUnits"> Specifies the number of streaming units that the streaming job uses. </param>
        /// <param name="validStreamingUnits"> Specifies the valid streaming units a streaming job can scale to. </param>
        /// <param name="query"> Specifies the query that will be run in the streaming job. You can learn more about the Stream Analytics Query Language (SAQL) here: https://msdn.microsoft.com/library/azure/dn834998 . Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="etag"> The current entity tag for the transformation. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </param>
        internal StreamingJobTransformationData(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, int? streamingUnits, IList<int> validStreamingUnits, string query, ETag? etag) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            StreamingUnits = streamingUnits;
            ValidStreamingUnits = validStreamingUnits;
            Query = query;
            ETag = etag;
        }

        /// <summary> Specifies the number of streaming units that the streaming job uses. </summary>
        public int? StreamingUnits { get; set; }
        /// <summary> Specifies the valid streaming units a streaming job can scale to. </summary>
        public IList<int> ValidStreamingUnits { get; }
        /// <summary> Specifies the query that will be run in the streaming job. You can learn more about the Stream Analytics Query Language (SAQL) here: https://msdn.microsoft.com/library/azure/dn834998 . Required on PUT (CreateOrReplace) requests. </summary>
        public string Query { get; set; }
        /// <summary> The current entity tag for the transformation. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </summary>
        public ETag? ETag { get; }
    }
}
