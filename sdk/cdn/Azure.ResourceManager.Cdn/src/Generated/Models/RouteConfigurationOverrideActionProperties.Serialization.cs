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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RouteConfigurationOverrideActionProperties : IUtf8JsonSerializable, IJsonModel<RouteConfigurationOverrideActionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouteConfigurationOverrideActionProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RouteConfigurationOverrideActionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(ActionType.ToString());
            if (Optional.IsDefined(OriginGroupOverride))
            {
                if (OriginGroupOverride != null)
                {
                    writer.WritePropertyName("originGroupOverride"u8);
                    writer.WriteObjectValue(OriginGroupOverride);
                }
                else
                {
                    writer.WriteNull("originGroupOverride");
                }
            }
            if (Optional.IsDefined(CacheConfiguration))
            {
                writer.WritePropertyName("cacheConfiguration"u8);
                writer.WriteObjectValue(CacheConfiguration);
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

        RouteConfigurationOverrideActionProperties IJsonModel<RouteConfigurationOverrideActionProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RouteConfigurationOverrideActionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouteConfigurationOverrideActionProperties(document.RootElement, options);
        }

        internal static RouteConfigurationOverrideActionProperties DeserializeRouteConfigurationOverrideActionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouteConfigurationOverrideActionType typeName = default;
            Optional<OriginGroupOverride> originGroupOverride = default;
            Optional<CacheConfiguration> cacheConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new RouteConfigurationOverrideActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("originGroupOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        originGroupOverride = null;
                        continue;
                    }
                    originGroupOverride = OriginGroupOverride.DeserializeOriginGroupOverride(property.Value);
                    continue;
                }
                if (property.NameEquals("cacheConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheConfiguration = CacheConfiguration.DeserializeCacheConfiguration(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RouteConfigurationOverrideActionProperties(typeName, originGroupOverride.Value, cacheConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<RouteConfigurationOverrideActionProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RouteConfigurationOverrideActionProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RouteConfigurationOverrideActionProperties IModel<RouteConfigurationOverrideActionProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RouteConfigurationOverrideActionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRouteConfigurationOverrideActionProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RouteConfigurationOverrideActionProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
