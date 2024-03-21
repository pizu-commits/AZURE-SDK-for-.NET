// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SqlAlwaysEncryptedProperties : IUtf8JsonSerializable, IJsonModel<SqlAlwaysEncryptedProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlAlwaysEncryptedProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlAlwaysEncryptedProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAlwaysEncryptedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAlwaysEncryptedProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("alwaysEncryptedAkvAuthType"u8);
            writer.WriteStringValue(AlwaysEncryptedAkvAuthType.ToString());
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalKey);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
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

        SqlAlwaysEncryptedProperties IJsonModel<SqlAlwaysEncryptedProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAlwaysEncryptedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAlwaysEncryptedProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlAlwaysEncryptedProperties(document.RootElement, options);
        }

        internal static SqlAlwaysEncryptedProperties DeserializeSqlAlwaysEncryptedProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlAlwaysEncryptedAkvAuthType alwaysEncryptedAkvAuthType = default;
            DataFactoryElement<string> servicePrincipalId = default;
            DataFactorySecret servicePrincipalKey = default;
            DataFactoryCredentialReference credential = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alwaysEncryptedAkvAuthType"u8))
                {
                    alwaysEncryptedAkvAuthType = new SqlAlwaysEncryptedAkvAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("servicePrincipalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("servicePrincipalKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalKey = JsonSerializer.Deserialize<DataFactorySecret>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlAlwaysEncryptedProperties(alwaysEncryptedAkvAuthType, servicePrincipalId, servicePrincipalKey, credential, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlAlwaysEncryptedProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAlwaysEncryptedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlAlwaysEncryptedProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SqlAlwaysEncryptedProperties IPersistableModel<SqlAlwaysEncryptedProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAlwaysEncryptedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlAlwaysEncryptedProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlAlwaysEncryptedProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlAlwaysEncryptedProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
