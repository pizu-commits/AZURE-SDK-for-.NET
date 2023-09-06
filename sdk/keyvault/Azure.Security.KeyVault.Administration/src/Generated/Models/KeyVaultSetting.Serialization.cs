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

namespace Azure.Security.KeyVault.Administration
{
    public partial class KeyVaultSetting : IUtf8JsonSerializable, IModelJsonSerializable<KeyVaultSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KeyVaultSetting>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KeyVaultSetting>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultSetting>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Content);
            if (Optional.IsDefined(SettingType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(SettingType.Value.ToString());
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

        internal static KeyVaultSetting DeserializeKeyVaultSetting(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string value = default;
            Optional<KeyVaultSettingType> type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new KeyVaultSettingType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KeyVaultSetting(name, value, Optional.ToNullable(type), rawData);
        }

        KeyVaultSetting IModelJsonSerializable<KeyVaultSetting>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultSetting>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultSetting(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KeyVaultSetting>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultSetting>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KeyVaultSetting IModelSerializable<KeyVaultSetting>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultSetting>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKeyVaultSetting(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KeyVaultSetting"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KeyVaultSetting"/> to convert. </param>
        public static implicit operator RequestContent(KeyVaultSetting model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KeyVaultSetting"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KeyVaultSetting(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKeyVaultSetting(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
