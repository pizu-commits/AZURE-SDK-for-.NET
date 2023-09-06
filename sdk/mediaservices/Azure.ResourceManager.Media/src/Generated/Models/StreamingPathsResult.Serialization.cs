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
    public partial class StreamingPathsResult : IUtf8JsonSerializable, IModelJsonSerializable<StreamingPathsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StreamingPathsResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StreamingPathsResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingPathsResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StreamingPaths))
            {
                writer.WritePropertyName("streamingPaths"u8);
                writer.WriteStartArray();
                foreach (var item in StreamingPaths)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<StreamingPath>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DownloadPaths))
            {
                writer.WritePropertyName("downloadPaths"u8);
                writer.WriteStartArray();
                foreach (var item in DownloadPaths)
                {
                    writer.WriteStringValue(item);
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

        internal static StreamingPathsResult DeserializeStreamingPathsResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StreamingPath>> streamingPaths = default;
            Optional<IReadOnlyList<string>> downloadPaths = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streamingPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamingPath> array = new List<StreamingPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamingPath.DeserializeStreamingPath(item));
                    }
                    streamingPaths = array;
                    continue;
                }
                if (property.NameEquals("downloadPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    downloadPaths = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StreamingPathsResult(Optional.ToList(streamingPaths), Optional.ToList(downloadPaths), rawData);
        }

        StreamingPathsResult IModelJsonSerializable<StreamingPathsResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingPathsResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingPathsResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StreamingPathsResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingPathsResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StreamingPathsResult IModelSerializable<StreamingPathsResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingPathsResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStreamingPathsResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StreamingPathsResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StreamingPathsResult"/> to convert. </param>
        public static implicit operator RequestContent(StreamingPathsResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StreamingPathsResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StreamingPathsResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStreamingPathsResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
