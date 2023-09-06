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
    public partial class LogicApiResourcePolicies : IUtf8JsonSerializable, IModelJsonSerializable<LogicApiResourcePolicies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogicApiResourcePolicies>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogicApiResourcePolicies>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicApiResourcePolicies>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Content);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Content.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ContentLink))
            {
                writer.WritePropertyName("contentLink"u8);
                writer.WriteStringValue(ContentLink);
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

        internal static LogicApiResourcePolicies DeserializeLogicApiResourcePolicies(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> content = default;
            Optional<string> contentLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("contentLink"u8))
                {
                    contentLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogicApiResourcePolicies(content.Value, contentLink.Value, rawData);
        }

        LogicApiResourcePolicies IModelJsonSerializable<LogicApiResourcePolicies>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicApiResourcePolicies>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiResourcePolicies(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogicApiResourcePolicies>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicApiResourcePolicies>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogicApiResourcePolicies IModelSerializable<LogicApiResourcePolicies>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicApiResourcePolicies>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogicApiResourcePolicies(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LogicApiResourcePolicies"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LogicApiResourcePolicies"/> to convert. </param>
        public static implicit operator RequestContent(LogicApiResourcePolicies model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LogicApiResourcePolicies"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LogicApiResourcePolicies(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogicApiResourcePolicies(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
