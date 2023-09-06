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

namespace Azure.ResourceManager.LoadTesting.Models
{
    internal partial class OutboundEnvironmentEndpointListResult : IUtf8JsonSerializable, IModelJsonSerializable<OutboundEnvironmentEndpointListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OutboundEnvironmentEndpointListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OutboundEnvironmentEndpointListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutboundEnvironmentEndpointListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static OutboundEnvironmentEndpointListResult DeserializeOutboundEnvironmentEndpointListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<LoadTestingOutboundEnvironmentEndpoint>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadTestingOutboundEnvironmentEndpoint> array = new List<LoadTestingOutboundEnvironmentEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadTestingOutboundEnvironmentEndpoint.DeserializeLoadTestingOutboundEnvironmentEndpoint(item));
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
            return new OutboundEnvironmentEndpointListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        OutboundEnvironmentEndpointListResult IModelJsonSerializable<OutboundEnvironmentEndpointListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutboundEnvironmentEndpointListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOutboundEnvironmentEndpointListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OutboundEnvironmentEndpointListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutboundEnvironmentEndpointListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OutboundEnvironmentEndpointListResult IModelSerializable<OutboundEnvironmentEndpointListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutboundEnvironmentEndpointListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOutboundEnvironmentEndpointListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OutboundEnvironmentEndpointListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OutboundEnvironmentEndpointListResult"/> to convert. </param>
        public static implicit operator RequestContent(OutboundEnvironmentEndpointListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OutboundEnvironmentEndpointListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OutboundEnvironmentEndpointListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOutboundEnvironmentEndpointListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
