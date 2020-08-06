// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The configuration for Iot Hub device and module twins. </summary>
    public partial class TwinConfiguration
    {
        /// <summary> Initializes a new instance of TwinConfiguration. </summary>
        public TwinConfiguration()
        {
            Labels = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of TwinConfiguration. </summary>
        /// <param name="id"> The unique identifier of the configuration. </param>
        /// <param name="schemaVersion"> The schema version of the configuration. </param>
        /// <param name="labels"> The key-value pairs used to describe the configuration. </param>
        /// <param name="content"> The content of the configuration. </param>
        /// <param name="targetCondition"> The query used to define the targeted devices or modules. The query is based on twin tags and/or reported properties. </param>
        /// <param name="createdTimeUtc"> The creation date and time of the configuration. </param>
        /// <param name="lastUpdatedTimeUtc"> The update date and time of the configuration. </param>
        /// <param name="priority"> The priority number assigned to the configuration. </param>
        /// <param name="systemMetrics"> The system metrics computed by the IoT Hub that cannot be customized. </param>
        /// <param name="metrics"> The custom metrics specified by the developer as queries against twin reported properties. </param>
        /// <param name="etag"> The ETag of the configuration. </param>
        internal TwinConfiguration(string id, string schemaVersion, IDictionary<string, string> labels, ConfigurationContent content, string targetCondition, DateTimeOffset? createdTimeUtc, DateTimeOffset? lastUpdatedTimeUtc, int? priority, ConfigurationMetrics systemMetrics, ConfigurationMetrics metrics, string etag)
        {
            Id = id;
            SchemaVersion = schemaVersion;
            Labels = labels;
            Content = content;
            TargetCondition = targetCondition;
            CreatedTimeUtc = createdTimeUtc;
            LastUpdatedTimeUtc = lastUpdatedTimeUtc;
            Priority = priority;
            SystemMetrics = systemMetrics;
            Metrics = metrics;
            Etag = etag;
        }

        /// <summary> The unique identifier of the configuration. </summary>
        public string Id { get; set; }
        /// <summary> The schema version of the configuration. </summary>
        public string SchemaVersion { get; set; }
        /// <summary> The key-value pairs used to describe the configuration. </summary>
        public IDictionary<string, string> Labels { get; }
        /// <summary> The content of the configuration. </summary>
        public ConfigurationContent Content { get; set; }
        /// <summary> The query used to define the targeted devices or modules. The query is based on twin tags and/or reported properties. </summary>
        public string TargetCondition { get; set; }
        /// <summary> The creation date and time of the configuration. </summary>
        public DateTimeOffset? CreatedTimeUtc { get; set; }
        /// <summary> The update date and time of the configuration. </summary>
        public DateTimeOffset? LastUpdatedTimeUtc { get; set; }
        /// <summary> The priority number assigned to the configuration. </summary>
        public int? Priority { get; set; }
        /// <summary> The system metrics computed by the IoT Hub that cannot be customized. </summary>
        public ConfigurationMetrics SystemMetrics { get; set; }
        /// <summary> The custom metrics specified by the developer as queries against twin reported properties. </summary>
        public ConfigurationMetrics Metrics { get; set; }
        /// <summary> The ETag of the configuration. </summary>
        public string Etag { get; set; }
    }
}
