// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class DatabaseInviteFollowerContent : IUtf8JsonSerializable, IJsonModel<DatabaseInviteFollowerContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseInviteFollowerContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatabaseInviteFollowerContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseInviteFollowerContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseInviteFollowerContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("inviteeEmail"u8);
            writer.WriteStringValue(InviteeEmail);
            if (Optional.IsDefined(TableLevelSharingProperties))
            {
                writer.WritePropertyName("tableLevelSharingProperties"u8);
                writer.WriteObjectValue(TableLevelSharingProperties);
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

        DatabaseInviteFollowerContent IJsonModel<DatabaseInviteFollowerContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseInviteFollowerContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseInviteFollowerContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseInviteFollowerContent(document.RootElement, options);
        }

        internal static DatabaseInviteFollowerContent DeserializeDatabaseInviteFollowerContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string inviteeEmail = default;
            KustoDatabaseTableLevelSharingProperties tableLevelSharingProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inviteeEmail"u8))
                {
                    inviteeEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tableLevelSharingProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tableLevelSharingProperties = KustoDatabaseTableLevelSharingProperties.DeserializeKustoDatabaseTableLevelSharingProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DatabaseInviteFollowerContent(inviteeEmail, tableLevelSharingProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DatabaseInviteFollowerContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseInviteFollowerContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatabaseInviteFollowerContent)} does not support '{options.Format}' format.");
            }
        }

        DatabaseInviteFollowerContent IPersistableModel<DatabaseInviteFollowerContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseInviteFollowerContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatabaseInviteFollowerContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatabaseInviteFollowerContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatabaseInviteFollowerContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
