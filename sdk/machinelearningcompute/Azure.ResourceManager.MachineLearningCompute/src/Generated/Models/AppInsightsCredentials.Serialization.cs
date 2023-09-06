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

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class AppInsightsCredentials : IUtf8JsonSerializable, IModelJsonSerializable<AppInsightsCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppInsightsCredentials>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppInsightsCredentials>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppInsightsCredentials>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(InstrumentationKey))
            {
                writer.WritePropertyName("instrumentationKey"u8);
                writer.WriteStringValue(InstrumentationKey);
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

        internal static AppInsightsCredentials DeserializeAppInsightsCredentials(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> appId = default;
            Optional<string> instrumentationKey = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instrumentationKey"u8))
                {
                    instrumentationKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppInsightsCredentials(appId.Value, instrumentationKey.Value, rawData);
        }

        AppInsightsCredentials IModelJsonSerializable<AppInsightsCredentials>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppInsightsCredentials>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppInsightsCredentials(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppInsightsCredentials>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppInsightsCredentials>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppInsightsCredentials IModelSerializable<AppInsightsCredentials>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppInsightsCredentials>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppInsightsCredentials(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppInsightsCredentials"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppInsightsCredentials"/> to convert. </param>
        public static implicit operator RequestContent(AppInsightsCredentials model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppInsightsCredentials"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppInsightsCredentials(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppInsightsCredentials(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
