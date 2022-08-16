// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes a raw input data source that contains stream data. This data source type is only applicable/usable when using the query testing API. You cannot create a job with this data source type or add an input of this data source type to an existing job. </summary>
    public partial class RawStreamInputDataSource : StreamInputDataSource
    {
        /// <summary> Initializes a new instance of RawStreamInputDataSource. </summary>
        public RawStreamInputDataSource()
        {
            StreamInputDataSourceType = "Raw";
        }

        /// <summary> Initializes a new instance of RawStreamInputDataSource. </summary>
        /// <param name="streamInputDataSourceType"> Indicates the type of input data source containing stream data. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="payload"> The JSON serialized content of the input data. Either payload or payloadUri must be set, but not both. </param>
        /// <param name="payloadUri"> The SAS URL to a blob containing the JSON serialized content of the input data. Either payload or payloadUri must be set, but not both. </param>
        internal RawStreamInputDataSource(string streamInputDataSourceType, BinaryData payload, Uri payloadUri) : base(streamInputDataSourceType)
        {
            Payload = payload;
            PayloadUri = payloadUri;
            StreamInputDataSourceType = streamInputDataSourceType ?? "Raw";
        }

        /// <summary> The JSON serialized content of the input data. Either payload or payloadUri must be set, but not both. </summary>
        public BinaryData Payload { get; set; }
        /// <summary> The SAS URL to a blob containing the JSON serialized content of the input data. Either payload or payloadUri must be set, but not both. </summary>
        public Uri PayloadUri { get; set; }
    }
}
