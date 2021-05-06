// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class StaticSiteBuildProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AppLocation))
            {
                writer.WritePropertyName("appLocation");
                writer.WriteStringValue(AppLocation);
            }
            if (Optional.IsDefined(ApiLocation))
            {
                writer.WritePropertyName("apiLocation");
                writer.WriteStringValue(ApiLocation);
            }
            if (Optional.IsDefined(AppArtifactLocation))
            {
                writer.WritePropertyName("appArtifactLocation");
                writer.WriteStringValue(AppArtifactLocation);
            }
            if (Optional.IsDefined(OutputLocation))
            {
                writer.WritePropertyName("outputLocation");
                writer.WriteStringValue(OutputLocation);
            }
            if (Optional.IsDefined(AppBuildCommand))
            {
                writer.WritePropertyName("appBuildCommand");
                writer.WriteStringValue(AppBuildCommand);
            }
            if (Optional.IsDefined(ApiBuildCommand))
            {
                writer.WritePropertyName("apiBuildCommand");
                writer.WriteStringValue(ApiBuildCommand);
            }
            if (Optional.IsDefined(SkipGithubActionWorkflowGeneration))
            {
                writer.WritePropertyName("skipGithubActionWorkflowGeneration");
                writer.WriteBooleanValue(SkipGithubActionWorkflowGeneration.Value);
            }
            if (Optional.IsDefined(GithubActionSecretNameOverride))
            {
                writer.WritePropertyName("githubActionSecretNameOverride");
                writer.WriteStringValue(GithubActionSecretNameOverride);
            }
            writer.WriteEndObject();
        }

        internal static StaticSiteBuildProperties DeserializeStaticSiteBuildProperties(JsonElement element)
        {
            Optional<string> appLocation = default;
            Optional<string> apiLocation = default;
            Optional<string> appArtifactLocation = default;
            Optional<string> outputLocation = default;
            Optional<string> appBuildCommand = default;
            Optional<string> apiBuildCommand = default;
            Optional<bool> skipGithubActionWorkflowGeneration = default;
            Optional<string> githubActionSecretNameOverride = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appLocation"))
                {
                    appLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiLocation"))
                {
                    apiLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appArtifactLocation"))
                {
                    appArtifactLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputLocation"))
                {
                    outputLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appBuildCommand"))
                {
                    appBuildCommand = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiBuildCommand"))
                {
                    apiBuildCommand = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skipGithubActionWorkflowGeneration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    skipGithubActionWorkflowGeneration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("githubActionSecretNameOverride"))
                {
                    githubActionSecretNameOverride = property.Value.GetString();
                    continue;
                }
            }
            return new StaticSiteBuildProperties(appLocation.Value, apiLocation.Value, appArtifactLocation.Value, outputLocation.Value, appBuildCommand.Value, apiBuildCommand.Value, Optional.ToNullable(skipGithubActionWorkflowGeneration), githubActionSecretNameOverride.Value);
        }
    }
}
