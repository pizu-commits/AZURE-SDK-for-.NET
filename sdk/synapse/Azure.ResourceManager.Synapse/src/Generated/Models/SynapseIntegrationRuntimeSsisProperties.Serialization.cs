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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeSsisProperties : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeSsisProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeSsisProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseIntegrationRuntimeSsisProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeSsisProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CatalogInfo))
            {
                writer.WritePropertyName("catalogInfo"u8);
                writer.WriteObjectValue(CatalogInfo);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(CustomSetupScriptProperties))
            {
                writer.WritePropertyName("customSetupScriptProperties"u8);
                writer.WriteObjectValue(CustomSetupScriptProperties);
            }
            if (Optional.IsDefined(DataProxyProperties))
            {
                writer.WritePropertyName("dataProxyProperties"u8);
                writer.WriteObjectValue(DataProxyProperties);
            }
            if (Optional.IsDefined(Edition))
            {
                writer.WritePropertyName("edition"u8);
                writer.WriteStringValue(Edition.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExpressCustomSetupProperties))
            {
                writer.WritePropertyName("expressCustomSetupProperties"u8);
                writer.WriteStartArray();
                foreach (var item in ExpressCustomSetupProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SynapseIntegrationRuntimeSsisProperties IJsonModel<SynapseIntegrationRuntimeSsisProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeSsisProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeSsisProperties(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeSsisProperties DeserializeSynapseIntegrationRuntimeSsisProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SynapseIntegrationRuntimeSsisCatalogInfo> catalogInfo = default;
            Optional<SynapseIntegrationRuntimeLicenseType> licenseType = default;
            Optional<SynapseIntegrationRuntimeCustomSetupScriptProperties> customSetupScriptProperties = default;
            Optional<SynapseIntegrationRuntimeDataProxyProperties> dataProxyProperties = default;
            Optional<SynapseIntegrationRuntimeEdition> edition = default;
            Optional<IList<SynapseCustomSetupBase>> expressCustomSetupProperties = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogInfo = SynapseIntegrationRuntimeSsisCatalogInfo.DeserializeSynapseIntegrationRuntimeSsisCatalogInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new SynapseIntegrationRuntimeLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customSetupScriptProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customSetupScriptProperties = SynapseIntegrationRuntimeCustomSetupScriptProperties.DeserializeSynapseIntegrationRuntimeCustomSetupScriptProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("dataProxyProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataProxyProperties = SynapseIntegrationRuntimeDataProxyProperties.DeserializeSynapseIntegrationRuntimeDataProxyProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("edition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    edition = new SynapseIntegrationRuntimeEdition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expressCustomSetupProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseCustomSetupBase> array = new List<SynapseCustomSetupBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseCustomSetupBase.DeserializeSynapseCustomSetupBase(item));
                    }
                    expressCustomSetupProperties = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeSsisProperties(catalogInfo.Value, Optional.ToNullable(licenseType), customSetupScriptProperties.Value, dataProxyProperties.Value, Optional.ToNullable(edition), Optional.ToList(expressCustomSetupProperties), additionalProperties);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(CatalogInfo))
            {
                builder.Append("  catalogInfo:");
                AppendChildObject(builder, CatalogInfo, options, 2, false);
            }

            if (Optional.IsDefined(LicenseType))
            {
                builder.Append("  licenseType:");
                builder.AppendLine($" '{LicenseType.ToString()}'");
            }

            if (Optional.IsDefined(CustomSetupScriptProperties))
            {
                builder.Append("  customSetupScriptProperties:");
                AppendChildObject(builder, CustomSetupScriptProperties, options, 2, false);
            }

            if (Optional.IsDefined(DataProxyProperties))
            {
                builder.Append("  dataProxyProperties:");
                AppendChildObject(builder, DataProxyProperties, options, 2, false);
            }

            if (Optional.IsDefined(Edition))
            {
                builder.Append("  edition:");
                builder.AppendLine($" '{Edition.ToString()}'");
            }

            if (Optional.IsCollectionDefined(ExpressCustomSetupProperties))
            {
                if (ExpressCustomSetupProperties.Any())
                {
                    builder.Append("  expressCustomSetupProperties:");
                    builder.AppendLine(" [");
                    foreach (var item in ExpressCustomSetupProperties)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

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

        BinaryData IPersistableModel<SynapseIntegrationRuntimeSsisProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeSsisProperties)} does not support '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeSsisProperties IPersistableModel<SynapseIntegrationRuntimeSsisProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseIntegrationRuntimeSsisProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeSsisProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeSsisProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
