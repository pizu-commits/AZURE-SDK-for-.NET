// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class LiveEventActionContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(RemoveOutputsOnStop))
            {
                writer.WritePropertyName("removeOutputsOnStop"u8);
                writer.WriteBooleanValue(RemoveOutputsOnStop.Value);
            }
            writer.WriteEndObject();
        }
    }
}
