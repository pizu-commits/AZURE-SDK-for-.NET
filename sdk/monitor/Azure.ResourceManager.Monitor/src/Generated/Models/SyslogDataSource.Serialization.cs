// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class SyslogDataSource : IUtf8JsonSerializable, IJsonModel<SyslogDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyslogDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SyslogDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyslogDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyslogDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Streams))
            {
                writer.WritePropertyName("streams"u8);
                writer.WriteStartArray();
                foreach (var item in Streams)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FacilityNames))
            {
                writer.WritePropertyName("facilityNames"u8);
                writer.WriteStartArray();
                foreach (var item in FacilityNames)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LogLevels))
            {
                writer.WritePropertyName("logLevels"u8);
                writer.WriteStartArray();
                foreach (var item in LogLevels)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        SyslogDataSource IJsonModel<SyslogDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyslogDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyslogDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyslogDataSource(document.RootElement, options);
        }

        internal static SyslogDataSource DeserializeSyslogDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SyslogDataSourceStream> streams = default;
            IList<SyslogDataSourceFacilityName> facilityNames = default;
            IList<SyslogDataSourceLogLevel> logLevels = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyslogDataSourceStream> array = new List<SyslogDataSourceStream>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SyslogDataSourceStream(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("facilityNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyslogDataSourceFacilityName> array = new List<SyslogDataSourceFacilityName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SyslogDataSourceFacilityName(item.GetString()));
                    }
                    facilityNames = array;
                    continue;
                }
                if (property.NameEquals("logLevels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyslogDataSourceLogLevel> array = new List<SyslogDataSourceLogLevel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SyslogDataSourceLogLevel(item.GetString()));
                    }
                    logLevels = array;
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SyslogDataSource(streams ?? new ChangeTrackingList<SyslogDataSourceStream>(), facilityNames ?? new ChangeTrackingList<SyslogDataSourceFacilityName>(), logLevels ?? new ChangeTrackingList<SyslogDataSourceLogLevel>(), name, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SyslogDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyslogDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SyslogDataSource)} does not support '{options.Format}' format.");
            }
        }

        SyslogDataSource IPersistableModel<SyslogDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyslogDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyslogDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyslogDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyslogDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
