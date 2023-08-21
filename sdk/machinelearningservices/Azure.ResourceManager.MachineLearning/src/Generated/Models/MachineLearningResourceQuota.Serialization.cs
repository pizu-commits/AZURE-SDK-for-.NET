// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningResourceQuota
    {
        internal static MachineLearningResourceQuota DeserializeMachineLearningResourceQuota(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> id = default;
            Core.Optional<string> amlWorkspaceLocation = default;
            Core.Optional<string> type = default;
            Core.Optional<MachineLearningResourceName> name = default;
            Core.Optional<long> limit = default;
            Core.Optional<MachineLearningQuotaUnit> unit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amlWorkspaceLocation"u8))
                {
                    amlWorkspaceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = MachineLearningResourceName.DeserializeMachineLearningResourceName(property.Value);
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new MachineLearningQuotaUnit(property.Value.GetString());
                    continue;
                }
            }
            return new MachineLearningResourceQuota(id.Value, amlWorkspaceLocation.Value, type.Value, name.Value, Core.Optional.ToNullable(limit), Core.Optional.ToNullable(unit));
        }
    }
}
