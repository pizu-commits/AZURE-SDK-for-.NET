// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterUserRoleAssignments : IUtf8JsonSerializable, IJsonModel<DevCenterUserRoleAssignments>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevCenterUserRoleAssignments>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevCenterUserRoleAssignments>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterUserRoleAssignments>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterUserRoleAssignments)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Roles))
            {
                writer.WritePropertyName("roles"u8);
                writer.WriteStartObject();
                foreach (var item in Roles)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
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

        DevCenterUserRoleAssignments IJsonModel<DevCenterUserRoleAssignments>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterUserRoleAssignments>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterUserRoleAssignments)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterUserRoleAssignments(document.RootElement, options);
        }

        internal static DevCenterUserRoleAssignments DeserializeDevCenterUserRoleAssignments(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, DevCenterEnvironmentRole> roles = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("roles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DevCenterEnvironmentRole> dictionary = new Dictionary<string, DevCenterEnvironmentRole>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DevCenterEnvironmentRole.DeserializeDevCenterEnvironmentRole(property0.Value, options));
                    }
                    roles = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevCenterUserRoleAssignments(roles ?? new ChangeTrackingDictionary<string, DevCenterEnvironmentRole>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevCenterUserRoleAssignments>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterUserRoleAssignments>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevCenterUserRoleAssignments)} does not support writing '{options.Format}' format.");
            }
        }

        DevCenterUserRoleAssignments IPersistableModel<DevCenterUserRoleAssignments>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterUserRoleAssignments>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevCenterUserRoleAssignments(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevCenterUserRoleAssignments)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevCenterUserRoleAssignments>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
