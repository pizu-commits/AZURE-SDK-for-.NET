// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class MonitoringDataPoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("Version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(InvariantVersion))
            {
                writer.WritePropertyName("InvariantVersion"u8);
                writer.WriteNumberValue(InvariantVersion.Value);
            }
            if (Optional.IsDefined(Instance))
            {
                writer.WritePropertyName("Instance"u8);
                writer.WriteStringValue(Instance);
            }
            if (Optional.IsDefined(RoleName))
            {
                writer.WritePropertyName("RoleName"u8);
                writer.WriteStringValue(RoleName);
            }
            if (Optional.IsDefined(MachineName))
            {
                writer.WritePropertyName("MachineName"u8);
                writer.WriteStringValue(MachineName);
            }
            if (Optional.IsDefined(StreamId))
            {
                writer.WritePropertyName("StreamId"u8);
                writer.WriteStringValue(StreamId);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("Timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(TransmissionTime))
            {
                writer.WritePropertyName("TransmissionTime"u8);
                writer.WriteStringValue(TransmissionTime.Value, "O");
            }
            if (Optional.IsDefined(IsWebApp))
            {
                writer.WritePropertyName("IsWebApp"u8);
                writer.WriteBooleanValue(IsWebApp.Value);
            }
            if (Optional.IsDefined(PerformanceCollectionSupported))
            {
                writer.WritePropertyName("PerformanceCollectionSupported"u8);
                writer.WriteBooleanValue(PerformanceCollectionSupported.Value);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("Metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue<MetricPoint>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Documents))
            {
                writer.WritePropertyName("Documents"u8);
                writer.WriteStartArray();
                foreach (var item in Documents)
                {
                    writer.WriteObjectValue<DocumentIngress>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TopCpuProcesses))
            {
                writer.WritePropertyName("TopCpuProcesses"u8);
                writer.WriteStartArray();
                foreach (var item in TopCpuProcesses)
                {
                    writer.WriteObjectValue<ProcessCpuData>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CollectionConfigurationErrors))
            {
                writer.WritePropertyName("CollectionConfigurationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in CollectionConfigurationErrors)
                {
                    writer.WriteObjectValue<CollectionConfigurationError>(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
