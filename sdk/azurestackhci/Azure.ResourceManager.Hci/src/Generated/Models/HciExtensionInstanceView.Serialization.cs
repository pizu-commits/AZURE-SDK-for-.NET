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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciExtensionInstanceView : IUtf8JsonSerializable, IModelJsonSerializable<HciExtensionInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HciExtensionInstanceView>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HciExtensionInstanceView>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciExtensionInstanceView>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ExtensionInstanceViewType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ExtensionInstanceViewType);
            }
            if (Optional.IsDefined(TypeHandlerVersion))
            {
                writer.WritePropertyName("typeHandlerVersion"u8);
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                if (Status is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ExtensionInstanceViewStatus>)Status).Serialize(writer, options);
                }
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

        internal static HciExtensionInstanceView DeserializeHciExtensionInstanceView(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> typeHandlerVersion = default;
            Optional<ExtensionInstanceViewStatus> status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ExtensionInstanceViewStatus.DeserializeExtensionInstanceViewStatus(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HciExtensionInstanceView(name.Value, type.Value, typeHandlerVersion.Value, status.Value, rawData);
        }

        HciExtensionInstanceView IModelJsonSerializable<HciExtensionInstanceView>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciExtensionInstanceView>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHciExtensionInstanceView(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HciExtensionInstanceView>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciExtensionInstanceView>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HciExtensionInstanceView IModelSerializable<HciExtensionInstanceView>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciExtensionInstanceView>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHciExtensionInstanceView(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HciExtensionInstanceView"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HciExtensionInstanceView"/> to convert. </param>
        public static implicit operator RequestContent(HciExtensionInstanceView model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HciExtensionInstanceView"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HciExtensionInstanceView(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHciExtensionInstanceView(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
