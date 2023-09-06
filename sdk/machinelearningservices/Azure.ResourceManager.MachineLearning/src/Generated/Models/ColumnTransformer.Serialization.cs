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
    public partial class ColumnTransformer : IUtf8JsonSerializable, IModelJsonSerializable<ColumnTransformer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ColumnTransformer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ColumnTransformer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ColumnTransformer>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Fields))
            {
                if (Fields != null)
                {
                    writer.WritePropertyName("fields"u8);
                    writer.WriteStartArray();
                    foreach (var item in Fields)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("fields");
                }
            }
            if (Optional.IsDefined(Parameters))
            {
                if (Parameters != null)
                {
                    writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(Parameters.ToString()).RootElement);
#endif
                }
                else
                {
                    writer.WriteNull("parameters");
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

        internal static ColumnTransformer DeserializeColumnTransformer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> fields = default;
            Optional<BinaryData> parameters = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fields = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parameters = null;
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ColumnTransformer(Optional.ToList(fields), parameters.Value, rawData);
        }

        ColumnTransformer IModelJsonSerializable<ColumnTransformer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ColumnTransformer>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeColumnTransformer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ColumnTransformer>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ColumnTransformer>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ColumnTransformer IModelSerializable<ColumnTransformer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ColumnTransformer>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeColumnTransformer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ColumnTransformer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ColumnTransformer"/> to convert. </param>
        public static implicit operator RequestContent(ColumnTransformer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ColumnTransformer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ColumnTransformer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeColumnTransformer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
