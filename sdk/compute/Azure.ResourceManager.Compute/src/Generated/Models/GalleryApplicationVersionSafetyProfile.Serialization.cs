// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class GalleryApplicationVersionSafetyProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowDeletionOfReplicatedLocations))
            {
                writer.WritePropertyName("allowDeletionOfReplicatedLocations");
                writer.WriteBooleanValue(AllowDeletionOfReplicatedLocations.Value);
            }
            writer.WriteEndObject();
        }

        internal static GalleryApplicationVersionSafetyProfile DeserializeGalleryApplicationVersionSafetyProfile(JsonElement element)
        {
            Optional<bool> allowDeletionOfReplicatedLocations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowDeletionOfReplicatedLocations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowDeletionOfReplicatedLocations = property.Value.GetBoolean();
                    continue;
                }
            }
            return new GalleryApplicationVersionSafetyProfile(Optional.ToNullable(allowDeletionOfReplicatedLocations));
        }
    }
}
