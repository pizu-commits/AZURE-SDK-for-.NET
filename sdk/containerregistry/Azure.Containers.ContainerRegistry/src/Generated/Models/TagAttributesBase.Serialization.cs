// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class TagAttributesBase
    {
        internal static TagAttributesBase DeserializeTagAttributesBase(JsonElement element)
        {
            string name = default;
            string digest = default;
            DateTimeOffset createdTime = default;
            DateTimeOffset lastUpdateTime = default;
            ContentProperties changeableAttributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("digest"))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"))
                {
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("changeableAttributes"))
                {
                    changeableAttributes = ContentProperties.DeserializeContentProperties(property.Value);
                    continue;
                }
            }
            return new TagAttributesBase(name, digest, createdTime, lastUpdateTime, changeableAttributes);
        }
    }
}
