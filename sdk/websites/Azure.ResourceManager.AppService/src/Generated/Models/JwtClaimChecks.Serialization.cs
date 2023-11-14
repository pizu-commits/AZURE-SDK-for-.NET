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
    public partial class JwtClaimChecks : IUtf8JsonSerializable, IJsonModel<JwtClaimChecks>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JwtClaimChecks>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<JwtClaimChecks>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<JwtClaimChecks>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<JwtClaimChecks>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedGroups))
            {
                writer.WritePropertyName("allowedGroups"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowedClientApplications))
            {
                writer.WritePropertyName("allowedClientApplications"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedClientApplications)
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

        JwtClaimChecks IJsonModel<JwtClaimChecks>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(JwtClaimChecks)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJwtClaimChecks(document.RootElement, options);
        }

        internal static JwtClaimChecks DeserializeJwtClaimChecks(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> allowedGroups = default;
            Optional<IList<string>> allowedClientApplications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedGroups"u8))
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
                    allowedGroups = array;
                    continue;
                }
                if (property.NameEquals("allowedClientApplications"u8))
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
                    allowedClientApplications = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JwtClaimChecks(Optional.ToList(allowedGroups), Optional.ToList(allowedClientApplications), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JwtClaimChecks>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(JwtClaimChecks)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        JwtClaimChecks IPersistableModel<JwtClaimChecks>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(JwtClaimChecks)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeJwtClaimChecks(document.RootElement, options);
        }

        string IPersistableModel<JwtClaimChecks>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
