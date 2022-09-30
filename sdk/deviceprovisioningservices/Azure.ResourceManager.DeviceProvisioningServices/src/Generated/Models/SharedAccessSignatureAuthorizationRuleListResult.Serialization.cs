// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    internal partial class SharedAccessSignatureAuthorizationRuleListResult
    {
        internal static SharedAccessSignatureAuthorizationRuleListResult DeserializeSharedAccessSignatureAuthorizationRuleListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DeviceProvisioningServicesSharedAccessKey>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DeviceProvisioningServicesSharedAccessKey> array = new List<DeviceProvisioningServicesSharedAccessKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesSharedAccessKey.DeserializeDeviceProvisioningServicesSharedAccessKey(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SharedAccessSignatureAuthorizationRuleListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
