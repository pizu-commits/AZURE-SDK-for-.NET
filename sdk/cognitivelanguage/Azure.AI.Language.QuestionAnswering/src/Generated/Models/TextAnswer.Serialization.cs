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

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class TextAnswer : IUtf8JsonSerializable, IModelJsonSerializable<TextAnswer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TextAnswer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TextAnswer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextAnswer>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Answer))
            {
                writer.WritePropertyName("answer"u8);
                writer.WriteStringValue(Answer);
            }
            if (Optional.IsDefined(Confidence))
            {
                writer.WritePropertyName("confidenceScore"u8);
                writer.WriteNumberValue(Confidence.Value);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(ShortAnswer))
            {
                writer.WritePropertyName("answerSpan"u8);
                if (ShortAnswer is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AnswerSpan>)ShortAnswer).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Offset))
            {
                writer.WritePropertyName("offset"u8);
                writer.WriteNumberValue(Offset.Value);
            }
            if (Optional.IsDefined(Length))
            {
                writer.WritePropertyName("length"u8);
                writer.WriteNumberValue(Length.Value);
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

        internal static TextAnswer DeserializeTextAnswer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> answer = default;
            Optional<double> confidenceScore = default;
            Optional<string> id = default;
            Optional<AnswerSpan> answerSpan = default;
            Optional<int> offset = default;
            Optional<int> length = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("answer"u8))
                {
                    answer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("answerSpan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    answerSpan = AnswerSpan.DeserializeAnswerSpan(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    length = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TextAnswer(answer.Value, Optional.ToNullable(confidenceScore), id.Value, answerSpan.Value, Optional.ToNullable(offset), Optional.ToNullable(length), rawData);
        }

        TextAnswer IModelJsonSerializable<TextAnswer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextAnswer>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTextAnswer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TextAnswer>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextAnswer>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TextAnswer IModelSerializable<TextAnswer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextAnswer>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTextAnswer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TextAnswer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TextAnswer"/> to convert. </param>
        public static implicit operator RequestContent(TextAnswer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TextAnswer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TextAnswer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTextAnswer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
