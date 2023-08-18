// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchTaskContainerSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ContainerRunOptions))
            {
                writer.WritePropertyName("containerRunOptions"u8);
                writer.WriteStringValue(ContainerRunOptions);
            }
            writer.WritePropertyName("imageName"u8);
            writer.WriteStringValue(ImageName);
            if (Core.Optional.IsDefined(Registry))
            {
                writer.WritePropertyName("registry"u8);
                writer.WriteObjectValue(Registry);
            }
            if (Core.Optional.IsDefined(WorkingDirectory))
            {
                writer.WritePropertyName("workingDirectory"u8);
                writer.WriteStringValue(WorkingDirectory.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static BatchTaskContainerSettings DeserializeBatchTaskContainerSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> containerRunOptions = default;
            string imageName = default;
            Core.Optional<BatchVmContainerRegistry> registry = default;
            Core.Optional<BatchContainerWorkingDirectory> workingDirectory = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerRunOptions"u8))
                {
                    containerRunOptions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageName"u8))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registry = BatchVmContainerRegistry.DeserializeBatchVmContainerRegistry(property.Value);
                    continue;
                }
                if (property.NameEquals("workingDirectory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workingDirectory = property.Value.GetString().ToBatchContainerWorkingDirectory();
                    continue;
                }
            }
            return new BatchTaskContainerSettings(containerRunOptions.Value, imageName, registry.Value, Core.Optional.ToNullable(workingDirectory));
        }
    }
}
