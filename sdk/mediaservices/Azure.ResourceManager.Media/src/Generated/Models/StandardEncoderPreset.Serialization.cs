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
    public partial class StandardEncoderPreset : IUtf8JsonSerializable, IModelJsonSerializable<StandardEncoderPreset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StandardEncoderPreset>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StandardEncoderPreset>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StandardEncoderPreset>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ExperimentalOptions))
            {
                writer.WritePropertyName("experimentalOptions"u8);
                writer.WriteStartObject();
                foreach (var item in ExperimentalOptions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                if (Filters is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<FilteringOperations>)Filters).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("codecs"u8);
            writer.WriteStartArray();
            foreach (var item in Codecs)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MediaCodecBase>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("formats"u8);
            writer.WriteStartArray();
            foreach (var item in Formats)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MediaFormatBase>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static StandardEncoderPreset DeserializeStandardEncoderPreset(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> experimentalOptions = default;
            Optional<FilteringOperations> filters = default;
            IList<MediaCodecBase> codecs = default;
            IList<MediaFormatBase> formats = default;
            string odataType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("experimentalOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    experimentalOptions = dictionary;
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filters = FilteringOperations.DeserializeFilteringOperations(property.Value);
                    continue;
                }
                if (property.NameEquals("codecs"u8))
                {
                    List<MediaCodecBase> array = new List<MediaCodecBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaCodecBase.DeserializeMediaCodecBase(item));
                    }
                    codecs = array;
                    continue;
                }
                if (property.NameEquals("formats"u8))
                {
                    List<MediaFormatBase> array = new List<MediaFormatBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaFormatBase.DeserializeMediaFormatBase(item));
                    }
                    formats = array;
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
            return new StandardEncoderPreset(odataType, Optional.ToDictionary(experimentalOptions), filters.Value, codecs, formats, rawData);
        }

        StandardEncoderPreset IModelJsonSerializable<StandardEncoderPreset>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StandardEncoderPreset>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStandardEncoderPreset(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StandardEncoderPreset>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StandardEncoderPreset>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StandardEncoderPreset IModelSerializable<StandardEncoderPreset>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StandardEncoderPreset>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStandardEncoderPreset(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StandardEncoderPreset"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StandardEncoderPreset"/> to convert. </param>
        public static implicit operator RequestContent(StandardEncoderPreset model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StandardEncoderPreset"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StandardEncoderPreset(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStandardEncoderPreset(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
