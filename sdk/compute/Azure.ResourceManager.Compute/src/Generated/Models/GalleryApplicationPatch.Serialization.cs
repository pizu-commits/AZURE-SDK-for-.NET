// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryApplicationPatch : IUtf8JsonSerializable, IJsonModel<GalleryApplicationPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryApplicationPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GalleryApplicationPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryApplicationPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Eula))
            {
                writer.WritePropertyName("eula"u8);
                writer.WriteStringValue(Eula);
            }
            if (Optional.IsDefined(PrivacyStatementUri))
            {
                writer.WritePropertyName("privacyStatementUri"u8);
                writer.WriteStringValue(PrivacyStatementUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ReleaseNoteUri))
            {
                writer.WritePropertyName("releaseNoteUri"u8);
                writer.WriteStringValue(ReleaseNoteUri.AbsoluteUri);
            }
            if (Optional.IsDefined(EndOfLifeOn))
            {
                writer.WritePropertyName("endOfLifeDate"u8);
                writer.WriteStringValue(EndOfLifeOn.Value, "O");
            }
            if (Optional.IsDefined(SupportedOSType))
            {
                writer.WritePropertyName("supportedOSType"u8);
                writer.WriteStringValue(SupportedOSType.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(CustomActions))
            {
                writer.WritePropertyName("customActions"u8);
                writer.WriteStartArray();
                foreach (var item in CustomActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        GalleryApplicationPatch IJsonModel<GalleryApplicationPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryApplicationPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryApplicationPatch(document.RootElement, options);
        }

        internal static GalleryApplicationPatch DeserializeGalleryApplicationPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<string> eula = default;
            Optional<Uri> privacyStatementUri = default;
            Optional<Uri> releaseNoteUri = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<SupportedOperatingSystemType> supportedOSType = default;
            Optional<IList<GalleryApplicationCustomAction>> customActions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eula"u8))
                        {
                            eula = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privacyStatementUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privacyStatementUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("releaseNoteUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            releaseNoteUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endOfLifeDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endOfLifeDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("supportedOSType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportedOSType = property0.Value.GetString().ToSupportedOperatingSystemType();
                            continue;
                        }
                        if (property0.NameEquals("customActions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GalleryApplicationCustomAction> array = new List<GalleryApplicationCustomAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GalleryApplicationCustomAction.DeserializeGalleryApplicationCustomAction(item, options));
                            }
                            customActions = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GalleryApplicationPatch(id, name, type, systemData.Value, description.Value, eula.Value, privacyStatementUri.Value, releaseNoteUri.Value, Optional.ToNullable(endOfLifeDate), Optional.ToNullable(supportedOSType), Optional.ToList(customActions), Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GalleryApplicationPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GalleryApplicationPatch)} does not support '{options.Format}' format.");
            }
        }

        GalleryApplicationPatch IPersistableModel<GalleryApplicationPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryApplicationPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryApplicationPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryApplicationPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
