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

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class ApplicationInsightsAgentVersions : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationInsightsAgentVersions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationInsightsAgentVersions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationInsightsAgentVersions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationInsightsAgentVersions>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ApplicationInsightsAgentVersions DeserializeApplicationInsightsAgentVersions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> java = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("java"u8))
                {
                    java = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationInsightsAgentVersions(java.Value, rawData);
        }

        ApplicationInsightsAgentVersions IModelJsonSerializable<ApplicationInsightsAgentVersions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationInsightsAgentVersions>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsAgentVersions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationInsightsAgentVersions>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationInsightsAgentVersions>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationInsightsAgentVersions IModelSerializable<ApplicationInsightsAgentVersions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationInsightsAgentVersions>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationInsightsAgentVersions(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApplicationInsightsAgentVersions"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApplicationInsightsAgentVersions"/> to convert. </param>
        public static implicit operator RequestContent(ApplicationInsightsAgentVersions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApplicationInsightsAgentVersions"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApplicationInsightsAgentVersions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationInsightsAgentVersions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
