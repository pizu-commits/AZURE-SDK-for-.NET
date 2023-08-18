// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciPrecheckResult : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteObjectValue(Tags);
            }
            if (Core.Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Core.Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Core.Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Core.Optional.IsDefined(Remediation))
            {
                writer.WritePropertyName("remediation"u8);
                writer.WriteStringValue(Remediation);
            }
            if (Core.Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceID"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (Core.Optional.IsDefined(TargetResourceName))
            {
                writer.WritePropertyName("targetResourceName"u8);
                writer.WriteStringValue(TargetResourceName);
            }
            if (Core.Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Core.Optional.IsDefined(AdditionalData))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteStringValue(AdditionalData);
            }
            if (Core.Optional.IsDefined(HealthCheckSource))
            {
                writer.WritePropertyName("healthCheckSource"u8);
                writer.WriteStringValue(HealthCheckSource);
            }
            writer.WriteEndObject();
        }

        internal static HciPrecheckResult DeserializeHciPrecheckResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<HciPrecheckResultTags> tags = default;
            Core.Optional<string> title = default;
            Core.Optional<HciClusterStatus> status = default;
            Core.Optional<UpdateSeverity> severity = default;
            Core.Optional<string> description = default;
            Core.Optional<string> remediation = default;
            Core.Optional<string> targetResourceId = default;
            Core.Optional<string> targetResourceName = default;
            Core.Optional<DateTimeOffset> timestamp = default;
            Core.Optional<string> additionalData = default;
            Core.Optional<string> healthCheckSource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tags = HciPrecheckResultTags.DeserializeHciPrecheckResultTags(property.Value);
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new HciClusterStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new UpdateSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remediation"u8))
                {
                    remediation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceID"u8))
                {
                    targetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("additionalData"u8))
                {
                    additionalData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthCheckSource"u8))
                {
                    healthCheckSource = property.Value.GetString();
                    continue;
                }
            }
            return new HciPrecheckResult(name.Value, tags.Value, title.Value, Core.Optional.ToNullable(status), Core.Optional.ToNullable(severity), description.Value, remediation.Value, targetResourceId.Value, targetResourceName.Value, Core.Optional.ToNullable(timestamp), additionalData.Value, healthCheckSource.Value);
        }
    }
}
