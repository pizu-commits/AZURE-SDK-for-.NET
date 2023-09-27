// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class UnknownMigrationProviderSpecificSettings
    {
        internal static UnknownMigrationProviderSpecificSettings DeserializeUnknownMigrationProviderSpecificSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownMigrationProviderSpecificSettings(instanceType);
        }
    }
}
