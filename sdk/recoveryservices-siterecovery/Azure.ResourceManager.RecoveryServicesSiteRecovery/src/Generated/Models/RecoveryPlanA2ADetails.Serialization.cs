// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanA2ADetails
    {
        internal static RecoveryPlanA2ADetails DeserializeRecoveryPlanA2ADetails(JsonElement element)
        {
            Optional<string> primaryZone = default;
            Optional<string> recoveryZone = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryZone"))
                {
                    primaryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryZone"))
                {
                    recoveryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new RecoveryPlanA2ADetails(instanceType, primaryZone.Value, recoveryZone.Value);
        }
    }
}
