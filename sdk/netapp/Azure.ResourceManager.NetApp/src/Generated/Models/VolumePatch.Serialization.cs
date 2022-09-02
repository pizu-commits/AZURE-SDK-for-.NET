// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class VolumePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceLevel))
            {
                writer.WritePropertyName("serviceLevel");
                writer.WriteStringValue(ServiceLevel.Value.ToString());
            }
            if (Optional.IsDefined(UsageThreshold))
            {
                writer.WritePropertyName("usageThreshold");
                writer.WriteNumberValue(UsageThreshold.Value);
            }
            if (Optional.IsDefined(ExportPolicy))
            {
                writer.WritePropertyName("exportPolicy");
                writer.WriteObjectValue(ExportPolicy);
            }
            if (Optional.IsDefined(ThroughputMibps))
            {
                writer.WritePropertyName("throughputMibps");
                writer.WriteNumberValue(ThroughputMibps.Value);
            }
            if (Optional.IsDefined(DataProtection))
            {
                writer.WritePropertyName("dataProtection");
                writer.WriteObjectValue(DataProtection);
            }
            if (Optional.IsDefined(IsDefaultQuotaEnabled))
            {
                writer.WritePropertyName("isDefaultQuotaEnabled");
                writer.WriteBooleanValue(IsDefaultQuotaEnabled.Value);
            }
            if (Optional.IsDefined(DefaultUserQuotaInKiBs))
            {
                writer.WritePropertyName("defaultUserQuotaInKiBs");
                writer.WriteNumberValue(DefaultUserQuotaInKiBs.Value);
            }
            if (Optional.IsDefined(DefaultGroupQuotaInKiBs))
            {
                writer.WritePropertyName("defaultGroupQuotaInKiBs");
                writer.WriteNumberValue(DefaultGroupQuotaInKiBs.Value);
            }
            if (Optional.IsDefined(UnixPermissions))
            {
                if (UnixPermissions != null)
                {
                    writer.WritePropertyName("unixPermissions");
                    writer.WriteStringValue(UnixPermissions);
                }
                else
                {
                    writer.WriteNull("unixPermissions");
                }
            }
            if (Optional.IsDefined(CoolAccess))
            {
                writer.WritePropertyName("coolAccess");
                writer.WriteBooleanValue(CoolAccess.Value);
            }
            if (Optional.IsDefined(CoolnessPeriod))
            {
                writer.WritePropertyName("coolnessPeriod");
                writer.WriteNumberValue(CoolnessPeriod.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
