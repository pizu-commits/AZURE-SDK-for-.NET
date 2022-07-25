// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class BatchReleaseCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MessageCount))
            {
                writer.WritePropertyName("messageCount");
                writer.WriteNumberValue(MessageCount.Value);
            }
            if (Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize");
                writer.WriteNumberValue(BatchSize.Value);
            }
            if (Optional.IsDefined(Recurrence))
            {
                writer.WritePropertyName("recurrence");
                writer.WriteObjectValue(Recurrence);
            }
            writer.WriteEndObject();
        }

        internal static BatchReleaseCriteria DeserializeBatchReleaseCriteria(JsonElement element)
        {
            Optional<int> messageCount = default;
            Optional<int> batchSize = default;
            Optional<LogicAppWorkflowTriggerRecurrence> recurrence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    messageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("batchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    batchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recurrence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recurrence = LogicAppWorkflowTriggerRecurrence.DeserializeLogicAppWorkflowTriggerRecurrence(property.Value);
                    continue;
                }
            }
            return new BatchReleaseCriteria(Optional.ToNullable(messageCount), Optional.ToNullable(batchSize), recurrence.Value);
        }
    }
}
