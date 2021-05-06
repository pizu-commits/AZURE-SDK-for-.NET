// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class WebAppRuntimeSettings
    {
        internal static WebAppRuntimeSettings DeserializeWebAppRuntimeSettings(JsonElement element)
        {
            Optional<string> runtimeVersion = default;
            Optional<bool> remoteDebuggingSupported = default;
            Optional<AppInsightsWebAppStackSettings> appInsightsSettings = default;
            Optional<GitHubActionWebAppStackSettings> gitHubActionSettings = default;
            Optional<bool> isPreview = default;
            Optional<bool> isDeprecated = default;
            Optional<bool> isHidden = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<bool> isAutoUpdate = default;
            Optional<bool> isEarlyAccess = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runtimeVersion"))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteDebuggingSupported"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    remoteDebuggingSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appInsightsSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appInsightsSettings = AppInsightsWebAppStackSettings.DeserializeAppInsightsWebAppStackSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("gitHubActionSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    gitHubActionSettings = GitHubActionWebAppStackSettings.DeserializeGitHubActionWebAppStackSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("isPreview"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeprecated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDeprecated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isAutoUpdate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAutoUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEarlyAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isEarlyAccess = property.Value.GetBoolean();
                    continue;
                }
            }
            return new WebAppRuntimeSettings(runtimeVersion.Value, Optional.ToNullable(remoteDebuggingSupported), appInsightsSettings.Value, gitHubActionSettings.Value, Optional.ToNullable(isPreview), Optional.ToNullable(isDeprecated), Optional.ToNullable(isHidden), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(isAutoUpdate), Optional.ToNullable(isEarlyAccess));
        }
    }
}
