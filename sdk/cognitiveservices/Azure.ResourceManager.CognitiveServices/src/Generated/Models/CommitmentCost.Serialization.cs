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

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CommitmentCost : IUtf8JsonSerializable, IModelJsonSerializable<CommitmentCost>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CommitmentCost>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CommitmentCost>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommitmentCost>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CommitmentMeterId))
            {
                writer.WritePropertyName("commitmentMeterId"u8);
                writer.WriteStringValue(CommitmentMeterId);
            }
            if (Optional.IsDefined(OverageMeterId))
            {
                writer.WritePropertyName("overageMeterId"u8);
                writer.WriteStringValue(OverageMeterId);
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

        internal static CommitmentCost DeserializeCommitmentCost(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> commitmentMeterId = default;
            Optional<string> overageMeterId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commitmentMeterId"u8))
                {
                    commitmentMeterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("overageMeterId"u8))
                {
                    overageMeterId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CommitmentCost(commitmentMeterId.Value, overageMeterId.Value, rawData);
        }

        CommitmentCost IModelJsonSerializable<CommitmentCost>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommitmentCost>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCommitmentCost(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CommitmentCost>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommitmentCost>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CommitmentCost IModelSerializable<CommitmentCost>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommitmentCost>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCommitmentCost(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CommitmentCost"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CommitmentCost"/> to convert. </param>
        public static implicit operator RequestContent(CommitmentCost model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CommitmentCost"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CommitmentCost(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCommitmentCost(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
