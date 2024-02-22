// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    public partial class CommunicationDomainResourcePatch : IUtf8JsonSerializable, IJsonModel<CommunicationDomainResourcePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommunicationDomainResourcePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommunicationDomainResourcePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationDomainResourcePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunicationDomainResourcePatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(UserEngagementTracking))
            {
                writer.WritePropertyName("userEngagementTracking"u8);
                writer.WriteStringValue(UserEngagementTracking.Value.ToString());
            }
            writer.WriteEndObject();
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

        CommunicationDomainResourcePatch IJsonModel<CommunicationDomainResourcePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationDomainResourcePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunicationDomainResourcePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunicationDomainResourcePatch(document.RootElement, options);
        }

        internal static CommunicationDomainResourcePatch DeserializeCommunicationDomainResourcePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<UserEngagementTracking> userEngagementTracking = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("userEngagementTracking"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userEngagementTracking = new UserEngagementTracking(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CommunicationDomainResourcePatch(Optional.ToDictionary(tags), serializedAdditionalRawData, Optional.ToNullable(userEngagementTracking));
        }

        BinaryData IPersistableModel<CommunicationDomainResourcePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationDomainResourcePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommunicationDomainResourcePatch)} does not support '{options.Format}' format.");
            }
        }

        CommunicationDomainResourcePatch IPersistableModel<CommunicationDomainResourcePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationDomainResourcePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommunicationDomainResourcePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommunicationDomainResourcePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommunicationDomainResourcePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
