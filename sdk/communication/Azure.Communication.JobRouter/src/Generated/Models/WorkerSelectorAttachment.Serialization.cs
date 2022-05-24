// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class WorkerSelectorAttachment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static WorkerSelectorAttachment DeserializeWorkerSelectorAttachment(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "conditional": return ConditionalWorkerSelector.DeserializeConditionalWorkerSelector(element);
                    case "pass-through": return PassThroughWorkerSelector.DeserializePassThroughWorkerSelector(element);
                    case "rule-engine": return RuleEngineWorkerSelector.DeserializeRuleEngineWorkerSelector(element);
                    case "static": return StaticWorkerSelector.DeserializeStaticWorkerSelector(element);
                    case "weighted-allocation-worker-selector": return WeightedAllocationWorkerSelector.DeserializeWeightedAllocationWorkerSelector(element);
                }
            }
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new WorkerSelectorAttachment(kind);
        }
    }
}
