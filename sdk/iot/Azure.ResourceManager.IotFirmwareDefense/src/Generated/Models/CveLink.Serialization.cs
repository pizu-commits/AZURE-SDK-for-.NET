// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class CveLink
    {
        internal static CveLink DeserializeCveLink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> href = default;
            Core.Optional<string> label = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("href"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        href = null;
                        continue;
                    }
                    href = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        label = null;
                        continue;
                    }
                    label = property.Value.GetString();
                    continue;
                }
            }
            return new CveLink(href.Value, label.Value);
        }
    }
}
