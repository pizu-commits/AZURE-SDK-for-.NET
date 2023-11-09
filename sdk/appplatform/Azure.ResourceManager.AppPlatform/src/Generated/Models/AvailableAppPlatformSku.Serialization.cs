// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AvailableAppPlatformSku : IUtf8JsonSerializable, IJsonModel<AvailableAppPlatformSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailableAppPlatformSku>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AvailableAppPlatformSku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity);
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LocationInfo))
            {
                writer.WritePropertyName("locationInfo"u8);
                writer.WriteStartArray();
                foreach (var item in LocationInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Restrictions))
            {
                writer.WritePropertyName("restrictions"u8);
                writer.WriteStartArray();
                foreach (var item in Restrictions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        AvailableAppPlatformSku IJsonModel<AvailableAppPlatformSku>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailableAppPlatformSku)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableAppPlatformSku(document.RootElement, options);
        }

        internal static AvailableAppPlatformSku DeserializeAvailableAppPlatformSku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceType> resourceType = default;
            Optional<string> name = default;
            Optional<string> tier = default;
            Optional<AppPlatformSkuCapacity> capacity = default;
            Optional<IReadOnlyList<AzureLocation>> locations = default;
            Optional<IReadOnlyList<AppPlatformSkuLocationInfo>> locationInfo = default;
            Optional<IReadOnlyList<AppPlatformSkuRestrictions>> restrictions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = AppPlatformSkuCapacity.DeserializeAppPlatformSkuCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("locationInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformSkuLocationInfo> array = new List<AppPlatformSkuLocationInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformSkuLocationInfo.DeserializeAppPlatformSkuLocationInfo(item));
                    }
                    locationInfo = array;
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformSkuRestrictions> array = new List<AppPlatformSkuRestrictions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformSkuRestrictions.DeserializeAppPlatformSkuRestrictions(item));
                    }
                    restrictions = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailableAppPlatformSku(Optional.ToNullable(resourceType), name.Value, tier.Value, capacity.Value, Optional.ToList(locations), Optional.ToList(locationInfo), Optional.ToList(restrictions), serializedAdditionalRawData);
        }

        BinaryData IModel<AvailableAppPlatformSku>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailableAppPlatformSku)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AvailableAppPlatformSku IModel<AvailableAppPlatformSku>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailableAppPlatformSku)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAvailableAppPlatformSku(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AvailableAppPlatformSku>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
