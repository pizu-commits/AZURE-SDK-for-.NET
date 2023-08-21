// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class SwaggerXml : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Core.Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix"u8);
                writer.WriteStringValue(Prefix);
            }
            if (Core.Optional.IsDefined(IsAttribute))
            {
                writer.WritePropertyName("attribute"u8);
                writer.WriteBooleanValue(IsAttribute.Value);
            }
            if (Core.Optional.IsDefined(IsWrapped))
            {
                writer.WritePropertyName("wrapped"u8);
                writer.WriteBooleanValue(IsWrapped.Value);
            }
            if (Core.Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartObject();
                foreach (var item in Extensions)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static SwaggerXml DeserializeSwaggerXml(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<string> @namespace = default;
            Core.Optional<string> prefix = default;
            Core.Optional<bool> attribute = default;
            Core.Optional<bool> wrapped = default;
            Core.Optional<IDictionary<string, BinaryData>> extensions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prefix"u8))
                {
                    prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attribute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attribute = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("wrapped"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wrapped = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("extensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    extensions = dictionary;
                    continue;
                }
            }
            return new SwaggerXml(name.Value, @namespace.Value, prefix.Value, Core.Optional.ToNullable(attribute), Core.Optional.ToNullable(wrapped), Core.Optional.ToDictionary(extensions));
        }
    }
}
