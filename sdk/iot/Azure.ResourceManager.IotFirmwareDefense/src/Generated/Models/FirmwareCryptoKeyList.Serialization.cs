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
    internal partial class FirmwareCryptoKeyList : IUtf8JsonSerializable, IModelJsonSerializable<FirmwareCryptoKeyList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FirmwareCryptoKeyList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FirmwareCryptoKeyList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static FirmwareCryptoKeyList DeserializeFirmwareCryptoKeyList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<FirmwareCryptoKey>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FirmwareCryptoKey> array = new List<FirmwareCryptoKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirmwareCryptoKey.DeserializeFirmwareCryptoKey(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FirmwareCryptoKeyList(Optional.ToList(value), nextLink.Value, rawData);
        }

        FirmwareCryptoKeyList IModelJsonSerializable<FirmwareCryptoKeyList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFirmwareCryptoKeyList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FirmwareCryptoKeyList>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FirmwareCryptoKeyList IModelSerializable<FirmwareCryptoKeyList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFirmwareCryptoKeyList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FirmwareCryptoKeyList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FirmwareCryptoKeyList"/> to convert. </param>
        public static implicit operator RequestContent(FirmwareCryptoKeyList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FirmwareCryptoKeyList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FirmwareCryptoKeyList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFirmwareCryptoKeyList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
