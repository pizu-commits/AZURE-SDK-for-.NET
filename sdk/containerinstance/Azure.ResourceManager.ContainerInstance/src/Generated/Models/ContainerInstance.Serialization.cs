// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerInstance : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("image");
            writer.WriteStringValue(Image);
            if (Optional.IsCollectionDefined(Command))
            {
                writer.WritePropertyName("command");
                writer.WriteStartArray();
                foreach (var item in Command)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports");
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartArray();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("resources");
            writer.WriteObjectValue(Resources);
            if (Optional.IsCollectionDefined(VolumeMounts))
            {
                writer.WritePropertyName("volumeMounts");
                writer.WriteStartArray();
                foreach (var item in VolumeMounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LivenessProbe))
            {
                writer.WritePropertyName("livenessProbe");
                writer.WriteObjectValue(LivenessProbe);
            }
            if (Optional.IsDefined(ReadinessProbe))
            {
                writer.WritePropertyName("readinessProbe");
                writer.WriteObjectValue(ReadinessProbe);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerInstance DeserializeContainerInstance(JsonElement element)
        {
            string name = default;
            string image = default;
            Optional<IList<string>> command = default;
            Optional<IList<ContainerPort>> ports = default;
            Optional<IList<EnvironmentVariable>> environmentVariables = default;
            Optional<ContainerInstanceView> instanceView = default;
            ResourceRequirements resources = default;
            Optional<IList<ContainerInstanceVolumeMount>> volumeMounts = default;
            Optional<ContainerProbe> livenessProbe = default;
            Optional<ContainerProbe> readinessProbe = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("image"))
                        {
                            image = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("command"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            command = array;
                            continue;
                        }
                        if (property0.NameEquals("ports"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ContainerPort> array = new List<ContainerPort>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerPort.DeserializeContainerPort(item));
                            }
                            ports = array;
                            continue;
                        }
                        if (property0.NameEquals("environmentVariables"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<EnvironmentVariable> array = new List<EnvironmentVariable>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EnvironmentVariable.DeserializeEnvironmentVariable(item));
                            }
                            environmentVariables = array;
                            continue;
                        }
                        if (property0.NameEquals("instanceView"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            instanceView = ContainerInstanceView.DeserializeContainerInstanceView(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resources"))
                        {
                            resources = ResourceRequirements.DeserializeResourceRequirements(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("volumeMounts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ContainerInstanceVolumeMount> array = new List<ContainerInstanceVolumeMount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerInstanceVolumeMount.DeserializeContainerInstanceVolumeMount(item));
                            }
                            volumeMounts = array;
                            continue;
                        }
                        if (property0.NameEquals("livenessProbe"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            livenessProbe = ContainerProbe.DeserializeContainerProbe(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("readinessProbe"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            readinessProbe = ContainerProbe.DeserializeContainerProbe(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerInstance(name, image, Optional.ToList(command), Optional.ToList(ports), Optional.ToList(environmentVariables), instanceView.Value, resources, Optional.ToList(volumeMounts), livenessProbe.Value, readinessProbe.Value);
        }
    }
}
