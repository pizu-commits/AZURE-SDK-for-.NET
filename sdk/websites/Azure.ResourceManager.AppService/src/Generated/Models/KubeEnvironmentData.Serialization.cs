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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class KubeEnvironmentData : IUtf8JsonSerializable, IJsonModel<KubeEnvironmentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubeEnvironmentData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubeEnvironmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubeEnvironmentData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(DeploymentErrors))
            {
                writer.WritePropertyName("deploymentErrors"u8);
                writer.WriteStringValue(DeploymentErrors);
            }
            if (Optional.IsDefined(IsInternalLoadBalancerEnabled))
            {
                writer.WritePropertyName("internalLoadBalancerEnabled"u8);
                writer.WriteBooleanValue(IsInternalLoadBalancerEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultDomain))
            {
                writer.WritePropertyName("defaultDomain"u8);
                writer.WriteStringValue(DefaultDomain);
            }
            if (Optional.IsDefined(StaticIP))
            {
                writer.WritePropertyName("staticIp"u8);
                writer.WriteStringValue(StaticIP);
            }
            if (Optional.IsDefined(ArcConfiguration))
            {
                writer.WritePropertyName("arcConfiguration"u8);
                writer.WriteObjectValue(ArcConfiguration);
            }
            if (Optional.IsDefined(AppLogsConfiguration))
            {
                writer.WritePropertyName("appLogsConfiguration"u8);
                writer.WriteObjectValue(AppLogsConfiguration);
            }
            if (Optional.IsDefined(AksResourceId))
            {
                writer.WritePropertyName("aksResourceID"u8);
                writer.WriteStringValue(AksResourceId);
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

        KubeEnvironmentData IJsonModel<KubeEnvironmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubeEnvironmentData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubeEnvironmentData(document.RootElement, options);
        }

        internal static KubeEnvironmentData DeserializeKubeEnvironmentData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<KubeEnvironmentProvisioningState> provisioningState = default;
            Optional<string> deploymentErrors = default;
            Optional<bool> internalLoadBalancerEnabled = default;
            Optional<string> defaultDomain = default;
            Optional<string> staticIP = default;
            Optional<ArcConfiguration> arcConfiguration = default;
            Optional<AppLogsConfiguration> appLogsConfiguration = default;
            Optional<ResourceIdentifier> aksResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToKubeEnvironmentProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("deploymentErrors"u8))
                        {
                            deploymentErrors = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("internalLoadBalancerEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internalLoadBalancerEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultDomain"u8))
                        {
                            defaultDomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("staticIp"u8))
                        {
                            staticIP = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("arcConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            arcConfiguration = ArcConfiguration.DeserializeArcConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("appLogsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appLogsConfiguration = AppLogsConfiguration.DeserializeAppLogsConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("aksResourceID"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aksResourceId = new ResourceIdentifier(property0.Value.GetString());
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
            return new KubeEnvironmentData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, Optional.ToNullable(provisioningState), deploymentErrors.Value, Optional.ToNullable(internalLoadBalancerEnabled), defaultDomain.Value, staticIP.Value, arcConfiguration.Value, appLogsConfiguration.Value, aksResourceId.Value, kind.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ExtendedLocation))
            {
                builder.Append("  extendedLocation:");
                AppendChildObject(builder, ExtendedLocation, options, 2, false);
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind}'");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value}'");
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.ToString()}'");
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

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("    provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(DeploymentErrors))
            {
                builder.Append("    deploymentErrors:");
                builder.AppendLine($" '{DeploymentErrors}'");
            }

            if (Optional.IsDefined(IsInternalLoadBalancerEnabled))
            {
                builder.Append("    internalLoadBalancerEnabled:");
                var boolValue = IsInternalLoadBalancerEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(DefaultDomain))
            {
                builder.Append("    defaultDomain:");
                builder.AppendLine($" '{DefaultDomain}'");
            }

            if (Optional.IsDefined(StaticIP))
            {
                builder.Append("    staticIp:");
                builder.AppendLine($" '{StaticIP}'");
            }

            if (Optional.IsDefined(ArcConfiguration))
            {
                builder.Append("    arcConfiguration:");
                AppendChildObject(builder, ArcConfiguration, options, 4, false);
            }

            if (Optional.IsDefined(AppLogsConfiguration))
            {
                builder.Append("    appLogsConfiguration:");
                AppendChildObject(builder, AppLogsConfiguration, options, 4, false);
            }

            if (Optional.IsDefined(AksResourceId))
            {
                builder.Append("    aksResourceID:");
                builder.AppendLine($" '{AksResourceId.ToString()}'");
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<KubeEnvironmentData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KubeEnvironmentData)} does not support '{options.Format}' format.");
            }
        }

        KubeEnvironmentData IPersistableModel<KubeEnvironmentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubeEnvironmentData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(KubeEnvironmentData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubeEnvironmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
