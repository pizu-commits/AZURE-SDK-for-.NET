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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmentSkuDefinition : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationServiceEnvironmentSkuDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationServiceEnvironmentSkuDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationServiceEnvironmentSkuDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IntegrationServiceEnvironmentSkuDefinitionSku>)Sku).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                if (Capacity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IntegrationServiceEnvironmentSkuCapacity>)Capacity).Serialize(writer, options);
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

        internal static IntegrationServiceEnvironmentSkuDefinition DeserializeIntegrationServiceEnvironmentSkuDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceType> resourceType = default;
            Optional<IntegrationServiceEnvironmentSkuDefinitionSku> sku = default;
            Optional<IntegrationServiceEnvironmentSkuCapacity> capacity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = IntegrationServiceEnvironmentSkuDefinitionSku.DeserializeIntegrationServiceEnvironmentSkuDefinitionSku(property.Value);
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = IntegrationServiceEnvironmentSkuCapacity.DeserializeIntegrationServiceEnvironmentSkuCapacity(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IntegrationServiceEnvironmentSkuDefinition(Optional.ToNullable(resourceType), sku.Value, capacity.Value, rawData);
        }

        IntegrationServiceEnvironmentSkuDefinition IModelJsonSerializable<IntegrationServiceEnvironmentSkuDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmentSkuDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationServiceEnvironmentSkuDefinition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationServiceEnvironmentSkuDefinition IModelSerializable<IntegrationServiceEnvironmentSkuDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationServiceEnvironmentSkuDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IntegrationServiceEnvironmentSkuDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IntegrationServiceEnvironmentSkuDefinition"/> to convert. </param>
        public static implicit operator RequestContent(IntegrationServiceEnvironmentSkuDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IntegrationServiceEnvironmentSkuDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IntegrationServiceEnvironmentSkuDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationServiceEnvironmentSkuDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
