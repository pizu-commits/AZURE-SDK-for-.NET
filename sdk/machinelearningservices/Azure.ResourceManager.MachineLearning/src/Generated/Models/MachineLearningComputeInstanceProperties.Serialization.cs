// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningComputeInstanceProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Core.Optional.IsDefined(Subnet))
            {
                if (Subnet != null)
                {
                    writer.WritePropertyName("subnet"u8);
                    writer.WriteObjectValue(Subnet);
                }
                else
                {
                    writer.WriteNull("subnet");
                }
            }
            if (Core.Optional.IsDefined(ApplicationSharingPolicy))
            {
                writer.WritePropertyName("applicationSharingPolicy"u8);
                writer.WriteStringValue(ApplicationSharingPolicy.Value.ToString());
            }
            if (Core.Optional.IsDefined(SshSettings))
            {
                if (SshSettings != null)
                {
                    writer.WritePropertyName("sshSettings"u8);
                    writer.WriteObjectValue(SshSettings);
                }
                else
                {
                    writer.WriteNull("sshSettings");
                }
            }
            if (Core.Optional.IsDefined(ComputeInstanceAuthorizationType))
            {
                if (ComputeInstanceAuthorizationType != null)
                {
                    writer.WritePropertyName("computeInstanceAuthorizationType"u8);
                    writer.WriteStringValue(ComputeInstanceAuthorizationType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("computeInstanceAuthorizationType");
                }
            }
            if (Core.Optional.IsDefined(PersonalComputeInstanceSettings))
            {
                if (PersonalComputeInstanceSettings != null)
                {
                    writer.WritePropertyName("personalComputeInstanceSettings"u8);
                    writer.WriteObjectValue(PersonalComputeInstanceSettings);
                }
                else
                {
                    writer.WriteNull("personalComputeInstanceSettings");
                }
            }
            if (Core.Optional.IsDefined(SetupScriptsSettings))
            {
                if (SetupScriptsSettings != null)
                {
                    writer.WritePropertyName("setupScripts"u8);
                    writer.WriteObjectValue(SetupScriptsSettings);
                }
                else
                {
                    writer.WriteNull("setupScripts");
                }
            }
            if (Core.Optional.IsDefined(EnableNodePublicIP))
            {
                writer.WritePropertyName("enableNodePublicIp"u8);
                writer.WriteBooleanValue(EnableNodePublicIP.Value);
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningComputeInstanceProperties DeserializeMachineLearningComputeInstanceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> vmSize = default;
            Core.Optional<ResourceId> subnet = default;
            Core.Optional<MachineLearningApplicationSharingPolicy> applicationSharingPolicy = default;
            Core.Optional<MachineLearningComputeInstanceSshSettings> sshSettings = default;
            Core.Optional<MachineLearningComputeInstanceConnectivityEndpoints> connectivityEndpoints = default;
            Core.Optional<IReadOnlyList<MachineLearningComputeInstanceApplication>> applications = default;
            Core.Optional<MachineLearningComputeInstanceCreatedBy> createdBy = default;
            Core.Optional<IReadOnlyList<MachineLearningError>> errors = default;
            Core.Optional<MachineLearningComputeInstanceState> state = default;
            Core.Optional<MachineLearningComputeInstanceAuthorizationType?> computeInstanceAuthorizationType = default;
            Core.Optional<PersonalComputeInstanceSettings> personalComputeInstanceSettings = default;
            Core.Optional<SetupScripts> setupScripts = default;
            Core.Optional<MachineLearningComputeInstanceLastOperation> lastOperation = default;
            Core.Optional<ComputeSchedules> schedules = default;
            Core.Optional<bool> enableNodePublicIP = default;
            Core.Optional<IReadOnlyList<MachineLearningComputeInstanceContainer>> containers = default;
            Core.Optional<IReadOnlyList<MachineLearningComputeInstanceDataDisk>> dataDisks = default;
            Core.Optional<IReadOnlyList<MachineLearningComputeInstanceDataMount>> dataMounts = default;
            Core.Optional<ComputeInstanceVersion> versions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subnet = null;
                        continue;
                    }
                    subnet = ResourceId.DeserializeResourceId(property.Value);
                    continue;
                }
                if (property.NameEquals("applicationSharingPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationSharingPolicy = new MachineLearningApplicationSharingPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sshSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sshSettings = null;
                        continue;
                    }
                    sshSettings = MachineLearningComputeInstanceSshSettings.DeserializeMachineLearningComputeInstanceSshSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("connectivityEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectivityEndpoints = MachineLearningComputeInstanceConnectivityEndpoints.DeserializeMachineLearningComputeInstanceConnectivityEndpoints(property.Value);
                    continue;
                }
                if (property.NameEquals("applications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningComputeInstanceApplication> array = new List<MachineLearningComputeInstanceApplication>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningComputeInstanceApplication.DeserializeMachineLearningComputeInstanceApplication(item));
                    }
                    applications = array;
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdBy = MachineLearningComputeInstanceCreatedBy.DeserializeMachineLearningComputeInstanceCreatedBy(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningError> array = new List<MachineLearningError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningError.DeserializeMachineLearningError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new MachineLearningComputeInstanceState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computeInstanceAuthorizationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        computeInstanceAuthorizationType = null;
                        continue;
                    }
                    computeInstanceAuthorizationType = new MachineLearningComputeInstanceAuthorizationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("personalComputeInstanceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        personalComputeInstanceSettings = null;
                        continue;
                    }
                    personalComputeInstanceSettings = PersonalComputeInstanceSettings.DeserializePersonalComputeInstanceSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("setupScripts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        setupScripts = null;
                        continue;
                    }
                    setupScripts = SetupScripts.DeserializeSetupScripts(property.Value);
                    continue;
                }
                if (property.NameEquals("lastOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastOperation = null;
                        continue;
                    }
                    lastOperation = MachineLearningComputeInstanceLastOperation.DeserializeMachineLearningComputeInstanceLastOperation(property.Value);
                    continue;
                }
                if (property.NameEquals("schedules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        schedules = null;
                        continue;
                    }
                    schedules = ComputeSchedules.DeserializeComputeSchedules(property.Value);
                    continue;
                }
                if (property.NameEquals("enableNodePublicIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableNodePublicIP = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        containers = null;
                        continue;
                    }
                    List<MachineLearningComputeInstanceContainer> array = new List<MachineLearningComputeInstanceContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningComputeInstanceContainer.DeserializeMachineLearningComputeInstanceContainer(item));
                    }
                    containers = array;
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataDisks = null;
                        continue;
                    }
                    List<MachineLearningComputeInstanceDataDisk> array = new List<MachineLearningComputeInstanceDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningComputeInstanceDataDisk.DeserializeMachineLearningComputeInstanceDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("dataMounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataMounts = null;
                        continue;
                    }
                    List<MachineLearningComputeInstanceDataMount> array = new List<MachineLearningComputeInstanceDataMount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningComputeInstanceDataMount.DeserializeMachineLearningComputeInstanceDataMount(item));
                    }
                    dataMounts = array;
                    continue;
                }
                if (property.NameEquals("versions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versions = ComputeInstanceVersion.DeserializeComputeInstanceVersion(property.Value);
                    continue;
                }
            }
            return new MachineLearningComputeInstanceProperties(vmSize.Value, subnet.Value, Core.Optional.ToNullable(applicationSharingPolicy), sshSettings.Value, connectivityEndpoints.Value, Core.Optional.ToList(applications), createdBy.Value, Core.Optional.ToList(errors), Core.Optional.ToNullable(state), Core.Optional.ToNullable(computeInstanceAuthorizationType), personalComputeInstanceSettings.Value, setupScripts.Value, lastOperation.Value, schedules.Value, Core.Optional.ToNullable(enableNodePublicIP), Core.Optional.ToList(containers), Core.Optional.ToList(dataDisks), Core.Optional.ToList(dataMounts), versions.Value);
        }
    }
}
