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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class SupportedConnectorProperties : IUtf8JsonSerializable, IModelJsonSerializable<SupportedConnectorProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SupportedConnectorProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SupportedConnectorProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SupportedConnectorProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectorType))
            {
                writer.WritePropertyName("connectorType"u8);
                writer.WriteStringValue(ConnectorType);
            }
            if (Optional.IsDefined(MaxSpeedInMbps))
            {
                writer.WritePropertyName("maxSpeedInMbps"u8);
                writer.WriteNumberValue(MaxSpeedInMbps.Value);
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

        internal static SupportedConnectorProperties DeserializeSupportedConnectorProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> connectorType = default;
            Optional<int> maxSpeedInMbps = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectorType"u8))
                {
                    connectorType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxSpeedInMbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxSpeedInMbps = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SupportedConnectorProperties(connectorType.Value, Optional.ToNullable(maxSpeedInMbps), rawData);
        }

        SupportedConnectorProperties IModelJsonSerializable<SupportedConnectorProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SupportedConnectorProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSupportedConnectorProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SupportedConnectorProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SupportedConnectorProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SupportedConnectorProperties IModelSerializable<SupportedConnectorProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SupportedConnectorProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSupportedConnectorProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SupportedConnectorProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SupportedConnectorProperties"/> to convert. </param>
        public static implicit operator RequestContent(SupportedConnectorProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SupportedConnectorProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SupportedConnectorProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSupportedConnectorProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
