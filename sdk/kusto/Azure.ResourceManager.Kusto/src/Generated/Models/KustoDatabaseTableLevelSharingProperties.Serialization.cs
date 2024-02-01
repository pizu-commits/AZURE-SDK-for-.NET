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

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoDatabaseTableLevelSharingProperties : IUtf8JsonSerializable, IJsonModel<KustoDatabaseTableLevelSharingProperties>, IPersistableModel<KustoDatabaseTableLevelSharingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KustoDatabaseTableLevelSharingProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KustoDatabaseTableLevelSharingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabaseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoDatabaseTableLevelSharingProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TablesToInclude))
            {
                writer.WritePropertyName("tablesToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TablesToExclude))
            {
                writer.WritePropertyName("tablesToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalTablesToInclude))
            {
                writer.WritePropertyName("externalTablesToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalTablesToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalTablesToExclude))
            {
                writer.WritePropertyName("externalTablesToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalTablesToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MaterializedViewsToInclude))
            {
                writer.WritePropertyName("materializedViewsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in MaterializedViewsToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MaterializedViewsToExclude))
            {
                writer.WritePropertyName("materializedViewsToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in MaterializedViewsToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FunctionsToInclude))
            {
                writer.WritePropertyName("functionsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in FunctionsToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FunctionsToExclude))
            {
                writer.WritePropertyName("functionsToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in FunctionsToExclude)
                {
                    writer.WriteStringValue(item);
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

        KustoDatabaseTableLevelSharingProperties IJsonModel<KustoDatabaseTableLevelSharingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabaseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoDatabaseTableLevelSharingProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoDatabaseTableLevelSharingProperties(document.RootElement, options);
        }

        internal static KustoDatabaseTableLevelSharingProperties DeserializeKustoDatabaseTableLevelSharingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> tablesToInclude = default;
            Optional<IList<string>> tablesToExclude = default;
            Optional<IList<string>> externalTablesToInclude = default;
            Optional<IList<string>> externalTablesToExclude = default;
            Optional<IList<string>> materializedViewsToInclude = default;
            Optional<IList<string>> materializedViewsToExclude = default;
            Optional<IList<string>> functionsToInclude = default;
            Optional<IList<string>> functionsToExclude = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tablesToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tablesToInclude = array;
                    continue;
                }
                if (property.NameEquals("tablesToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tablesToExclude = array;
                    continue;
                }
                if (property.NameEquals("externalTablesToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    externalTablesToInclude = array;
                    continue;
                }
                if (property.NameEquals("externalTablesToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    externalTablesToExclude = array;
                    continue;
                }
                if (property.NameEquals("materializedViewsToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    materializedViewsToInclude = array;
                    continue;
                }
                if (property.NameEquals("materializedViewsToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    materializedViewsToExclude = array;
                    continue;
                }
                if (property.NameEquals("functionsToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    functionsToInclude = array;
                    continue;
                }
                if (property.NameEquals("functionsToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    functionsToExclude = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KustoDatabaseTableLevelSharingProperties(Optional.ToList(tablesToInclude), Optional.ToList(tablesToExclude), Optional.ToList(externalTablesToInclude), Optional.ToList(externalTablesToExclude), Optional.ToList(materializedViewsToInclude), Optional.ToList(materializedViewsToExclude), Optional.ToList(functionsToInclude), Optional.ToList(functionsToExclude), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(TablesToInclude))
            {
                builder.Append("  tablesToInclude:");
                builder.AppendLine(" [");
                foreach (var item in TablesToInclude)
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

            if (Optional.IsCollectionDefined(TablesToExclude))
            {
                builder.Append("  tablesToExclude:");
                builder.AppendLine(" [");
                foreach (var item in TablesToExclude)
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

            if (Optional.IsCollectionDefined(ExternalTablesToInclude))
            {
                builder.Append("  externalTablesToInclude:");
                builder.AppendLine(" [");
                foreach (var item in ExternalTablesToInclude)
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

            if (Optional.IsCollectionDefined(ExternalTablesToExclude))
            {
                builder.Append("  externalTablesToExclude:");
                builder.AppendLine(" [");
                foreach (var item in ExternalTablesToExclude)
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

            if (Optional.IsCollectionDefined(MaterializedViewsToInclude))
            {
                builder.Append("  materializedViewsToInclude:");
                builder.AppendLine(" [");
                foreach (var item in MaterializedViewsToInclude)
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

            if (Optional.IsCollectionDefined(MaterializedViewsToExclude))
            {
                builder.Append("  materializedViewsToExclude:");
                builder.AppendLine(" [");
                foreach (var item in MaterializedViewsToExclude)
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

            if (Optional.IsCollectionDefined(FunctionsToInclude))
            {
                builder.Append("  functionsToInclude:");
                builder.AppendLine(" [");
                foreach (var item in FunctionsToInclude)
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

            if (Optional.IsCollectionDefined(FunctionsToExclude))
            {
                builder.Append("  functionsToExclude:");
                builder.AppendLine(" [");
                foreach (var item in FunctionsToExclude)
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

        BinaryData IPersistableModel<KustoDatabaseTableLevelSharingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabaseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KustoDatabaseTableLevelSharingProperties)} does not support '{options.Format}' format.");
            }
        }

        KustoDatabaseTableLevelSharingProperties IPersistableModel<KustoDatabaseTableLevelSharingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabaseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKustoDatabaseTableLevelSharingProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(KustoDatabaseTableLevelSharingProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KustoDatabaseTableLevelSharingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
