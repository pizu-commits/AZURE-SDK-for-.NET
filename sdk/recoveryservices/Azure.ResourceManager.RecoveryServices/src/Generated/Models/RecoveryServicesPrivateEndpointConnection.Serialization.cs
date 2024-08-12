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

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class RecoveryServicesPrivateEndpointConnection : IUtf8JsonSerializable, IJsonModel<RecoveryServicesPrivateEndpointConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryServicesPrivateEndpointConnection>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryServicesPrivateEndpointConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesPrivateEndpointConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryServicesPrivateEndpointConnection)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateLinkServiceConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                writer.WriteObjectValue(PrivateLinkServiceConnectionState, options);
            }
            if (Optional.IsCollectionDefined(GroupIds))
            {
                writer.WritePropertyName("groupIds"u8);
                writer.WriteStartArray();
                foreach (var item in GroupIds)
                {
                    writer.WriteStringValue(item.ToString());
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

        RecoveryServicesPrivateEndpointConnection IJsonModel<RecoveryServicesPrivateEndpointConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesPrivateEndpointConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryServicesPrivateEndpointConnection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryServicesPrivateEndpointConnection(document.RootElement, options);
        }

        internal static RecoveryServicesPrivateEndpointConnection DeserializeRecoveryServicesPrivateEndpointConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecoveryServicesPrivateEndpointConnectionProvisioningState? provisioningState = default;
            SubResource privateEndpoint = default;
            RecoveryServicesPrivateLinkServiceConnectionState privateLinkServiceConnectionState = default;
            IReadOnlyList<VaultSubResourceType> groupIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new RecoveryServicesPrivateEndpointConnectionProvisioningState(property.Value.GetString());
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceConnectionState = RecoveryServicesPrivateLinkServiceConnectionState.DeserializeRecoveryServicesPrivateLinkServiceConnectionState(property.Value, options);
                    continue;
                }
                if (property.NameEquals("groupIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VaultSubResourceType> array = new List<VaultSubResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new VaultSubResourceType(item.GetString()));
                    }
                    groupIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecoveryServicesPrivateEndpointConnection(provisioningState, privateEndpoint, privateLinkServiceConnectionState, groupIds ?? new ChangeTrackingList<VaultSubResourceType>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryServicesPrivateEndpointConnection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesPrivateEndpointConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryServicesPrivateEndpointConnection)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryServicesPrivateEndpointConnection IPersistableModel<RecoveryServicesPrivateEndpointConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesPrivateEndpointConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryServicesPrivateEndpointConnection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryServicesPrivateEndpointConnection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryServicesPrivateEndpointConnection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
