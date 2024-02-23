// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudBareMetalMachineKeySetPatch : IUtf8JsonSerializable, IJsonModel<NetworkCloudBareMetalMachineKeySetPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudBareMetalMachineKeySetPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkCloudBareMetalMachineKeySetPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudBareMetalMachineKeySetPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudBareMetalMachineKeySetPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ExpireOn.HasValue)
            {
                writer.WritePropertyName("expiration"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (!(JumpHostsAllowed is ChangeTrackingList<IPAddress> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("jumpHostsAllowed"u8);
                writer.WriteStartArray();
                foreach (var item in JumpHostsAllowed)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(UserList is ChangeTrackingList<KeySetUser> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("userList"u8);
                writer.WriteStartArray();
                foreach (var item in UserList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        NetworkCloudBareMetalMachineKeySetPatch IJsonModel<NetworkCloudBareMetalMachineKeySetPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudBareMetalMachineKeySetPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudBareMetalMachineKeySetPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudBareMetalMachineKeySetPatch(document.RootElement, options);
        }

        internal static NetworkCloudBareMetalMachineKeySetPatch DeserializeNetworkCloudBareMetalMachineKeySetPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<DateTimeOffset> expiration = default;
            IList<IPAddress> jumpHostsAllowed = default;
            IList<KeySetUser> userList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("expiration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiration = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("jumpHostsAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            jumpHostsAllowed = array;
                            continue;
                        }
                        if (property0.NameEquals("userList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KeySetUser> array = new List<KeySetUser>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KeySetUser.DeserializeKeySetUser(item, options));
                            }
                            userList = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkCloudBareMetalMachineKeySetPatch(Optional.ToDictionary(tags), Optional.ToNullable(expiration), jumpHostsAllowed ?? new ChangeTrackingList<IPAddress>(), userList ?? new ChangeTrackingList<KeySetUser>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudBareMetalMachineKeySetPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudBareMetalMachineKeySetPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudBareMetalMachineKeySetPatch)} does not support '{options.Format}' format.");
            }
        }

        NetworkCloudBareMetalMachineKeySetPatch IPersistableModel<NetworkCloudBareMetalMachineKeySetPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudBareMetalMachineKeySetPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkCloudBareMetalMachineKeySetPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudBareMetalMachineKeySetPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudBareMetalMachineKeySetPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
