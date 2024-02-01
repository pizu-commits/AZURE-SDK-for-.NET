// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class IPExtendedCommunityRule : IUtf8JsonSerializable, IJsonModel<IPExtendedCommunityRule>, IPersistableModel<IPExtendedCommunityRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IPExtendedCommunityRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IPExtendedCommunityRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPExtendedCommunityRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPExtendedCommunityRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
            writer.WritePropertyName("sequenceNumber"u8);
            writer.WriteNumberValue(SequenceNumber);
            writer.WritePropertyName("routeTargets"u8);
            writer.WriteStartArray();
            foreach (var item in RouteTargets)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        IPExtendedCommunityRule IJsonModel<IPExtendedCommunityRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPExtendedCommunityRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPExtendedCommunityRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIPExtendedCommunityRule(document.RootElement, options);
        }

        internal static IPExtendedCommunityRule DeserializeIPExtendedCommunityRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunityActionType action = default;
            long sequenceNumber = default;
            IList<string> routeTargets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"u8))
                {
                    action = new CommunityActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("routeTargets"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    routeTargets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IPExtendedCommunityRule(action, sequenceNumber, routeTargets, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Action))
            {
                builder.Append("  action:");
                builder.AppendLine($" '{Action.ToString()}'");
            }

            if (Optional.IsDefined(SequenceNumber))
            {
                builder.Append("  sequenceNumber:");
                builder.AppendLine($" '{SequenceNumber.ToString()}'");
            }

            if (Optional.IsCollectionDefined(RouteTargets))
            {
                builder.Append("  routeTargets:");
                builder.AppendLine(" [");
                foreach (var item in RouteTargets)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<IPExtendedCommunityRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPExtendedCommunityRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(IPExtendedCommunityRule)} does not support '{options.Format}' format.");
            }
        }

        IPExtendedCommunityRule IPersistableModel<IPExtendedCommunityRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPExtendedCommunityRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIPExtendedCommunityRule(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(IPExtendedCommunityRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IPExtendedCommunityRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
