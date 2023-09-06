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
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class LiveOutputListResult : IUtf8JsonSerializable, IModelJsonSerializable<LiveOutputListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LiveOutputListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LiveOutputListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LiveOutputListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
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
                        ((IModelJsonSerializable<MediaLiveOutputData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OdataCount))
            {
                writer.WritePropertyName("@odata.count"u8);
                writer.WriteNumberValue(OdataCount.Value);
            }
            if (Optional.IsDefined(OdataNextLink))
            {
                writer.WritePropertyName("@odata.nextLink"u8);
                writer.WriteStringValue(OdataNextLink);
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

        internal static LiveOutputListResult DeserializeLiveOutputListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MediaLiveOutputData>> value = default;
            Optional<int> odataCount = default;
            Optional<string> odataNextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaLiveOutputData> array = new List<MediaLiveOutputData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaLiveOutputData.DeserializeMediaLiveOutputData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LiveOutputListResult(Optional.ToList(value), Optional.ToNullable(odataCount), odataNextLink.Value, rawData);
        }

        LiveOutputListResult IModelJsonSerializable<LiveOutputListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LiveOutputListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLiveOutputListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LiveOutputListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LiveOutputListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LiveOutputListResult IModelSerializable<LiveOutputListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LiveOutputListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLiveOutputListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LiveOutputListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LiveOutputListResult"/> to convert. </param>
        public static implicit operator RequestContent(LiveOutputListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LiveOutputListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LiveOutputListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLiveOutputListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
