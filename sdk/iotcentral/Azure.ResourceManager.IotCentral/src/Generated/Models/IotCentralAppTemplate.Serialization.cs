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

namespace Azure.ResourceManager.IotCentral.Models
{
    public partial class IotCentralAppTemplate : IUtf8JsonSerializable, IJsonModel<IotCentralAppTemplate>, IPersistableModel<IotCentralAppTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotCentralAppTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotCentralAppTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralAppTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotCentralAppTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ManifestId))
            {
                writer.WritePropertyName("manifestId"u8);
                writer.WriteStringValue(ManifestId);
            }
            if (options.Format != "W" && Optional.IsDefined(ManifestVersion))
            {
                writer.WritePropertyName("manifestVersion"u8);
                writer.WriteStringValue(ManifestVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (options.Format != "W" && Optional.IsDefined(Order))
            {
                writer.WritePropertyName("order"u8);
                writer.WriteNumberValue(Order.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(Industry))
            {
                writer.WritePropertyName("industry"u8);
                writer.WriteStringValue(Industry);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
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

        IotCentralAppTemplate IJsonModel<IotCentralAppTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralAppTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotCentralAppTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotCentralAppTemplate(document.RootElement, options);
        }

        internal static IotCentralAppTemplate DeserializeIotCentralAppTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> manifestId = default;
            Optional<string> manifestVersion = default;
            Optional<string> name = default;
            Optional<string> title = default;
            Optional<int> order = default;
            Optional<string> description = default;
            Optional<string> industry = default;
            Optional<IReadOnlyList<IotCentralAppTemplateLocation>> locations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("manifestId"u8))
                {
                    manifestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifestVersion"u8))
                {
                    manifestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("industry"u8))
                {
                    industry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotCentralAppTemplateLocation> array = new List<IotCentralAppTemplateLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotCentralAppTemplateLocation.DeserializeIotCentralAppTemplateLocation(item));
                    }
                    locations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotCentralAppTemplate(manifestId.Value, manifestVersion.Value, name.Value, title.Value, Optional.ToNullable(order), description.Value, industry.Value, Optional.ToList(locations), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ManifestId))
            {
                builder.Append("  manifestId:");
                builder.AppendLine($" '{ManifestId}'");
            }

            if (Optional.IsDefined(ManifestVersion))
            {
                builder.Append("  manifestVersion:");
                builder.AppendLine($" '{ManifestVersion}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(Title))
            {
                builder.Append("  title:");
                builder.AppendLine($" '{Title}'");
            }

            if (Optional.IsDefined(Order))
            {
                builder.Append("  order:");
                builder.AppendLine($" '{Order.Value.ToString()}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("  description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(Industry))
            {
                builder.Append("  industry:");
                builder.AppendLine($" '{Industry}'");
            }

            if (Optional.IsCollectionDefined(Locations))
            {
                builder.Append("  locations:");
                builder.AppendLine(" [");
                foreach (var item in Locations)
                {
                    AppendChildObject(builder, item, options, 4);
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

        BinaryData IPersistableModel<IotCentralAppTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralAppTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(IotCentralAppTemplate)} does not support '{options.Format}' format.");
            }
        }

        IotCentralAppTemplate IPersistableModel<IotCentralAppTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralAppTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotCentralAppTemplate(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(IotCentralAppTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotCentralAppTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
