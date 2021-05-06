// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class FunctionAppMinorVersion
    {
        internal static FunctionAppMinorVersion DeserializeFunctionAppMinorVersion(JsonElement element)
        {
            Optional<string> displayText = default;
            Optional<string> value = default;
            Optional<FunctionAppRuntimes> stackSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayText"))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stackSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stackSettings = FunctionAppRuntimes.DeserializeFunctionAppRuntimes(property.Value);
                    continue;
                }
            }
            return new FunctionAppMinorVersion(displayText.Value, value.Value, stackSettings.Value);
        }
    }
}
