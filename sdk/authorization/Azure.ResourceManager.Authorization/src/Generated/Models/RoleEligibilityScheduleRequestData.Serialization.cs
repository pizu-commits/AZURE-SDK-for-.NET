// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class RoleEligibilityScheduleRequestData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RoleDefinitionId))
            {
                writer.WritePropertyName("roleDefinitionId");
                writer.WriteStringValue(RoleDefinitionId);
            }
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId");
                writer.WriteStringValue(PrincipalId.Value);
            }
            if (Optional.IsDefined(RequestType))
            {
                writer.WritePropertyName("requestType");
                writer.WriteStringValue(RequestType.Value.ToString());
            }
            if (Optional.IsDefined(TargetRoleEligibilityScheduleId))
            {
                writer.WritePropertyName("targetRoleEligibilityScheduleId");
                writer.WriteStringValue(TargetRoleEligibilityScheduleId);
            }
            if (Optional.IsDefined(TargetRoleEligibilityScheduleInstanceId))
            {
                writer.WritePropertyName("targetRoleEligibilityScheduleInstanceId");
                writer.WriteStringValue(TargetRoleEligibilityScheduleInstanceId);
            }
            if (Optional.IsDefined(Justification))
            {
                writer.WritePropertyName("justification");
                writer.WriteStringValue(Justification);
            }
            if (Optional.IsDefined(TicketInfo))
            {
                writer.WritePropertyName("ticketInfo");
                writer.WriteObjectValue(TicketInfo);
            }
            if (Optional.IsDefined(Condition))
            {
                writer.WritePropertyName("condition");
                writer.WriteStringValue(Condition);
            }
            if (Optional.IsDefined(ConditionVersion))
            {
                writer.WritePropertyName("conditionVersion");
                writer.WriteStringValue(ConditionVersion);
            }
            writer.WritePropertyName("scheduleInfo");
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime");
                writer.WriteStringValue(StartOn.Value, "O");
            }
            writer.WritePropertyName("expiration");
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpirationType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ExpirationType.Value.ToString());
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDateTime");
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration");
                writer.WriteStringValue(Duration.Value, "P");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RoleEligibilityScheduleRequestData DeserializeRoleEligibilityScheduleRequestData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> scope = default;
            Optional<ResourceIdentifier> roleDefinitionId = default;
            Optional<Guid> principalId = default;
            Optional<RoleEligibilitySchedulePrincipalType> principalType = default;
            Optional<RoleEligibilityScheduleRequestType> requestType = default;
            Optional<RoleEligibilityScheduleStatus> status = default;
            Optional<string> approvalId = default;
            Optional<string> targetRoleEligibilityScheduleId = default;
            Optional<string> targetRoleEligibilityScheduleInstanceId = default;
            Optional<string> justification = default;
            Optional<RoleEligibilityScheduleRequestPropertiesTicketInfo> ticketInfo = default;
            Optional<string> condition = default;
            Optional<string> conditionVersion = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<Guid> requestorId = default;
            Optional<ExpandedProperties> expandedProperties = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<RoleEligibilityScheduleExpirationType> type0 = default;
            Optional<DateTimeOffset> endDateTime = default;
            Optional<TimeSpan> duration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("scope"))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("roleDefinitionId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            roleDefinitionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("principalId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            principalId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("principalType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            principalType = new RoleEligibilitySchedulePrincipalType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requestType = new RoleEligibilityScheduleRequestType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new RoleEligibilityScheduleStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("approvalId"))
                        {
                            approvalId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetRoleEligibilityScheduleId"))
                        {
                            targetRoleEligibilityScheduleId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetRoleEligibilityScheduleInstanceId"))
                        {
                            targetRoleEligibilityScheduleInstanceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("justification"))
                        {
                            justification = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ticketInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ticketInfo = RoleEligibilityScheduleRequestPropertiesTicketInfo.DeserializeRoleEligibilityScheduleRequestPropertiesTicketInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("condition"))
                        {
                            condition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("conditionVersion"))
                        {
                            conditionVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("requestorId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requestorId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("expandedProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expandedProperties = ExpandedProperties.DeserializeExpandedProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("scheduleInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("startDateTime"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    startDateTime = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                                if (property1.NameEquals("expiration"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    foreach (var property2 in property1.Value.EnumerateObject())
                                    {
                                        if (property2.NameEquals("type"))
                                        {
                                            if (property2.Value.ValueKind == JsonValueKind.Null)
                                            {
                                                property2.ThrowNonNullablePropertyIsNull();
                                                continue;
                                            }
                                            type0 = new RoleEligibilityScheduleExpirationType(property2.Value.GetString());
                                            continue;
                                        }
                                        if (property2.NameEquals("endDateTime"))
                                        {
                                            if (property2.Value.ValueKind == JsonValueKind.Null)
                                            {
                                                property2.ThrowNonNullablePropertyIsNull();
                                                continue;
                                            }
                                            endDateTime = property2.Value.GetDateTimeOffset("O");
                                            continue;
                                        }
                                        if (property2.NameEquals("duration"))
                                        {
                                            if (property2.Value.ValueKind == JsonValueKind.Null)
                                            {
                                                property2.ThrowNonNullablePropertyIsNull();
                                                continue;
                                            }
                                            duration = property2.Value.GetTimeSpan("P");
                                            continue;
                                        }
                                    }
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RoleEligibilityScheduleRequestData(id, name, type, systemData.Value, scope.Value, roleDefinitionId.Value, Optional.ToNullable(principalId), Optional.ToNullable(principalType), Optional.ToNullable(requestType), Optional.ToNullable(status), approvalId.Value, targetRoleEligibilityScheduleId.Value, targetRoleEligibilityScheduleInstanceId.Value, justification.Value, ticketInfo.Value, condition.Value, conditionVersion.Value, Optional.ToNullable(createdOn), Optional.ToNullable(requestorId), expandedProperties.Value, Optional.ToNullable(startDateTime), Optional.ToNullable(type0), Optional.ToNullable(endDateTime), Optional.ToNullable(duration));
        }
    }
}
