// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    public partial class DiskPoolIscsiTargetData : IUtf8JsonSerializable, IJsonModel<DiskPoolIscsiTargetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiskPoolIscsiTargetData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiskPoolIscsiTargetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolIscsiTargetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskPoolIscsiTargetData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ManagedBy != null)
            {
                writer.WritePropertyName("managedBy"u8);
                writer.WriteStringValue(ManagedBy);
            }
            if (options.Format != "W" && !(ManagedByExtended is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("managedByExtended"u8);
                writer.WriteStartArray();
                foreach (var item in ManagedByExtended)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("aclMode"u8);
            writer.WriteStringValue(AclMode.ToString());
            if (!(StaticAcls is ChangeTrackingList<DiskPoolIscsiTargetPortalGroupAcl> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("staticAcls"u8);
                writer.WriteStartArray();
                foreach (var item in StaticAcls)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Luns is ChangeTrackingList<ManagedDiskIscsiLun> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("luns"u8);
                writer.WriteStartArray();
                foreach (var item in Luns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("targetIqn"u8);
            writer.WriteStringValue(TargetIqn);
            if (options.Format != "W")
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.ToString());
            }
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (!(Endpoints is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Port.HasValue)
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (options.Format != "W" && !(Sessions is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("sessions"u8);
                writer.WriteStartArray();
                foreach (var item in Sessions)
                {
                    writer.WriteStringValue(item);
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

        DiskPoolIscsiTargetData IJsonModel<DiskPoolIscsiTargetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolIscsiTargetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskPoolIscsiTargetData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskPoolIscsiTargetData(document.RootElement, options);
        }

        internal static DiskPoolIscsiTargetData DeserializeDiskPoolIscsiTargetData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> managedBy = default;
            IReadOnlyList<string> managedByExtended = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            DiskPoolIscsiTargetAclMode aclMode = default;
            IList<DiskPoolIscsiTargetPortalGroupAcl> staticAcls = default;
            IList<ManagedDiskIscsiLun> luns = default;
            string targetIqn = default;
            DiskPoolIscsiTargetProvisioningState provisioningState = default;
            StoragePoolOperationalStatus status = default;
            IList<string> endpoints = default;
            Optional<int> port = default;
            IReadOnlyList<string> sessions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"u8))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByExtended"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    managedByExtended = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("aclMode"u8))
                        {
                            aclMode = new DiskPoolIscsiTargetAclMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("staticAcls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DiskPoolIscsiTargetPortalGroupAcl> array = new List<DiskPoolIscsiTargetPortalGroupAcl>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DiskPoolIscsiTargetPortalGroupAcl.DeserializeDiskPoolIscsiTargetPortalGroupAcl(item, options));
                            }
                            staticAcls = array;
                            continue;
                        }
                        if (property0.NameEquals("luns"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedDiskIscsiLun> array = new List<ManagedDiskIscsiLun>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedDiskIscsiLun.DeserializeManagedDiskIscsiLun(item, options));
                            }
                            luns = array;
                            continue;
                        }
                        if (property0.NameEquals("targetIqn"u8))
                        {
                            targetIqn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = new DiskPoolIscsiTargetProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = new StoragePoolOperationalStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            endpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sessions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            sessions = array;
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
            return new DiskPoolIscsiTargetData(id, name, type, systemData.Value, managedBy.Value, managedByExtended ?? new ChangeTrackingList<string>(), aclMode, staticAcls ?? new ChangeTrackingList<DiskPoolIscsiTargetPortalGroupAcl>(), luns ?? new ChangeTrackingList<ManagedDiskIscsiLun>(), targetIqn, provisioningState, status, endpoints ?? new ChangeTrackingList<string>(), Optional.ToNullable(port), sessions ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiskPoolIscsiTargetData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolIscsiTargetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiskPoolIscsiTargetData)} does not support '{options.Format}' format.");
            }
        }

        DiskPoolIscsiTargetData IPersistableModel<DiskPoolIscsiTargetData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolIscsiTargetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiskPoolIscsiTargetData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiskPoolIscsiTargetData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiskPoolIscsiTargetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
