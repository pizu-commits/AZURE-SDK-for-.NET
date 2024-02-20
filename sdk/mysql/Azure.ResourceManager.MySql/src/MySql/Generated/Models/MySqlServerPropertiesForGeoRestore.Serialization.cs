// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlServerPropertiesForGeoRestore : IUtf8JsonSerializable, IJsonModel<MySqlServerPropertiesForGeoRestore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlServerPropertiesForGeoRestore>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlServerPropertiesForGeoRestore>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlServerPropertiesForGeoRestore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlServerPropertiesForGeoRestore)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourceServerId"u8);
            writer.WriteStringValue(SourceServerId);
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (Optional.IsDefined(SslEnforcement))
            {
                writer.WritePropertyName("sslEnforcement"u8);
                writer.WriteStringValue(SslEnforcement.Value.ToSerialString());
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinimalTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(InfrastructureEncryption))
            {
                writer.WritePropertyName("infrastructureEncryption"u8);
                writer.WriteStringValue(InfrastructureEncryption.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            writer.WritePropertyName("createMode"u8);
            writer.WriteStringValue(CreateMode.ToString());
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

        MySqlServerPropertiesForGeoRestore IJsonModel<MySqlServerPropertiesForGeoRestore>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlServerPropertiesForGeoRestore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlServerPropertiesForGeoRestore)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlServerPropertiesForGeoRestore(document.RootElement, options);
        }

        internal static MySqlServerPropertiesForGeoRestore DeserializeMySqlServerPropertiesForGeoRestore(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier sourceServerId = default;
            Optional<MySqlServerVersion> version = default;
            Optional<MySqlSslEnforcementEnum> sslEnforcement = default;
            Optional<MySqlMinimalTlsVersionEnum> minimalTlsVersion = default;
            Optional<MySqlInfrastructureEncryption> infrastructureEncryption = default;
            Optional<MySqlPublicNetworkAccessEnum> publicNetworkAccess = default;
            Optional<MySqlStorageProfile> storageProfile = default;
            MySqlCreateMode createMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceServerId"u8))
                {
                    sourceServerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = new MySqlServerVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslEnforcement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslEnforcement = property.Value.GetString().ToMySqlSslEnforcementEnum();
                    continue;
                }
                if (property.NameEquals("minimalTlsVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimalTlsVersion = new MySqlMinimalTlsVersionEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("infrastructureEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureEncryption = new MySqlInfrastructureEncryption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new MySqlPublicNetworkAccessEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = MySqlStorageProfile.DeserializeMySqlStorageProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    createMode = new MySqlCreateMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlServerPropertiesForGeoRestore(Optional.ToNullable(version), Optional.ToNullable(sslEnforcement), Optional.ToNullable(minimalTlsVersion), Optional.ToNullable(infrastructureEncryption), Optional.ToNullable(publicNetworkAccess), storageProfile.Value, createMode, serializedAdditionalRawData, sourceServerId);
        }

        BinaryData IPersistableModel<MySqlServerPropertiesForGeoRestore>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlServerPropertiesForGeoRestore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlServerPropertiesForGeoRestore)} does not support '{options.Format}' format.");
            }
        }

        MySqlServerPropertiesForGeoRestore IPersistableModel<MySqlServerPropertiesForGeoRestore>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlServerPropertiesForGeoRestore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlServerPropertiesForGeoRestore(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlServerPropertiesForGeoRestore)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlServerPropertiesForGeoRestore>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
