// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageEnableProtectionContent : IUtf8JsonSerializable, IJsonModel<InMageEnableProtectionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageEnableProtectionContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InMageEnableProtectionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageEnableProtectionContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VmFriendlyName))
            {
                writer.WritePropertyName("vmFriendlyName"u8);
                writer.WriteStringValue(VmFriendlyName);
            }
            writer.WritePropertyName("masterTargetId"u8);
            writer.WriteStringValue(MasterTargetId);
            writer.WritePropertyName("processServerId"u8);
            writer.WriteStringValue(ProcessServerId);
            writer.WritePropertyName("retentionDrive"u8);
            writer.WriteStringValue(RetentionDrive);
            if (Optional.IsDefined(RunAsAccountId))
            {
                writer.WritePropertyName("runAsAccountId"u8);
                writer.WriteStringValue(RunAsAccountId);
            }
            writer.WritePropertyName("multiVmGroupId"u8);
            writer.WriteStringValue(MultiVmGroupId);
            writer.WritePropertyName("multiVmGroupName"u8);
            writer.WriteStringValue(MultiVmGroupName);
            if (Optional.IsDefined(DatastoreName))
            {
                writer.WritePropertyName("datastoreName"u8);
                writer.WriteStringValue(DatastoreName);
            }
            if (Optional.IsDefined(DiskExclusionContent))
            {
                writer.WritePropertyName("diskExclusionInput"u8);
                writer.WriteObjectValue(DiskExclusionContent, options);
            }
            if (Optional.IsCollectionDefined(DisksToInclude))
            {
                writer.WritePropertyName("disksToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in DisksToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        InMageEnableProtectionContent IJsonModel<InMageEnableProtectionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageEnableProtectionContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageEnableProtectionContent(document.RootElement, options);
        }

        internal static InMageEnableProtectionContent DeserializeInMageEnableProtectionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vmFriendlyName = default;
            string masterTargetId = default;
            Guid processServerId = default;
            string retentionDrive = default;
            string runAsAccountId = default;
            string multiVmGroupId = default;
            string multiVmGroupName = default;
            string datastoreName = default;
            InMageDiskExclusionContent diskExclusionContent = default;
            IList<string> disksToInclude = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmFriendlyName"u8))
                {
                    vmFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("masterTargetId"u8))
                {
                    masterTargetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processServerId"u8))
                {
                    processServerId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("retentionDrive"u8))
                {
                    retentionDrive = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runAsAccountId"u8))
                {
                    runAsAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupId"u8))
                {
                    multiVmGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datastoreName"u8))
                {
                    datastoreName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskExclusionInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskExclusionContent = InMageDiskExclusionContent.DeserializeInMageDiskExclusionContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("disksToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    disksToInclude = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InMageEnableProtectionContent(
                instanceType,
                serializedAdditionalRawData,
                vmFriendlyName,
                masterTargetId,
                processServerId,
                retentionDrive,
                runAsAccountId,
                multiVmGroupId,
                multiVmGroupName,
                datastoreName,
                diskExclusionContent,
                disksToInclude ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<InMageEnableProtectionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageEnableProtectionContent)} does not support writing '{options.Format}' format.");
            }
        }

        InMageEnableProtectionContent IPersistableModel<InMageEnableProtectionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageEnableProtectionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageEnableProtectionContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageEnableProtectionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
