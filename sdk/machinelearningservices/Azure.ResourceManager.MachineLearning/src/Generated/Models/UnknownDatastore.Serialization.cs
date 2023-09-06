// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownDatastore : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningDatastoreProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningDatastoreProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningDatastoreProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningDatastoreProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("credentials"u8);
            if (Credentials is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<MachineLearningDatastoreCredentials>)Credentials).Serialize(writer, options);
            }
            writer.WritePropertyName("datastoreType"u8);
            writer.WriteStringValue(DatastoreType.ToString());
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
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

        internal static MachineLearningDatastoreProperties DeserializeUnknownDatastore(JsonElement element, ModelSerializerOptions options = default) => DeserializeMachineLearningDatastoreProperties(element, options);

        MachineLearningDatastoreProperties IModelJsonSerializable<MachineLearningDatastoreProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningDatastoreProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownDatastore(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningDatastoreProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningDatastoreProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningDatastoreProperties IModelSerializable<MachineLearningDatastoreProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningDatastoreProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningDatastoreProperties(doc.RootElement, options);
        }
    }
}
