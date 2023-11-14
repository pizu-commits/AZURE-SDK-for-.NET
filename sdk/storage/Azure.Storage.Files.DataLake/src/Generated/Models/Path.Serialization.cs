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

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class Path : IUtf8JsonSerializable, IJsonModel<Path>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Path>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<Path>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<Path>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<Path>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(LastModified))
            {
                writer.WritePropertyName("lastModified"u8);
                writer.WriteStringValue(LastModified.Value, "R");
            }
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteStringValue(Owner);
            }
            if (Optional.IsDefined(Group))
            {
                writer.WritePropertyName("group"u8);
                writer.WriteStringValue(Group);
            }
            if (Optional.IsDefined(Permissions))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStringValue(Permissions);
            }
            if (Optional.IsDefined(EncryptionScope))
            {
                writer.WritePropertyName("EncryptionScope"u8);
                writer.WriteStringValue(EncryptionScope);
            }
            if (Optional.IsDefined(CreationTime))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreationTime);
            }
            if (Optional.IsDefined(ExpiryTime))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpiryTime);
            }
            if (Optional.IsDefined(EncryptionContext))
            {
                writer.WritePropertyName("EncryptionContext"u8);
                writer.WriteStringValue(EncryptionContext);
            }
            if (Optional.IsDefined(ContentLength))
            {
                writer.WritePropertyName("contentLength"u8);
                writer.WriteStringValue(ContentLength);
            }
            if (Optional.IsDefined(IsDirectory))
            {
                writer.WritePropertyName("isDirectory"u8);
                writer.WriteStringValue(IsDirectory);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(Etag);
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

        Path IJsonModel<Path>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(Path)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePath(document.RootElement, options);
        }

        internal static Path DeserializePath(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<string> owner = default;
            Optional<string> group = default;
            Optional<string> permissions = default;
            Optional<string> encryptionScope = default;
            Optional<string> creationTime = default;
            Optional<string> expiryTime = default;
            Optional<string> encryptionContext = default;
            Optional<string> contentLength = default;
            Optional<string> isDirectory = default;
            Optional<string> etag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("owner"u8))
                {
                    owner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("group"u8))
                {
                    group = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("permissions"u8))
                {
                    permissions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("EncryptionScope"u8))
                {
                    encryptionScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    creationTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    expiryTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("EncryptionContext"u8))
                {
                    encryptionContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentLength"u8))
                {
                    contentLength = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDirectory"u8))
                {
                    isDirectory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Path(name.Value, Optional.ToNullable(lastModified), owner.Value, group.Value, permissions.Value, encryptionScope.Value, creationTime.Value, expiryTime.Value, encryptionContext.Value, contentLength.Value, isDirectory.Value, etag.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Path>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(Path)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        Path IPersistableModel<Path>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(Path)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePath(document.RootElement, options);
        }

        string IPersistableModel<Path>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
