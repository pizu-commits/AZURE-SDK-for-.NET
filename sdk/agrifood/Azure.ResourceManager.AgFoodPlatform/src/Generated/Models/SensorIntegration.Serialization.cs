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

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    public partial class SensorIntegration : IUtf8JsonSerializable, IModelJsonSerializable<SensorIntegration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SensorIntegration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SensorIntegration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SensorIntegration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteStringValue(Enabled);
            }
            if (Optional.IsDefined(ProvisioningInfo))
            {
                writer.WritePropertyName("provisioningInfo"u8);
                if (ProvisioningInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ErrorResponse>)ProvisioningInfo).Serialize(writer, options);
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

        internal static SensorIntegration DeserializeSensorIntegration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> enabled = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<ErrorResponse> provisioningInfo = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningInfo = ErrorResponse.DeserializeErrorResponse(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SensorIntegration(enabled.Value, Optional.ToNullable(provisioningState), provisioningInfo.Value, rawData);
        }

        SensorIntegration IModelJsonSerializable<SensorIntegration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SensorIntegration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSensorIntegration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SensorIntegration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SensorIntegration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SensorIntegration IModelSerializable<SensorIntegration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SensorIntegration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSensorIntegration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SensorIntegration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SensorIntegration"/> to convert. </param>
        public static implicit operator RequestContent(SensorIntegration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SensorIntegration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SensorIntegration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSensorIntegration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
