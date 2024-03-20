// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    public partial class UpdateSupportTicket : IUtf8JsonSerializable, IJsonModel<UpdateSupportTicket>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateSupportTicket>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpdateSupportTicket>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateSupportTicket>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateSupportTicket)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(ContactDetails))
            {
                writer.WritePropertyName("contactDetails"u8);
                writer.WriteObjectValue(ContactDetails);
            }
            if (Optional.IsDefined(AdvancedDiagnosticConsent))
            {
                writer.WritePropertyName("advancedDiagnosticConsent"u8);
                writer.WriteStringValue(AdvancedDiagnosticConsent.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SecondaryConsent))
            {
                writer.WritePropertyName("secondaryConsent"u8);
                writer.WriteStartArray();
                foreach (var item in SecondaryConsent)
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

        UpdateSupportTicket IJsonModel<UpdateSupportTicket>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateSupportTicket>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateSupportTicket)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateSupportTicket(document.RootElement, options);
        }

        internal static UpdateSupportTicket DeserializeUpdateSupportTicket(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SupportSeverityLevel? severity = default;
            SupportTicketStatus? status = default;
            SupportContactProfileContent contactDetails = default;
            AdvancedDiagnosticConsent? advancedDiagnosticConsent = default;
            IList<SecondaryConsent> secondaryConsent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new SupportSeverityLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SupportTicketStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contactDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contactDetails = SupportContactProfileContent.DeserializeSupportContactProfileContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("advancedDiagnosticConsent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    advancedDiagnosticConsent = new AdvancedDiagnosticConsent(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secondaryConsent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecondaryConsent> array = new List<SecondaryConsent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.SecondaryConsent.DeserializeSecondaryConsent(item, options));
                    }
                    secondaryConsent = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpdateSupportTicket(
                severity,
                status,
                contactDetails,
                advancedDiagnosticConsent,
                secondaryConsent ?? new ChangeTrackingList<SecondaryConsent>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateSupportTicket>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateSupportTicket>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateSupportTicket)} does not support '{options.Format}' format.");
            }
        }

        UpdateSupportTicket IPersistableModel<UpdateSupportTicket>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateSupportTicket>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdateSupportTicket(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateSupportTicket)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateSupportTicket>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
