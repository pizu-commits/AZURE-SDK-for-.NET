// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServices;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class VaultUsage : IUtf8JsonSerializable, IJsonModel<VaultUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VaultUsage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VaultUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultUsage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (Optional.IsDefined(QuotaPeriod))
            {
                writer.WritePropertyName("quotaPeriod"u8);
                writer.WriteStringValue(QuotaPeriod);
            }
            if (Optional.IsDefined(NextResetOn))
            {
                writer.WritePropertyName("nextResetTime"u8);
                writer.WriteStringValue(NextResetOn.Value, "O");
            }
            if (Optional.IsDefined(CurrentValue))
            {
                writer.WritePropertyName("currentValue"u8);
                writer.WriteNumberValue(CurrentValue.Value);
            }
            if (Optional.IsDefined(Limit))
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteNumberValue(Limit.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteObjectValue(Name);
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

        VaultUsage IJsonModel<VaultUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultUsage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVaultUsage(document.RootElement, options);
        }

        internal static VaultUsage DeserializeVaultUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VaultUsageUnit? unit = default;
            string quotaPeriod = default;
            DateTimeOffset? nextResetTime = default;
            long? currentValue = default;
            long? limit = default;
            VaultUsageNameInfo name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new VaultUsageUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("quotaPeriod"u8))
                {
                    quotaPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextResetTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextResetTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentValue = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = VaultUsageNameInfo.DeserializeVaultUsageNameInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VaultUsage(
                unit,
                quotaPeriod,
                nextResetTime,
                currentValue,
                limit,
                name,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VaultUsage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VaultUsage)} does not support '{options.Format}' format.");
            }
        }

        VaultUsage IPersistableModel<VaultUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVaultUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VaultUsage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VaultUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
