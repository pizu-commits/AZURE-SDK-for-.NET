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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class WebSiteInstanceStatusData : IUtf8JsonSerializable, IJsonModel<WebSiteInstanceStatusData>, IPersistableModel<WebSiteInstanceStatusData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebSiteInstanceStatusData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebSiteInstanceStatusData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteInstanceStatusData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebSiteInstanceStatusData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsDefined(StatusUri))
            {
                writer.WritePropertyName("statusUrl"u8);
                writer.WriteStringValue(StatusUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DetectorUri))
            {
                writer.WritePropertyName("detectorUrl"u8);
                writer.WriteStringValue(DetectorUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ConsoleUri))
            {
                writer.WritePropertyName("consoleUrl"u8);
                writer.WriteStringValue(ConsoleUri.AbsoluteUri);
            }
            if (Optional.IsDefined(HealthCheckUrlString))
            {
                writer.WritePropertyName("healthCheckUrl"u8);
                writer.WriteStringValue(HealthCheckUrlString);
            }
            if (Optional.IsCollectionDefined(Containers))
            {
                writer.WritePropertyName("containers"u8);
                writer.WriteStartObject();
                foreach (var item in Containers)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        WebSiteInstanceStatusData IJsonModel<WebSiteInstanceStatusData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteInstanceStatusData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebSiteInstanceStatusData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebSiteInstanceStatusData(document.RootElement, options);
        }

        internal static WebSiteInstanceStatusData DeserializeWebSiteInstanceStatusData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SiteRuntimeState> state = default;
            Optional<Uri> statusUrl = default;
            Optional<Uri> detectorUrl = default;
            Optional<Uri> consoleUrl = default;
            Optional<string> healthCheckUrl = default;
            Optional<IDictionary<string, ContainerInfo>> containers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToSiteRuntimeState();
                            continue;
                        }
                        if (property0.NameEquals("statusUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            statusUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detectorUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            detectorUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("consoleUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            consoleUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("healthCheckUrl"u8))
                        {
                            healthCheckUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ContainerInfo> dictionary = new Dictionary<string, ContainerInfo>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ContainerInfo.DeserializeContainerInfo(property1.Value));
                            }
                            containers = dictionary;
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
            return new WebSiteInstanceStatusData(id, name, type, systemData.Value, Optional.ToNullable(state), statusUrl.Value, detectorUrl.Value, consoleUrl.Value, healthCheckUrl.Value, Optional.ToDictionary(containers), kind.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(State))
            {
                builder.Append("  state:");
                builder.AppendLine($" '{State.ToString()}'");
            }

            if (Optional.IsDefined(StatusUri))
            {
                builder.Append("  statusUrl:");
                builder.AppendLine($" '{StatusUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(DetectorUri))
            {
                builder.Append("  detectorUrl:");
                builder.AppendLine($" '{DetectorUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(ConsoleUri))
            {
                builder.Append("  consoleUrl:");
                builder.AppendLine($" '{ConsoleUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(HealthCheckUrlString))
            {
                builder.Append("  healthCheckUrl:");
                builder.AppendLine($" '{HealthCheckUrlString}'");
            }

            if (Optional.IsCollectionDefined(Containers))
            {
                builder.Append("  containers:");
                builder.AppendLine(" {");
                foreach (var item in Containers)
                {
                    builder.Append($"    {item.Key}: ");

                    AppendChildObject(builder, item.Value, options, 4);
                }
                builder.AppendLine("  }");
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind}'");
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

        BinaryData IPersistableModel<WebSiteInstanceStatusData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteInstanceStatusData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WebSiteInstanceStatusData)} does not support '{options.Format}' format.");
            }
        }

        WebSiteInstanceStatusData IPersistableModel<WebSiteInstanceStatusData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteInstanceStatusData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebSiteInstanceStatusData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(WebSiteInstanceStatusData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebSiteInstanceStatusData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
