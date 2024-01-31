// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ProductEntityBaseProperties : IUtf8JsonSerializable, IJsonModel<ProductEntityBaseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProductEntityBaseProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProductEntityBaseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductEntityBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductEntityBaseProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Terms))
            {
                writer.WritePropertyName("terms"u8);
                writer.WriteStringValue(Terms);
            }
            if (Optional.IsDefined(IsSubscriptionRequired))
            {
                writer.WritePropertyName("subscriptionRequired"u8);
                writer.WriteBooleanValue(IsSubscriptionRequired.Value);
            }
            if (Optional.IsDefined(IsApprovalRequired))
            {
                writer.WritePropertyName("approvalRequired"u8);
                writer.WriteBooleanValue(IsApprovalRequired.Value);
            }
            if (Optional.IsDefined(SubscriptionsLimit))
            {
                writer.WritePropertyName("subscriptionsLimit"u8);
                writer.WriteNumberValue(SubscriptionsLimit.Value);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
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

        ProductEntityBaseProperties IJsonModel<ProductEntityBaseProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductEntityBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductEntityBaseProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProductEntityBaseProperties(document.RootElement, options);
        }

        internal static ProductEntityBaseProperties DeserializeProductEntityBaseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            Optional<string> terms = default;
            Optional<bool> subscriptionRequired = default;
            Optional<bool> approvalRequired = default;
            Optional<int> subscriptionsLimit = default;
            Optional<ApiManagementProductState> state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("terms"u8))
                {
                    terms = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("approvalRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    approvalRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subscriptionsLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToApiManagementProductState();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProductEntityBaseProperties(description.Value, terms.Value, Optional.ToNullable(subscriptionRequired), Optional.ToNullable(approvalRequired), Optional.ToNullable(subscriptionsLimit), Optional.ToNullable(state), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProductEntityBaseProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductEntityBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProductEntityBaseProperties)} does not support '{options.Format}' format.");
            }
        }

        ProductEntityBaseProperties IPersistableModel<ProductEntityBaseProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductEntityBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProductEntityBaseProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProductEntityBaseProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProductEntityBaseProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
