// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmDiscoveredProtectedVmDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmDiscoveredProtectedVmDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmDiscoveredProtectedVmDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InMageRcmDiscoveredProtectedVmDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmDiscoveredProtectedVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmDiscoveredProtectedVmDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(VCenterId))
            {
                writer.WritePropertyName("vCenterId"u8);
                writer.WriteStringValue(VCenterId);
            }
            if (options.Format != "W" && Optional.IsDefined(VCenterFqdn))
            {
                writer.WritePropertyName("vCenterFqdn"u8);
                writer.WriteStringValue(VCenterFqdn);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Datastores))
            {
                writer.WritePropertyName("datastores"u8);
                writer.WriteStartArray();
                foreach (var item in Datastores)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(IPAddresses))
            {
                writer.WritePropertyName("ipAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(VMwareToolsStatus))
            {
                writer.WritePropertyName("vmwareToolsStatus"u8);
                writer.WriteStringValue(VMwareToolsStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(PowerStatus))
            {
                writer.WritePropertyName("powerStatus"u8);
                writer.WriteStringValue(PowerStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(VmFqdn))
            {
                writer.WritePropertyName("vmFqdn"u8);
                writer.WriteStringValue(VmFqdn);
            }
            if (options.Format != "W" && Optional.IsDefined(OSName))
            {
                writer.WritePropertyName("osName"u8);
                writer.WriteStringValue(OSName);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTimestamp"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedTimestamp"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(IsDeleted))
            {
                writer.WritePropertyName("isDeleted"u8);
                writer.WriteBooleanValue(IsDeleted.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastDiscoveryTimeInUtc))
            {
                writer.WritePropertyName("lastDiscoveryTimeInUtc"u8);
                writer.WriteStringValue(LastDiscoveryTimeInUtc.Value, "O");
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

        InMageRcmDiscoveredProtectedVmDetails IJsonModel<InMageRcmDiscoveredProtectedVmDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmDiscoveredProtectedVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmDiscoveredProtectedVmDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmDiscoveredProtectedVmDetails(document.RootElement, options);
        }

        internal static InMageRcmDiscoveredProtectedVmDetails DeserializeInMageRcmDiscoveredProtectedVmDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vCenterId = default;
            string vCenterFqdn = default;
            IReadOnlyList<string> datastores = default;
            IReadOnlyList<IPAddress> ipAddresses = default;
            string vmwareToolsStatus = default;
            string powerStatus = default;
            string vmFqdn = default;
            string osName = default;
            DateTimeOffset? createdTimestamp = default;
            DateTimeOffset? updatedTimestamp = default;
            bool? isDeleted = default;
            DateTimeOffset? lastDiscoveryTimeInUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCenterId"u8))
                {
                    vCenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCenterFqdn"u8))
                {
                    vCenterFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datastores"u8))
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
                    datastores = array;
                    continue;
                }
                if (property.NameEquals("ipAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    ipAddresses = array;
                    continue;
                }
                if (property.NameEquals("vmwareToolsStatus"u8))
                {
                    vmwareToolsStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("powerStatus"u8))
                {
                    powerStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmFqdn"u8))
                {
                    vmFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"u8))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isDeleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeleted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastDiscoveryTimeInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastDiscoveryTimeInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InMageRcmDiscoveredProtectedVmDetails(
                vCenterId,
                vCenterFqdn,
                datastores ?? new ChangeTrackingList<string>(),
                ipAddresses ?? new ChangeTrackingList<IPAddress>(),
                vmwareToolsStatus,
                powerStatus,
                vmFqdn,
                osName,
                createdTimestamp,
                updatedTimestamp,
                isDeleted,
                lastDiscoveryTimeInUtc,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageRcmDiscoveredProtectedVmDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmDiscoveredProtectedVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmDiscoveredProtectedVmDetails)} does not support writing '{options.Format}' format.");
            }
        }

        InMageRcmDiscoveredProtectedVmDetails IPersistableModel<InMageRcmDiscoveredProtectedVmDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmDiscoveredProtectedVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmDiscoveredProtectedVmDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmDiscoveredProtectedVmDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmDiscoveredProtectedVmDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
