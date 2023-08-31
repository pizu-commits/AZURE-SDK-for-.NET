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

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class OutboundNetworkDependenciesEndpointListResult : IUtf8JsonSerializable, IModelJsonSerializable<OutboundNetworkDependenciesEndpointListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OutboundNetworkDependenciesEndpointListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OutboundNetworkDependenciesEndpointListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OutboundNetworkDependenciesEndpoint>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static OutboundNetworkDependenciesEndpointListResult DeserializeOutboundNetworkDependenciesEndpointListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<OutboundNetworkDependenciesEndpoint> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<OutboundNetworkDependenciesEndpoint> array = new List<OutboundNetworkDependenciesEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutboundNetworkDependenciesEndpoint.DeserializeOutboundNetworkDependenciesEndpoint(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OutboundNetworkDependenciesEndpointListResult(value, nextLink.Value, rawData);
        }

        OutboundNetworkDependenciesEndpointListResult IModelJsonSerializable<OutboundNetworkDependenciesEndpointListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOutboundNetworkDependenciesEndpointListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OutboundNetworkDependenciesEndpointListResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OutboundNetworkDependenciesEndpointListResult IModelSerializable<OutboundNetworkDependenciesEndpointListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOutboundNetworkDependenciesEndpointListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OutboundNetworkDependenciesEndpointListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OutboundNetworkDependenciesEndpointListResult"/> to convert. </param>
        public static implicit operator RequestContent(OutboundNetworkDependenciesEndpointListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OutboundNetworkDependenciesEndpointListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OutboundNetworkDependenciesEndpointListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOutboundNetworkDependenciesEndpointListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
