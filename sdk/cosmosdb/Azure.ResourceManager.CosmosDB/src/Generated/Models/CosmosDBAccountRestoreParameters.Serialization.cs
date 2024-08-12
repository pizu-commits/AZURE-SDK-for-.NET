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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountRestoreParameters : IUtf8JsonSerializable, IJsonModel<CosmosDBAccountRestoreParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBAccountRestoreParameters>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosDBAccountRestoreParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountRestoreParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBAccountRestoreParameters)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RestoreMode))
            {
                writer.WritePropertyName("restoreMode"u8);
                writer.WriteStringValue(RestoreMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DatabasesToRestore))
            {
                writer.WritePropertyName("databasesToRestore"u8);
                writer.WriteStartArray();
                foreach (var item in DatabasesToRestore)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(GremlinDatabasesToRestore))
            {
                writer.WritePropertyName("gremlinDatabasesToRestore"u8);
                writer.WriteStartArray();
                foreach (var item in GremlinDatabasesToRestore)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TablesToRestore))
            {
                writer.WritePropertyName("tablesToRestore"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToRestore)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SourceBackupLocation))
            {
                writer.WritePropertyName("sourceBackupLocation"u8);
                writer.WriteStringValue(SourceBackupLocation);
            }
            if (Optional.IsDefined(RestoreSource))
            {
                writer.WritePropertyName("restoreSource"u8);
                writer.WriteStringValue(RestoreSource);
            }
            if (Optional.IsDefined(RestoreTimestampInUtc))
            {
                writer.WritePropertyName("restoreTimestampInUtc"u8);
                writer.WriteStringValue(RestoreTimestampInUtc.Value, "O");
            }
            if (Optional.IsDefined(IsRestoreWithTtlDisabled))
            {
                writer.WritePropertyName("restoreWithTtlDisabled"u8);
                writer.WriteBooleanValue(IsRestoreWithTtlDisabled.Value);
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

        CosmosDBAccountRestoreParameters IJsonModel<CosmosDBAccountRestoreParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountRestoreParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBAccountRestoreParameters)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBAccountRestoreParameters(document.RootElement, options);
        }

        internal static CosmosDBAccountRestoreParameters DeserializeCosmosDBAccountRestoreParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CosmosDBAccountRestoreMode? restoreMode = default;
            IList<DatabaseRestoreResourceInfo> databasesToRestore = default;
            IList<GremlinDatabaseRestoreResourceInfo> gremlinDatabasesToRestore = default;
            IList<string> tablesToRestore = default;
            string sourceBackupLocation = default;
            string restoreSource = default;
            DateTimeOffset? restoreTimestampInUtc = default;
            bool? restoreWithTtlDisabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restoreMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreMode = new CosmosDBAccountRestoreMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("databasesToRestore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatabaseRestoreResourceInfo> array = new List<DatabaseRestoreResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatabaseRestoreResourceInfo.DeserializeDatabaseRestoreResourceInfo(item, options));
                    }
                    databasesToRestore = array;
                    continue;
                }
                if (property.NameEquals("gremlinDatabasesToRestore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GremlinDatabaseRestoreResourceInfo> array = new List<GremlinDatabaseRestoreResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GremlinDatabaseRestoreResourceInfo.DeserializeGremlinDatabaseRestoreResourceInfo(item, options));
                    }
                    gremlinDatabasesToRestore = array;
                    continue;
                }
                if (property.NameEquals("tablesToRestore"u8))
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
                    tablesToRestore = array;
                    continue;
                }
                if (property.NameEquals("sourceBackupLocation"u8))
                {
                    sourceBackupLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreSource"u8))
                {
                    restoreSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreTimestampInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreTimestampInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("restoreWithTtlDisabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreWithTtlDisabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CosmosDBAccountRestoreParameters(
                restoreSource,
                restoreTimestampInUtc,
                restoreWithTtlDisabled,
                serializedAdditionalRawData,
                restoreMode,
                databasesToRestore ?? new ChangeTrackingList<DatabaseRestoreResourceInfo>(),
                gremlinDatabasesToRestore ?? new ChangeTrackingList<GremlinDatabaseRestoreResourceInfo>(),
                tablesToRestore ?? new ChangeTrackingList<string>(),
                sourceBackupLocation);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RestoreMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  restoreMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RestoreMode))
                {
                    builder.Append("  restoreMode: ");
                    builder.AppendLine($"'{RestoreMode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabasesToRestore), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  databasesToRestore: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(DatabasesToRestore))
                {
                    if (DatabasesToRestore.Any())
                    {
                        builder.Append("  databasesToRestore: ");
                        builder.AppendLine("[");
                        foreach (var item in DatabasesToRestore)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  databasesToRestore: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GremlinDatabasesToRestore), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  gremlinDatabasesToRestore: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(GremlinDatabasesToRestore))
                {
                    if (GremlinDatabasesToRestore.Any())
                    {
                        builder.Append("  gremlinDatabasesToRestore: ");
                        builder.AppendLine("[");
                        foreach (var item in GremlinDatabasesToRestore)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  gremlinDatabasesToRestore: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TablesToRestore), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tablesToRestore: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(TablesToRestore))
                {
                    if (TablesToRestore.Any())
                    {
                        builder.Append("  tablesToRestore: ");
                        builder.AppendLine("[");
                        foreach (var item in TablesToRestore)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceBackupLocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceBackupLocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceBackupLocation))
                {
                    builder.Append("  sourceBackupLocation: ");
                    if (SourceBackupLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceBackupLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceBackupLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RestoreSource), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  restoreSource: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RestoreSource))
                {
                    builder.Append("  restoreSource: ");
                    if (RestoreSource.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RestoreSource}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RestoreSource}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RestoreTimestampInUtc), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  restoreTimestampInUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RestoreTimestampInUtc))
                {
                    builder.Append("  restoreTimestampInUtc: ");
                    var formattedDateTimeString = TypeFormatters.ToString(RestoreTimestampInUtc.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsRestoreWithTtlDisabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  restoreWithTtlDisabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsRestoreWithTtlDisabled))
                {
                    builder.Append("  restoreWithTtlDisabled: ");
                    var boolValue = IsRestoreWithTtlDisabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CosmosDBAccountRestoreParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountRestoreParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBAccountRestoreParameters)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBAccountRestoreParameters IPersistableModel<CosmosDBAccountRestoreParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountRestoreParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBAccountRestoreParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBAccountRestoreParameters)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBAccountRestoreParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
