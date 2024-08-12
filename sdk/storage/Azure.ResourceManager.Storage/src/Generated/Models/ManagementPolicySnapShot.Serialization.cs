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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ManagementPolicySnapShot : IUtf8JsonSerializable, IJsonModel<ManagementPolicySnapShot>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementPolicySnapShot>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagementPolicySnapShot>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicySnapShot>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementPolicySnapShot)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TierToCool))
            {
                writer.WritePropertyName("tierToCool"u8);
                writer.WriteObjectValue(TierToCool, options);
            }
            if (Optional.IsDefined(TierToArchive))
            {
                writer.WritePropertyName("tierToArchive"u8);
                writer.WriteObjectValue(TierToArchive, options);
            }
            if (Optional.IsDefined(TierToCold))
            {
                writer.WritePropertyName("tierToCold"u8);
                writer.WriteObjectValue(TierToCold, options);
            }
            if (Optional.IsDefined(TierToHot))
            {
                writer.WritePropertyName("tierToHot"u8);
                writer.WriteObjectValue(TierToHot, options);
            }
            if (Optional.IsDefined(Delete))
            {
                writer.WritePropertyName("delete"u8);
                writer.WriteObjectValue(Delete, options);
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

        ManagementPolicySnapShot IJsonModel<ManagementPolicySnapShot>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicySnapShot>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementPolicySnapShot)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementPolicySnapShot(document.RootElement, options);
        }

        internal static ManagementPolicySnapShot DeserializeManagementPolicySnapShot(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateAfterCreation tierToCool = default;
            DateAfterCreation tierToArchive = default;
            DateAfterCreation tierToCold = default;
            DateAfterCreation tierToHot = default;
            DateAfterCreation delete = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tierToCool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToCool = DateAfterCreation.DeserializeDateAfterCreation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tierToArchive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToArchive = DateAfterCreation.DeserializeDateAfterCreation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tierToCold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToCold = DateAfterCreation.DeserializeDateAfterCreation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tierToHot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToHot = DateAfterCreation.DeserializeDateAfterCreation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("delete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delete = DateAfterCreation.DeserializeDateAfterCreation(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagementPolicySnapShot(
                tierToCool,
                tierToArchive,
                tierToCold,
                tierToHot,
                delete,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TierToCool), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tierToCool: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TierToCool))
                {
                    builder.Append("  tierToCool: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TierToCool, options, 2, false, "  tierToCool: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TierToArchive), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tierToArchive: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TierToArchive))
                {
                    builder.Append("  tierToArchive: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TierToArchive, options, 2, false, "  tierToArchive: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TierToCold), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tierToCold: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TierToCold))
                {
                    builder.Append("  tierToCold: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TierToCold, options, 2, false, "  tierToCold: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TierToHot), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tierToHot: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TierToHot))
                {
                    builder.Append("  tierToHot: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TierToHot, options, 2, false, "  tierToHot: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Delete), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  delete: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Delete))
                {
                    builder.Append("  delete: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Delete, options, 2, false, "  delete: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagementPolicySnapShot>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicySnapShot>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagementPolicySnapShot)} does not support writing '{options.Format}' format.");
            }
        }

        ManagementPolicySnapShot IPersistableModel<ManagementPolicySnapShot>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicySnapShot>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementPolicySnapShot(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementPolicySnapShot)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementPolicySnapShot>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
