// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningTrialComponent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(CodeId))
            {
                if (CodeId != null)
                {
                    writer.WritePropertyName("codeId"u8);
                    writer.WriteStringValue(CodeId);
                }
                else
                {
                    writer.WriteNull("codeId");
                }
            }
            writer.WritePropertyName("command"u8);
            writer.WriteStringValue(Command);
            if (Core.Optional.IsDefined(Distribution))
            {
                if (Distribution != null)
                {
                    writer.WritePropertyName("distribution"u8);
                    writer.WriteObjectValue(Distribution);
                }
                else
                {
                    writer.WriteNull("distribution");
                }
            }
            writer.WritePropertyName("environmentId"u8);
            writer.WriteStringValue(EnvironmentId);
            if (Core.Optional.IsCollectionDefined(EnvironmentVariables))
            {
                if (EnvironmentVariables != null)
                {
                    writer.WritePropertyName("environmentVariables"u8);
                    writer.WriteStartObject();
                    foreach (var item in EnvironmentVariables)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("environmentVariables");
                }
            }
            if (Core.Optional.IsDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteObjectValue(Resources);
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningTrialComponent DeserializeMachineLearningTrialComponent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceIdentifier> codeId = default;
            string command = default;
            Core.Optional<MachineLearningDistributionConfiguration> distribution = default;
            ResourceIdentifier environmentId = default;
            Core.Optional<IDictionary<string, string>> environmentVariables = default;
            Core.Optional<MachineLearningJobResourceConfiguration> resources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeId = null;
                        continue;
                    }
                    codeId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("command"u8))
                {
                    command = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distribution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        distribution = null;
                        continue;
                    }
                    distribution = MachineLearningDistributionConfiguration.DeserializeMachineLearningDistributionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentId"u8))
                {
                    environmentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentVariables = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resources = MachineLearningJobResourceConfiguration.DeserializeMachineLearningJobResourceConfiguration(property.Value);
                    continue;
                }
            }
            return new MachineLearningTrialComponent(codeId.Value, command, distribution.Value, environmentId, Core.Optional.ToDictionary(environmentVariables), resources.Value);
        }
    }
}
