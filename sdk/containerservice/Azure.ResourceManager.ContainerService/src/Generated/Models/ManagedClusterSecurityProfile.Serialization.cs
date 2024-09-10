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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterSecurityProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterSecurityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterSecurityProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterSecurityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSecurityProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Defender))
            {
                writer.WritePropertyName("defender"u8);
                writer.WriteObjectValue(Defender, options);
            }
            if (Optional.IsDefined(AzureKeyVaultKms))
            {
                writer.WritePropertyName("azureKeyVaultKms"u8);
                writer.WriteObjectValue(AzureKeyVaultKms, options);
            }
            if (Optional.IsDefined(WorkloadIdentity))
            {
                writer.WritePropertyName("workloadIdentity"u8);
                writer.WriteObjectValue(WorkloadIdentity, options);
            }
            if (Optional.IsDefined(ImageCleaner))
            {
                writer.WritePropertyName("imageCleaner"u8);
                writer.WriteObjectValue(ImageCleaner, options);
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

        ManagedClusterSecurityProfile IJsonModel<ManagedClusterSecurityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSecurityProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterSecurityProfile(document.RootElement, options);
        }

        internal static ManagedClusterSecurityProfile DeserializeManagedClusterSecurityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedClusterSecurityProfileDefender defender = default;
            ManagedClusterSecurityProfileKeyVaultKms azureKeyVaultKms = default;
            ManagedClusterSecurityProfileWorkloadIdentity workloadIdentity = default;
            ManagedClusterSecurityProfileImageCleaner imageCleaner = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defender"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defender = ManagedClusterSecurityProfileDefender.DeserializeManagedClusterSecurityProfileDefender(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureKeyVaultKms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureKeyVaultKms = ManagedClusterSecurityProfileKeyVaultKms.DeserializeManagedClusterSecurityProfileKeyVaultKms(property.Value, options);
                    continue;
                }
                if (property.NameEquals("workloadIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadIdentity = ManagedClusterSecurityProfileWorkloadIdentity.DeserializeManagedClusterSecurityProfileWorkloadIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("imageCleaner"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageCleaner = ManagedClusterSecurityProfileImageCleaner.DeserializeManagedClusterSecurityProfileImageCleaner(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterSecurityProfile(defender, azureKeyVaultKms, workloadIdentity, imageCleaner, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Defender), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  defender: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Defender))
                {
                    builder.Append("  defender: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Defender, options, 2, false, "  defender: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureKeyVaultKms), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureKeyVaultKms: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureKeyVaultKms))
                {
                    builder.Append("  azureKeyVaultKms: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AzureKeyVaultKms, options, 2, false, "  azureKeyVaultKms: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("IsWorkloadIdentityEnabled", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  workloadIdentity: ");
                builder.AppendLine("{");
                builder.Append("    enabled: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(WorkloadIdentity))
                {
                    builder.Append("  workloadIdentity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, WorkloadIdentity, options, 2, false, "  workloadIdentity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ImageCleaner), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  imageCleaner: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ImageCleaner))
                {
                    builder.Append("  imageCleaner: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ImageCleaner, options, 2, false, "  imageCleaner: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedClusterSecurityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSecurityProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterSecurityProfile IPersistableModel<ManagedClusterSecurityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterSecurityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSecurityProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterSecurityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
