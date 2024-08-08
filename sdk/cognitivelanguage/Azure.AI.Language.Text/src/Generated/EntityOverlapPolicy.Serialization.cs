// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    [PersistableModelProxy(typeof(UnknownEntityOverlapPolicy))]
    public partial class EntityOverlapPolicy : IUtf8JsonSerializable, IJsonModel<EntityOverlapPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EntityOverlapPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EntityOverlapPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityOverlapPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EntityOverlapPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("policyKind"u8);
            writer.WriteStringValue(PolicyKind.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        EntityOverlapPolicy IJsonModel<EntityOverlapPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityOverlapPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EntityOverlapPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEntityOverlapPolicy(document.RootElement, options);
        }

        internal static EntityOverlapPolicy DeserializeEntityOverlapPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("policyKind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "allowOverlap": return AllowOverlapEntityPolicyType.DeserializeAllowOverlapEntityPolicyType(element, options);
                    case "matchLongest": return MatchLongestEntityPolicyType.DeserializeMatchLongestEntityPolicyType(element, options);
                }
            }
            return UnknownEntityOverlapPolicy.DeserializeUnknownEntityOverlapPolicy(element, options);
        }

        BinaryData IPersistableModel<EntityOverlapPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityOverlapPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EntityOverlapPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        EntityOverlapPolicy IPersistableModel<EntityOverlapPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityOverlapPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEntityOverlapPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EntityOverlapPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EntityOverlapPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static EntityOverlapPolicy FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEntityOverlapPolicy(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
