// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class SupportedOSProperties
    {
        internal static SupportedOSProperties DeserializeSupportedOSProperties(JsonElement element)
        {
            Optional<IReadOnlyList<SupportedOSProperty>> supportedOSList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedOsList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SupportedOSProperty> array = new List<SupportedOSProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportedOSProperty.DeserializeSupportedOSProperty(item));
                    }
                    supportedOSList = array;
                    continue;
                }
            }
            return new SupportedOSProperties(Optional.ToList(supportedOSList));
        }
    }
}
