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
    public partial class MachineLearningServicePrincipalDatastoreCredentials : IUtf8JsonSerializable, IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>, IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorityUri))
            {
                if (AuthorityUri != null)
                {
                    writer.WritePropertyName("authorityUrl"u8);
                    writer.WriteStringValue(AuthorityUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("authorityUrl");
                }
            }
            writer.WritePropertyName("clientId"u8);
            writer.WriteStringValue(ClientId);
            if (Optional.IsDefined(ResourceUri))
            {
                if (ResourceUri != null)
                {
                    writer.WritePropertyName("resourceUrl"u8);
                    writer.WriteStringValue(ResourceUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("resourceUrl");
                }
            }
            writer.WritePropertyName("secrets"u8);
            writer.WriteObjectValue(Secrets);
            writer.WritePropertyName("tenantId"u8);
            writer.WriteStringValue(TenantId);
            writer.WritePropertyName("credentialsType"u8);
            writer.WriteStringValue(CredentialsType.ToString());
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

        MachineLearningServicePrincipalDatastoreCredentials IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServicePrincipalDatastoreCredentials(document.RootElement, options);
        }

        internal static MachineLearningServicePrincipalDatastoreCredentials DeserializeMachineLearningServicePrincipalDatastoreCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> authorityUrl = default;
            Guid clientId = default;
            Optional<Uri> resourceUrl = default;
            MachineLearningServicePrincipalDatastoreSecrets secrets = default;
            Guid tenantId = default;
            CredentialsType credentialsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorityUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authorityUrl = null;
                        continue;
                    }
                    authorityUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceUrl = null;
                        continue;
                    }
                    resourceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    secrets = MachineLearningServicePrincipalDatastoreSecrets.DeserializeMachineLearningServicePrincipalDatastoreSecrets(property.Value);
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("credentialsType"u8))
                {
                    credentialsType = new CredentialsType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningServicePrincipalDatastoreCredentials(credentialsType, serializedAdditionalRawData, authorityUrl.Value, clientId, resourceUrl.Value, secrets, tenantId);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(AuthorityUri))
            {
                builder.Append("  authorityUrl:");
                builder.AppendLine($" '{AuthorityUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(ClientId))
            {
                builder.Append("  clientId:");
                builder.AppendLine($" '{ClientId.ToString()}'");
            }

            if (Optional.IsDefined(ResourceUri))
            {
                builder.Append("  resourceUrl:");
                builder.AppendLine($" '{ResourceUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(Secrets))
            {
                builder.Append("  secrets:");
                AppendChildObject(builder, Secrets, options, 2);
            }

            if (Optional.IsDefined(TenantId))
            {
                builder.Append("  tenantId:");
                builder.AppendLine($" '{TenantId.ToString()}'");
            }

            if (Optional.IsDefined(CredentialsType))
            {
                builder.Append("  credentialsType:");
                builder.AppendLine($" '{CredentialsType.ToString()}'");
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

        BinaryData IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningServicePrincipalDatastoreCredentials IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningServicePrincipalDatastoreCredentials(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
