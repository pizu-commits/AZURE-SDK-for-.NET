// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ControlFamily
    {
        internal static ControlFamily DeserializeControlFamily(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> familyName = default;
            Core.Optional<ControlFamilyType> familyType = default;
            Core.Optional<ControlFamilyStatus> familyStatus = default;
            Core.Optional<IReadOnlyList<Control>> controls = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("familyName"u8))
                {
                    familyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("familyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familyType = new ControlFamilyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("familyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familyStatus = new ControlFamilyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Control> array = new List<Control>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Control.DeserializeControl(item));
                    }
                    controls = array;
                    continue;
                }
            }
            return new ControlFamily(familyName.Value, Core.Optional.ToNullable(familyType), Core.Optional.ToNullable(familyStatus), Core.Optional.ToList(controls));
        }
    }
}
