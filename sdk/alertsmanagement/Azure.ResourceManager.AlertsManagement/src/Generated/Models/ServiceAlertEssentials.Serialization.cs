// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertEssentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetResource))
            {
                writer.WritePropertyName("targetResource");
                writer.WriteStringValue(TargetResource);
            }
            if (Optional.IsDefined(TargetResourceName))
            {
                writer.WritePropertyName("targetResourceName");
                writer.WriteStringValue(TargetResourceName);
            }
            if (Optional.IsDefined(TargetResourceGroup))
            {
                writer.WritePropertyName("targetResourceGroup");
                writer.WriteStringValue(TargetResourceGroup);
            }
            if (Optional.IsDefined(TargetResourceType))
            {
                writer.WritePropertyName("targetResourceType");
                writer.WriteStringValue(TargetResourceType);
            }
            if (Optional.IsDefined(ActionStatus))
            {
                writer.WritePropertyName("actionStatus");
                writer.WriteObjectValue(ActionStatus);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static ServiceAlertEssentials DeserializeServiceAlertEssentials(JsonElement element)
        {
            Optional<ServiceAlertSeverity> severity = default;
            Optional<ServiceAlertSignalType> signalType = default;
            Optional<AlertState> alertState = default;
            Optional<MonitorCondition> monitorCondition = default;
            Optional<string> targetResource = default;
            Optional<string> targetResourceName = default;
            Optional<string> targetResourceGroup = default;
            Optional<string> targetResourceType = default;
            Optional<MonitorServiceSourceForAlert> monitorService = default;
            Optional<string> alertRule = default;
            Optional<string> sourceCreatedId = default;
            Optional<Guid> smartGroupId = default;
            Optional<string> smartGroupingReason = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> lastModifiedDateTime = default;
            Optional<DateTimeOffset> monitorConditionResolvedDateTime = default;
            Optional<string> lastModifiedUserName = default;
            Optional<ServiceAlertActionStatus> actionStatus = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("severity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    severity = new ServiceAlertSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signalType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signalType = new ServiceAlertSignalType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    alertState = new AlertState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitorCondition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    monitorCondition = new MonitorCondition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResource"))
                {
                    targetResource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroup"))
                {
                    targetResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceType"))
                {
                    targetResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("monitorService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    monitorService = new MonitorServiceSourceForAlert(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertRule"))
                {
                    alertRule = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCreatedId"))
                {
                    sourceCreatedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("smartGroupId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    smartGroupId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("smartGroupingReason"))
                {
                    smartGroupingReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("monitorConditionResolvedDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    monitorConditionResolvedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedUserName"))
                {
                    lastModifiedUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    actionStatus = ServiceAlertActionStatus.DeserializeServiceAlertActionStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceAlertEssentials(Optional.ToNullable(severity), Optional.ToNullable(signalType), Optional.ToNullable(alertState), Optional.ToNullable(monitorCondition), targetResource.Value, targetResourceName.Value, targetResourceGroup.Value, targetResourceType.Value, Optional.ToNullable(monitorService), alertRule.Value, sourceCreatedId.Value, Optional.ToNullable(smartGroupId), smartGroupingReason.Value, Optional.ToNullable(startDateTime), Optional.ToNullable(lastModifiedDateTime), Optional.ToNullable(monitorConditionResolvedDateTime), lastModifiedUserName.Value, actionStatus.Value, description.Value);
        }
    }
}
