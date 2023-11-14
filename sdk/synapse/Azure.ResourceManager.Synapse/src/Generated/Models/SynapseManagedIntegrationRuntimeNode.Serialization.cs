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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseManagedIntegrationRuntimeNode : IUtf8JsonSerializable, IJsonModel<SynapseManagedIntegrationRuntimeNode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseManagedIntegrationRuntimeNode>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SynapseManagedIntegrationRuntimeNode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SynapseManagedIntegrationRuntimeNode>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SynapseManagedIntegrationRuntimeNode>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NodeId))
                {
                    writer.WritePropertyName("nodeId"u8);
                    writer.WriteStringValue(NodeId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToString());
                }
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        SynapseManagedIntegrationRuntimeNode IJsonModel<SynapseManagedIntegrationRuntimeNode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeNode)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseManagedIntegrationRuntimeNode(document.RootElement, options);
        }

        internal static SynapseManagedIntegrationRuntimeNode DeserializeSynapseManagedIntegrationRuntimeNode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nodeId = default;
            Optional<SynapseManagedIntegrationRuntimeNodeStatus> status = default;
            Optional<IReadOnlyList<SynapseManagedIntegrationRuntimeError>> errors = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeId"u8))
                {
                    nodeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SynapseManagedIntegrationRuntimeNodeStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseManagedIntegrationRuntimeError> array = new List<SynapseManagedIntegrationRuntimeError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseManagedIntegrationRuntimeError.DeserializeSynapseManagedIntegrationRuntimeError(item));
                    }
                    errors = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseManagedIntegrationRuntimeNode(nodeId.Value, Optional.ToNullable(status), Optional.ToList(errors), additionalProperties);
        }

        BinaryData IPersistableModel<SynapseManagedIntegrationRuntimeNode>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeNode)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SynapseManagedIntegrationRuntimeNode IPersistableModel<SynapseManagedIntegrationRuntimeNode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeNode)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSynapseManagedIntegrationRuntimeNode(document.RootElement, options);
        }

        string IPersistableModel<SynapseManagedIntegrationRuntimeNode>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
