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
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkToNetworkInterconnectData : IUtf8JsonSerializable, IJsonModel<NetworkToNetworkInterconnectData>, IPersistableModel<NetworkToNetworkInterconnectData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkToNetworkInterconnectData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkToNetworkInterconnectData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkToNetworkInterconnectData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkToNetworkInterconnectData)} does not support '{format}' format.");
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
            if (Optional.IsDefined(NniType))
            {
                writer.WritePropertyName("nniType"u8);
                writer.WriteStringValue(NniType.Value.ToString());
            }
            if (Optional.IsDefined(IsManagementType))
            {
                writer.WritePropertyName("isManagementType"u8);
                writer.WriteStringValue(IsManagementType.Value.ToString());
            }
            writer.WritePropertyName("useOptionB"u8);
            writer.WriteStringValue(UseOptionB.ToString());
            if (Optional.IsDefined(Layer2Configuration))
            {
                writer.WritePropertyName("layer2Configuration"u8);
                writer.WriteObjectValue(Layer2Configuration);
            }
            if (Optional.IsDefined(OptionBLayer3Configuration))
            {
                writer.WritePropertyName("optionBLayer3Configuration"u8);
                writer.WriteObjectValue(OptionBLayer3Configuration);
            }
            if (Optional.IsDefined(NpbStaticRouteConfiguration))
            {
                writer.WritePropertyName("npbStaticRouteConfiguration"u8);
                writer.WriteObjectValue(NpbStaticRouteConfiguration);
            }
            if (Optional.IsDefined(ImportRoutePolicy))
            {
                writer.WritePropertyName("importRoutePolicy"u8);
                writer.WriteObjectValue(ImportRoutePolicy);
            }
            if (Optional.IsDefined(ExportRoutePolicy))
            {
                writer.WritePropertyName("exportRoutePolicy"u8);
                writer.WriteObjectValue(ExportRoutePolicy);
            }
            if (Optional.IsDefined(EgressAclId))
            {
                writer.WritePropertyName("egressAclId"u8);
                writer.WriteStringValue(EgressAclId);
            }
            if (Optional.IsDefined(IngressAclId))
            {
                writer.WritePropertyName("ingressAclId"u8);
                writer.WriteStringValue(IngressAclId);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationState))
            {
                writer.WritePropertyName("configurationState"u8);
                writer.WriteStringValue(ConfigurationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AdministrativeState))
            {
                writer.WritePropertyName("administrativeState"u8);
                writer.WriteStringValue(AdministrativeState.Value.ToString());
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

        NetworkToNetworkInterconnectData IJsonModel<NetworkToNetworkInterconnectData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkToNetworkInterconnectData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkToNetworkInterconnectData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkToNetworkInterconnectData(document.RootElement, options);
        }

        internal static NetworkToNetworkInterconnectData DeserializeNetworkToNetworkInterconnectData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<NniType> nniType = default;
            Optional<IsManagementType> isManagementType = default;
            NetworkFabricBooleanValue useOptionB = default;
            Optional<Layer2Configuration> layer2Configuration = default;
            Optional<NetworkToNetworkInterconnectOptionBLayer3Configuration> optionBLayer3Configuration = default;
            Optional<NpbStaticRouteConfiguration> npbStaticRouteConfiguration = default;
            Optional<ImportRoutePolicyInformation> importRoutePolicy = default;
            Optional<ExportRoutePolicyInformation> exportRoutePolicy = default;
            Optional<ResourceIdentifier> egressAclId = default;
            Optional<ResourceIdentifier> ingressAclId = default;
            Optional<NetworkFabricConfigurationState> configurationState = default;
            Optional<NetworkFabricProvisioningState> provisioningState = default;
            Optional<NetworkFabricAdministrativeState> administrativeState = default;
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
                        if (property0.NameEquals("nniType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nniType = new NniType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isManagementType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isManagementType = new IsManagementType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("useOptionB"u8))
                        {
                            useOptionB = new NetworkFabricBooleanValue(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("layer2Configuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            layer2Configuration = Layer2Configuration.DeserializeLayer2Configuration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("optionBLayer3Configuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optionBLayer3Configuration = NetworkToNetworkInterconnectOptionBLayer3Configuration.DeserializeNetworkToNetworkInterconnectOptionBLayer3Configuration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("npbStaticRouteConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            npbStaticRouteConfiguration = NpbStaticRouteConfiguration.DeserializeNpbStaticRouteConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicy = ImportRoutePolicyInformation.DeserializeImportRoutePolicyInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicy = ExportRoutePolicyInformation.DeserializeExportRoutePolicyInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("egressAclId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressAclId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ingressAclId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressAclId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("configurationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationState = new NetworkFabricConfigurationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
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
            return new NetworkToNetworkInterconnectData(id, name, type, systemData.Value, Optional.ToNullable(nniType), Optional.ToNullable(isManagementType), useOptionB, layer2Configuration.Value, optionBLayer3Configuration.Value, npbStaticRouteConfiguration.Value, importRoutePolicy.Value, exportRoutePolicy.Value, egressAclId.Value, ingressAclId.Value, Optional.ToNullable(configurationState), Optional.ToNullable(provisioningState), Optional.ToNullable(administrativeState), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(NniType))
            {
                builder.Append("  nniType:");
                builder.AppendLine($" '{NniType.ToString()}'");
            }

            if (Optional.IsDefined(IsManagementType))
            {
                builder.Append("  isManagementType:");
                builder.AppendLine($" '{IsManagementType.ToString()}'");
            }

            if (Optional.IsDefined(UseOptionB))
            {
                builder.Append("  useOptionB:");
                builder.AppendLine($" '{UseOptionB.ToString()}'");
            }

            if (Optional.IsDefined(Layer2Configuration))
            {
                builder.Append("  layer2Configuration:");
                AppendChildObject(builder, Layer2Configuration, options, 2);
            }

            if (Optional.IsDefined(OptionBLayer3Configuration))
            {
                builder.Append("  optionBLayer3Configuration:");
                AppendChildObject(builder, OptionBLayer3Configuration, options, 2);
            }

            if (Optional.IsDefined(NpbStaticRouteConfiguration))
            {
                builder.Append("  npbStaticRouteConfiguration:");
                AppendChildObject(builder, NpbStaticRouteConfiguration, options, 2);
            }

            if (Optional.IsDefined(ImportRoutePolicy))
            {
                builder.Append("  importRoutePolicy:");
                AppendChildObject(builder, ImportRoutePolicy, options, 2);
            }

            if (Optional.IsDefined(ExportRoutePolicy))
            {
                builder.Append("  exportRoutePolicy:");
                AppendChildObject(builder, ExportRoutePolicy, options, 2);
            }

            if (Optional.IsDefined(EgressAclId))
            {
                builder.Append("  egressAclId:");
                builder.AppendLine($" '{EgressAclId.ToString()}'");
            }

            if (Optional.IsDefined(IngressAclId))
            {
                builder.Append("  ingressAclId:");
                builder.AppendLine($" '{IngressAclId.ToString()}'");
            }

            if (Optional.IsDefined(ConfigurationState))
            {
                builder.Append("  configurationState:");
                builder.AppendLine($" '{ConfigurationState.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(AdministrativeState))
            {
                builder.Append("  administrativeState:");
                builder.AppendLine($" '{AdministrativeState.ToString()}'");
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

        BinaryData IPersistableModel<NetworkToNetworkInterconnectData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkToNetworkInterconnectData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NetworkToNetworkInterconnectData)} does not support '{options.Format}' format.");
            }
        }

        NetworkToNetworkInterconnectData IPersistableModel<NetworkToNetworkInterconnectData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkToNetworkInterconnectData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkToNetworkInterconnectData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(NetworkToNetworkInterconnectData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkToNetworkInterconnectData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
