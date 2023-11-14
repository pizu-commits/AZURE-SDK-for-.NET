// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SlotDifference : IUtf8JsonSerializable, IJsonModel<SlotDifference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SlotDifference>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SlotDifference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SlotDifference>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SlotDifference>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Level))
                {
                    writer.WritePropertyName("level"u8);
                    writer.WriteStringValue(Level);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SettingType))
                {
                    writer.WritePropertyName("settingType"u8);
                    writer.WriteStringValue(SettingType);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DiffRule))
                {
                    writer.WritePropertyName("diffRule"u8);
                    writer.WriteStringValue(DiffRule);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SettingName))
                {
                    writer.WritePropertyName("settingName"u8);
                    writer.WriteStringValue(SettingName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ValueInCurrentSlot))
                {
                    writer.WritePropertyName("valueInCurrentSlot"u8);
                    writer.WriteStringValue(ValueInCurrentSlot);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ValueInTargetSlot))
                {
                    writer.WritePropertyName("valueInTargetSlot"u8);
                    writer.WriteStringValue(ValueInTargetSlot);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Description))
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        SlotDifference IJsonModel<SlotDifference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SlotDifference)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSlotDifference(document.RootElement, options);
        }

        internal static SlotDifference DeserializeSlotDifference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> level = default;
            Optional<string> settingType = default;
            Optional<string> diffRule = default;
            Optional<string> settingName = default;
            Optional<string> valueInCurrentSlot = default;
            Optional<string> valueInTargetSlot = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("level"u8))
                        {
                            level = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("settingType"u8))
                        {
                            settingType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("diffRule"u8))
                        {
                            diffRule = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("settingName"u8))
                        {
                            settingName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("valueInCurrentSlot"u8))
                        {
                            valueInCurrentSlot = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("valueInTargetSlot"u8))
                        {
                            valueInTargetSlot = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SlotDifference(id, name, type, systemData.Value, level.Value, settingType.Value, diffRule.Value, settingName.Value, valueInCurrentSlot.Value, valueInTargetSlot.Value, description.Value, kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SlotDifference>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SlotDifference)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SlotDifference IPersistableModel<SlotDifference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SlotDifference)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSlotDifference(document.RootElement, options);
        }

        string IPersistableModel<SlotDifference>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
