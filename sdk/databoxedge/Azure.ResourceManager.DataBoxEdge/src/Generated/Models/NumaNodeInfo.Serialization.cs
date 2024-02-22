// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class NumaNodeInfo : IUtf8JsonSerializable, IJsonModel<NumaNodeInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NumaNodeInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NumaNodeInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumaNodeInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NumaNodeInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NumaNodeIndex))
            {
                writer.WritePropertyName("numaNodeIndex"u8);
                writer.WriteNumberValue(NumaNodeIndex.Value);
            }
            if (Optional.IsDefined(TotalMemoryInMB))
            {
                writer.WritePropertyName("totalMemoryInMb"u8);
                writer.WriteNumberValue(TotalMemoryInMB.Value);
            }
            if (Optional.IsDefined(LogicalCoreCountPerCore))
            {
                writer.WritePropertyName("logicalCoreCountPerCore"u8);
                writer.WriteNumberValue(LogicalCoreCountPerCore.Value);
            }
            if (Optional.IsDefined(EffectiveAvailableMemoryInMB))
            {
                writer.WritePropertyName("effectiveAvailableMemoryInMb"u8);
                writer.WriteNumberValue(EffectiveAvailableMemoryInMB.Value);
            }
            if (!(FreeVCpuIndexesForHpn is ChangeTrackingList<int> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("freeVCpuIndexesForHpn"u8);
                writer.WriteStartArray();
                foreach (var item in FreeVCpuIndexesForHpn)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(VCpuIndexesForHpn is ChangeTrackingList<int> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("vCpuIndexesForHpn"u8);
                writer.WriteStartArray();
                foreach (var item in VCpuIndexesForHpn)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(VCpuIndexesForRoot is ChangeTrackingList<int> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("vCpuIndexesForRoot"u8);
                writer.WriteStartArray();
                foreach (var item in VCpuIndexesForRoot)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
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

        NumaNodeInfo IJsonModel<NumaNodeInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumaNodeInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NumaNodeInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNumaNodeInfo(document.RootElement, options);
        }

        internal static NumaNodeInfo DeserializeNumaNodeInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> numaNodeIndex = default;
            Optional<long> totalMemoryInMb = default;
            Optional<int> logicalCoreCountPerCore = default;
            Optional<long> effectiveAvailableMemoryInMb = default;
            Optional<IList<int>> freeVCpuIndexesForHpn = default;
            Optional<IList<int>> vCpuIndexesForHpn = default;
            Optional<IList<int>> vCpuIndexesForRoot = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numaNodeIndex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numaNodeIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalMemoryInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMemoryInMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("logicalCoreCountPerCore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logicalCoreCountPerCore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("effectiveAvailableMemoryInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveAvailableMemoryInMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("freeVCpuIndexesForHpn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    freeVCpuIndexesForHpn = array;
                    continue;
                }
                if (property.NameEquals("vCpuIndexesForHpn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    vCpuIndexesForHpn = array;
                    continue;
                }
                if (property.NameEquals("vCpuIndexesForRoot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    vCpuIndexesForRoot = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NumaNodeInfo(Optional.ToNullable(numaNodeIndex), Optional.ToNullable(totalMemoryInMb), Optional.ToNullable(logicalCoreCountPerCore), Optional.ToNullable(effectiveAvailableMemoryInMb), Optional.ToList(freeVCpuIndexesForHpn), Optional.ToList(vCpuIndexesForHpn), Optional.ToList(vCpuIndexesForRoot), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NumaNodeInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumaNodeInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NumaNodeInfo)} does not support '{options.Format}' format.");
            }
        }

        NumaNodeInfo IPersistableModel<NumaNodeInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumaNodeInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNumaNodeInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NumaNodeInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NumaNodeInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
