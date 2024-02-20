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
    public partial class GoogleAdWordsLinkedService : IUtf8JsonSerializable, IJsonModel<GoogleAdWordsLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GoogleAdWordsLinkedService>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GoogleAdWordsLinkedService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleAdWordsLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GoogleAdWordsLinkedService)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionProperties))
            {
                writer.WritePropertyName("connectionProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ConnectionProperties);
#else
                using (JsonDocument document = JsonDocument.Parse(ConnectionProperties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ClientCustomerId))
            {
                writer.WritePropertyName("clientCustomerID"u8);
                JsonSerializer.Serialize(writer, ClientCustomerId);
            }
            if (Optional.IsDefined(DeveloperToken))
            {
                writer.WritePropertyName("developerToken"u8);
                JsonSerializer.Serialize(writer, DeveloperToken);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken"u8);
                JsonSerializer.Serialize(writer, RefreshToken);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                JsonSerializer.Serialize(writer, ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                JsonSerializer.Serialize(writer, ClientSecret);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                JsonSerializer.Serialize(writer, Email);
            }
            if (Optional.IsDefined(KeyFilePath))
            {
                writer.WritePropertyName("keyFilePath"u8);
                JsonSerializer.Serialize(writer, KeyFilePath);
            }
            if (Optional.IsDefined(TrustedCertPath))
            {
                writer.WritePropertyName("trustedCertPath"u8);
                JsonSerializer.Serialize(writer, TrustedCertPath);
            }
            if (Optional.IsDefined(UseSystemTrustStore))
            {
                writer.WritePropertyName("useSystemTrustStore"u8);
                JsonSerializer.Serialize(writer, UseSystemTrustStore);
            }
            if (Optional.IsDefined(PrivateKey))
            {
                writer.WritePropertyName("privateKey"u8);
                JsonSerializer.Serialize(writer, PrivateKey);
            }
            if (Optional.IsDefined(LoginCustomerId))
            {
                writer.WritePropertyName("loginCustomerID"u8);
                JsonSerializer.Serialize(writer, LoginCustomerId);
            }
            if (Optional.IsDefined(GoogleAdsApiVersion))
            {
                writer.WritePropertyName("googleAdsApiVersion"u8);
                JsonSerializer.Serialize(writer, GoogleAdsApiVersion);
            }
            if (Optional.IsDefined(SupportLegacyDataTypes))
            {
                writer.WritePropertyName("supportLegacyDataTypes"u8);
                JsonSerializer.Serialize(writer, SupportLegacyDataTypes);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            writer.WriteEndObject();
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

        GoogleAdWordsLinkedService IJsonModel<GoogleAdWordsLinkedService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleAdWordsLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GoogleAdWordsLinkedService)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGoogleAdWordsLinkedService(document.RootElement, options);
        }

        internal static GoogleAdWordsLinkedService DeserializeGoogleAdWordsLinkedService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<BinaryData> connectionProperties = default;
            Optional<DataFactoryElement<string>> clientCustomerId = default;
            Optional<DataFactorySecretBaseDefinition> developerToken = default;
            Optional<GoogleAdWordsAuthenticationType> authenticationType = default;
            Optional<DataFactorySecretBaseDefinition> refreshToken = default;
            Optional<DataFactoryElement<string>> clientId = default;
            Optional<DataFactorySecretBaseDefinition> clientSecret = default;
            Optional<DataFactoryElement<string>> email = default;
            Optional<DataFactoryElement<string>> keyFilePath = default;
            Optional<DataFactoryElement<string>> trustedCertPath = default;
            Optional<DataFactoryElement<bool>> useSystemTrustStore = default;
            Optional<DataFactorySecretBaseDefinition> privateKey = default;
            Optional<DataFactoryElement<string>> loginCustomerId = default;
            Optional<DataFactoryElement<string>> googleAdsApiVersion = default;
            Optional<DataFactoryElement<bool>> supportLegacyDataTypes = default;
            Optional<string> encryptedCredential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("connectionProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clientCustomerID"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientCustomerId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("developerToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            developerToken = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationType = new GoogleAdWordsAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("refreshToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            refreshToken = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientSecret = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("email"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            email = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("keyFilePath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyFilePath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("trustedCertPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustedCertPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("useSystemTrustStore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useSystemTrustStore = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("privateKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateKey = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("loginCustomerID"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loginCustomerId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("googleAdsApiVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            googleAdsApiVersion = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("supportLegacyDataTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportLegacyDataTypes = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new GoogleAdWordsLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, connectionProperties.Value, clientCustomerId.Value, developerToken, Optional.ToNullable(authenticationType), refreshToken, clientId.Value, clientSecret, email.Value, keyFilePath.Value, trustedCertPath.Value, useSystemTrustStore.Value, privateKey, loginCustomerId.Value, googleAdsApiVersion.Value, supportLegacyDataTypes.Value, encryptedCredential.Value);
        }

        BinaryData IPersistableModel<GoogleAdWordsLinkedService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleAdWordsLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GoogleAdWordsLinkedService)} does not support '{options.Format}' format.");
            }
        }

        GoogleAdWordsLinkedService IPersistableModel<GoogleAdWordsLinkedService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleAdWordsLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGoogleAdWordsLinkedService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GoogleAdWordsLinkedService)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GoogleAdWordsLinkedService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
