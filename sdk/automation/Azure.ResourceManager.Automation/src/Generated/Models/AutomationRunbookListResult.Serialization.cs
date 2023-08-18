// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class AutomationRunbookListResult
    {
        internal static AutomationRunbookListResult DeserializeAutomationRunbookListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<AutomationRunbookData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AutomationRunbookData> array = new List<AutomationRunbookData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomationRunbookData.DeserializeAutomationRunbookData(item));
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
            return new AutomationRunbookListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
