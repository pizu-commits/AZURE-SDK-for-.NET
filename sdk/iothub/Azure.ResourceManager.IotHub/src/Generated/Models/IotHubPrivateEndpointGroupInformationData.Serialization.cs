// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.IotHub.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotHub
{
    public partial class IotHubPrivateEndpointGroupInformationData : IUtf8JsonSerializable, IModelJsonSerializable<IotHubPrivateEndpointGroupInformationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotHubPrivateEndpointGroupInformationData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotHubPrivateEndpointGroupInformationData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            if (Properties is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<IotHubPrivateEndpointGroupInformationProperties>)Properties).Serialize(writer, options);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static IotHubPrivateEndpointGroupInformationData DeserializeIotHubPrivateEndpointGroupInformationData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IotHubPrivateEndpointGroupInformationProperties properties = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = IotHubPrivateEndpointGroupInformationProperties.DeserializeIotHubPrivateEndpointGroupInformationProperties(property.Value);
                    continue;
                }
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotHubPrivateEndpointGroupInformationData(id, name, type, systemData.Value, properties, rawData);
        }

        IotHubPrivateEndpointGroupInformationData IModelJsonSerializable<IotHubPrivateEndpointGroupInformationData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubPrivateEndpointGroupInformationData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotHubPrivateEndpointGroupInformationData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotHubPrivateEndpointGroupInformationData IModelSerializable<IotHubPrivateEndpointGroupInformationData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotHubPrivateEndpointGroupInformationData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotHubPrivateEndpointGroupInformationData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotHubPrivateEndpointGroupInformationData"/> to convert. </param>
        public static implicit operator RequestContent(IotHubPrivateEndpointGroupInformationData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotHubPrivateEndpointGroupInformationData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotHubPrivateEndpointGroupInformationData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotHubPrivateEndpointGroupInformationData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
