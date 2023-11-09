// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    [ModelReaderProxy(typeof(UnknownAlertsMetaDataProperties))]
    public partial class ServiceAlertMetadataProperties : IUtf8JsonSerializable, IJsonModel<ServiceAlertMetadataProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAlertMetadataProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ServiceAlertMetadataProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("metadataIdentifier"u8);
            writer.WriteStringValue(MetadataIdentifier.ToString());
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ServiceAlertMetadataProperties IJsonModel<ServiceAlertMetadataProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceAlertMetadataProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAlertMetadataProperties(document.RootElement, options);
        }

        internal static ServiceAlertMetadataProperties DeserializeServiceAlertMetadataProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("metadataIdentifier", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "MonitorServiceList": return MonitorServiceList.DeserializeMonitorServiceList(element);
                }
            }
            return UnknownAlertsMetaDataProperties.DeserializeUnknownAlertsMetaDataProperties(element);
        }

        BinaryData IModel<ServiceAlertMetadataProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceAlertMetadataProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ServiceAlertMetadataProperties IModel<ServiceAlertMetadataProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceAlertMetadataProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeServiceAlertMetadataProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ServiceAlertMetadataProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
