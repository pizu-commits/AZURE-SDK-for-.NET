// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class HostPoolRegistrationInfoPatch : IUtf8JsonSerializable, IJsonModel<HostPoolRegistrationInfoPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostPoolRegistrationInfoPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HostPoolRegistrationInfoPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolRegistrationInfoPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostPoolRegistrationInfoPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(RegistrationTokenOperation))
            {
                writer.WritePropertyName("registrationTokenOperation"u8);
                writer.WriteStringValue(RegistrationTokenOperation.Value.ToString());
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

        HostPoolRegistrationInfoPatch IJsonModel<HostPoolRegistrationInfoPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolRegistrationInfoPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostPoolRegistrationInfoPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostPoolRegistrationInfoPatch(document.RootElement, options);
        }

        internal static HostPoolRegistrationInfoPatch DeserializeHostPoolRegistrationInfoPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? expirationTime = default;
            HostPoolRegistrationTokenOperation? registrationTokenOperation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expirationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("registrationTokenOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registrationTokenOperation = new HostPoolRegistrationTokenOperation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HostPoolRegistrationInfoPatch(expirationTime, registrationTokenOperation, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HostPoolRegistrationInfoPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolRegistrationInfoPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HostPoolRegistrationInfoPatch)} does not support writing '{options.Format}' format.");
            }
        }

        HostPoolRegistrationInfoPatch IPersistableModel<HostPoolRegistrationInfoPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolRegistrationInfoPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostPoolRegistrationInfoPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HostPoolRegistrationInfoPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostPoolRegistrationInfoPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
