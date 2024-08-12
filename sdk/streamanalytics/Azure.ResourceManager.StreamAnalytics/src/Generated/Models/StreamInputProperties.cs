// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The properties that are associated with an input containing stream data. </summary>
    public partial class StreamInputProperties : StreamingJobInputProperties
    {
        /// <summary> Initializes a new instance of <see cref="StreamInputProperties"/>. </summary>
        public StreamInputProperties()
        {
            InputPropertiesType = "Stream";
        }

        /// <summary> Initializes a new instance of <see cref="StreamInputProperties"/>. </summary>
        /// <param name="inputPropertiesType"> Indicates whether the input is a source of reference data or stream data. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="serialization">
        /// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamAnalyticsDataSerialization"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroFormatSerialization"/>, <see cref="CsvFormatSerialization"/>, <see cref="CustomClrFormatSerialization"/>, <see cref="JsonFormatSerialization"/> and <see cref="ParquetFormatSerialization"/>.
        /// </param>
        /// <param name="diagnostics"> Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention. </param>
        /// <param name="etag"> The current entity tag for the input. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </param>
        /// <param name="compression"> Describes how input data is compressed. </param>
        /// <param name="partitionKey"> partitionKey Describes a key in the input data which is used for partitioning the input data. </param>
        /// <param name="watermarkSettings"> Settings which determine whether to read watermark events. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="datasource">
        /// Describes an input data source that contains stream data. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamInputDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GatewayMessageBusStreamInputDataSource"/>, <see cref="IoTHubStreamInputDataSource"/>, <see cref="EventGridStreamInputDataSource"/>, <see cref="EventHubV2StreamInputDataSource"/>, <see cref="EventHubStreamInputDataSource"/>, <see cref="BlobStreamInputDataSource"/> and <see cref="RawStreamInputDataSource"/>.
        /// </param>
        internal StreamInputProperties(string inputPropertiesType, StreamAnalyticsDataSerialization serialization, StreamingJobDiagnostics diagnostics, ETag? etag, StreamingCompression compression, string partitionKey, StreamingJobInputWatermarkProperties watermarkSettings, IDictionary<string, BinaryData> serializedAdditionalRawData, StreamInputDataSource datasource) : base(inputPropertiesType, serialization, diagnostics, etag, compression, partitionKey, watermarkSettings, serializedAdditionalRawData)
        {
            Datasource = datasource;
            InputPropertiesType = inputPropertiesType ?? "Stream";
        }

        /// <summary>
        /// Describes an input data source that contains stream data. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamInputDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GatewayMessageBusStreamInputDataSource"/>, <see cref="IoTHubStreamInputDataSource"/>, <see cref="EventGridStreamInputDataSource"/>, <see cref="EventHubV2StreamInputDataSource"/>, <see cref="EventHubStreamInputDataSource"/>, <see cref="BlobStreamInputDataSource"/> and <see cref="RawStreamInputDataSource"/>.
        /// </summary>
        public StreamInputDataSource Datasource { get; set; }
    }
}
