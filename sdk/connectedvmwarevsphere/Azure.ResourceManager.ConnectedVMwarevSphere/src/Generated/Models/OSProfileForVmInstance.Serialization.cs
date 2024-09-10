// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class OSProfileForVmInstance : IUtf8JsonSerializable, IJsonModel<OSProfileForVmInstance>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OSProfileForVmInstance>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OSProfileForVmInstance>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileForVmInstance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSProfileForVmInstance)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ComputerName))
            {
                writer.WritePropertyName("computerName"u8);
                writer.WriteStringValue(ComputerName);
            }
            if (Optional.IsDefined(AdminUsername))
            {
                writer.WritePropertyName("adminUsername"u8);
                writer.WriteStringValue(AdminUsername);
            }
            if (Optional.IsDefined(AdminPassword))
            {
                writer.WritePropertyName("adminPassword"u8);
                writer.WriteStringValue(AdminPassword);
            }
            if (Optional.IsDefined(GuestId))
            {
                writer.WritePropertyName("guestId"u8);
                writer.WriteStringValue(GuestId);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OSSku))
            {
                writer.WritePropertyName("osSku"u8);
                writer.WriteStringValue(OSSku);
            }
            if (options.Format != "W" && Optional.IsDefined(ToolsRunningStatus))
            {
                writer.WritePropertyName("toolsRunningStatus"u8);
                writer.WriteStringValue(ToolsRunningStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(ToolsVersionStatus))
            {
                writer.WritePropertyName("toolsVersionStatus"u8);
                writer.WriteStringValue(ToolsVersionStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(ToolsVersion))
            {
                writer.WritePropertyName("toolsVersion"u8);
                writer.WriteStringValue(ToolsVersion);
            }
            if (Optional.IsDefined(WindowsConfiguration))
            {
                writer.WritePropertyName("windowsConfiguration"u8);
                writer.WriteObjectValue(WindowsConfiguration, options);
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

        OSProfileForVmInstance IJsonModel<OSProfileForVmInstance>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileForVmInstance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSProfileForVmInstance)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOSProfileForVmInstance(document.RootElement, options);
        }

        internal static OSProfileForVmInstance DeserializeOSProfileForVmInstance(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string computerName = default;
            string adminUsername = default;
            string adminPassword = default;
            string guestId = default;
            VMwareOSType? osType = default;
            string osSku = default;
            string toolsRunningStatus = default;
            string toolsVersionStatus = default;
            string toolsVersion = default;
            VMwareVmWindowsConfiguration windowsConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computerName"u8))
                {
                    computerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminPassword"u8))
                {
                    adminPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guestId"u8))
                {
                    guestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new VMwareOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osSku"u8))
                {
                    osSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("toolsRunningStatus"u8))
                {
                    toolsRunningStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("toolsVersionStatus"u8))
                {
                    toolsVersionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("toolsVersion"u8))
                {
                    toolsVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsConfiguration = VMwareVmWindowsConfiguration.DeserializeVMwareVmWindowsConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OSProfileForVmInstance(
                computerName,
                adminUsername,
                adminPassword,
                guestId,
                osType,
                osSku,
                toolsRunningStatus,
                toolsVersionStatus,
                toolsVersion,
                windowsConfiguration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OSProfileForVmInstance>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileForVmInstance>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OSProfileForVmInstance)} does not support writing '{options.Format}' format.");
            }
        }

        OSProfileForVmInstance IPersistableModel<OSProfileForVmInstance>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileForVmInstance>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOSProfileForVmInstance(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OSProfileForVmInstance)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OSProfileForVmInstance>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
