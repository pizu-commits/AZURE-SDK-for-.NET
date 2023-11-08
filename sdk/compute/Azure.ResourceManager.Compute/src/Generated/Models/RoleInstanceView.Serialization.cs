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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RoleInstanceView : IUtf8JsonSerializable, IJsonModel<RoleInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleInstanceView>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RoleInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PlatformUpdateDomain))
                {
                    writer.WritePropertyName("platformUpdateDomain"u8);
                    writer.WriteNumberValue(PlatformUpdateDomain.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PlatformFaultDomain))
                {
                    writer.WritePropertyName("platformFaultDomain"u8);
                    writer.WriteNumberValue(PlatformFaultDomain.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PrivateId))
                {
                    writer.WritePropertyName("privateId"u8);
                    writer.WriteStringValue(PrivateId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Statuses))
                {
                    writer.WritePropertyName("statuses"u8);
                    writer.WriteStartArray();
                    foreach (var item in Statuses)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
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

        RoleInstanceView IJsonModel<RoleInstanceView>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RoleInstanceView)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleInstanceView(document.RootElement, options);
        }

        internal static RoleInstanceView DeserializeRoleInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> platformUpdateDomain = default;
            Optional<int> platformFaultDomain = default;
            Optional<string> privateId = default;
            Optional<IReadOnlyList<ResourceInstanceViewStatus>> statuses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("platformUpdateDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platformUpdateDomain = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("platformFaultDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platformFaultDomain = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("privateId"u8))
                {
                    privateId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceInstanceViewStatus> array = new List<ResourceInstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceInstanceViewStatus.DeserializeResourceInstanceViewStatus(item));
                    }
                    statuses = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoleInstanceView(Optional.ToNullable(platformUpdateDomain), Optional.ToNullable(platformFaultDomain), privateId.Value, Optional.ToList(statuses), serializedAdditionalRawData);
        }

        BinaryData IModel<RoleInstanceView>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RoleInstanceView)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RoleInstanceView IModel<RoleInstanceView>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RoleInstanceView)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRoleInstanceView(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RoleInstanceView>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
