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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiDeploymentParameterMetadataSet : IUtf8JsonSerializable, IJsonModel<LogicApiDeploymentParameterMetadataSet>, IPersistableModel<LogicApiDeploymentParameterMetadataSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicApiDeploymentParameterMetadataSet>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicApiDeploymentParameterMetadataSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiDeploymentParameterMetadataSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiDeploymentParameterMetadataSet)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PackageContentLink))
            {
                writer.WritePropertyName("packageContentLink"u8);
                writer.WriteObjectValue(PackageContentLink);
            }
            if (Optional.IsDefined(RedisCacheConnectionString))
            {
                writer.WritePropertyName("redisCacheConnectionString"u8);
                writer.WriteObjectValue(RedisCacheConnectionString);
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

        LogicApiDeploymentParameterMetadataSet IJsonModel<LogicApiDeploymentParameterMetadataSet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiDeploymentParameterMetadataSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiDeploymentParameterMetadataSet)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiDeploymentParameterMetadataSet(document.RootElement, options);
        }

        internal static LogicApiDeploymentParameterMetadataSet DeserializeLogicApiDeploymentParameterMetadataSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LogicApiDeploymentParameterMetadata> packageContentLink = default;
            Optional<LogicApiDeploymentParameterMetadata> redisCacheConnectionString = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packageContentLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    packageContentLink = LogicApiDeploymentParameterMetadata.DeserializeLogicApiDeploymentParameterMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("redisCacheConnectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redisCacheConnectionString = LogicApiDeploymentParameterMetadata.DeserializeLogicApiDeploymentParameterMetadata(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicApiDeploymentParameterMetadataSet(packageContentLink.Value, redisCacheConnectionString.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(PackageContentLink))
            {
                builder.Append("  packageContentLink:");
                AppendChildObject(builder, PackageContentLink, options, 2);
            }

            if (Optional.IsDefined(RedisCacheConnectionString))
            {
                builder.Append("  redisCacheConnectionString:");
                AppendChildObject(builder, RedisCacheConnectionString, options, 2);
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

        BinaryData IPersistableModel<LogicApiDeploymentParameterMetadataSet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiDeploymentParameterMetadataSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LogicApiDeploymentParameterMetadataSet)} does not support '{options.Format}' format.");
            }
        }

        LogicApiDeploymentParameterMetadataSet IPersistableModel<LogicApiDeploymentParameterMetadataSet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiDeploymentParameterMetadataSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicApiDeploymentParameterMetadataSet(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(LogicApiDeploymentParameterMetadataSet)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicApiDeploymentParameterMetadataSet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
