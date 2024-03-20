// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PipelineExternalComputeScaleProperties : IUtf8JsonSerializable, IJsonModel<PipelineExternalComputeScaleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PipelineExternalComputeScaleProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PipelineExternalComputeScaleProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineExternalComputeScaleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineExternalComputeScaleProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TimeToLive))
            {
                writer.WritePropertyName("timeToLive"u8);
                writer.WriteNumberValue(TimeToLive.Value);
            }
            if (Optional.IsDefined(NumberOfPipelineNodes))
            {
                writer.WritePropertyName("numberOfPipelineNodes"u8);
                writer.WriteNumberValue(NumberOfPipelineNodes.Value);
            }
            if (Optional.IsDefined(NumberOfExternalNodes))
            {
                writer.WritePropertyName("numberOfExternalNodes"u8);
                writer.WriteNumberValue(NumberOfExternalNodes.Value);
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

        PipelineExternalComputeScaleProperties IJsonModel<PipelineExternalComputeScaleProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineExternalComputeScaleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineExternalComputeScaleProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineExternalComputeScaleProperties(document.RootElement, options);
        }

        internal static PipelineExternalComputeScaleProperties DeserializePipelineExternalComputeScaleProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? timeToLive = default;
            int? numberOfPipelineNodes = default;
            int? numberOfExternalNodes = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeToLive = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numberOfPipelineNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfPipelineNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numberOfExternalNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfExternalNodes = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PipelineExternalComputeScaleProperties(timeToLive, numberOfPipelineNodes, numberOfExternalNodes, additionalProperties);
        }

        BinaryData IPersistableModel<PipelineExternalComputeScaleProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineExternalComputeScaleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PipelineExternalComputeScaleProperties)} does not support '{options.Format}' format.");
            }
        }

        PipelineExternalComputeScaleProperties IPersistableModel<PipelineExternalComputeScaleProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineExternalComputeScaleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePipelineExternalComputeScaleProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PipelineExternalComputeScaleProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PipelineExternalComputeScaleProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
