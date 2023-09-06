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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ResourcesResponseCustomDomainsItem : IUtf8JsonSerializable, IModelJsonSerializable<ResourcesResponseCustomDomainsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourcesResponseCustomDomainsItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourcesResponseCustomDomainsItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourcesResponseCustomDomainsItem>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(EndpointId))
            {
                writer.WritePropertyName("endpointId"u8);
                writer.WriteStringValue(EndpointId);
            }
            if (Optional.IsDefined(History))
            {
                writer.WritePropertyName("history"u8);
                writer.WriteBooleanValue(History.Value);
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

        internal static ResourcesResponseCustomDomainsItem DeserializeResourcesResponseCustomDomainsItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> endpointId = default;
            Optional<bool> history = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointId"u8))
                {
                    endpointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("history"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    history = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourcesResponseCustomDomainsItem(id.Value, name.Value, endpointId.Value, Optional.ToNullable(history), rawData);
        }

        ResourcesResponseCustomDomainsItem IModelJsonSerializable<ResourcesResponseCustomDomainsItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourcesResponseCustomDomainsItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourcesResponseCustomDomainsItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourcesResponseCustomDomainsItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourcesResponseCustomDomainsItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourcesResponseCustomDomainsItem IModelSerializable<ResourcesResponseCustomDomainsItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourcesResponseCustomDomainsItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourcesResponseCustomDomainsItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourcesResponseCustomDomainsItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourcesResponseCustomDomainsItem"/> to convert. </param>
        public static implicit operator RequestContent(ResourcesResponseCustomDomainsItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourcesResponseCustomDomainsItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourcesResponseCustomDomainsItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourcesResponseCustomDomainsItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
