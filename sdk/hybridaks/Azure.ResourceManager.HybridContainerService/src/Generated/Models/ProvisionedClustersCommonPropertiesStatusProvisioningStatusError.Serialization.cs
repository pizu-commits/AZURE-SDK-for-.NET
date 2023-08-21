// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClustersCommonPropertiesStatusProvisioningStatusError
    {
        internal static ProvisionedClustersCommonPropertiesStatusProvisioningStatusError DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatusError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> code = default;
            Core.Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new ProvisionedClustersCommonPropertiesStatusProvisioningStatusError(code.Value, message.Value);
        }
    }
}
