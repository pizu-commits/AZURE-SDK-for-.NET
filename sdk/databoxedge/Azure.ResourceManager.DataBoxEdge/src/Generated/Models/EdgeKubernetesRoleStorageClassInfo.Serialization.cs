// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeKubernetesRoleStorageClassInfo
    {
        internal static EdgeKubernetesRoleStorageClassInfo DeserializeEdgeKubernetesRoleStorageClassInfo(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<PosixComplianceStatus> posixCompliant = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("posixCompliant"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    posixCompliant = new PosixComplianceStatus(property.Value.GetString());
                    continue;
                }
            }
            return new EdgeKubernetesRoleStorageClassInfo(name.Value, type.Value, Optional.ToNullable(posixCompliant));
        }
    }
}
