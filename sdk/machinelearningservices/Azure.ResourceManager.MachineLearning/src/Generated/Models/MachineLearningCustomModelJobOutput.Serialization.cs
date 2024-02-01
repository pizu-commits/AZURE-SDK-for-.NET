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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningCustomModelJobOutput : IUtf8JsonSerializable, IJsonModel<MachineLearningCustomModelJobOutput>, IPersistableModel<MachineLearningCustomModelJobOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningCustomModelJobOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningCustomModelJobOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningCustomModelJobOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningCustomModelJobOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AssetName))
            {
                if (AssetName != null)
                {
                    writer.WritePropertyName("assetName"u8);
                    writer.WriteStringValue(AssetName);
                }
                else
                {
                    writer.WriteNull("assetName");
                }
            }
            if (Optional.IsDefined(AssetVersion))
            {
                if (AssetVersion != null)
                {
                    writer.WritePropertyName("assetVersion"u8);
                    writer.WriteStringValue(AssetVersion);
                }
                else
                {
                    writer.WriteNull("assetVersion");
                }
            }
            if (Optional.IsDefined(AutoDeleteSetting))
            {
                if (AutoDeleteSetting != null)
                {
                    writer.WritePropertyName("autoDeleteSetting"u8);
                    writer.WriteObjectValue(AutoDeleteSetting);
                }
                else
                {
                    writer.WriteNull("autoDeleteSetting");
                }
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("uri"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("uri");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            writer.WritePropertyName("jobOutputType"u8);
            writer.WriteStringValue(JobOutputType.ToString());
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

        MachineLearningCustomModelJobOutput IJsonModel<MachineLearningCustomModelJobOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningCustomModelJobOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningCustomModelJobOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningCustomModelJobOutput(document.RootElement, options);
        }

        internal static MachineLearningCustomModelJobOutput DeserializeMachineLearningCustomModelJobOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> assetName = default;
            Optional<string> assetVersion = default;
            Optional<AutoDeleteSetting> autoDeleteSetting = default;
            Optional<MachineLearningOutputDeliveryMode> mode = default;
            Optional<Uri> uri = default;
            Optional<string> description = default;
            JobOutputType jobOutputType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assetName = null;
                        continue;
                    }
                    assetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assetVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assetVersion = null;
                        continue;
                    }
                    assetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoDeleteSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        autoDeleteSetting = null;
                        continue;
                    }
                    autoDeleteSetting = AutoDeleteSetting.DeserializeAutoDeleteSetting(property.Value);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new MachineLearningOutputDeliveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobOutputType"u8))
                {
                    jobOutputType = new JobOutputType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningCustomModelJobOutput(description.Value, jobOutputType, serializedAdditionalRawData, assetName.Value, assetVersion.Value, autoDeleteSetting.Value, Optional.ToNullable(mode), uri.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(AssetName))
            {
                builder.Append("  assetName:");
                builder.AppendLine($" '{AssetName}'");
            }

            if (Optional.IsDefined(AssetVersion))
            {
                builder.Append("  assetVersion:");
                builder.AppendLine($" '{AssetVersion}'");
            }

            if (Optional.IsDefined(AutoDeleteSetting))
            {
                builder.Append("  autoDeleteSetting:");
                AppendChildObject(builder, AutoDeleteSetting, options, 2);
            }

            if (Optional.IsDefined(Mode))
            {
                builder.Append("  mode:");
                builder.AppendLine($" '{Mode.ToString()}'");
            }

            if (Optional.IsDefined(Uri))
            {
                builder.Append("  uri:");
                builder.AppendLine($" '{Uri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("  description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(JobOutputType))
            {
                builder.Append("  jobOutputType:");
                builder.AppendLine($" '{JobOutputType.ToString()}'");
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

        BinaryData IPersistableModel<MachineLearningCustomModelJobOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningCustomModelJobOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningCustomModelJobOutput)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningCustomModelJobOutput IPersistableModel<MachineLearningCustomModelJobOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningCustomModelJobOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningCustomModelJobOutput(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MachineLearningCustomModelJobOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningCustomModelJobOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
