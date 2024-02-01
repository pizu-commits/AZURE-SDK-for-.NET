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
    public partial class OptionBLayer3Configuration : IUtf8JsonSerializable, IJsonModel<OptionBLayer3Configuration>, IPersistableModel<OptionBLayer3Configuration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OptionBLayer3Configuration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OptionBLayer3Configuration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionBLayer3Configuration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OptionBLayer3Configuration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerASN"u8);
                writer.WriteNumberValue(PeerAsn.Value);
            }
            if (Optional.IsDefined(VlanId))
            {
                writer.WritePropertyName("vlanId"u8);
                writer.WriteNumberValue(VlanId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FabricAsn))
            {
                writer.WritePropertyName("fabricASN"u8);
                writer.WriteNumberValue(FabricAsn.Value);
            }
            if (Optional.IsDefined(PrimaryIPv4Prefix))
            {
                writer.WritePropertyName("primaryIpv4Prefix"u8);
                writer.WriteStringValue(PrimaryIPv4Prefix);
            }
            if (Optional.IsDefined(PrimaryIPv6Prefix))
            {
                writer.WritePropertyName("primaryIpv6Prefix"u8);
                writer.WriteStringValue(PrimaryIPv6Prefix);
            }
            if (Optional.IsDefined(SecondaryIPv4Prefix))
            {
                writer.WritePropertyName("secondaryIpv4Prefix"u8);
                writer.WriteStringValue(SecondaryIPv4Prefix);
            }
            if (Optional.IsDefined(SecondaryIPv6Prefix))
            {
                writer.WritePropertyName("secondaryIpv6Prefix"u8);
                writer.WriteStringValue(SecondaryIPv6Prefix);
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

        OptionBLayer3Configuration IJsonModel<OptionBLayer3Configuration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionBLayer3Configuration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OptionBLayer3Configuration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOptionBLayer3Configuration(document.RootElement, options);
        }

        internal static OptionBLayer3Configuration DeserializeOptionBLayer3Configuration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> peerAsn = default;
            Optional<int> vlanId = default;
            Optional<long> fabricAsn = default;
            Optional<string> primaryIPv4Prefix = default;
            Optional<string> primaryIPv6Prefix = default;
            Optional<string> secondaryIPv4Prefix = default;
            Optional<string> secondaryIPv6Prefix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peerASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vlanId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vlanId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fabricASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("primaryIpv4Prefix"u8))
                {
                    primaryIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryIpv6Prefix"u8))
                {
                    primaryIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryIpv4Prefix"u8))
                {
                    secondaryIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryIpv6Prefix"u8))
                {
                    secondaryIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OptionBLayer3Configuration(primaryIPv4Prefix.Value, primaryIPv6Prefix.Value, secondaryIPv4Prefix.Value, secondaryIPv6Prefix.Value, serializedAdditionalRawData, Optional.ToNullable(peerAsn), Optional.ToNullable(vlanId), Optional.ToNullable(fabricAsn));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(PeerAsn))
            {
                builder.Append("  peerASN:");
                builder.AppendLine($" '{PeerAsn.Value.ToString()}'");
            }

            if (Optional.IsDefined(VlanId))
            {
                builder.Append("  vlanId:");
                builder.AppendLine($" '{VlanId.Value.ToString()}'");
            }

            if (Optional.IsDefined(FabricAsn))
            {
                builder.Append("  fabricASN:");
                builder.AppendLine($" '{FabricAsn.Value.ToString()}'");
            }

            if (Optional.IsDefined(PrimaryIPv4Prefix))
            {
                builder.Append("  primaryIpv4Prefix:");
                builder.AppendLine($" '{PrimaryIPv4Prefix}'");
            }

            if (Optional.IsDefined(PrimaryIPv6Prefix))
            {
                builder.Append("  primaryIpv6Prefix:");
                builder.AppendLine($" '{PrimaryIPv6Prefix}'");
            }

            if (Optional.IsDefined(SecondaryIPv4Prefix))
            {
                builder.Append("  secondaryIpv4Prefix:");
                builder.AppendLine($" '{SecondaryIPv4Prefix}'");
            }

            if (Optional.IsDefined(SecondaryIPv6Prefix))
            {
                builder.Append("  secondaryIpv6Prefix:");
                builder.AppendLine($" '{SecondaryIPv6Prefix}'");
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

        BinaryData IPersistableModel<OptionBLayer3Configuration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionBLayer3Configuration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OptionBLayer3Configuration)} does not support '{options.Format}' format.");
            }
        }

        OptionBLayer3Configuration IPersistableModel<OptionBLayer3Configuration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionBLayer3Configuration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOptionBLayer3Configuration(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(OptionBLayer3Configuration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OptionBLayer3Configuration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
