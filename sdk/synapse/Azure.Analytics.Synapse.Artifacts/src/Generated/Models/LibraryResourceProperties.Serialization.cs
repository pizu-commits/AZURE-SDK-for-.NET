// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LibraryResourcePropertiesConverter))]
    public partial class LibraryResourceProperties : IUtf8JsonSerializable, IJsonModel<LibraryResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LibraryResourceProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<LibraryResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<LibraryResourceProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<LibraryResourceProperties>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Path))
                {
                    writer.WritePropertyName("path"u8);
                    writer.WriteStringValue(Path);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ContainerName))
                {
                    writer.WritePropertyName("containerName"u8);
                    writer.WriteStringValue(ContainerName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(UploadedTimestamp))
                {
                    writer.WritePropertyName("uploadedTimestamp"u8);
                    writer.WriteStringValue(UploadedTimestamp);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Type))
                {
                    writer.WritePropertyName("type"u8);
                    writer.WriteStringValue(Type);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningStatus))
                {
                    writer.WritePropertyName("provisioningStatus"u8);
                    writer.WriteStringValue(ProvisioningStatus);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CreatorId))
                {
                    writer.WritePropertyName("creatorId"u8);
                    writer.WriteStringValue(CreatorId);
                }
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

        LibraryResourceProperties IJsonModel<LibraryResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LibraryResourceProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLibraryResourceProperties(document.RootElement, options);
        }

        internal static LibraryResourceProperties DeserializeLibraryResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> path = default;
            Optional<string> containerName = default;
            Optional<string> uploadedTimestamp = default;
            Optional<string> type = default;
            Optional<string> provisioningStatus = default;
            Optional<string> creatorId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadedTimestamp"u8))
                {
                    uploadedTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    provisioningStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creatorId"u8))
                {
                    creatorId = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LibraryResourceProperties(name.Value, path.Value, containerName.Value, uploadedTimestamp.Value, type.Value, provisioningStatus.Value, creatorId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LibraryResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LibraryResourceProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LibraryResourceProperties IPersistableModel<LibraryResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LibraryResourceProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLibraryResourceProperties(document.RootElement, options);
        }

        string IPersistableModel<LibraryResourceProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class LibraryResourcePropertiesConverter : JsonConverter<LibraryResourceProperties>
        {
            public override void Write(Utf8JsonWriter writer, LibraryResourceProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LibraryResourceProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLibraryResourceProperties(document.RootElement);
            }
        }
    }
}
