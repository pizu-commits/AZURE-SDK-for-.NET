// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionRuleDataSources : IUtf8JsonSerializable, IJsonModel<DataCollectionRuleDataSources>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionRuleDataSources>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCollectionRuleDataSources>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleDataSources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleDataSources)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PerformanceCounters))
            {
                writer.WritePropertyName("performanceCounters"u8);
                writer.WriteStartArray();
                foreach (var item in PerformanceCounters)
                {
                    writer.WriteObjectValue<PerfCounterDataSource>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WindowsEventLogs))
            {
                writer.WritePropertyName("windowsEventLogs"u8);
                writer.WriteStartArray();
                foreach (var item in WindowsEventLogs)
                {
                    writer.WriteObjectValue<WindowsEventLogDataSource>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Syslog))
            {
                writer.WritePropertyName("syslog"u8);
                writer.WriteStartArray();
                foreach (var item in Syslog)
                {
                    writer.WriteObjectValue<SyslogDataSource>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue<ExtensionDataSource>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LogFiles))
            {
                writer.WritePropertyName("logFiles"u8);
                writer.WriteStartArray();
                foreach (var item in LogFiles)
                {
                    writer.WriteObjectValue<LogFilesDataSource>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IisLogs))
            {
                writer.WritePropertyName("iisLogs"u8);
                writer.WriteStartArray();
                foreach (var item in IisLogs)
                {
                    writer.WriteObjectValue<IisLogsDataSource>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WindowsFirewallLogs))
            {
                writer.WritePropertyName("windowsFirewallLogs"u8);
                writer.WriteStartArray();
                foreach (var item in WindowsFirewallLogs)
                {
                    writer.WriteObjectValue<WindowsFirewallLogsDataSource>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrometheusForwarder))
            {
                writer.WritePropertyName("prometheusForwarder"u8);
                writer.WriteStartArray();
                foreach (var item in PrometheusForwarder)
                {
                    writer.WriteObjectValue<PrometheusForwarderDataSource>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PlatformTelemetry))
            {
                writer.WritePropertyName("platformTelemetry"u8);
                writer.WriteStartArray();
                foreach (var item in PlatformTelemetry)
                {
                    writer.WriteObjectValue<PlatformTelemetryDataSource>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DataImports))
            {
                writer.WritePropertyName("dataImports"u8);
                writer.WriteObjectValue<DataSourcesSpecDataImports>(DataImports, options);
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

        DataCollectionRuleDataSources IJsonModel<DataCollectionRuleDataSources>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleDataSources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleDataSources)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRuleDataSources(document.RootElement, options);
        }

        internal static DataCollectionRuleDataSources DeserializeDataCollectionRuleDataSources(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<PerfCounterDataSource> performanceCounters = default;
            IList<WindowsEventLogDataSource> windowsEventLogs = default;
            IList<SyslogDataSource> syslog = default;
            IList<ExtensionDataSource> extensions = default;
            IList<LogFilesDataSource> logFiles = default;
            IList<IisLogsDataSource> iisLogs = default;
            IList<WindowsFirewallLogsDataSource> windowsFirewallLogs = default;
            IList<PrometheusForwarderDataSource> prometheusForwarder = default;
            IList<PlatformTelemetryDataSource> platformTelemetry = default;
            DataSourcesSpecDataImports dataImports = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("performanceCounters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PerfCounterDataSource> array = new List<PerfCounterDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PerfCounterDataSource.DeserializePerfCounterDataSource(item, options));
                    }
                    performanceCounters = array;
                    continue;
                }
                if (property.NameEquals("windowsEventLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WindowsEventLogDataSource> array = new List<WindowsEventLogDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WindowsEventLogDataSource.DeserializeWindowsEventLogDataSource(item, options));
                    }
                    windowsEventLogs = array;
                    continue;
                }
                if (property.NameEquals("syslog"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyslogDataSource> array = new List<SyslogDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyslogDataSource.DeserializeSyslogDataSource(item, options));
                    }
                    syslog = array;
                    continue;
                }
                if (property.NameEquals("extensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExtensionDataSource> array = new List<ExtensionDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExtensionDataSource.DeserializeExtensionDataSource(item, options));
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("logFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogFilesDataSource> array = new List<LogFilesDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogFilesDataSource.DeserializeLogFilesDataSource(item, options));
                    }
                    logFiles = array;
                    continue;
                }
                if (property.NameEquals("iisLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IisLogsDataSource> array = new List<IisLogsDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IisLogsDataSource.DeserializeIisLogsDataSource(item, options));
                    }
                    iisLogs = array;
                    continue;
                }
                if (property.NameEquals("windowsFirewallLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WindowsFirewallLogsDataSource> array = new List<WindowsFirewallLogsDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WindowsFirewallLogsDataSource.DeserializeWindowsFirewallLogsDataSource(item, options));
                    }
                    windowsFirewallLogs = array;
                    continue;
                }
                if (property.NameEquals("prometheusForwarder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrometheusForwarderDataSource> array = new List<PrometheusForwarderDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrometheusForwarderDataSource.DeserializePrometheusForwarderDataSource(item, options));
                    }
                    prometheusForwarder = array;
                    continue;
                }
                if (property.NameEquals("platformTelemetry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PlatformTelemetryDataSource> array = new List<PlatformTelemetryDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PlatformTelemetryDataSource.DeserializePlatformTelemetryDataSource(item, options));
                    }
                    platformTelemetry = array;
                    continue;
                }
                if (property.NameEquals("dataImports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataImports = DataSourcesSpecDataImports.DeserializeDataSourcesSpecDataImports(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionRuleDataSources(
                performanceCounters ?? new ChangeTrackingList<PerfCounterDataSource>(),
                windowsEventLogs ?? new ChangeTrackingList<WindowsEventLogDataSource>(),
                syslog ?? new ChangeTrackingList<SyslogDataSource>(),
                extensions ?? new ChangeTrackingList<ExtensionDataSource>(),
                logFiles ?? new ChangeTrackingList<LogFilesDataSource>(),
                iisLogs ?? new ChangeTrackingList<IisLogsDataSource>(),
                windowsFirewallLogs ?? new ChangeTrackingList<WindowsFirewallLogsDataSource>(),
                prometheusForwarder ?? new ChangeTrackingList<PrometheusForwarderDataSource>(),
                platformTelemetry ?? new ChangeTrackingList<PlatformTelemetryDataSource>(),
                dataImports,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionRuleDataSources>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleDataSources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleDataSources)} does not support writing '{options.Format}' format.");
            }
        }

        DataCollectionRuleDataSources IPersistableModel<DataCollectionRuleDataSources>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleDataSources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCollectionRuleDataSources(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleDataSources)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionRuleDataSources>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
