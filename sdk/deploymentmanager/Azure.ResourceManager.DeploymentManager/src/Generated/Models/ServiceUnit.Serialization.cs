// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class ServiceUnit
    {
        internal static ServiceUnit DeserializeServiceUnit(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IReadOnlyList<RolloutStep>> steps = default;
            string targetResourceGroup = default;
            DeploymentMode deploymentMode = default;
            Optional<ServiceUnitArtifacts> artifacts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("steps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RolloutStep> array = new List<RolloutStep>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RolloutStep.DeserializeRolloutStep(item));
                    }
                    steps = array;
                    continue;
                }
                if (property.NameEquals("targetResourceGroup"))
                {
                    targetResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentMode"))
                {
                    deploymentMode = property.Value.GetString().ToDeploymentMode();
                    continue;
                }
                if (property.NameEquals("artifacts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    artifacts = ServiceUnitArtifacts.DeserializeServiceUnitArtifacts(property.Value);
                    continue;
                }
            }
            return new ServiceUnit(targetResourceGroup, deploymentMode, artifacts.Value, name.Value, Optional.ToList(steps));
        }
    }
}
