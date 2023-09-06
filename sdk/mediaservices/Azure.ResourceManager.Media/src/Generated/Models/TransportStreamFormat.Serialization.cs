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
    public partial class TransportStreamFormat : IUtf8JsonSerializable, IModelJsonSerializable<TransportStreamFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TransportStreamFormat>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TransportStreamFormat>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportStreamFormat>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(OutputFiles))
            {
                writer.WritePropertyName("outputFiles"u8);
                writer.WriteStartArray();
                foreach (var item in OutputFiles)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MediaOutputFile>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("filenamePattern"u8);
            writer.WriteStringValue(FilenamePattern);
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

        internal static TransportStreamFormat DeserializeTransportStreamFormat(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<MediaOutputFile>> outputFiles = default;
            string odataType = default;
            string filenamePattern = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outputFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaOutputFile> array = new List<MediaOutputFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaOutputFile.DeserializeMediaOutputFile(item));
                    }
                    outputFiles = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filenamePattern"u8))
                {
                    filenamePattern = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TransportStreamFormat(odataType, filenamePattern, Optional.ToList(outputFiles), rawData);
        }

        TransportStreamFormat IModelJsonSerializable<TransportStreamFormat>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportStreamFormat>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTransportStreamFormat(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TransportStreamFormat>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportStreamFormat>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TransportStreamFormat IModelSerializable<TransportStreamFormat>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransportStreamFormat>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTransportStreamFormat(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TransportStreamFormat"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TransportStreamFormat"/> to convert. </param>
        public static implicit operator RequestContent(TransportStreamFormat model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TransportStreamFormat"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TransportStreamFormat(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTransportStreamFormat(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
