// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SsisObjectMetadata
    {
        internal static SsisObjectMetadata DeserializeSsisObjectMetadata(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Environment": return SsisEnvironment.DeserializeSsisEnvironment(element);
                    case "Folder": return SsisFolder.DeserializeSsisFolder(element);
                    case "Package": return SsisPackage.DeserializeSsisPackage(element);
                    case "Project": return SsisProject.DeserializeSsisProject(element);
                }
            }
            SsisObjectMetadataType type = default;
            Optional<long> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new SsisObjectMetadataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownSsisObjectMetadata(type, Optional.ToNullable(id), name.Value, description.Value);
        }
    }
}
