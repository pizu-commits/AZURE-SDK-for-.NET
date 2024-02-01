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
    public partial class MachineLearningUserAccountCredentials : IUtf8JsonSerializable, IJsonModel<MachineLearningUserAccountCredentials>, IPersistableModel<MachineLearningUserAccountCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningUserAccountCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningUserAccountCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUserAccountCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningUserAccountCredentials)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("adminUserName"u8);
            writer.WriteStringValue(AdminUserName);
            if (Optional.IsDefined(AdminUserSshPublicKey))
            {
                writer.WritePropertyName("adminUserSshPublicKey"u8);
                writer.WriteStringValue(AdminUserSshPublicKey);
            }
            if (Optional.IsDefined(AdminUserPassword))
            {
                writer.WritePropertyName("adminUserPassword"u8);
                writer.WriteStringValue(AdminUserPassword);
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

        MachineLearningUserAccountCredentials IJsonModel<MachineLearningUserAccountCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUserAccountCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningUserAccountCredentials)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningUserAccountCredentials(document.RootElement, options);
        }

        internal static MachineLearningUserAccountCredentials DeserializeMachineLearningUserAccountCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string adminUserName = default;
            Optional<string> adminUserSshPublicKey = default;
            Optional<string> adminUserPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUserName"u8))
                {
                    adminUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminUserSshPublicKey"u8))
                {
                    adminUserSshPublicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminUserPassword"u8))
                {
                    adminUserPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningUserAccountCredentials(adminUserName, adminUserSshPublicKey.Value, adminUserPassword.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(AdminUserName))
            {
                builder.Append("  adminUserName:");
                builder.AppendLine($" '{AdminUserName}'");
            }

            if (Optional.IsDefined(AdminUserSshPublicKey))
            {
                builder.Append("  adminUserSshPublicKey:");
                builder.AppendLine($" '{AdminUserSshPublicKey}'");
            }

            if (Optional.IsDefined(AdminUserPassword))
            {
                builder.Append("  adminUserPassword:");
                builder.AppendLine($" '{AdminUserPassword}'");
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

        BinaryData IPersistableModel<MachineLearningUserAccountCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUserAccountCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningUserAccountCredentials)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningUserAccountCredentials IPersistableModel<MachineLearningUserAccountCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUserAccountCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningUserAccountCredentials(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MachineLearningUserAccountCredentials)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningUserAccountCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
