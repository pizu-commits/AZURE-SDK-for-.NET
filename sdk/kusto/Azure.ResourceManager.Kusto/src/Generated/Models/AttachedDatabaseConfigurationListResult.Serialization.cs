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
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class AttachedDatabaseConfigurationListResult : IUtf8JsonSerializable, IModelJsonSerializable<AttachedDatabaseConfigurationListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AttachedDatabaseConfigurationListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AttachedDatabaseConfigurationListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttachedDatabaseConfigurationListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<KustoAttachedDatabaseConfigurationData>)item).Serialize(writer, options);
                    }
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

        internal static AttachedDatabaseConfigurationListResult DeserializeAttachedDatabaseConfigurationListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<KustoAttachedDatabaseConfigurationData>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KustoAttachedDatabaseConfigurationData> array = new List<KustoAttachedDatabaseConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoAttachedDatabaseConfigurationData.DeserializeKustoAttachedDatabaseConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AttachedDatabaseConfigurationListResult(Optional.ToList(value), rawData);
        }

        AttachedDatabaseConfigurationListResult IModelJsonSerializable<AttachedDatabaseConfigurationListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttachedDatabaseConfigurationListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAttachedDatabaseConfigurationListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AttachedDatabaseConfigurationListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttachedDatabaseConfigurationListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AttachedDatabaseConfigurationListResult IModelSerializable<AttachedDatabaseConfigurationListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttachedDatabaseConfigurationListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAttachedDatabaseConfigurationListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AttachedDatabaseConfigurationListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AttachedDatabaseConfigurationListResult"/> to convert. </param>
        public static implicit operator RequestContent(AttachedDatabaseConfigurationListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AttachedDatabaseConfigurationListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AttachedDatabaseConfigurationListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAttachedDatabaseConfigurationListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
