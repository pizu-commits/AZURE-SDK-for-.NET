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
    internal partial class DiskEncryptionConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<DiskEncryptionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DiskEncryptionConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DiskEncryptionConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiskEncryptionConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Targets))
            {
                writer.WritePropertyName("targets"u8);
                writer.WriteStartArray();
                foreach (var item in Targets)
                {
                    writer.WriteStringValue(item.ToSerialString());
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

        internal static DiskEncryptionConfiguration DeserializeDiskEncryptionConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<BatchDiskEncryptionTarget>> targets = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchDiskEncryptionTarget> array = new List<BatchDiskEncryptionTarget>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBatchDiskEncryptionTarget());
                    }
                    targets = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DiskEncryptionConfiguration(Optional.ToList(targets), rawData);
        }

        DiskEncryptionConfiguration IModelJsonSerializable<DiskEncryptionConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiskEncryptionConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskEncryptionConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DiskEncryptionConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiskEncryptionConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DiskEncryptionConfiguration IModelSerializable<DiskEncryptionConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiskEncryptionConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDiskEncryptionConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DiskEncryptionConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DiskEncryptionConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(DiskEncryptionConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DiskEncryptionConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DiskEncryptionConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDiskEncryptionConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
