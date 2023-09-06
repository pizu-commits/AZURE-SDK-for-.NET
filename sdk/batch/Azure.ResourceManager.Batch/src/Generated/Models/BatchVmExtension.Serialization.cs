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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchVmExtension : IUtf8JsonSerializable, IModelJsonSerializable<BatchVmExtension>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchVmExtension>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchVmExtension>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchVmExtension>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("publisher"u8);
            writer.WriteStringValue(Publisher);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ExtensionType);
            if (Optional.IsDefined(TypeHandlerVersion))
            {
                writer.WritePropertyName("typeHandlerVersion"u8);
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (Optional.IsDefined(AutoUpgradeMinorVersion))
            {
                writer.WritePropertyName("autoUpgradeMinorVersion"u8);
                writer.WriteBooleanValue(AutoUpgradeMinorVersion.Value);
            }
            if (Optional.IsDefined(EnableAutomaticUpgrade))
            {
                writer.WritePropertyName("enableAutomaticUpgrade"u8);
                writer.WriteBooleanValue(EnableAutomaticUpgrade.Value);
            }
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Settings);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Settings.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ProtectedSettings))
            {
                writer.WritePropertyName("protectedSettings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ProtectedSettings);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ProtectedSettings.ToString()).RootElement);
#endif
            }
            if (Optional.IsCollectionDefined(ProvisionAfterExtensions))
            {
                writer.WritePropertyName("provisionAfterExtensions"u8);
                writer.WriteStartArray();
                foreach (var item in ProvisionAfterExtensions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static BatchVmExtension DeserializeBatchVmExtension(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string publisher = default;
            string type = default;
            Optional<string> typeHandlerVersion = default;
            Optional<bool> autoUpgradeMinorVersion = default;
            Optional<bool> enableAutomaticUpgrade = default;
            Optional<BinaryData> settings = default;
            Optional<BinaryData> protectedSettings = default;
            Optional<IList<string>> provisionAfterExtensions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisher"u8))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeHandlerVersion"u8))
                {
                    typeHandlerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoUpgradeMinorVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoUpgradeMinorVersion = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableAutomaticUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutomaticUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    settings = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("protectedSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedSettings = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("provisionAfterExtensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    provisionAfterExtensions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchVmExtension(name, publisher, type, typeHandlerVersion.Value, Optional.ToNullable(autoUpgradeMinorVersion), Optional.ToNullable(enableAutomaticUpgrade), settings.Value, protectedSettings.Value, Optional.ToList(provisionAfterExtensions), rawData);
        }

        BatchVmExtension IModelJsonSerializable<BatchVmExtension>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchVmExtension>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchVmExtension(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchVmExtension>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchVmExtension>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchVmExtension IModelSerializable<BatchVmExtension>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchVmExtension>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchVmExtension(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchVmExtension"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchVmExtension"/> to convert. </param>
        public static implicit operator RequestContent(BatchVmExtension model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchVmExtension"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchVmExtension(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchVmExtension(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
