// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class OrchestratorVersionProfile
    {
        internal static OrchestratorVersionProfile DeserializeOrchestratorVersionProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> isPreview = default;
            Core.Optional<bool> @default = default;
            Core.Optional<string> orchestratorType = default;
            Core.Optional<string> orchestratorVersion = default;
            Core.Optional<IReadOnlyList<OrchestratorProfile>> upgrades = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("orchestratorType"u8))
                {
                    orchestratorType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("orchestratorVersion"u8))
                {
                    orchestratorVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgrades"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OrchestratorProfile> array = new List<OrchestratorProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OrchestratorProfile.DeserializeOrchestratorProfile(item));
                    }
                    upgrades = array;
                    continue;
                }
            }
            return new OrchestratorVersionProfile(Core.Optional.ToNullable(isPreview), Core.Optional.ToNullable(@default), orchestratorType.Value, orchestratorVersion.Value, Core.Optional.ToList(upgrades));
        }
    }
}
