// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class SupportTopic
    {
        internal static SupportTopic DeserializeSupportTopic(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> pesId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pesId"))
                {
                    pesId = property.Value.GetString();
                    continue;
                }
            }
            return new SupportTopic(id.Value, pesId.Value);
        }
    }
}
