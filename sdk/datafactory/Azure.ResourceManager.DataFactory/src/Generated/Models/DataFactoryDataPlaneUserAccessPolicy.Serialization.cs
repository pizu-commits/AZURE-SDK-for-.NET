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
    public partial class DataFactoryDataPlaneUserAccessPolicy : IUtf8JsonSerializable, IJsonModel<DataFactoryDataPlaneUserAccessPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryDataPlaneUserAccessPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataFactoryDataPlaneUserAccessPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataPlaneUserAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataPlaneUserAccessPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Permissions))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStringValue(Permissions);
            }
            if (Optional.IsDefined(AccessResourcePath))
            {
                writer.WritePropertyName("accessResourcePath"u8);
                writer.WriteStringValue(AccessResourcePath);
            }
            if (Optional.IsDefined(ProfileName))
            {
                writer.WritePropertyName("profileName"u8);
                writer.WriteStringValue(ProfileName);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expireTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        DataFactoryDataPlaneUserAccessPolicy IJsonModel<DataFactoryDataPlaneUserAccessPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataPlaneUserAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataPlaneUserAccessPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryDataPlaneUserAccessPolicy(document.RootElement, options);
        }

        internal static DataFactoryDataPlaneUserAccessPolicy DeserializeDataFactoryDataPlaneUserAccessPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string permissions = default;
            string accessResourcePath = default;
            string profileName = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? expireTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("permissions"u8))
                {
                    permissions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessResourcePath"u8))
                {
                    accessResourcePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("profileName"u8))
                {
                    profileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expireTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expireTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataFactoryDataPlaneUserAccessPolicy(
                permissions,
                accessResourcePath,
                profileName,
                startTime,
                expireTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFactoryDataPlaneUserAccessPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataPlaneUserAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataPlaneUserAccessPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        DataFactoryDataPlaneUserAccessPolicy IPersistableModel<DataFactoryDataPlaneUserAccessPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataPlaneUserAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryDataPlaneUserAccessPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataPlaneUserAccessPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryDataPlaneUserAccessPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
