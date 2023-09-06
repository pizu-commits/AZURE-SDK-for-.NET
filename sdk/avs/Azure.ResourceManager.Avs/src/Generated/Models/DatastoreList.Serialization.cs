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
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    internal partial class DatastoreList : IUtf8JsonSerializable, IModelJsonSerializable<DatastoreList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DatastoreList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DatastoreList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatastoreList>(this, options.Format);

            writer.WriteStartObject();
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

        internal static DatastoreList DeserializeDatastoreList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AvsPrivateCloudDatastoreData>> value = default;
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
                    List<AvsPrivateCloudDatastoreData> array = new List<AvsPrivateCloudDatastoreData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvsPrivateCloudDatastoreData.DeserializeAvsPrivateCloudDatastoreData(item));
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
            return new DatastoreList(Optional.ToList(value), nextLink.Value, rawData);
        }

        DatastoreList IModelJsonSerializable<DatastoreList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatastoreList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDatastoreList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DatastoreList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatastoreList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DatastoreList IModelSerializable<DatastoreList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatastoreList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDatastoreList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DatastoreList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DatastoreList"/> to convert. </param>
        public static implicit operator RequestContent(DatastoreList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DatastoreList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DatastoreList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDatastoreList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
