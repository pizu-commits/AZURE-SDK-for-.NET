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
    public partial class AutoForecastHorizon : IUtf8JsonSerializable, IModelJsonSerializable<AutoForecastHorizon>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutoForecastHorizon>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutoForecastHorizon>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoForecastHorizon>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
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

        internal static AutoForecastHorizon DeserializeAutoForecastHorizon(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ForecastHorizonMode mode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    mode = new ForecastHorizonMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutoForecastHorizon(mode, rawData);
        }

        AutoForecastHorizon IModelJsonSerializable<AutoForecastHorizon>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoForecastHorizon>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoForecastHorizon(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutoForecastHorizon>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoForecastHorizon>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutoForecastHorizon IModelSerializable<AutoForecastHorizon>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoForecastHorizon>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutoForecastHorizon(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutoForecastHorizon"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutoForecastHorizon"/> to convert. </param>
        public static implicit operator RequestContent(AutoForecastHorizon model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutoForecastHorizon"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutoForecastHorizon(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutoForecastHorizon(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
