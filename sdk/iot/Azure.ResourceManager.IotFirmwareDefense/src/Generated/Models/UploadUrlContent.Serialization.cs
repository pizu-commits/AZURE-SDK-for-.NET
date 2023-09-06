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

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class UploadUrlContent : IUtf8JsonSerializable, IModelJsonSerializable<UploadUrlContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UploadUrlContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UploadUrlContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UploadUrlContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FirmwareName))
            {
                writer.WritePropertyName("firmwareId"u8);
                writer.WriteStringValue(FirmwareName);
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

        internal static UploadUrlContent DeserializeUploadUrlContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> firmwareName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firmwareId"u8))
                {
                    firmwareName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UploadUrlContent(firmwareName.Value, rawData);
        }

        UploadUrlContent IModelJsonSerializable<UploadUrlContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UploadUrlContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUploadUrlContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UploadUrlContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UploadUrlContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UploadUrlContent IModelSerializable<UploadUrlContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UploadUrlContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUploadUrlContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UploadUrlContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UploadUrlContent"/> to convert. </param>
        public static implicit operator RequestContent(UploadUrlContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UploadUrlContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UploadUrlContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUploadUrlContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
