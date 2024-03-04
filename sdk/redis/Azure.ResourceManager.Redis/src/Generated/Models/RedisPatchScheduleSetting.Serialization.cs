// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Redis;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisPatchScheduleSetting : IUtf8JsonSerializable, IJsonModel<RedisPatchScheduleSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisPatchScheduleSetting>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedisPatchScheduleSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisPatchScheduleSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisPatchScheduleSetting)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dayOfWeek"u8);
            writer.WriteStringValue(DayOfWeek.ToSerialString());
            writer.WritePropertyName("startHourUtc"u8);
            writer.WriteNumberValue(StartHourUtc);
            if (Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                writer.WriteStringValue(MaintenanceWindow.Value, "P");
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

        RedisPatchScheduleSetting IJsonModel<RedisPatchScheduleSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisPatchScheduleSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisPatchScheduleSetting)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisPatchScheduleSetting(document.RootElement, options);
        }

        internal static RedisPatchScheduleSetting DeserializeRedisPatchScheduleSetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RedisDayOfWeek dayOfWeek = default;
            int startHourUtc = default;
            TimeSpan? maintenanceWindow = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dayOfWeek"u8))
                {
                    dayOfWeek = property.Value.GetString().ToRedisDayOfWeek();
                    continue;
                }
                if (property.NameEquals("startHourUtc"u8))
                {
                    startHourUtc = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maintenanceWindow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceWindow = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisPatchScheduleSetting(dayOfWeek, startHourUtc, maintenanceWindow, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisPatchScheduleSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisPatchScheduleSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedisPatchScheduleSetting)} does not support '{options.Format}' format.");
            }
        }

        RedisPatchScheduleSetting IPersistableModel<RedisPatchScheduleSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisPatchScheduleSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisPatchScheduleSetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisPatchScheduleSetting)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisPatchScheduleSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
