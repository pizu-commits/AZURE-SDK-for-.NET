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
    public partial class AppPlatformGatewayRouteConfigProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformGatewayRouteConfigProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformGatewayRouteConfigProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AppPlatformGatewayRouteConfigProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsDefined(AppResourceId))
            {
                writer.WritePropertyName("appResourceId"u8);
                writer.WriteStringValue(AppResourceId);
            }
            if (Optional.IsDefined(OpenApi))
            {
                writer.WritePropertyName("openApi"u8);
                writer.WriteObjectValue(OpenApi);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteStartArray();
                foreach (var item in Routes)
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

        AppPlatformGatewayRouteConfigProperties IJsonModel<AppPlatformGatewayRouteConfigProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayRouteConfigProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformGatewayRouteConfigProperties(document.RootElement, options);
        }

        internal static AppPlatformGatewayRouteConfigProperties DeserializeAppPlatformGatewayRouteConfigProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformGatewayProvisioningState> provisioningState = default;
            Optional<ResourceIdentifier> appResourceId = default;
            Optional<GatewayRouteConfigOpenApiProperties> openApi = default;
            Optional<AppPlatformGatewayRouteConfigProtocol> protocol = default;
            Optional<IList<AppPlatformGatewayApiRoute>> routes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformGatewayProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("openApi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openApi = GatewayRouteConfigOpenApiProperties.DeserializeGatewayRouteConfigOpenApiProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new AppPlatformGatewayRouteConfigProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformGatewayApiRoute> array = new List<AppPlatformGatewayApiRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformGatewayApiRoute.DeserializeAppPlatformGatewayApiRoute(item));
                    }
                    routes = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformGatewayRouteConfigProperties(Optional.ToNullable(provisioningState), appResourceId.Value, openApi.Value, Optional.ToNullable(protocol), Optional.ToList(routes), serializedAdditionalRawData);
        }

        BinaryData IModel<AppPlatformGatewayRouteConfigProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayRouteConfigProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppPlatformGatewayRouteConfigProperties IModel<AppPlatformGatewayRouteConfigProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayRouteConfigProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppPlatformGatewayRouteConfigProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AppPlatformGatewayRouteConfigProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
