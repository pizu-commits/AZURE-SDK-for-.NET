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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClustersResponseExtendedLocation : IUtf8JsonSerializable, IModelJsonSerializable<ProvisionedClustersResponseExtendedLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProvisionedClustersResponseExtendedLocation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProvisionedClustersResponseExtendedLocation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisionedClustersResponseExtendedLocationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ProvisionedClustersResponseExtendedLocationType);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        internal static ProvisionedClustersResponseExtendedLocation DeserializeProvisionedClustersResponseExtendedLocation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> type = default;
            Optional<string> name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProvisionedClustersResponseExtendedLocation(type.Value, name.Value, rawData);
        }

        ProvisionedClustersResponseExtendedLocation IModelJsonSerializable<ProvisionedClustersResponseExtendedLocation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClustersResponseExtendedLocation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProvisionedClustersResponseExtendedLocation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProvisionedClustersResponseExtendedLocation IModelSerializable<ProvisionedClustersResponseExtendedLocation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProvisionedClustersResponseExtendedLocation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProvisionedClustersResponseExtendedLocation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProvisionedClustersResponseExtendedLocation"/> to convert. </param>
        public static implicit operator RequestContent(ProvisionedClustersResponseExtendedLocation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProvisionedClustersResponseExtendedLocation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProvisionedClustersResponseExtendedLocation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProvisionedClustersResponseExtendedLocation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
