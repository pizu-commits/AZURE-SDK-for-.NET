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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ResponseContract : IUtf8JsonSerializable, IModelJsonSerializable<ResponseContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResponseContract>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResponseContract>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResponseContract>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("statusCode"u8);
            writer.WriteNumberValue(StatusCode);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Representations))
            {
                writer.WritePropertyName("representations"u8);
                writer.WriteStartArray();
                foreach (var item in Representations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RepresentationContract>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ParameterContract>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static ResponseContract DeserializeResponseContract(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int statusCode = default;
            Optional<string> description = default;
            Optional<IList<RepresentationContract>> representations = default;
            Optional<IList<ParameterContract>> headers = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCode"u8))
                {
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("representations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RepresentationContract> array = new List<RepresentationContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RepresentationContract.DeserializeRepresentationContract(item));
                    }
                    representations = array;
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ParameterContract> array = new List<ParameterContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParameterContract.DeserializeParameterContract(item));
                    }
                    headers = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResponseContract(statusCode, description.Value, Optional.ToList(representations), Optional.ToList(headers), rawData);
        }

        ResponseContract IModelJsonSerializable<ResponseContract>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResponseContract>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResponseContract(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResponseContract>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResponseContract>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResponseContract IModelSerializable<ResponseContract>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResponseContract>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResponseContract(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResponseContract"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResponseContract"/> to convert. </param>
        public static implicit operator RequestContent(ResponseContract model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResponseContract"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResponseContract(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResponseContract(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
