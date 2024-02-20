// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDeviceUpdateSummary : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeDeviceUpdateSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeDeviceUpdateSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxEdgeDeviceUpdateSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceUpdateSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDeviceUpdateSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceVersionNumber))
            {
                writer.WritePropertyName("deviceVersionNumber"u8);
                writer.WriteStringValue(DeviceVersionNumber);
            }
            if (Optional.IsDefined(FriendlyDeviceVersionName))
            {
                writer.WritePropertyName("friendlyDeviceVersionName"u8);
                writer.WriteStringValue(FriendlyDeviceVersionName);
            }
            if (Optional.IsDefined(DeviceLastScannedOn))
            {
                writer.WritePropertyName("deviceLastScannedDateTime"u8);
                writer.WriteStringValue(DeviceLastScannedOn.Value, "O");
            }
            if (Optional.IsDefined(LastCompletedScanJobOn))
            {
                writer.WritePropertyName("lastCompletedScanJobDateTime"u8);
                writer.WriteStringValue(LastCompletedScanJobOn.Value, "O");
            }
            if (Optional.IsDefined(LastSuccessfulScanJobOn))
            {
                writer.WritePropertyName("lastSuccessfulScanJobTime"u8);
                writer.WriteStringValue(LastSuccessfulScanJobOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastCompletedDownloadJobOn))
            {
                writer.WritePropertyName("lastCompletedDownloadJobDateTime"u8);
                writer.WriteStringValue(LastCompletedDownloadJobOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastCompletedDownloadJobId))
            {
                writer.WritePropertyName("lastCompletedDownloadJobId"u8);
                writer.WriteStringValue(LastCompletedDownloadJobId);
            }
            if (options.Format != "W" && Optional.IsDefined(LastDownloadJobStatus))
            {
                writer.WritePropertyName("lastDownloadJobStatus"u8);
                writer.WriteStringValue(LastDownloadJobStatus.Value.ToString());
            }
            if (Optional.IsDefined(LastSuccessfulInstallJobOn))
            {
                writer.WritePropertyName("lastSuccessfulInstallJobDateTime"u8);
                writer.WriteStringValue(LastSuccessfulInstallJobOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastCompletedInstallJobOn))
            {
                writer.WritePropertyName("lastCompletedInstallJobDateTime"u8);
                writer.WriteStringValue(LastCompletedInstallJobOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastCompletedInstallJobId))
            {
                writer.WritePropertyName("lastCompletedInstallJobId"u8);
                writer.WriteStringValue(LastCompletedInstallJobId);
            }
            if (options.Format != "W" && Optional.IsDefined(LastInstallJobStatus))
            {
                writer.WritePropertyName("lastInstallJobStatus"u8);
                writer.WriteStringValue(LastInstallJobStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TotalNumberOfUpdatesAvailable))
            {
                writer.WritePropertyName("totalNumberOfUpdatesAvailable"u8);
                writer.WriteNumberValue(TotalNumberOfUpdatesAvailable.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalNumberOfUpdatesPendingDownload))
            {
                writer.WritePropertyName("totalNumberOfUpdatesPendingDownload"u8);
                writer.WriteNumberValue(TotalNumberOfUpdatesPendingDownload.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalNumberOfUpdatesPendingInstall))
            {
                writer.WritePropertyName("totalNumberOfUpdatesPendingInstall"u8);
                writer.WriteNumberValue(TotalNumberOfUpdatesPendingInstall.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RebootBehavior))
            {
                writer.WritePropertyName("rebootBehavior"u8);
                writer.WriteStringValue(RebootBehavior.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OngoingUpdateOperation))
            {
                writer.WritePropertyName("ongoingUpdateOperation"u8);
                writer.WriteStringValue(OngoingUpdateOperation.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(InProgressDownloadJobId))
            {
                writer.WritePropertyName("inProgressDownloadJobId"u8);
                writer.WriteStringValue(InProgressDownloadJobId);
            }
            if (options.Format != "W" && Optional.IsDefined(InProgressInstallJobId))
            {
                writer.WritePropertyName("inProgressInstallJobId"u8);
                writer.WriteStringValue(InProgressInstallJobId);
            }
            if (options.Format != "W" && Optional.IsDefined(InProgressDownloadJobStartedOn))
            {
                writer.WritePropertyName("inProgressDownloadJobStartedDateTime"u8);
                writer.WriteStringValue(InProgressDownloadJobStartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(InProgressInstallJobStartedOn))
            {
                writer.WritePropertyName("inProgressInstallJobStartedDateTime"u8);
                writer.WriteStringValue(InProgressInstallJobStartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(UpdateTitles))
            {
                writer.WritePropertyName("updateTitles"u8);
                writer.WriteStartArray();
                foreach (var item in UpdateTitles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Updates))
            {
                writer.WritePropertyName("updates"u8);
                writer.WriteStartArray();
                foreach (var item in Updates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TotalUpdateSizeInBytes))
            {
                writer.WritePropertyName("totalUpdateSizeInBytes"u8);
                writer.WriteNumberValue(TotalUpdateSizeInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalTimeInMinutes))
            {
                writer.WritePropertyName("totalTimeInMinutes"u8);
                writer.WriteNumberValue(TotalTimeInMinutes.Value);
            }
            writer.WriteEndObject();
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

        DataBoxEdgeDeviceUpdateSummary IJsonModel<DataBoxEdgeDeviceUpdateSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceUpdateSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDeviceUpdateSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeDeviceUpdateSummary(document.RootElement, options);
        }

        internal static DataBoxEdgeDeviceUpdateSummary DeserializeDataBoxEdgeDeviceUpdateSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> deviceVersionNumber = default;
            Optional<string> friendlyDeviceVersionName = default;
            Optional<DateTimeOffset> deviceLastScannedDateTime = default;
            Optional<DateTimeOffset> lastCompletedScanJobDateTime = default;
            Optional<DateTimeOffset> lastSuccessfulScanJobTime = default;
            Optional<DateTimeOffset> lastCompletedDownloadJobDateTime = default;
            Optional<ResourceIdentifier> lastCompletedDownloadJobId = default;
            Optional<DataBoxEdgeJobStatus> lastDownloadJobStatus = default;
            Optional<DateTimeOffset> lastSuccessfulInstallJobDateTime = default;
            Optional<DateTimeOffset> lastCompletedInstallJobDateTime = default;
            Optional<ResourceIdentifier> lastCompletedInstallJobId = default;
            Optional<DataBoxEdgeJobStatus> lastInstallJobStatus = default;
            Optional<int> totalNumberOfUpdatesAvailable = default;
            Optional<int> totalNumberOfUpdatesPendingDownload = default;
            Optional<int> totalNumberOfUpdatesPendingInstall = default;
            Optional<InstallRebootBehavior> rebootBehavior = default;
            Optional<DataBoxEdgeUpdateOperation> ongoingUpdateOperation = default;
            Optional<ResourceIdentifier> inProgressDownloadJobId = default;
            Optional<ResourceIdentifier> inProgressInstallJobId = default;
            Optional<DateTimeOffset> inProgressDownloadJobStartedDateTime = default;
            Optional<DateTimeOffset> inProgressInstallJobStartedDateTime = default;
            Optional<IReadOnlyList<string>> updateTitles = default;
            Optional<IReadOnlyList<DataBoxEdgeUpdateDetails>> updates = default;
            Optional<double> totalUpdateSizeInBytes = default;
            Optional<int> totalTimeInMinutes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("deviceVersionNumber"u8))
                        {
                            deviceVersionNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyDeviceVersionName"u8))
                        {
                            friendlyDeviceVersionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceLastScannedDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deviceLastScannedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastCompletedScanJobDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastCompletedScanJobDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastSuccessfulScanJobTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSuccessfulScanJobTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastCompletedDownloadJobDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastCompletedDownloadJobDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastCompletedDownloadJobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastCompletedDownloadJobId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastDownloadJobStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastDownloadJobStatus = new DataBoxEdgeJobStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastSuccessfulInstallJobDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSuccessfulInstallJobDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastCompletedInstallJobDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastCompletedInstallJobDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastCompletedInstallJobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastCompletedInstallJobId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastInstallJobStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastInstallJobStatus = new DataBoxEdgeJobStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("totalNumberOfUpdatesAvailable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalNumberOfUpdatesAvailable = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("totalNumberOfUpdatesPendingDownload"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalNumberOfUpdatesPendingDownload = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("totalNumberOfUpdatesPendingInstall"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalNumberOfUpdatesPendingInstall = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rebootBehavior"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rebootBehavior = new InstallRebootBehavior(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ongoingUpdateOperation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ongoingUpdateOperation = new DataBoxEdgeUpdateOperation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inProgressDownloadJobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inProgressDownloadJobId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inProgressInstallJobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inProgressInstallJobId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inProgressDownloadJobStartedDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inProgressDownloadJobStartedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("inProgressInstallJobStartedDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inProgressInstallJobStartedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateTitles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            updateTitles = array;
                            continue;
                        }
                        if (property0.NameEquals("updates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeUpdateDetails> array = new List<DataBoxEdgeUpdateDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeUpdateDetails.DeserializeDataBoxEdgeUpdateDetails(item, options));
                            }
                            updates = array;
                            continue;
                        }
                        if (property0.NameEquals("totalUpdateSizeInBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalUpdateSizeInBytes = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("totalTimeInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalTimeInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxEdgeDeviceUpdateSummary(id, name, type, systemData.Value, deviceVersionNumber.Value, friendlyDeviceVersionName.Value, Optional.ToNullable(deviceLastScannedDateTime), Optional.ToNullable(lastCompletedScanJobDateTime), Optional.ToNullable(lastSuccessfulScanJobTime), Optional.ToNullable(lastCompletedDownloadJobDateTime), lastCompletedDownloadJobId.Value, Optional.ToNullable(lastDownloadJobStatus), Optional.ToNullable(lastSuccessfulInstallJobDateTime), Optional.ToNullable(lastCompletedInstallJobDateTime), lastCompletedInstallJobId.Value, Optional.ToNullable(lastInstallJobStatus), Optional.ToNullable(totalNumberOfUpdatesAvailable), Optional.ToNullable(totalNumberOfUpdatesPendingDownload), Optional.ToNullable(totalNumberOfUpdatesPendingInstall), Optional.ToNullable(rebootBehavior), Optional.ToNullable(ongoingUpdateOperation), inProgressDownloadJobId.Value, inProgressInstallJobId.Value, Optional.ToNullable(inProgressDownloadJobStartedDateTime), Optional.ToNullable(inProgressInstallJobStartedDateTime), Optional.ToList(updateTitles), Optional.ToList(updates), Optional.ToNullable(totalUpdateSizeInBytes), Optional.ToNullable(totalTimeInMinutes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeDeviceUpdateSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceUpdateSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDeviceUpdateSummary)} does not support '{options.Format}' format.");
            }
        }

        DataBoxEdgeDeviceUpdateSummary IPersistableModel<DataBoxEdgeDeviceUpdateSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceUpdateSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeDeviceUpdateSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDeviceUpdateSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeDeviceUpdateSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
