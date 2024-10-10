// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HealthDataAIServices.Models
{
    public partial class PrivateEndpointConnectionProperties : IUtf8JsonSerializable, IJsonModel<PrivateEndpointConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateEndpointConnectionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateEndpointConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointConnectionProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsCollectionDefined(GroupIds))
            {
                writer.WritePropertyName("groupIds"u8);
                writer.WriteStartArray();
                foreach (var item in GroupIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            writer.WritePropertyName("privateLinkServiceConnectionState"u8);
            writer.WriteObjectValue(PrivateLinkServiceConnectionState, options);
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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
        }

        PrivateEndpointConnectionProperties IJsonModel<PrivateEndpointConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointConnectionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateEndpointConnectionProperties(document.RootElement, options);
        }

        internal static PrivateEndpointConnectionProperties DeserializePrivateEndpointConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> groupIds = default;
            SubResource privateEndpoint = default;
            HealthDataAIServicesPrivateLinkServiceConnectionState privateLinkServiceConnectionState = default;
            HealthDataAIServicesPrivateEndpointConnectionProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupIds"u8))
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
                    groupIds = array;
                    continue;
                }
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    privateLinkServiceConnectionState = HealthDataAIServicesPrivateLinkServiceConnectionState.DeserializeHealthDataAIServicesPrivateLinkServiceConnectionState(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new HealthDataAIServicesPrivateEndpointConnectionProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PrivateEndpointConnectionProperties(groupIds ?? new ChangeTrackingList<string>(), privateEndpoint, privateLinkServiceConnectionState, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateEndpointConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointConnectionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateEndpointConnectionProperties IPersistableModel<PrivateEndpointConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateEndpointConnectionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointConnectionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateEndpointConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
