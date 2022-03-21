// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class HttpMessage
    {
        internal static HttpMessage DeserializeHttpMessage(JsonElement element)
        {
            Optional<BinaryData> content = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    content = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new HttpMessage(content.Value);
        }
    }
}
