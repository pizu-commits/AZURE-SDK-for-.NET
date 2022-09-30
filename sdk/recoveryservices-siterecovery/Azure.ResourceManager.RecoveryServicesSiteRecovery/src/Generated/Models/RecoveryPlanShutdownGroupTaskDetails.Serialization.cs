// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanShutdownGroupTaskDetails
    {
        internal static RecoveryPlanShutdownGroupTaskDetails DeserializeRecoveryPlanShutdownGroupTaskDetails(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> groupId = default;
            Optional<string> rpGroupType = default;
            string instanceType = default;
            Optional<IReadOnlyList<ASRTask>> childTasks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rpGroupType"))
                {
                    rpGroupType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("childTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ASRTask> array = new List<ASRTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ASRTask.DeserializeASRTask(item));
                    }
                    childTasks = array;
                    continue;
                }
            }
            return new RecoveryPlanShutdownGroupTaskDetails(instanceType, Optional.ToList(childTasks), name.Value, groupId.Value, rpGroupType.Value);
        }
    }
}
