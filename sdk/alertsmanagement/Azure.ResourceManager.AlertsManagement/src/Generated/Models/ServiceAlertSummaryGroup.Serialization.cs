// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertSummaryGroup : IUtf8JsonSerializable, IJsonModel<ServiceAlertSummaryGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAlertSummaryGroup>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceAlertSummaryGroup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertSummaryGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertSummaryGroup)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Total))
            {
                writer.WritePropertyName("total"u8);
                writer.WriteNumberValue(Total.Value);
            }
            if (Optional.IsDefined(SmartGroupsCount))
            {
                writer.WritePropertyName("smartGroupsCount"u8);
                writer.WriteNumberValue(SmartGroupsCount.Value);
            }
            if (Optional.IsDefined(GroupedBy))
            {
                writer.WritePropertyName("groupedby"u8);
                writer.WriteStringValue(GroupedBy);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue<ServiceAlertSummaryGroupItemInfo>(item, options);
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

        ServiceAlertSummaryGroup IJsonModel<ServiceAlertSummaryGroup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertSummaryGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertSummaryGroup)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAlertSummaryGroup(document.RootElement, options);
        }

        internal static ServiceAlertSummaryGroup DeserializeServiceAlertSummaryGroup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? total = default;
            long? smartGroupsCount = default;
            string groupedby = default;
            IList<ServiceAlertSummaryGroupItemInfo> values = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("total"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    total = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("smartGroupsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartGroupsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("groupedby"u8))
                {
                    groupedby = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAlertSummaryGroupItemInfo> array = new List<ServiceAlertSummaryGroupItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAlertSummaryGroupItemInfo.DeserializeServiceAlertSummaryGroupItemInfo(item, options));
                    }
                    values = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceAlertSummaryGroup(total, smartGroupsCount, groupedby, values ?? new ChangeTrackingList<ServiceAlertSummaryGroupItemInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceAlertSummaryGroup>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertSummaryGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertSummaryGroup)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceAlertSummaryGroup IPersistableModel<ServiceAlertSummaryGroup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertSummaryGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceAlertSummaryGroup(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertSummaryGroup)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceAlertSummaryGroup>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
