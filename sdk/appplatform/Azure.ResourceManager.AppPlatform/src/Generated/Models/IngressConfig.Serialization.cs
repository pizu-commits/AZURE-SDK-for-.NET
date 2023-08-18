// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class IngressConfig : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ReadTimeoutInSeconds))
            {
                writer.WritePropertyName("readTimeoutInSeconds"u8);
                writer.WriteNumberValue(ReadTimeoutInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static IngressConfig DeserializeIngressConfig(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> readTimeoutInSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("readTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new IngressConfig(Core.Optional.ToNullable(readTimeoutInSeconds));
        }
    }
}
