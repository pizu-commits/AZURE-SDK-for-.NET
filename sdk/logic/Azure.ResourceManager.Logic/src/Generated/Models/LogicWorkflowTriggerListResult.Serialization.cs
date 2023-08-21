// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class LogicWorkflowTriggerListResult
    {
        internal static LogicWorkflowTriggerListResult DeserializeLogicWorkflowTriggerListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<LogicWorkflowTriggerData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogicWorkflowTriggerData> array = new List<LogicWorkflowTriggerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogicWorkflowTriggerData.DeserializeLogicWorkflowTriggerData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LogicWorkflowTriggerListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
