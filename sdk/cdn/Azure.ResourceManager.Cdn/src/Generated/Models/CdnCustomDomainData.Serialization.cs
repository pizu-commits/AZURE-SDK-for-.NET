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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class CdnCustomDomainData : IUtf8JsonSerializable, IJsonModel<CdnCustomDomainData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CdnCustomDomainData>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<CdnCustomDomainData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ResourceState))
                {
                    writer.WritePropertyName("resourceState"u8);
                    writer.WriteStringValue(ResourceState.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CustomHttpsProvisioningState))
                {
                    writer.WritePropertyName("customHttpsProvisioningState"u8);
                    writer.WriteStringValue(CustomHttpsProvisioningState.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CustomHttpsAvailabilityState))
                {
                    writer.WritePropertyName("customHttpsProvisioningSubstate"u8);
                    writer.WriteStringValue(CustomHttpsAvailabilityState.Value.ToString());
                }
            }
            if (Optional.IsDefined(CustomDomainHttpsContent))
            {
                if (CustomDomainHttpsContent != null)
                {
                    writer.WritePropertyName("customHttpsParameters"u8);
                    writer.WriteObjectValue(CustomDomainHttpsContent);
                }
                else
                {
                    writer.WriteNull("customHttpsParameters");
                }
            }
            if (Optional.IsDefined(ValidationData))
            {
                writer.WritePropertyName("validationData"u8);
                writer.WriteStringValue(ValidationData);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            writer.WriteEndObject();
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

        CdnCustomDomainData IJsonModel<CdnCustomDomainData>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CdnCustomDomainData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnCustomDomainData(document.RootElement, options);
        }

        internal static CdnCustomDomainData DeserializeCdnCustomDomainData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> hostName = default;
            Optional<CustomDomainResourceState> resourceState = default;
            Optional<CustomHttpsProvisioningState> customHttpsProvisioningState = default;
            Optional<CustomHttpsAvailabilityState> customHttpsProvisioningSubstate = default;
            Optional<CustomDomainHttpsContent> customHttpsParameters = default;
            Optional<string> validationData = default;
            Optional<CustomHttpsProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new CustomDomainResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customHttpsProvisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customHttpsProvisioningState = new CustomHttpsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customHttpsProvisioningSubstate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customHttpsProvisioningSubstate = new CustomHttpsAvailabilityState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customHttpsParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                customHttpsParameters = null;
                                continue;
                            }
                            customHttpsParameters = CustomDomainHttpsContent.DeserializeCustomDomainHttpsContent(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("validationData"u8))
                        {
                            validationData = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new CustomHttpsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CdnCustomDomainData(id, name, type, systemData.Value, hostName.Value, Optional.ToNullable(resourceState), Optional.ToNullable(customHttpsProvisioningState), Optional.ToNullable(customHttpsProvisioningSubstate), customHttpsParameters.Value, validationData.Value, Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        BinaryData IModel<CdnCustomDomainData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CdnCustomDomainData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        CdnCustomDomainData IModel<CdnCustomDomainData>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CdnCustomDomainData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeCdnCustomDomainData(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<CdnCustomDomainData>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
