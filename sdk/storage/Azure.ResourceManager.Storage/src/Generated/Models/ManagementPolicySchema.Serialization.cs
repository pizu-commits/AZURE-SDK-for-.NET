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

namespace Azure.ResourceManager.Storage.Models
{
    internal partial class ManagementPolicySchema : IUtf8JsonSerializable, IJsonModel<ManagementPolicySchema>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementPolicySchema>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ManagementPolicySchema>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ManagementPolicySchema>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ManagementPolicySchema>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("rules"u8);
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        ManagementPolicySchema IJsonModel<ManagementPolicySchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagementPolicySchema)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementPolicySchema(document.RootElement, options);
        }

        internal static ManagementPolicySchema DeserializeManagementPolicySchema(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ManagementPolicyRule> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rules"u8))
                {
                    List<ManagementPolicyRule> array = new List<ManagementPolicyRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagementPolicyRule.DeserializeManagementPolicyRule(item));
                    }
                    rules = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementPolicySchema(rules, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagementPolicySchema>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagementPolicySchema)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ManagementPolicySchema IPersistableModel<ManagementPolicySchema>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagementPolicySchema)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeManagementPolicySchema(document.RootElement, options);
        }

        string IPersistableModel<ManagementPolicySchema>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
