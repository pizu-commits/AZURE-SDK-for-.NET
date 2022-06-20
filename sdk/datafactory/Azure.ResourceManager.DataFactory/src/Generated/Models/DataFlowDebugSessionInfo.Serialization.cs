// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFlowDebugSessionInfo
    {
        internal static DataFlowDebugSessionInfo DeserializeDataFlowDebugSessionInfo(JsonElement element)
        {
            Optional<string> dataFlowName = default;
            Optional<string> computeType = default;
            Optional<int> coreCount = default;
            Optional<int> nodeCount = default;
            Optional<string> integrationRuntimeName = default;
            Optional<string> sessionId = default;
            Optional<string> startTime = default;
            Optional<int> timeToLiveInMinutes = default;
            Optional<string> lastActivityTime = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataFlowName"))
                {
                    dataFlowName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("computeType"))
                {
                    computeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("integrationRuntimeName"))
                {
                    integrationRuntimeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionId"))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeToLiveInMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeToLiveInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastActivityTime"))
                {
                    lastActivityTime = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFlowDebugSessionInfo(dataFlowName.Value, computeType.Value, Optional.ToNullable(coreCount), Optional.ToNullable(nodeCount), integrationRuntimeName.Value, sessionId.Value, startTime.Value, Optional.ToNullable(timeToLiveInMinutes), lastActivityTime.Value, additionalProperties);
        }
    }
}
