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
    public partial class AccessKeyAuthTypeWorkspaceConnectionProperties : IUtf8JsonSerializable, IJsonModel<AccessKeyAuthTypeWorkspaceConnectionProperties>, IPersistableModel<AccessKeyAuthTypeWorkspaceConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AccessKeyAuthTypeWorkspaceConnectionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AccessKeyAuthTypeWorkspaceConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessKeyAuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessKeyAuthTypeWorkspaceConnectionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(ExpiryOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpiryOn.Value, "O");
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
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

        AccessKeyAuthTypeWorkspaceConnectionProperties IJsonModel<AccessKeyAuthTypeWorkspaceConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessKeyAuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessKeyAuthTypeWorkspaceConnectionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessKeyAuthTypeWorkspaceConnectionProperties(document.RootElement, options);
        }

        internal static AccessKeyAuthTypeWorkspaceConnectionProperties DeserializeAccessKeyAuthTypeWorkspaceConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WorkspaceConnectionAccessKey> credentials = default;
            MachineLearningConnectionAuthType authType = default;
            Optional<MachineLearningConnectionCategory> category = default;
            Optional<DateTimeOffset> expiryTime = default;
            Optional<BinaryData> metadata = default;
            Optional<string> target = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = WorkspaceConnectionAccessKey.DeserializeWorkspaceConnectionAccessKey(property.Value);
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = new MachineLearningConnectionAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new MachineLearningConnectionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AccessKeyAuthTypeWorkspaceConnectionProperties(authType, Optional.ToNullable(category), Optional.ToNullable(expiryTime), metadata.Value, target.Value, serializedAdditionalRawData, credentials.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Credentials))
            {
                builder.Append("  credentials:");
                AppendChildObject(builder, Credentials, options, 2);
            }

            if (Optional.IsDefined(AuthType))
            {
                builder.Append("  authType:");
                builder.AppendLine($" '{AuthType.ToString()}'");
            }

            if (Optional.IsDefined(Category))
            {
                builder.Append("  category:");
                builder.AppendLine($" '{Category.ToString()}'");
            }

            if (Optional.IsDefined(ExpiryOn))
            {
                builder.Append("  expiryTime:");
                builder.AppendLine($" '{ExpiryOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(Metadata))
            {
                builder.Append("  metadata:");
                builder.AppendLine($" '{Metadata.ToString()}'");
            }

            if (Optional.IsDefined(Target))
            {
                builder.Append("  target:");
                builder.AppendLine($" '{Target}'");
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

        BinaryData IPersistableModel<AccessKeyAuthTypeWorkspaceConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessKeyAuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AccessKeyAuthTypeWorkspaceConnectionProperties)} does not support '{options.Format}' format.");
            }
        }

        AccessKeyAuthTypeWorkspaceConnectionProperties IPersistableModel<AccessKeyAuthTypeWorkspaceConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessKeyAuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAccessKeyAuthTypeWorkspaceConnectionProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AccessKeyAuthTypeWorkspaceConnectionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AccessKeyAuthTypeWorkspaceConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
