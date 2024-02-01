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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class OpenIdConnectClientCredential : IUtf8JsonSerializable, IJsonModel<OpenIdConnectClientCredential>, IPersistableModel<OpenIdConnectClientCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenIdConnectClientCredential>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OpenIdConnectClientCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdConnectClientCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenIdConnectClientCredential)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method.Value.ToString());
            }
            if (Optional.IsDefined(ClientSecretSettingName))
            {
                writer.WritePropertyName("clientSecretSettingName"u8);
                writer.WriteStringValue(ClientSecretSettingName);
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

        OpenIdConnectClientCredential IJsonModel<OpenIdConnectClientCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdConnectClientCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenIdConnectClientCredential)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenIdConnectClientCredential(document.RootElement, options);
        }

        internal static OpenIdConnectClientCredential DeserializeOpenIdConnectClientCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ClientCredentialMethod> method = default;
            Optional<string> clientSecretSettingName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("method"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    method = new ClientCredentialMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientSecretSettingName"u8))
                {
                    clientSecretSettingName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OpenIdConnectClientCredential(Optional.ToNullable(method), clientSecretSettingName.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Method))
            {
                builder.Append("  method:");
                builder.AppendLine($" '{Method.ToString()}'");
            }

            if (Optional.IsDefined(ClientSecretSettingName))
            {
                builder.Append("  clientSecretSettingName:");
                builder.AppendLine($" '{ClientSecretSettingName}'");
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

        BinaryData IPersistableModel<OpenIdConnectClientCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdConnectClientCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OpenIdConnectClientCredential)} does not support '{options.Format}' format.");
            }
        }

        OpenIdConnectClientCredential IPersistableModel<OpenIdConnectClientCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdConnectClientCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOpenIdConnectClientCredential(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(OpenIdConnectClientCredential)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenIdConnectClientCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
