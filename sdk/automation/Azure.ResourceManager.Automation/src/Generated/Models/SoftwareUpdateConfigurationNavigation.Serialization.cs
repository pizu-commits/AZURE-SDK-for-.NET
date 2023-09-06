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

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class SoftwareUpdateConfigurationNavigation : IUtf8JsonSerializable, IModelJsonSerializable<SoftwareUpdateConfigurationNavigation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SoftwareUpdateConfigurationNavigation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SoftwareUpdateConfigurationNavigation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SoftwareUpdateConfigurationNavigation>(this, options.Format);

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

        internal static SoftwareUpdateConfigurationNavigation DeserializeSoftwareUpdateConfigurationNavigation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new SoftwareUpdateConfigurationNavigation(name.Value, rawData);
        }

        SoftwareUpdateConfigurationNavigation IModelJsonSerializable<SoftwareUpdateConfigurationNavigation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SoftwareUpdateConfigurationNavigation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareUpdateConfigurationNavigation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SoftwareUpdateConfigurationNavigation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SoftwareUpdateConfigurationNavigation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SoftwareUpdateConfigurationNavigation IModelSerializable<SoftwareUpdateConfigurationNavigation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SoftwareUpdateConfigurationNavigation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSoftwareUpdateConfigurationNavigation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SoftwareUpdateConfigurationNavigation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SoftwareUpdateConfigurationNavigation"/> to convert. </param>
        public static implicit operator RequestContent(SoftwareUpdateConfigurationNavigation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SoftwareUpdateConfigurationNavigation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SoftwareUpdateConfigurationNavigation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSoftwareUpdateConfigurationNavigation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
