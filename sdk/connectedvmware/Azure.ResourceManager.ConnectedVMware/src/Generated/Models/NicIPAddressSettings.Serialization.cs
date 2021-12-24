// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    public partial class NicIPAddressSettings
    {
        internal static NicIPAddressSettings DeserializeNicIPAddressSettings(JsonElement element)
        {
            Optional<string> allocationMethod = default;
            Optional<string> ipAddress = default;
            Optional<string> subnetMask = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocationMethod"))
                {
                    allocationMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetMask"))
                {
                    subnetMask = property.Value.GetString();
                    continue;
                }
            }
            return new NicIPAddressSettings(allocationMethod.Value, ipAddress.Value, subnetMask.Value);
        }
    }
}
