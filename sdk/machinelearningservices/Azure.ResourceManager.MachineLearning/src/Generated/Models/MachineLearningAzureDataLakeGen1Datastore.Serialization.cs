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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAzureDataLakeGen1Datastore : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningAzureDataLakeGen1Datastore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningAzureDataLakeGen1Datastore>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningAzureDataLakeGen1Datastore>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningAzureDataLakeGen1Datastore>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceDataAccessAuthIdentity))
            {
                writer.WritePropertyName("serviceDataAccessAuthIdentity"u8);
                writer.WriteStringValue(ServiceDataAccessAuthIdentity.Value.ToString());
            }
            writer.WritePropertyName("storeName"u8);
            writer.WriteStringValue(StoreName);
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

        internal static MachineLearningAzureDataLakeGen1Datastore DeserializeMachineLearningAzureDataLakeGen1Datastore(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningServiceDataAccessAuthIdentity> serviceDataAccessAuthIdentity = default;
            string storeName = default;
            MachineLearningDatastoreCredentials credentials = default;
            DatastoreType datastoreType = default;
            Optional<bool> isDefault = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceDataAccessAuthIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceDataAccessAuthIdentity = new MachineLearningServiceDataAccessAuthIdentity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storeName"u8))
                {
                    storeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    credentials = MachineLearningDatastoreCredentials.DeserializeMachineLearningDatastoreCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("datastoreType"u8))
                {
                    datastoreType = new DatastoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningAzureDataLakeGen1Datastore(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), credentials, datastoreType, Optional.ToNullable(isDefault), Optional.ToNullable(serviceDataAccessAuthIdentity), storeName, rawData);
        }

        MachineLearningAzureDataLakeGen1Datastore IModelJsonSerializable<MachineLearningAzureDataLakeGen1Datastore>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningAzureDataLakeGen1Datastore>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAzureDataLakeGen1Datastore(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningAzureDataLakeGen1Datastore>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningAzureDataLakeGen1Datastore>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningAzureDataLakeGen1Datastore IModelSerializable<MachineLearningAzureDataLakeGen1Datastore>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningAzureDataLakeGen1Datastore>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningAzureDataLakeGen1Datastore(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningAzureDataLakeGen1Datastore"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningAzureDataLakeGen1Datastore"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningAzureDataLakeGen1Datastore model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningAzureDataLakeGen1Datastore"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningAzureDataLakeGen1Datastore(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningAzureDataLakeGen1Datastore(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
