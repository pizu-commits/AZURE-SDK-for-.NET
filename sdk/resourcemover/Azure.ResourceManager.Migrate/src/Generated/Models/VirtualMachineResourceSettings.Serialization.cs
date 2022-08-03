// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class VirtualMachineResourceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(UserManagedIdentities))
            {
                writer.WritePropertyName("userManagedIdentities");
                writer.WriteStartArray();
                foreach (var item in UserManagedIdentities)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                writer.WritePropertyName("targetAvailabilityZone");
                writer.WriteStringValue(TargetAvailabilityZone.Value.ToString());
            }
            if (Optional.IsDefined(TargetVmSize))
            {
                writer.WritePropertyName("targetVmSize");
                writer.WriteStringValue(TargetVmSize);
            }
            if (Optional.IsDefined(TargetAvailabilitySetId))
            {
                writer.WritePropertyName("targetAvailabilitySetId");
                writer.WriteStringValue(TargetAvailabilitySetId);
            }
            writer.WritePropertyName("resourceType");
            writer.WriteStringValue(ResourceType);
            writer.WritePropertyName("targetResourceName");
            writer.WriteStringValue(TargetResourceName);
            writer.WriteEndObject();
        }

        internal static VirtualMachineResourceSettings DeserializeVirtualMachineResourceSettings(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<string>> userManagedIdentities = default;
            Optional<MoverTargetAvailabilityZone> targetAvailabilityZone = default;
            Optional<string> targetVmSize = default;
            Optional<ResourceIdentifier> targetAvailabilitySetId = default;
            string resourceType = default;
            string targetResourceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("userManagedIdentities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    userManagedIdentities = array;
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetAvailabilityZone = new MoverTargetAvailabilityZone(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmSize"))
                {
                    targetVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAvailabilitySetId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualMachineResourceSettings(resourceType, targetResourceName, Optional.ToDictionary(tags), Optional.ToList(userManagedIdentities), Optional.ToNullable(targetAvailabilityZone), targetVmSize.Value, targetAvailabilitySetId.Value);
        }
    }
}
