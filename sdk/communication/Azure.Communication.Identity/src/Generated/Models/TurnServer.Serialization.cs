// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Identity.Models
{
    public partial class TurnServer
    {
        internal static TurnServer DeserializeTurnServer(JsonElement element)
        {
            string urls = default;
            string username = default;
            string credential = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("urls"))
                {
                    urls = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credential"))
                {
                    credential = property.Value.GetString();
                    continue;
                }
            }
            return new TurnServer(urls, username, credential);
        }
    }
}
