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
    public partial class HostNameBindingData : IUtf8JsonSerializable, IJsonModel<HostNameBindingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostNameBindingData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HostNameBindingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameBindingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostNameBindingData)} does not support writing '{format}' format.");
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
            if (Optional.IsDefined(SiteName))
            {
                writer.WritePropertyName("siteName"u8);
                writer.WriteStringValue(SiteName);
            }
            if (Optional.IsDefined(DomainId))
            {
                writer.WritePropertyName("domainId"u8);
                writer.WriteStringValue(DomainId);
            }
            if (Optional.IsDefined(AzureResourceName))
            {
                writer.WritePropertyName("azureResourceName"u8);
                writer.WriteStringValue(AzureResourceName);
            }
            if (Optional.IsDefined(AzureResourceType))
            {
                writer.WritePropertyName("azureResourceType"u8);
                writer.WriteStringValue(AzureResourceType.Value.ToSerialString());
            }
            if (Optional.IsDefined(CustomHostNameDnsRecordType))
            {
                writer.WritePropertyName("customHostNameDnsRecordType"u8);
                writer.WriteStringValue(CustomHostNameDnsRecordType.Value.ToSerialString());
            }
            if (Optional.IsDefined(HostNameType))
            {
                writer.WritePropertyName("hostNameType"u8);
                writer.WriteStringValue(HostNameType.Value.ToSerialString());
            }
            if (Optional.IsDefined(SslState))
            {
                writer.WritePropertyName("sslState"u8);
                writer.WriteStringValue(SslState.Value.ToSerialString());
            }
            if (Optional.IsDefined(ThumbprintString))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            if (options.Format != "W" && Optional.IsDefined(VirtualIP))
            {
                writer.WritePropertyName("virtualIP"u8);
                writer.WriteStringValue(VirtualIP);
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

        HostNameBindingData IJsonModel<HostNameBindingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameBindingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostNameBindingData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostNameBindingData(document.RootElement, options);
        }

        internal static HostNameBindingData DeserializeHostNameBindingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string siteName = default;
            string domainId = default;
            string azureResourceName = default;
            AppServiceResourceType? azureResourceType = default;
            CustomHostNameDnsRecordType? customHostNameDnsRecordType = default;
            AppServiceHostNameType? hostNameType = default;
            HostNameBindingSslState? sslState = default;
            string thumbprint = default;
            string virtualIP = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("siteName"u8))
                        {
                            siteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainId"u8))
                        {
                            domainId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureResourceName"u8))
                        {
                            azureResourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureResourceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureResourceType = property0.Value.GetString().ToAppServiceResourceType();
                            continue;
                        }
                        if (property0.NameEquals("customHostNameDnsRecordType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customHostNameDnsRecordType = property0.Value.GetString().ToCustomHostNameDnsRecordType();
                            continue;
                        }
                        if (property0.NameEquals("hostNameType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostNameType = property0.Value.GetString().ToAppServiceHostNameType();
                            continue;
                        }
                        if (property0.NameEquals("sslState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sslState = property0.Value.GetString().ToHostNameBindingSslState();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"u8))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualIP"u8))
                        {
                            virtualIP = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HostNameBindingData(
                id,
                name,
                type,
                systemData,
                siteName,
                domainId,
                azureResourceName,
                azureResourceType,
                customHostNameDnsRecordType,
                hostNameType,
                sslState,
                thumbprint,
                virtualIP,
                kind,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SiteName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    siteName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SiteName))
                {
                    builder.Append("    siteName: ");
                    if (SiteName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SiteName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SiteName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DomainId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    domainId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DomainId))
                {
                    builder.Append("    domainId: ");
                    if (DomainId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DomainId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DomainId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureResourceName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    azureResourceName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureResourceName))
                {
                    builder.Append("    azureResourceName: ");
                    if (AzureResourceName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AzureResourceName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AzureResourceName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureResourceType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    azureResourceType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureResourceType))
                {
                    builder.Append("    azureResourceType: ");
                    builder.AppendLine($"'{AzureResourceType.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomHostNameDnsRecordType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    customHostNameDnsRecordType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomHostNameDnsRecordType))
                {
                    builder.Append("    customHostNameDnsRecordType: ");
                    builder.AppendLine($"'{CustomHostNameDnsRecordType.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostNameType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    hostNameType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HostNameType))
                {
                    builder.Append("    hostNameType: ");
                    builder.AppendLine($"'{HostNameType.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SslState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sslState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SslState))
                {
                    builder.Append("    sslState: ");
                    builder.AppendLine($"'{SslState.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ThumbprintString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    thumbprint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ThumbprintString))
                {
                    builder.Append("    thumbprint: ");
                    if (ThumbprintString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ThumbprintString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ThumbprintString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VirtualIP), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    virtualIP: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VirtualIP))
                {
                    builder.Append("    virtualIP: ");
                    if (VirtualIP.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{VirtualIP}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{VirtualIP}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HostNameBindingData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameBindingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HostNameBindingData)} does not support writing '{options.Format}' format.");
            }
        }

        HostNameBindingData IPersistableModel<HostNameBindingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameBindingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostNameBindingData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HostNameBindingData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostNameBindingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
