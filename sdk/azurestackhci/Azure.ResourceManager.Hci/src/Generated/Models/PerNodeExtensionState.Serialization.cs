// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class PerNodeExtensionState
    {
        internal static PerNodeExtensionState DeserializePerNodeExtensionState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<string> extension = default;
            Core.Optional<string> typeHandlerVersion = default;
            Core.Optional<NodeExtensionState> state = default;
            Core.Optional<HciExtensionInstanceView> instanceView = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extension"u8))
                {
                    extension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeHandlerVersion"u8))
                {
                    typeHandlerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new NodeExtensionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceView"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceView = HciExtensionInstanceView.DeserializeHciExtensionInstanceView(property.Value);
                    continue;
                }
            }
            return new PerNodeExtensionState(name.Value, extension.Value, typeHandlerVersion.Value, Core.Optional.ToNullable(state), instanceView.Value);
        }
    }
}
