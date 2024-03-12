// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile : IUtf8JsonSerializable, IJsonModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AccessRulesVersion))
            {
                writer.WritePropertyName("accessRulesVersion"u8);
                writer.WriteStringValue(AccessRulesVersion);
            }
            if (Optional.IsCollectionDefined(AccessRules))
            {
                writer.WritePropertyName("accessRules"u8);
                writer.WriteStartArray();
                foreach (var item in AccessRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile IJsonModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(document.RootElement, options);
        }

        internal static EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string accessRulesVersion = default;
            IReadOnlyList<EventHubsNspAccessRule> accessRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessRulesVersion"u8))
                {
                    accessRulesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventHubsNspAccessRule> array = new List<EventHubsNspAccessRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubsNspAccessRule.DeserializeEventHubsNspAccessRule(item, options));
                    }
                    accessRules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(name, accessRulesVersion, accessRules ?? new ChangeTrackingList<EventHubsNspAccessRule>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (Optional.IsDefined(Name) || hasPropertyOverride)
            {
                builder.Append("  name: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccessRulesVersion), out propertyOverride);
            if (Optional.IsDefined(AccessRulesVersion) || hasPropertyOverride)
            {
                builder.Append("  accessRulesVersion: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (AccessRulesVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AccessRulesVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AccessRulesVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccessRules), out propertyOverride);
            if (Optional.IsCollectionDefined(AccessRules) || hasPropertyOverride)
            {
                if (AccessRules.Any() || hasPropertyOverride)
                {
                    builder.Append("  accessRules: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in AccessRules)
                        {
                            AppendChildObject(builder, item, options, 4, true, "  accessRules: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile)} does not support '{options.Format}' format.");
            }
        }

        EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile IPersistableModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
