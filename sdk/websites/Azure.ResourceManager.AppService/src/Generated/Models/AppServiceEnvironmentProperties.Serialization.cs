// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceEnvironmentProperties : IUtf8JsonSerializable, IJsonModel<AppServiceEnvironmentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceEnvironmentProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AppServiceEnvironmentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AppServiceEnvironmentProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AppServiceEnvironmentProperties>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToSerialString());
                }
            }
            writer.WritePropertyName("virtualNetwork"u8);
            writer.WriteObjectValue(VirtualNetwork);
            if (Optional.IsDefined(InternalLoadBalancingMode))
            {
                writer.WritePropertyName("internalLoadBalancingMode"u8);
                writer.WriteStringValue(InternalLoadBalancingMode.Value.ToString());
            }
            if (Optional.IsDefined(MultiSize))
            {
                writer.WritePropertyName("multiSize"u8);
                writer.WriteStringValue(MultiSize);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(MultiRoleCount))
                {
                    writer.WritePropertyName("multiRoleCount"u8);
                    writer.WriteNumberValue(MultiRoleCount.Value);
                }
            }
            if (Optional.IsDefined(IPSslAddressCount))
            {
                writer.WritePropertyName("ipsslAddressCount"u8);
                writer.WriteNumberValue(IPSslAddressCount.Value);
            }
            if (Optional.IsDefined(DnsSuffix))
            {
                writer.WritePropertyName("dnsSuffix"u8);
                writer.WriteStringValue(DnsSuffix);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(MaximumNumberOfMachines))
                {
                    writer.WritePropertyName("maximumNumberOfMachines"u8);
                    writer.WriteNumberValue(MaximumNumberOfMachines.Value);
                }
            }
            if (Optional.IsDefined(FrontEndScaleFactor))
            {
                writer.WritePropertyName("frontEndScaleFactor"u8);
                writer.WriteNumberValue(FrontEndScaleFactor.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsSuspended))
                {
                    writer.WritePropertyName("suspended"u8);
                    writer.WriteBooleanValue(IsSuspended.Value);
                }
            }
            if (Optional.IsCollectionDefined(ClusterSettings))
            {
                writer.WritePropertyName("clusterSettings"u8);
                writer.WriteStartArray();
                foreach (var item in ClusterSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserWhitelistedIPRanges))
            {
                writer.WritePropertyName("userWhitelistedIpRanges"u8);
                writer.WriteStartArray();
                foreach (var item in UserWhitelistedIPRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(HasLinuxWorkers))
                {
                    writer.WritePropertyName("hasLinuxWorkers"u8);
                    writer.WriteBooleanValue(HasLinuxWorkers.Value);
                }
            }
            if (Optional.IsDefined(DedicatedHostCount))
            {
                writer.WritePropertyName("dedicatedHostCount"u8);
                writer.WriteNumberValue(DedicatedHostCount.Value);
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        AppServiceEnvironmentProperties IJsonModel<AppServiceEnvironmentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceEnvironmentProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceEnvironmentProperties(document.RootElement, options);
        }

        internal static AppServiceEnvironmentProperties DeserializeAppServiceEnvironmentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<HostingEnvironmentStatus> status = default;
            AppServiceVirtualNetworkProfile virtualNetwork = default;
            Optional<LoadBalancingMode> internalLoadBalancingMode = default;
            Optional<string> multiSize = default;
            Optional<int> multiRoleCount = default;
            Optional<int> ipSslAddressCount = default;
            Optional<string> dnsSuffix = default;
            Optional<int> maximumNumberOfMachines = default;
            Optional<int> frontEndScaleFactor = default;
            Optional<bool> suspended = default;
            Optional<IList<AppServiceNameValuePair>> clusterSettings = default;
            Optional<IList<string>> userWhitelistedIPRanges = default;
            Optional<bool> hasLinuxWorkers = default;
            Optional<int> dedicatedHostCount = default;
            Optional<bool> zoneRedundant = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = property.Value.GetString().ToProvisioningState();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToHostingEnvironmentStatus();
                    continue;
                }
                if (property.NameEquals("virtualNetwork"u8))
                {
                    virtualNetwork = AppServiceVirtualNetworkProfile.DeserializeAppServiceVirtualNetworkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("internalLoadBalancingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internalLoadBalancingMode = new LoadBalancingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiSize"u8))
                {
                    multiSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiRoleCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multiRoleCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ipsslAddressCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipSslAddressCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dnsSuffix"u8))
                {
                    dnsSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumNumberOfMachines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumNumberOfMachines = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frontEndScaleFactor"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frontEndScaleFactor = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("suspended"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    suspended = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("clusterSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppServiceNameValuePair> array = new List<AppServiceNameValuePair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item));
                    }
                    clusterSettings = array;
                    continue;
                }
                if (property.NameEquals("userWhitelistedIpRanges"u8))
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
                    userWhitelistedIPRanges = array;
                    continue;
                }
                if (property.NameEquals("hasLinuxWorkers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasLinuxWorkers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dedicatedHostCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dedicatedHostCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("zoneRedundant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceEnvironmentProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(status), virtualNetwork, Optional.ToNullable(internalLoadBalancingMode), multiSize.Value, Optional.ToNullable(multiRoleCount), Optional.ToNullable(ipSslAddressCount), dnsSuffix.Value, Optional.ToNullable(maximumNumberOfMachines), Optional.ToNullable(frontEndScaleFactor), Optional.ToNullable(suspended), Optional.ToList(clusterSettings), Optional.ToList(userWhitelistedIPRanges), Optional.ToNullable(hasLinuxWorkers), Optional.ToNullable(dedicatedHostCount), Optional.ToNullable(zoneRedundant), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceEnvironmentProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceEnvironmentProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppServiceEnvironmentProperties IPersistableModel<AppServiceEnvironmentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceEnvironmentProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppServiceEnvironmentProperties(document.RootElement, options);
        }

        string IPersistableModel<AppServiceEnvironmentProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
