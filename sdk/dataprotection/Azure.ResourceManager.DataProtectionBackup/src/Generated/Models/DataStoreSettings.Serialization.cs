// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    [PersistableModelProxy(typeof(UnknownDataStoreParameters))]
    public partial class DataStoreSettings : IUtf8JsonSerializable, IJsonModel<DataStoreSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataStoreSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataStoreSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataStoreSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataStoreSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("dataStoreType"u8);
            writer.WriteStringValue(DataStoreType.ToString());
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

        DataStoreSettings IJsonModel<DataStoreSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataStoreSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataStoreSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataStoreSettings(document.RootElement, options);
        }

        internal static DataStoreSettings DeserializeDataStoreSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureOperationalStoreParameters": return OperationalDataStoreSettings.DeserializeOperationalDataStoreSettings(element, options);
                }
            }
            return UnknownDataStoreParameters.DeserializeUnknownDataStoreParameters(element, options);
        }

        BinaryData IPersistableModel<DataStoreSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataStoreSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataStoreSettings)} does not support writing '{options.Format}' format.");
            }
        }

        DataStoreSettings IPersistableModel<DataStoreSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataStoreSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataStoreSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataStoreSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataStoreSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
