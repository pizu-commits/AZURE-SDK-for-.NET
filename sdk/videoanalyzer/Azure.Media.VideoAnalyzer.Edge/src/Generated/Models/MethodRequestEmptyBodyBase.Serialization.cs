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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class MethodRequestEmptyBodyBase : IUtf8JsonSerializable, IJsonModel<MethodRequestEmptyBodyBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MethodRequestEmptyBodyBase>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MethodRequestEmptyBodyBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MethodRequestEmptyBodyBase>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MethodRequestEmptyBodyBase>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (options.Format == "J")
            {
                writer.WritePropertyName("methodName"u8);
                writer.WriteStringValue(MethodName);
            }
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
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

        MethodRequestEmptyBodyBase IJsonModel<MethodRequestEmptyBodyBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MethodRequestEmptyBodyBase)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMethodRequestEmptyBodyBase(document.RootElement, options);
        }

        internal static MethodRequestEmptyBodyBase DeserializeMethodRequestEmptyBodyBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("methodName", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "livePipelineActivate": return LivePipelineActivateRequest.DeserializeLivePipelineActivateRequest(element);
                    case "livePipelineDeactivate": return LivePipelineDeactivateRequest.DeserializeLivePipelineDeactivateRequest(element);
                    case "livePipelineDelete": return LivePipelineDeleteRequest.DeserializeLivePipelineDeleteRequest(element);
                    case "livePipelineGet": return LivePipelineGetRequest.DeserializeLivePipelineGetRequest(element);
                    case "pipelineTopologyDelete": return PipelineTopologyDeleteRequest.DeserializePipelineTopologyDeleteRequest(element);
                    case "pipelineTopologyGet": return PipelineTopologyGetRequest.DeserializePipelineTopologyGetRequest(element);
                    case "remoteDeviceAdapterDelete": return RemoteDeviceAdapterDeleteRequest.DeserializeRemoteDeviceAdapterDeleteRequest(element);
                    case "remoteDeviceAdapterGet": return RemoteDeviceAdapterGetRequest.DeserializeRemoteDeviceAdapterGetRequest(element);
                }
            }
            string name = default;
            string methodName = "MethodRequestEmptyBodyBase";
            Optional<string> apiVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("methodName"u8))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MethodRequestEmptyBodyBase(methodName, apiVersion.Value, serializedAdditionalRawData, name);
        }

        BinaryData IPersistableModel<MethodRequestEmptyBodyBase>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MethodRequestEmptyBodyBase)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MethodRequestEmptyBodyBase IPersistableModel<MethodRequestEmptyBodyBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MethodRequestEmptyBodyBase)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMethodRequestEmptyBodyBase(document.RootElement, options);
        }

        string IPersistableModel<MethodRequestEmptyBodyBase>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
