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
    public partial class AgentRegistrationKeys : IUtf8JsonSerializable, IModelJsonSerializable<AgentRegistrationKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AgentRegistrationKeys>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AgentRegistrationKeys>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AgentRegistrationKeys>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Primary))
            {
                writer.WritePropertyName("primary"u8);
                writer.WriteStringValue(Primary);
            }
            if (Optional.IsDefined(Secondary))
            {
                writer.WritePropertyName("secondary"u8);
                writer.WriteStringValue(Secondary);
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

        internal static AgentRegistrationKeys DeserializeAgentRegistrationKeys(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primary = default;
            Optional<string> secondary = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primary"u8))
                {
                    primary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondary"u8))
                {
                    secondary = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AgentRegistrationKeys(primary.Value, secondary.Value, rawData);
        }

        AgentRegistrationKeys IModelJsonSerializable<AgentRegistrationKeys>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AgentRegistrationKeys>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentRegistrationKeys(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AgentRegistrationKeys>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AgentRegistrationKeys>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AgentRegistrationKeys IModelSerializable<AgentRegistrationKeys>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AgentRegistrationKeys>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAgentRegistrationKeys(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AgentRegistrationKeys"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AgentRegistrationKeys"/> to convert. </param>
        public static implicit operator RequestContent(AgentRegistrationKeys model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AgentRegistrationKeys"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AgentRegistrationKeys(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAgentRegistrationKeys(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
