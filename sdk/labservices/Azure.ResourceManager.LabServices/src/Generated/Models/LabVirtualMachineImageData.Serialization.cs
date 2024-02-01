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
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    public partial class LabVirtualMachineImageData : IUtf8JsonSerializable, IJsonModel<LabVirtualMachineImageData>, IPersistableModel<LabVirtualMachineImageData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabVirtualMachineImageData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LabVirtualMachineImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabVirtualMachineImageData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(IconUri))
            {
                writer.WritePropertyName("iconUrl"u8);
                writer.WriteStringValue(IconUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(Author))
            {
                writer.WritePropertyName("author"u8);
                writer.WriteStringValue(Author);
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteStringValue(Plan);
            }
            if (options.Format != "W" && Optional.IsDefined(TermsStatus))
            {
                writer.WritePropertyName("termsStatus"u8);
                writer.WriteStringValue(TermsStatus.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(Offer))
            {
                writer.WritePropertyName("offer"u8);
                writer.WriteStringValue(Offer);
            }
            if (options.Format != "W" && Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (options.Format != "W" && Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(SharedGalleryId))
            {
                writer.WritePropertyName("sharedGalleryId"u8);
                writer.WriteStringValue(SharedGalleryId);
            }
            if (Optional.IsCollectionDefined(AvailableRegions))
            {
                writer.WritePropertyName("availableRegions"u8);
                writer.WriteStartArray();
                foreach (var item in AvailableRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(OSState))
            {
                writer.WritePropertyName("osState"u8);
                writer.WriteStringValue(OSState.Value.ToSerialString());
            }
            writer.WriteEndObject();
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

        LabVirtualMachineImageData IJsonModel<LabVirtualMachineImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabVirtualMachineImageData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabVirtualMachineImageData(document.RootElement, options);
        }

        internal static LabVirtualMachineImageData DeserializeLabVirtualMachineImageData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<LabServicesEnableState> enabledState = default;
            Optional<LabServicesProvisioningState> provisioningState = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<Uri> iconUrl = default;
            Optional<string> author = default;
            Optional<LabVirtualMachineImageOSType> osType = default;
            Optional<string> plan = default;
            Optional<LabServicesEnableState> termsStatus = default;
            Optional<string> offer = default;
            Optional<string> publisher = default;
            Optional<string> sku = default;
            Optional<string> version = default;
            Optional<ResourceIdentifier> sharedGalleryId = default;
            Optional<IList<AzureLocation>> availableRegions = default;
            Optional<LabVirtualMachineImageOSState> osState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("enabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledState = property0.Value.GetString().ToLabServicesEnableState();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToLabServicesProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iconUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("author"u8))
                        {
                            author = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osType = property0.Value.GetString().ToLabVirtualMachineImageOSType();
                            continue;
                        }
                        if (property0.NameEquals("plan"u8))
                        {
                            plan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("termsStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            termsStatus = property0.Value.GetString().ToLabServicesEnableState();
                            continue;
                        }
                        if (property0.NameEquals("offer"u8))
                        {
                            offer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedGalleryId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sharedGalleryId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("availableRegions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureLocation> array = new List<AzureLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AzureLocation(item.GetString()));
                            }
                            availableRegions = array;
                            continue;
                        }
                        if (property0.NameEquals("osState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osState = property0.Value.GetString().ToLabVirtualMachineImageOSState();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LabVirtualMachineImageData(id, name, type, systemData.Value, Optional.ToNullable(enabledState), Optional.ToNullable(provisioningState), displayName.Value, description.Value, iconUrl.Value, author.Value, Optional.ToNullable(osType), plan.Value, Optional.ToNullable(termsStatus), offer.Value, publisher.Value, sku.Value, version.Value, sharedGalleryId.Value, Optional.ToList(availableRegions), Optional.ToNullable(osState), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(EnabledState))
            {
                builder.Append("  enabledState:");
                builder.AppendLine($" '{EnabledState.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(DisplayName))
            {
                builder.Append("  displayName:");
                builder.AppendLine($" '{DisplayName}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("  description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(IconUri))
            {
                builder.Append("  iconUrl:");
                builder.AppendLine($" '{IconUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(Author))
            {
                builder.Append("  author:");
                builder.AppendLine($" '{Author}'");
            }

            if (Optional.IsDefined(OSType))
            {
                builder.Append("  osType:");
                builder.AppendLine($" '{OSType.ToString()}'");
            }

            if (Optional.IsDefined(Plan))
            {
                builder.Append("  plan:");
                builder.AppendLine($" '{Plan}'");
            }

            if (Optional.IsDefined(TermsStatus))
            {
                builder.Append("  termsStatus:");
                builder.AppendLine($" '{TermsStatus.ToString()}'");
            }

            if (Optional.IsDefined(Offer))
            {
                builder.Append("  offer:");
                builder.AppendLine($" '{Offer}'");
            }

            if (Optional.IsDefined(Publisher))
            {
                builder.Append("  publisher:");
                builder.AppendLine($" '{Publisher}'");
            }

            if (Optional.IsDefined(Sku))
            {
                builder.Append("  sku:");
                builder.AppendLine($" '{Sku}'");
            }

            if (Optional.IsDefined(Version))
            {
                builder.Append("  version:");
                builder.AppendLine($" '{Version}'");
            }

            if (Optional.IsDefined(SharedGalleryId))
            {
                builder.Append("  sharedGalleryId:");
                builder.AppendLine($" '{SharedGalleryId.ToString()}'");
            }

            if (Optional.IsCollectionDefined(AvailableRegions))
            {
                builder.Append("  availableRegions:");
                builder.AppendLine(" [");
                foreach (var item in AvailableRegions)
                {
                    builder.AppendLine($"    '{item.ToString()}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(OSState))
            {
                builder.Append("  osState:");
                builder.AppendLine($" '{OSState.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
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

        BinaryData IPersistableModel<LabVirtualMachineImageData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LabVirtualMachineImageData)} does not support '{options.Format}' format.");
            }
        }

        LabVirtualMachineImageData IPersistableModel<LabVirtualMachineImageData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLabVirtualMachineImageData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(LabVirtualMachineImageData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LabVirtualMachineImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
