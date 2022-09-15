// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Attestation;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Attestation.Models
{
    internal partial class AttestationProviderListResult
    {
        internal static AttestationProviderListResult DeserializeAttestationProviderListResult(JsonElement element)
        {
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<AttestationProviderData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AttestationProviderData> array = new List<AttestationProviderData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AttestationProviderData.DeserializeAttestationProviderData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AttestationProviderListResult(systemData, Optional.ToList(value));
        }
    }
}
