// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Rendering
{
    public partial class CopyrightCaption
    {
        internal static CopyrightCaption DeserializeCopyrightCaption(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> formatVersion = default;
            Core.Optional<string> copyrightsCaption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatVersion"u8))
                {
                    formatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyrightsCaption"u8))
                {
                    copyrightsCaption = property.Value.GetString();
                    continue;
                }
            }
            return new CopyrightCaption(formatVersion.Value, copyrightsCaption.Value);
        }
    }
}
