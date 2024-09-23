// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    [PersistableModelProxy(typeof(UnknownAlertsMetaDataProperties))]
    public partial class ServiceAlertMetadataProperties : IUtf8JsonSerializable, IJsonModel<ServiceAlertMetadataProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAlertMetadataProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServiceAlertMetadataProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertMetadataProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertMetadataProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("metadataIdentifier"u8);
            writer.WriteStringValue(MetadataIdentifier.ToString());
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

        ServiceAlertMetadataProperties IJsonModel<ServiceAlertMetadataProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertMetadataProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertMetadataProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAlertMetadataProperties(document.RootElement, options);
        }

        internal static ServiceAlertMetadataProperties DeserializeServiceAlertMetadataProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("metadataIdentifier", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "MonitorServiceList": return MonitorServiceList.DeserializeMonitorServiceList(element, options);
                }
            }
            return UnknownAlertsMetaDataProperties.DeserializeUnknownAlertsMetaDataProperties(element, options);
        }

        BinaryData IPersistableModel<ServiceAlertMetadataProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertMetadataProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertMetadataProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceAlertMetadataProperties IPersistableModel<ServiceAlertMetadataProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertMetadataProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceAlertMetadataProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertMetadataProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceAlertMetadataProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
