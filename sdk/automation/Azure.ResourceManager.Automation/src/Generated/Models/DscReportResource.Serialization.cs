// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscReportResource : IUtf8JsonSerializable, IJsonModel<DscReportResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DscReportResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DscReportResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscReportResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscReportResource)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(SourceInfo))
            {
                writer.WritePropertyName("sourceInfo"u8);
                writer.WriteStringValue(SourceInfo);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue<DscReportResourceNavigation>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ModuleName))
            {
                writer.WritePropertyName("moduleName"u8);
                writer.WriteStringValue(ModuleName);
            }
            if (Optional.IsDefined(ModuleVersion))
            {
                writer.WritePropertyName("moduleVersion"u8);
                writer.WriteStringValue(ModuleVersion);
            }
            if (Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resourceName"u8);
                writer.WriteStringValue(ResourceName);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteStringValue(Error);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(DurationInSeconds))
            {
                writer.WritePropertyName("durationInSeconds"u8);
                writer.WriteNumberValue(DurationInSeconds.Value);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartOn.Value, "O");
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

        DscReportResource IJsonModel<DscReportResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscReportResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscReportResource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDscReportResource(document.RootElement, options);
        }

        internal static DscReportResource DeserializeDscReportResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceId = default;
            string sourceInfo = default;
            IReadOnlyList<DscReportResourceNavigation> dependsOn = default;
            string moduleName = default;
            string moduleVersion = default;
            string resourceName = default;
            string error = default;
            string status = default;
            double? durationInSeconds = default;
            DateTimeOffset? startDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceInfo"u8))
                {
                    sourceInfo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DscReportResourceNavigation> array = new List<DscReportResourceNavigation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscReportResourceNavigation.DeserializeDscReportResourceNavigation(item, options));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("moduleName"u8))
                {
                    moduleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleVersion"u8))
                {
                    moduleVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("durationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInSeconds = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DscReportResource(
                resourceId,
                sourceInfo,
                dependsOn ?? new ChangeTrackingList<DscReportResourceNavigation>(),
                moduleName,
                moduleVersion,
                resourceName,
                error,
                status,
                durationInSeconds,
                startDate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DscReportResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscReportResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DscReportResource)} does not support writing '{options.Format}' format.");
            }
        }

        DscReportResource IPersistableModel<DscReportResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscReportResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDscReportResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DscReportResource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DscReportResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
