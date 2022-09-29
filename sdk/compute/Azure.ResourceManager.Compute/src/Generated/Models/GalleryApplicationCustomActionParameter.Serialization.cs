// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryApplicationCustomActionParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Required))
            {
                writer.WritePropertyName("required");
                writer.WriteBooleanValue(Required.Value);
            }
            if (Optional.IsDefined(ParameterType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ParameterType.Value.ToSerialString());
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue");
                writer.WriteStringValue(DefaultValue);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static GalleryApplicationCustomActionParameter DeserializeGalleryApplicationCustomActionParameter(JsonElement element)
        {
            string name = default;
            Optional<bool> required = default;
            Optional<GalleryApplicationCustomActionParameterType> type = default;
            Optional<string> defaultValue = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("required"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    required = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.GetString().ToGalleryApplicationCustomActionParameterType();
                    continue;
                }
                if (property.NameEquals("defaultValue"))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new GalleryApplicationCustomActionParameter(name, Optional.ToNullable(required), Optional.ToNullable(type), defaultValue.Value, description.Value);
        }
    }
}
