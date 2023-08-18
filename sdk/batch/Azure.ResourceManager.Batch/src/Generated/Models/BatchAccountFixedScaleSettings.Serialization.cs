// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountFixedScaleSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ResizeTimeout))
            {
                writer.WritePropertyName("resizeTimeout"u8);
                writer.WriteStringValue(ResizeTimeout.Value, "P");
            }
            if (Core.Optional.IsDefined(TargetDedicatedNodes))
            {
                writer.WritePropertyName("targetDedicatedNodes"u8);
                writer.WriteNumberValue(TargetDedicatedNodes.Value);
            }
            if (Core.Optional.IsDefined(TargetLowPriorityNodes))
            {
                writer.WritePropertyName("targetLowPriorityNodes"u8);
                writer.WriteNumberValue(TargetLowPriorityNodes.Value);
            }
            if (Core.Optional.IsDefined(NodeDeallocationOption))
            {
                writer.WritePropertyName("nodeDeallocationOption"u8);
                writer.WriteStringValue(NodeDeallocationOption.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static BatchAccountFixedScaleSettings DeserializeBatchAccountFixedScaleSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<TimeSpan> resizeTimeout = default;
            Core.Optional<int> targetDedicatedNodes = default;
            Core.Optional<int> targetLowPriorityNodes = default;
            Core.Optional<BatchNodeDeallocationOption> nodeDeallocationOption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resizeTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resizeTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("targetDedicatedNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDedicatedNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetLowPriorityNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetLowPriorityNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeDeallocationOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeDeallocationOption = property.Value.GetString().ToBatchNodeDeallocationOption();
                    continue;
                }
            }
            return new BatchAccountFixedScaleSettings(Core.Optional.ToNullable(resizeTimeout), Core.Optional.ToNullable(targetDedicatedNodes), Core.Optional.ToNullable(targetLowPriorityNodes), Core.Optional.ToNullable(nodeDeallocationOption));
        }
    }
}
