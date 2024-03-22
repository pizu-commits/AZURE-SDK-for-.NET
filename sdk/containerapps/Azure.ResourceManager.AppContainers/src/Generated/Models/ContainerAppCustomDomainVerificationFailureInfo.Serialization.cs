// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppCustomDomainVerificationFailureInfo : IUtf8JsonSerializable, IJsonModel<ContainerAppCustomDomainVerificationFailureInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppCustomDomainVerificationFailureInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppCustomDomainVerificationFailureInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomDomainVerificationFailureInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCustomDomainVerificationFailureInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsCollectionDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ContainerAppCustomDomainVerificationFailureInfo IJsonModel<ContainerAppCustomDomainVerificationFailureInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomDomainVerificationFailureInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCustomDomainVerificationFailureInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppCustomDomainVerificationFailureInfo(document.RootElement, options);
        }

        internal static ContainerAppCustomDomainVerificationFailureInfo DeserializeContainerAppCustomDomainVerificationFailureInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            string target = default;
            IReadOnlyList<ContainerAppCustomDomainVerificationFailureInfoDetailsItem> details = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppCustomDomainVerificationFailureInfoDetailsItem> array = new List<ContainerAppCustomDomainVerificationFailureInfoDetailsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppCustomDomainVerificationFailureInfoDetailsItem.DeserializeContainerAppCustomDomainVerificationFailureInfoDetailsItem(item, options));
                    }
                    details = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppCustomDomainVerificationFailureInfo(code, message, target, details ?? new ChangeTrackingList<ContainerAppCustomDomainVerificationFailureInfoDetailsItem>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppCustomDomainVerificationFailureInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomDomainVerificationFailureInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCustomDomainVerificationFailureInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppCustomDomainVerificationFailureInfo IPersistableModel<ContainerAppCustomDomainVerificationFailureInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomDomainVerificationFailureInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppCustomDomainVerificationFailureInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCustomDomainVerificationFailureInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppCustomDomainVerificationFailureInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
