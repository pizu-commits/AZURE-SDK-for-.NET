// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(SystemDataConverter))]
    public partial class SystemData : IUtf8JsonSerializable, IJsonModel<SystemData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SystemData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SystemData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SystemData)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedByType))
            {
                writer.WritePropertyName("createdByType"u8);
                writer.WriteStringValue(CreatedByType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedBy))
            {
                writer.WritePropertyName("lastModifiedBy"u8);
                writer.WriteStringValue(LastModifiedBy);
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedByType))
            {
                writer.WritePropertyName("lastModifiedByType"u8);
                writer.WriteStringValue(LastModifiedByType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedAt"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
        }

        SystemData IJsonModel<SystemData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SystemData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSystemData(document.RootElement, options);
        }

        internal static SystemData DeserializeSystemData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string createdBy = default;
            CreatedByType? createdByType = default;
            DateTimeOffset? createdAt = default;
            string lastModifiedBy = default;
            CreatedByType? lastModifiedByType = default;
            DateTimeOffset? lastModifiedAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdBy"u8))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdByType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdByType = new CreatedByType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedBy"u8))
                {
                    lastModifiedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModifiedByType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedByType = new CreatedByType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastModifiedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new SystemData(
                createdBy,
                createdByType,
                createdAt,
                lastModifiedBy,
                lastModifiedByType,
                lastModifiedAt);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedBy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  createdBy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedBy))
                {
                    builder.Append("  createdBy: ");
                    if (CreatedBy.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CreatedBy}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CreatedBy}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedByType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  createdByType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedByType))
                {
                    builder.Append("  createdByType: ");
                    builder.AppendLine($"'{CreatedByType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  createdAt: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    builder.Append("  createdAt: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastModifiedBy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastModifiedBy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastModifiedBy))
                {
                    builder.Append("  lastModifiedBy: ");
                    if (LastModifiedBy.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastModifiedBy}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastModifiedBy}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastModifiedByType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastModifiedByType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastModifiedByType))
                {
                    builder.Append("  lastModifiedByType: ");
                    builder.AppendLine($"'{LastModifiedByType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastModifiedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastModifiedAt: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastModifiedOn))
                {
                    builder.Append("  lastModifiedAt: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastModifiedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SystemData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SystemData)} does not support writing '{options.Format}' format.");
            }
        }

        SystemData IPersistableModel<SystemData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSystemData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SystemData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SystemData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class SystemDataConverter : JsonConverter<SystemData>
        {
            public override void Write(Utf8JsonWriter writer, SystemData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model, ModelSerializationExtensions.WireOptions);
            }

            public override SystemData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSystemData(document.RootElement);
            }
        }
    }
}
