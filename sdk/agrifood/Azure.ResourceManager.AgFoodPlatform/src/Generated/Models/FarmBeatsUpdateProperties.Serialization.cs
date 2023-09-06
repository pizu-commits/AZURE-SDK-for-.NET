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
    public partial class FarmBeatsUpdateProperties : IUtf8JsonSerializable, IModelJsonSerializable<FarmBeatsUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FarmBeatsUpdateProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FarmBeatsUpdateProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FarmBeatsUpdateProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SensorIntegration))
            {
                writer.WritePropertyName("sensorIntegration"u8);
                if (SensorIntegration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SensorIntegration>)SensorIntegration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
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

        internal static FarmBeatsUpdateProperties DeserializeFarmBeatsUpdateProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SensorIntegration> sensorIntegration = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sensorIntegration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensorIntegration = SensorIntegration.DeserializeSensorIntegration(property.Value);
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FarmBeatsUpdateProperties(sensorIntegration.Value, Optional.ToNullable(publicNetworkAccess), rawData);
        }

        FarmBeatsUpdateProperties IModelJsonSerializable<FarmBeatsUpdateProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FarmBeatsUpdateProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFarmBeatsUpdateProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FarmBeatsUpdateProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FarmBeatsUpdateProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FarmBeatsUpdateProperties IModelSerializable<FarmBeatsUpdateProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FarmBeatsUpdateProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFarmBeatsUpdateProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FarmBeatsUpdateProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FarmBeatsUpdateProperties"/> to convert. </param>
        public static implicit operator RequestContent(FarmBeatsUpdateProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FarmBeatsUpdateProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FarmBeatsUpdateProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFarmBeatsUpdateProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
