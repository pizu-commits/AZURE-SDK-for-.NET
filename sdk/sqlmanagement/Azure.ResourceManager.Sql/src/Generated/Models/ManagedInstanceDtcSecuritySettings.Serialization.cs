// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceDtcSecuritySettings : IUtf8JsonSerializable, IJsonModel<ManagedInstanceDtcSecuritySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceDtcSecuritySettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedInstanceDtcSecuritySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceDtcSecuritySettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(TransactionManagerCommunicationSettings))
            {
                writer.WritePropertyName("transactionManagerCommunicationSettings"u8);
                writer.WriteObjectValue(TransactionManagerCommunicationSettings, options);
            }
            if (Optional.IsDefined(IsXATransactionsEnabled))
            {
                writer.WritePropertyName("xaTransactionsEnabled"u8);
                writer.WriteBooleanValue(IsXATransactionsEnabled.Value);
            }
            if (Optional.IsDefined(SnaLu6Point2TransactionsEnabled))
            {
                writer.WritePropertyName("snaLu6point2TransactionsEnabled"u8);
                writer.WriteBooleanValue(SnaLu6Point2TransactionsEnabled.Value);
            }
            if (Optional.IsDefined(XATransactionsDefaultTimeoutInSeconds))
            {
                writer.WritePropertyName("xaTransactionsDefaultTimeout"u8);
                writer.WriteNumberValue(XATransactionsDefaultTimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(XATransactionsMaximumTimeoutInSeconds))
            {
                writer.WritePropertyName("xaTransactionsMaximumTimeout"u8);
                writer.WriteNumberValue(XATransactionsMaximumTimeoutInSeconds.Value);
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
        }

        ManagedInstanceDtcSecuritySettings IJsonModel<ManagedInstanceDtcSecuritySettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceDtcSecuritySettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceDtcSecuritySettings(document.RootElement, options);
        }

        internal static ManagedInstanceDtcSecuritySettings DeserializeManagedInstanceDtcSecuritySettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedInstanceDtcTransactionManagerCommunicationSettings transactionManagerCommunicationSettings = default;
            bool? xaTransactionsEnabled = default;
            bool? snaLu6point2TransactionsEnabled = default;
            int? xaTransactionsDefaultTimeout = default;
            int? xaTransactionsMaximumTimeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transactionManagerCommunicationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transactionManagerCommunicationSettings = ManagedInstanceDtcTransactionManagerCommunicationSettings.DeserializeManagedInstanceDtcTransactionManagerCommunicationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("xaTransactionsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xaTransactionsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("snaLu6point2TransactionsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snaLu6point2TransactionsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("xaTransactionsDefaultTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xaTransactionsDefaultTimeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("xaTransactionsMaximumTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xaTransactionsMaximumTimeout = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedInstanceDtcSecuritySettings(
                transactionManagerCommunicationSettings,
                xaTransactionsEnabled,
                snaLu6point2TransactionsEnabled,
                xaTransactionsDefaultTimeout,
                xaTransactionsMaximumTimeout,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TransactionManagerCommunicationSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  transactionManagerCommunicationSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TransactionManagerCommunicationSettings))
                {
                    builder.Append("  transactionManagerCommunicationSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TransactionManagerCommunicationSettings, options, 2, false, "  transactionManagerCommunicationSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsXATransactionsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  xaTransactionsEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsXATransactionsEnabled))
                {
                    builder.Append("  xaTransactionsEnabled: ");
                    var boolValue = IsXATransactionsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SnaLu6Point2TransactionsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  snaLu6point2TransactionsEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SnaLu6Point2TransactionsEnabled))
                {
                    builder.Append("  snaLu6point2TransactionsEnabled: ");
                    var boolValue = SnaLu6Point2TransactionsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(XATransactionsDefaultTimeoutInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  xaTransactionsDefaultTimeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(XATransactionsDefaultTimeoutInSeconds))
                {
                    builder.Append("  xaTransactionsDefaultTimeout: ");
                    builder.AppendLine($"{XATransactionsDefaultTimeoutInSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(XATransactionsMaximumTimeoutInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  xaTransactionsMaximumTimeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(XATransactionsMaximumTimeoutInSeconds))
                {
                    builder.Append("  xaTransactionsMaximumTimeout: ");
                    builder.AppendLine($"{XATransactionsMaximumTimeoutInSeconds.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedInstanceDtcSecuritySettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceDtcSecuritySettings)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedInstanceDtcSecuritySettings IPersistableModel<ManagedInstanceDtcSecuritySettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedInstanceDtcSecuritySettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceDtcSecuritySettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstanceDtcSecuritySettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
