// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraClusterDataCenterNodeItem : IUtf8JsonSerializable, IJsonModel<CassandraClusterDataCenterNodeItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraClusterDataCenterNodeItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CassandraClusterDataCenterNodeItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterDataCenterNodeItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterDataCenterNodeItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(CassandraProcessStatus))
            {
                writer.WritePropertyName("cassandraProcessStatus"u8);
                writer.WriteStringValue(CassandraProcessStatus);
            }
            if (Optional.IsDefined(Load))
            {
                writer.WritePropertyName("load"u8);
                writer.WriteStringValue(Load);
            }
            if (!(Tokens is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tokens"u8);
                writer.WriteStartArray();
                foreach (var item in Tokens)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteNumberValue(Size.Value);
            }
            if (Optional.IsDefined(HostId))
            {
                writer.WritePropertyName("hostID"u8);
                writer.WriteStringValue(HostId.Value);
            }
            if (Optional.IsDefined(Rack))
            {
                writer.WritePropertyName("rack"u8);
                writer.WriteStringValue(Rack);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp);
            }
            if (Optional.IsDefined(DiskUsedKB))
            {
                writer.WritePropertyName("diskUsedKB"u8);
                writer.WriteNumberValue(DiskUsedKB.Value);
            }
            if (Optional.IsDefined(DiskFreeKB))
            {
                writer.WritePropertyName("diskFreeKB"u8);
                writer.WriteNumberValue(DiskFreeKB.Value);
            }
            if (Optional.IsDefined(MemoryUsedKB))
            {
                writer.WritePropertyName("memoryUsedKB"u8);
                writer.WriteNumberValue(MemoryUsedKB.Value);
            }
            if (Optional.IsDefined(MemoryBuffersAndCachedKB))
            {
                writer.WritePropertyName("memoryBuffersAndCachedKB"u8);
                writer.WriteNumberValue(MemoryBuffersAndCachedKB.Value);
            }
            if (Optional.IsDefined(MemoryFreeKB))
            {
                writer.WritePropertyName("memoryFreeKB"u8);
                writer.WriteNumberValue(MemoryFreeKB.Value);
            }
            if (Optional.IsDefined(MemoryTotalKB))
            {
                writer.WritePropertyName("memoryTotalKB"u8);
                writer.WriteNumberValue(MemoryTotalKB.Value);
            }
            if (Optional.IsDefined(CpuUsage))
            {
                writer.WritePropertyName("cpuUsage"u8);
                writer.WriteNumberValue(CpuUsage.Value);
            }
            if (Optional.IsDefined(IsLatestModel))
            {
                writer.WritePropertyName("isLatestModel"u8);
                writer.WriteBooleanValue(IsLatestModel.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        CassandraClusterDataCenterNodeItem IJsonModel<CassandraClusterDataCenterNodeItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterDataCenterNodeItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterDataCenterNodeItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraClusterDataCenterNodeItem(document.RootElement, options);
        }

        internal static CassandraClusterDataCenterNodeItem DeserializeCassandraClusterDataCenterNodeItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> address = default;
            Optional<CassandraNodeState> state = default;
            Optional<string> status = default;
            Optional<string> cassandraProcessStatus = default;
            Optional<string> load = default;
            Optional<IReadOnlyList<string>> tokens = default;
            Optional<int> size = default;
            Optional<Guid> hostId = default;
            Optional<string> rack = default;
            Optional<string> timestamp = default;
            Optional<long> diskUsedKB = default;
            Optional<long> diskFreeKB = default;
            Optional<long> memoryUsedKB = default;
            Optional<long> memoryBuffersAndCachedKB = default;
            Optional<long> memoryFreeKB = default;
            Optional<long> memoryTotalKB = default;
            Optional<double> cpuUsage = default;
            Optional<bool> isLatestModel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new CassandraNodeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cassandraProcessStatus"u8))
                {
                    cassandraProcessStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("load"u8))
                {
                    load = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokens"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tokens = array;
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    size = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("rack"u8))
                {
                    rack = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    timestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskUsedKB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskUsedKB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskFreeKB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskFreeKB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryUsedKB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryUsedKB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryBuffersAndCachedKB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryBuffersAndCachedKB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryFreeKB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryFreeKB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryTotalKB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryTotalKB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cpuUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuUsage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("isLatestModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLatestModel = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CassandraClusterDataCenterNodeItem(address.Value, Optional.ToNullable(state), status.Value, cassandraProcessStatus.Value, load.Value, Optional.ToList(tokens), Optional.ToNullable(size), Optional.ToNullable(hostId), rack.Value, timestamp.Value, Optional.ToNullable(diskUsedKB), Optional.ToNullable(diskFreeKB), Optional.ToNullable(memoryUsedKB), Optional.ToNullable(memoryBuffersAndCachedKB), Optional.ToNullable(memoryFreeKB), Optional.ToNullable(memoryTotalKB), Optional.ToNullable(cpuUsage), Optional.ToNullable(isLatestModel), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CassandraClusterDataCenterNodeItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterDataCenterNodeItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterDataCenterNodeItem)} does not support '{options.Format}' format.");
            }
        }

        CassandraClusterDataCenterNodeItem IPersistableModel<CassandraClusterDataCenterNodeItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterDataCenterNodeItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraClusterDataCenterNodeItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterDataCenterNodeItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraClusterDataCenterNodeItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
