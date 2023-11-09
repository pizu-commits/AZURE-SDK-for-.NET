// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class SingleSignOnIdentitySource : IUtf8JsonSerializable, IJsonModel<SingleSignOnIdentitySource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SingleSignOnIdentitySource>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SingleSignOnIdentitySource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Alias))
            {
                writer.WritePropertyName("alias"u8);
                writer.WriteStringValue(Alias);
            }
            if (Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            if (Optional.IsDefined(BaseUserDN))
            {
                writer.WritePropertyName("baseUserDN"u8);
                writer.WriteStringValue(BaseUserDN);
            }
            if (Optional.IsDefined(BaseGroupDN))
            {
                writer.WritePropertyName("baseGroupDN"u8);
                writer.WriteStringValue(BaseGroupDN);
            }
            if (Optional.IsDefined(PrimaryServer))
            {
                writer.WritePropertyName("primaryServer"u8);
                writer.WriteStringValue(PrimaryServer.AbsoluteUri);
            }
            if (Optional.IsDefined(SecondaryServer))
            {
                writer.WritePropertyName("secondaryServer"u8);
                writer.WriteStringValue(SecondaryServer.AbsoluteUri);
            }
            if (Optional.IsDefined(Ssl))
            {
                writer.WritePropertyName("ssl"u8);
                writer.WriteStringValue(Ssl.Value.ToString());
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SingleSignOnIdentitySource IJsonModel<SingleSignOnIdentitySource>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SingleSignOnIdentitySource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSingleSignOnIdentitySource(document.RootElement, options);
        }

        internal static SingleSignOnIdentitySource DeserializeSingleSignOnIdentitySource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> @alias = default;
            Optional<string> domain = default;
            Optional<string> baseUserDN = default;
            Optional<string> baseGroupDN = default;
            Optional<Uri> primaryServer = default;
            Optional<Uri> secondaryServer = default;
            Optional<SslCertificateStatus> ssl = default;
            Optional<string> username = default;
            Optional<string> password = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alias"u8))
                {
                    @alias = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseUserDN"u8))
                {
                    baseUserDN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseGroupDN"u8))
                {
                    baseGroupDN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryServer = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secondaryServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryServer = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ssl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssl = new SslCertificateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SingleSignOnIdentitySource(name.Value, @alias.Value, domain.Value, baseUserDN.Value, baseGroupDN.Value, primaryServer.Value, secondaryServer.Value, Optional.ToNullable(ssl), username.Value, password.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<SingleSignOnIdentitySource>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SingleSignOnIdentitySource)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SingleSignOnIdentitySource IModel<SingleSignOnIdentitySource>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SingleSignOnIdentitySource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSingleSignOnIdentitySource(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SingleSignOnIdentitySource>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
