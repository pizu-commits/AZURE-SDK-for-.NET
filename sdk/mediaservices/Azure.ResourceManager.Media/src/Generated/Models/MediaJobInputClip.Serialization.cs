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
    public partial class MediaJobInputClip : IUtf8JsonSerializable, IModelJsonSerializable<MediaJobInputClip>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaJobInputClip>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaJobInputClip>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobInputClip>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start"u8);
                if (Start is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClipTime>)Start).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end"u8);
                if (End is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClipTime>)End).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (Optional.IsCollectionDefined(InputDefinitions))
            {
                writer.WritePropertyName("inputDefinitions"u8);
                writer.WriteStartArray();
                foreach (var item in InputDefinitions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MediaJobInputDefinition>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        internal static MediaJobInputClip DeserializeMediaJobInputClip(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.JobInputAsset": return MediaJobInputAsset.DeserializeMediaJobInputAsset(element);
                    case "#Microsoft.Media.JobInputHttp": return MediaJobInputHttp.DeserializeMediaJobInputHttp(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<IList<string>> files = default;
            Optional<ClipTime> start = default;
            Optional<ClipTime> end = default;
            Optional<string> label = default;
            Optional<IList<MediaJobInputDefinition>> inputDefinitions = default;
            string odataType = "#Microsoft.Media.JobInputClip";
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("files"u8))
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
                    files = array;
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    start = ClipTime.DeserializeClipTime(property.Value);
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    end = ClipTime.DeserializeClipTime(property.Value);
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDefinitions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaJobInputDefinition> array = new List<MediaJobInputDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobInputDefinition.DeserializeMediaJobInputDefinition(item));
                    }
                    inputDefinitions = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaJobInputClip(odataType, Optional.ToList(files), start.Value, end.Value, label.Value, Optional.ToList(inputDefinitions), rawData);
        }

        MediaJobInputClip IModelJsonSerializable<MediaJobInputClip>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobInputClip>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobInputClip(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaJobInputClip>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobInputClip>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaJobInputClip IModelSerializable<MediaJobInputClip>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobInputClip>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaJobInputClip(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaJobInputClip"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaJobInputClip"/> to convert. </param>
        public static implicit operator RequestContent(MediaJobInputClip model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaJobInputClip"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaJobInputClip(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaJobInputClip(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
