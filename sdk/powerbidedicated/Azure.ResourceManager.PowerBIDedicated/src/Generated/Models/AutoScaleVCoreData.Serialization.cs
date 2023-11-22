// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PowerBIDedicated.Models;

namespace Azure.ResourceManager.PowerBIDedicated
{
    public partial class AutoScaleVCoreData : IUtf8JsonSerializable, IJsonModel<AutoScaleVCoreData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoScaleVCoreData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoScaleVCoreData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleVCoreData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AutoScaleVCoreData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                writer.WriteObjectValue(SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CapacityLimit))
            {
                writer.WritePropertyName("capacityLimit"u8);
                writer.WriteNumberValue(CapacityLimit.Value);
            }
            if (Optional.IsDefined(CapacityObjectId))
            {
                writer.WritePropertyName("capacityObjectId"u8);
                writer.WriteStringValue(CapacityObjectId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
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

        AutoScaleVCoreData IJsonModel<AutoScaleVCoreData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleVCoreData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AutoScaleVCoreData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoScaleVCoreData(document.RootElement, options);
        }

        internal static AutoScaleVCoreData DeserializeAutoScaleVCoreData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AutoScaleVCoreSku sku = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            AzureLocation location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<SystemData> systemData = default;
            Optional<int> capacityLimit = default;
            Optional<string> capacityObjectId = default;
            Optional<VCoreProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = AutoScaleVCoreSku.DeserializeAutoScaleVCoreSku(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("capacityLimit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacityLimit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("capacityObjectId"u8))
                        {
                            capacityObjectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VCoreProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoScaleVCoreData(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), systemData.Value, serializedAdditionalRawData, sku, Optional.ToNullable(capacityLimit), capacityObjectId.Value, Optional.ToNullable(provisioningState));
        }

        BinaryData IPersistableModel<AutoScaleVCoreData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleVCoreData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AutoScaleVCoreData)} does not support '{options.Format}' format.");
            }
        }

        AutoScaleVCoreData IPersistableModel<AutoScaleVCoreData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleVCoreData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoScaleVCoreData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AutoScaleVCoreData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoScaleVCoreData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
