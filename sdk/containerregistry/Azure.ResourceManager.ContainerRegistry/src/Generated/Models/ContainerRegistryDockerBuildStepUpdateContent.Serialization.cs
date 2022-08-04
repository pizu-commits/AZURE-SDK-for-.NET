// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryDockerBuildStepUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ImageNames))
            {
                writer.WritePropertyName("imageNames");
                writer.WriteStartArray();
                foreach (var item in ImageNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsPushEnabled))
            {
                writer.WritePropertyName("isPushEnabled");
                writer.WriteBooleanValue(IsPushEnabled.Value);
            }
            if (Optional.IsDefined(NoCache))
            {
                writer.WritePropertyName("noCache");
                writer.WriteBooleanValue(NoCache.Value);
            }
            if (Optional.IsDefined(DockerFilePath))
            {
                writer.WritePropertyName("dockerFilePath");
                writer.WriteStringValue(DockerFilePath);
            }
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("arguments");
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target");
                writer.WriteStringValue(Target);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(StepType.ToString());
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath");
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(ContextAccessToken))
            {
                writer.WritePropertyName("contextAccessToken");
                writer.WriteStringValue(ContextAccessToken);
            }
            writer.WriteEndObject();
        }
    }
}
