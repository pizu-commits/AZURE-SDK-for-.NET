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
    public partial class MachineLearningBatchEndpointProperties : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningBatchEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningBatchEndpointProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningBatchEndpointProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningBatchEndpointProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Defaults))
            {
                if (Defaults != null)
                {
                    writer.WritePropertyName("defaults"u8);
                    if (Defaults is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchEndpointDefaults>)Defaults).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("defaults");
                }
            }
            writer.WritePropertyName("authMode"u8);
            writer.WriteStringValue(AuthMode.ToString());
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
            if (Optional.IsDefined(Keys))
            {
                if (Keys != null)
                {
                    writer.WritePropertyName("keys"u8);
                    if (Keys is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningEndpointAuthKeys>)Keys).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("keys");
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

        internal static MachineLearningBatchEndpointProperties DeserializeMachineLearningBatchEndpointProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BatchEndpointDefaults> defaults = default;
            Optional<MachineLearningEndpointProvisioningState> provisioningState = default;
            MachineLearningEndpointAuthMode authMode = default;
            Optional<string> description = default;
            Optional<MachineLearningEndpointAuthKeys> keys = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<Uri> scoringUri = default;
            Optional<Uri> swaggerUri = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaults = null;
                        continue;
                    }
                    defaults = BatchEndpointDefaults.DeserializeBatchEndpointDefaults(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authMode"u8))
                {
                    authMode = new MachineLearningEndpointAuthMode(property.Value.GetString());
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
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keys = null;
                        continue;
                    }
                    keys = MachineLearningEndpointAuthKeys.DeserializeMachineLearningEndpointAuthKeys(property.Value);
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
                if (property.NameEquals("scoringUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scoringUri = null;
                        continue;
                    }
                    scoringUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("swaggerUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        swaggerUri = null;
                        continue;
                    }
                    swaggerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningBatchEndpointProperties(authMode, description.Value, keys.Value, Optional.ToDictionary(properties), scoringUri.Value, swaggerUri.Value, defaults.Value, Optional.ToNullable(provisioningState), rawData);
        }

        MachineLearningBatchEndpointProperties IModelJsonSerializable<MachineLearningBatchEndpointProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningBatchEndpointProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningBatchEndpointProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningBatchEndpointProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningBatchEndpointProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningBatchEndpointProperties IModelSerializable<MachineLearningBatchEndpointProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningBatchEndpointProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningBatchEndpointProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningBatchEndpointProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningBatchEndpointProperties"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningBatchEndpointProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningBatchEndpointProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningBatchEndpointProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningBatchEndpointProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
