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

namespace Azure.ResourceManager.Media.Models
{
    public partial class StreamingEndpointAccessControl : IUtf8JsonSerializable, IModelJsonSerializable<StreamingEndpointAccessControl>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StreamingEndpointAccessControl>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StreamingEndpointAccessControl>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingEndpointAccessControl>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Akamai))
            {
                writer.WritePropertyName("akamai"u8);
                if (Akamai is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AkamaiAccessControl>)Akamai).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IPs))
            {
                writer.WritePropertyName("ip"u8);
                if (IPs is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IPAccessControl>)IPs).Serialize(writer, options);
                }
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

        internal static StreamingEndpointAccessControl DeserializeStreamingEndpointAccessControl(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AkamaiAccessControl> akamai = default;
            Optional<IPAccessControl> ip = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("akamai"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    akamai = AkamaiAccessControl.DeserializeAkamaiAccessControl(property.Value);
                    continue;
                }
                if (property.NameEquals("ip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ip = IPAccessControl.DeserializeIPAccessControl(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StreamingEndpointAccessControl(akamai.Value, ip.Value, rawData);
        }

        StreamingEndpointAccessControl IModelJsonSerializable<StreamingEndpointAccessControl>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingEndpointAccessControl>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingEndpointAccessControl(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StreamingEndpointAccessControl>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingEndpointAccessControl>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StreamingEndpointAccessControl IModelSerializable<StreamingEndpointAccessControl>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingEndpointAccessControl>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStreamingEndpointAccessControl(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StreamingEndpointAccessControl"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StreamingEndpointAccessControl"/> to convert. </param>
        public static implicit operator RequestContent(StreamingEndpointAccessControl model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StreamingEndpointAccessControl"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StreamingEndpointAccessControl(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStreamingEndpointAccessControl(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
