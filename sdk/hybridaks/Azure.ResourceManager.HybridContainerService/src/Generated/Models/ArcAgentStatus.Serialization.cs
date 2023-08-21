// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ArcAgentStatus
    {
        internal static ArcAgentStatus DeserializeArcAgentStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DeploymentState> deploymentState = default;
            Core.Optional<string> errorMessage = default;
            Core.Optional<string> onboardingPublicKey = default;
            Core.Optional<string> agentVersion = default;
            Core.Optional<long> coreCount = default;
            Core.Optional<DateTimeOffset> managedIdentityCertificateExpirationTime = default;
            Core.Optional<DateTimeOffset> lastConnectivityTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentState = new DeploymentState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onboardingPublicKey"u8))
                {
                    onboardingPublicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("managedIdentityCertificateExpirationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedIdentityCertificateExpirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastConnectivityTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConnectivityTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ArcAgentStatus(Core.Optional.ToNullable(deploymentState), errorMessage.Value, onboardingPublicKey.Value, agentVersion.Value, Core.Optional.ToNullable(coreCount), Core.Optional.ToNullable(managedIdentityCertificateExpirationTime), Core.Optional.ToNullable(lastConnectivityTime));
        }
    }
}
