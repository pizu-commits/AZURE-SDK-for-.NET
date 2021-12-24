// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    public partial class VirtualDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(DeviceKey))
            {
                writer.WritePropertyName("deviceKey");
                writer.WriteNumberValue(DeviceKey.Value);
            }
            if (Optional.IsDefined(DiskMode))
            {
                writer.WritePropertyName("diskMode");
                writer.WriteStringValue(DiskMode.Value.ToString());
            }
            if (Optional.IsDefined(ControllerKey))
            {
                writer.WritePropertyName("controllerKey");
                writer.WriteNumberValue(ControllerKey.Value);
            }
            if (Optional.IsDefined(UnitNumber))
            {
                writer.WritePropertyName("unitNumber");
                writer.WriteNumberValue(UnitNumber.Value);
            }
            if (Optional.IsDefined(DeviceName))
            {
                writer.WritePropertyName("deviceName");
                writer.WriteStringValue(DeviceName);
            }
            if (Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType");
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static VirtualDisk DeserializeVirtualDisk(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> label = default;
            Optional<string> diskObjectId = default;
            Optional<int> diskSizeGB = default;
            Optional<int> deviceKey = default;
            Optional<DiskMode> diskMode = default;
            Optional<int> controllerKey = default;
            Optional<int> unitNumber = default;
            Optional<string> deviceName = default;
            Optional<DiskType> diskType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskObjectId"))
                {
                    diskObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deviceKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deviceKey = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskMode = new DiskMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controllerKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    controllerKey = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unitNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unitNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deviceName"))
                {
                    deviceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskType = new DiskType(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualDisk(name.Value, label.Value, diskObjectId.Value, Optional.ToNullable(diskSizeGB), Optional.ToNullable(deviceKey), Optional.ToNullable(diskMode), Optional.ToNullable(controllerKey), Optional.ToNullable(unitNumber), deviceName.Value, Optional.ToNullable(diskType));
        }
    }
}
