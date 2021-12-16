// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class VirtualDirectory : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualPath))
            {
                writer.WritePropertyName("virtualPath");
                writer.WriteStringValue(VirtualPath);
            }
            if (Optional.IsDefined(PhysicalPath))
            {
                writer.WritePropertyName("physicalPath");
                writer.WriteStringValue(PhysicalPath);
            }
            writer.WriteEndObject();
        }

        internal static VirtualDirectory DeserializeVirtualDirectory(JsonElement element)
        {
            Optional<string> virtualPath = default;
            Optional<string> physicalPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualPath"))
                {
                    virtualPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalPath"))
                {
                    physicalPath = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualDirectory(virtualPath.Value, physicalPath.Value);
        }
    }
}
