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

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoAttachedDatabaseConfigurationNameAvailabilityContent : IUtf8JsonSerializable, IModelJsonSerializable<KustoAttachedDatabaseConfigurationNameAvailabilityContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KustoAttachedDatabaseConfigurationNameAvailabilityContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KustoAttachedDatabaseConfigurationNameAvailabilityContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ResourceType.ToString());
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

        internal static KustoAttachedDatabaseConfigurationNameAvailabilityContent DeserializeKustoAttachedDatabaseConfigurationNameAvailabilityContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            AttachedDatabaseType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new AttachedDatabaseType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KustoAttachedDatabaseConfigurationNameAvailabilityContent(name, type, rawData);
        }

        KustoAttachedDatabaseConfigurationNameAvailabilityContent IModelJsonSerializable<KustoAttachedDatabaseConfigurationNameAvailabilityContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoAttachedDatabaseConfigurationNameAvailabilityContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KustoAttachedDatabaseConfigurationNameAvailabilityContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KustoAttachedDatabaseConfigurationNameAvailabilityContent IModelSerializable<KustoAttachedDatabaseConfigurationNameAvailabilityContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKustoAttachedDatabaseConfigurationNameAvailabilityContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KustoAttachedDatabaseConfigurationNameAvailabilityContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KustoAttachedDatabaseConfigurationNameAvailabilityContent"/> to convert. </param>
        public static implicit operator RequestContent(KustoAttachedDatabaseConfigurationNameAvailabilityContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KustoAttachedDatabaseConfigurationNameAvailabilityContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KustoAttachedDatabaseConfigurationNameAvailabilityContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKustoAttachedDatabaseConfigurationNameAvailabilityContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
