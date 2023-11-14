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
    public partial class ContainerCpuUsage : IUtf8JsonSerializable, IJsonModel<ContainerCpuUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerCpuUsage>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ContainerCpuUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ContainerCpuUsage>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ContainerCpuUsage>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TotalUsage))
            {
                writer.WritePropertyName("totalUsage"u8);
                writer.WriteNumberValue(TotalUsage.Value);
            }
            if (Optional.IsCollectionDefined(PerCpuUsage))
            {
                writer.WritePropertyName("perCpuUsage"u8);
                writer.WriteStartArray();
                foreach (var item in PerCpuUsage)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(KernelModeUsage))
            {
                writer.WritePropertyName("kernelModeUsage"u8);
                writer.WriteNumberValue(KernelModeUsage.Value);
            }
            if (Optional.IsDefined(UserModeUsage))
            {
                writer.WritePropertyName("userModeUsage"u8);
                writer.WriteNumberValue(UserModeUsage.Value);
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

        ContainerCpuUsage IJsonModel<ContainerCpuUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerCpuUsage)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerCpuUsage(document.RootElement, options);
        }

        internal static ContainerCpuUsage DeserializeContainerCpuUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> totalUsage = default;
            Optional<IList<long>> perCpuUsage = default;
            Optional<long> kernelModeUsage = default;
            Optional<long> userModeUsage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalUsage = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("perCpuUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<long> array = new List<long>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt64());
                    }
                    perCpuUsage = array;
                    continue;
                }
                if (property.NameEquals("kernelModeUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kernelModeUsage = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("userModeUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userModeUsage = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerCpuUsage(Optional.ToNullable(totalUsage), Optional.ToList(perCpuUsage), Optional.ToNullable(kernelModeUsage), Optional.ToNullable(userModeUsage), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerCpuUsage>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerCpuUsage)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContainerCpuUsage IPersistableModel<ContainerCpuUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerCpuUsage)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContainerCpuUsage(document.RootElement, options);
        }

        string IPersistableModel<ContainerCpuUsage>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
