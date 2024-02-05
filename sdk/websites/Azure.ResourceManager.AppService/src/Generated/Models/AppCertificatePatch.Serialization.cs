// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppCertificatePatch : IUtf8JsonSerializable, IJsonModel<AppCertificatePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppCertificatePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppCertificatePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificatePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppCertificatePatch)} does not support '{format}' format.");
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
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(SubjectName))
            {
                writer.WritePropertyName("subjectName"u8);
                writer.WriteStringValue(SubjectName);
            }
            if (Optional.IsCollectionDefined(HostNames))
            {
                writer.WritePropertyName("hostNames"u8);
                writer.WriteStartArray();
                foreach (var item in HostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PfxBlob))
            {
                writer.WritePropertyName("pfxBlob"u8);
                writer.WriteBase64StringValue(PfxBlob, "D");
            }
            if (options.Format != "W" && Optional.IsDefined(SiteName))
            {
                writer.WritePropertyName("siteName"u8);
                writer.WriteStringValue(SiteName);
            }
            if (options.Format != "W" && Optional.IsDefined(SelfLink))
            {
                writer.WritePropertyName("selfLink"u8);
                writer.WriteStringValue(SelfLink);
            }
            if (options.Format != "W" && Optional.IsDefined(Issuer))
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (options.Format != "W" && Optional.IsDefined(IssueOn))
            {
                writer.WritePropertyName("issueDate"u8);
                writer.WriteStringValue(IssueOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ThumbprintString))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            if (options.Format != "W" && Optional.IsDefined(IsValid))
            {
                writer.WritePropertyName("valid"u8);
                writer.WriteBooleanValue(IsValid.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CerBlob))
            {
                writer.WritePropertyName("cerBlob"u8);
                writer.WriteBase64StringValue(CerBlob, "D");
            }
            if (options.Format != "W" && Optional.IsDefined(PublicKeyHash))
            {
                writer.WritePropertyName("publicKeyHash"u8);
                writer.WriteStringValue(PublicKeyHash);
            }
            if (options.Format != "W" && Optional.IsDefined(HostingEnvironmentProfile))
            {
                writer.WritePropertyName("hostingEnvironmentProfile"u8);
                writer.WriteObjectValue(HostingEnvironmentProfile);
            }
            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            if (Optional.IsDefined(KeyVaultSecretName))
            {
                writer.WritePropertyName("keyVaultSecretName"u8);
                writer.WriteStringValue(KeyVaultSecretName);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyVaultSecretStatus))
            {
                writer.WritePropertyName("keyVaultSecretStatus"u8);
                writer.WriteStringValue(KeyVaultSecretStatus.Value.ToSerialString());
            }
            if (Optional.IsDefined(ServerFarmId))
            {
                writer.WritePropertyName("serverFarmId"u8);
                writer.WriteStringValue(ServerFarmId);
            }
            if (Optional.IsDefined(CanonicalName))
            {
                writer.WritePropertyName("canonicalName"u8);
                writer.WriteStringValue(CanonicalName);
            }
            if (Optional.IsDefined(DomainValidationMethod))
            {
                writer.WritePropertyName("domainValidationMethod"u8);
                writer.WriteStringValue(DomainValidationMethod);
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

        AppCertificatePatch IJsonModel<AppCertificatePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificatePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppCertificatePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppCertificatePatch(document.RootElement, options);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

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

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(Password))
            {
                builder.Append("    password:");
                builder.AppendLine($" '{Password}'");
            }

            if (Optional.IsDefined(FriendlyName))
            {
                builder.Append("    friendlyName:");
                builder.AppendLine($" '{FriendlyName}'");
            }

            if (Optional.IsDefined(SubjectName))
            {
                builder.Append("    subjectName:");
                builder.AppendLine($" '{SubjectName}'");
            }

            if (Optional.IsCollectionDefined(HostNames))
            {
                if (HostNames.Any())
                {
                    builder.Append("    hostNames:");
                    builder.AppendLine(" [");
                    foreach (var item in HostNames)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"      '{item}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(PfxBlob))
            {
                builder.Append("    pfxBlob:");
                builder.AppendLine($" '{PfxBlob.ToString()}'");
            }

            if (Optional.IsDefined(SiteName))
            {
                builder.Append("    siteName:");
                builder.AppendLine($" '{SiteName}'");
            }

            if (Optional.IsDefined(SelfLink))
            {
                builder.Append("    selfLink:");
                builder.AppendLine($" '{SelfLink}'");
            }

            if (Optional.IsDefined(Issuer))
            {
                builder.Append("    issuer:");
                builder.AppendLine($" '{Issuer}'");
            }

            if (Optional.IsDefined(IssueOn))
            {
                builder.Append("    issueDate:");
                var formattedDateTimeString = TypeFormatters.ToString(IssueOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(ExpireOn))
            {
                builder.Append("    expirationDate:");
                var formattedDateTimeString = TypeFormatters.ToString(ExpireOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(ThumbprintString))
            {
                builder.Append("    thumbprint:");
                builder.AppendLine($" '{ThumbprintString}'");
            }

            if (Optional.IsDefined(IsValid))
            {
                builder.Append("    valid:");
                var boolValue = IsValid.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(CerBlob))
            {
                builder.Append("    cerBlob:");
                builder.AppendLine($" '{CerBlob.ToString()}'");
            }

            if (Optional.IsDefined(PublicKeyHash))
            {
                builder.Append("    publicKeyHash:");
                builder.AppendLine($" '{PublicKeyHash}'");
            }

            if (Optional.IsDefined(HostingEnvironmentProfile))
            {
                builder.Append("    hostingEnvironmentProfile:");
                AppendChildObject(builder, HostingEnvironmentProfile, options, 4, false);
            }

            if (Optional.IsDefined(KeyVaultId))
            {
                builder.Append("    keyVaultId:");
                builder.AppendLine($" '{KeyVaultId.ToString()}'");
            }

            if (Optional.IsDefined(KeyVaultSecretName))
            {
                builder.Append("    keyVaultSecretName:");
                builder.AppendLine($" '{KeyVaultSecretName}'");
            }

            if (Optional.IsDefined(KeyVaultSecretStatus))
            {
                builder.Append("    keyVaultSecretStatus:");
                builder.AppendLine($" '{KeyVaultSecretStatus.ToString()}'");
            }

            if (Optional.IsDefined(ServerFarmId))
            {
                builder.Append("    serverFarmId:");
                builder.AppendLine($" '{ServerFarmId.ToString()}'");
            }

            if (Optional.IsDefined(CanonicalName))
            {
                builder.Append("    canonicalName:");
                builder.AppendLine($" '{CanonicalName}'");
            }

            if (Optional.IsDefined(DomainValidationMethod))
            {
                builder.Append("    domainValidationMethod:");
                builder.AppendLine($" '{DomainValidationMethod}'");
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

        BinaryData IPersistableModel<AppCertificatePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificatePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppCertificatePatch)} does not support '{options.Format}' format.");
            }
        }

        AppCertificatePatch IPersistableModel<AppCertificatePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificatePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppCertificatePatch(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AppCertificatePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppCertificatePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
