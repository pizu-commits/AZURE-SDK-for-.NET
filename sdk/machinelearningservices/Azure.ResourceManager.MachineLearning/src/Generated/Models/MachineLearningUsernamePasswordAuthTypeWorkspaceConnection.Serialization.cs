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
    public partial class MachineLearningUsernamePasswordAuthTypeWorkspaceConnection : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                if (Credentials is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MachineLearningWorkspaceConnectionUsernamePassword>)Credentials).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(ValueFormat))
            {
                writer.WritePropertyName("valueFormat"u8);
                writer.WriteStringValue(ValueFormat.Value.ToString());
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

        internal static MachineLearningUsernamePasswordAuthTypeWorkspaceConnection DeserializeMachineLearningUsernamePasswordAuthTypeWorkspaceConnection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningWorkspaceConnectionUsernamePassword> credentials = default;
            MachineLearningConnectionAuthType authType = default;
            Optional<MachineLearningConnectionCategory> category = default;
            Optional<string> target = default;
            Optional<string> value = default;
            Optional<MachineLearningValueFormat> valueFormat = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = MachineLearningWorkspaceConnectionUsernamePassword.DeserializeMachineLearningWorkspaceConnectionUsernamePassword(property.Value);
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = new MachineLearningConnectionAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new MachineLearningConnectionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueFormat = new MachineLearningValueFormat(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningUsernamePasswordAuthTypeWorkspaceConnection(authType, Optional.ToNullable(category), target.Value, value.Value, Optional.ToNullable(valueFormat), credentials.Value, rawData);
        }

        MachineLearningUsernamePasswordAuthTypeWorkspaceConnection IModelJsonSerializable<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningUsernamePasswordAuthTypeWorkspaceConnection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningUsernamePasswordAuthTypeWorkspaceConnection IModelSerializable<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningUsernamePasswordAuthTypeWorkspaceConnection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningUsernamePasswordAuthTypeWorkspaceConnection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningUsernamePasswordAuthTypeWorkspaceConnection"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningUsernamePasswordAuthTypeWorkspaceConnection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningUsernamePasswordAuthTypeWorkspaceConnection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningUsernamePasswordAuthTypeWorkspaceConnection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningUsernamePasswordAuthTypeWorkspaceConnection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
