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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountPoolStartTask : IUtf8JsonSerializable, IJsonModel<BatchAccountPoolStartTask>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountPoolStartTask>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<BatchAccountPoolStartTask>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CommandLine))
            {
                writer.WritePropertyName("commandLine"u8);
                writer.WriteStringValue(CommandLine);
            }
            if (Optional.IsCollectionDefined(ResourceFiles))
            {
                writer.WritePropertyName("resourceFiles"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceFiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EnvironmentSettings))
            {
                writer.WritePropertyName("environmentSettings"u8);
                writer.WriteStartArray();
                foreach (var item in EnvironmentSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UserIdentity))
            {
                writer.WritePropertyName("userIdentity"u8);
                writer.WriteObjectValue(UserIdentity);
            }
            if (Optional.IsDefined(MaxTaskRetryCount))
            {
                writer.WritePropertyName("maxTaskRetryCount"u8);
                writer.WriteNumberValue(MaxTaskRetryCount.Value);
            }
            if (Optional.IsDefined(WaitForSuccess))
            {
                writer.WritePropertyName("waitForSuccess"u8);
                writer.WriteBooleanValue(WaitForSuccess.Value);
            }
            if (Optional.IsDefined(ContainerSettings))
            {
                writer.WritePropertyName("containerSettings"u8);
                writer.WriteObjectValue(ContainerSettings);
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

        BatchAccountPoolStartTask IJsonModel<BatchAccountPoolStartTask>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolStartTask)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountPoolStartTask(document.RootElement, options);
        }

        internal static BatchAccountPoolStartTask DeserializeBatchAccountPoolStartTask(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> commandLine = default;
            Optional<IList<BatchResourceFile>> resourceFiles = default;
            Optional<IList<BatchEnvironmentSetting>> environmentSettings = default;
            Optional<BatchUserIdentity> userIdentity = default;
            Optional<int> maxTaskRetryCount = default;
            Optional<bool> waitForSuccess = default;
            Optional<BatchTaskContainerSettings> containerSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commandLine"u8))
                {
                    commandLine = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchResourceFile> array = new List<BatchResourceFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchResourceFile.DeserializeBatchResourceFile(item));
                    }
                    resourceFiles = array;
                    continue;
                }
                if (property.NameEquals("environmentSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchEnvironmentSetting> array = new List<BatchEnvironmentSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchEnvironmentSetting.DeserializeBatchEnvironmentSetting(item));
                    }
                    environmentSettings = array;
                    continue;
                }
                if (property.NameEquals("userIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userIdentity = BatchUserIdentity.DeserializeBatchUserIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("maxTaskRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTaskRetryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("waitForSuccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    waitForSuccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containerSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerSettings = BatchTaskContainerSettings.DeserializeBatchTaskContainerSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountPoolStartTask(commandLine.Value, Optional.ToList(resourceFiles), Optional.ToList(environmentSettings), userIdentity.Value, Optional.ToNullable(maxTaskRetryCount), Optional.ToNullable(waitForSuccess), containerSettings.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<BatchAccountPoolStartTask>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolStartTask)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BatchAccountPoolStartTask IModel<BatchAccountPoolStartTask>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolStartTask)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBatchAccountPoolStartTask(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<BatchAccountPoolStartTask>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
