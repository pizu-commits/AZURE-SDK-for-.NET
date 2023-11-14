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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class OpenIdConnectLogin : IUtf8JsonSerializable, IJsonModel<OpenIdConnectLogin>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenIdConnectLogin>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<OpenIdConnectLogin>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<OpenIdConnectLogin>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<OpenIdConnectLogin>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NameClaimType))
            {
                writer.WritePropertyName("nameClaimType"u8);
                writer.WriteStringValue(NameClaimType);
            }
            if (Optional.IsCollectionDefined(Scopes))
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStartArray();
                foreach (var item in Scopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        OpenIdConnectLogin IJsonModel<OpenIdConnectLogin>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OpenIdConnectLogin)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenIdConnectLogin(document.RootElement, options);
        }

        internal static OpenIdConnectLogin DeserializeOpenIdConnectLogin(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nameClaimType = default;
            Optional<IList<string>> scopes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameClaimType"u8))
                {
                    nameClaimType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scopes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    scopes = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OpenIdConnectLogin(nameClaimType.Value, Optional.ToList(scopes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OpenIdConnectLogin>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OpenIdConnectLogin)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OpenIdConnectLogin IPersistableModel<OpenIdConnectLogin>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OpenIdConnectLogin)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOpenIdConnectLogin(document.RootElement, options);
        }

        string IPersistableModel<OpenIdConnectLogin>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
