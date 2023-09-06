// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class VirtualDisk : IUtf8JsonSerializable, IModelJsonSerializable<VirtualDisk>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualDisk>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualDisk>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualDisk>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(Bus))
            {
                writer.WritePropertyName("bus"u8);
                writer.WriteNumberValue(Bus.Value);
            }
            if (Optional.IsDefined(Lun))
            {
                writer.WritePropertyName("lun"u8);
                writer.WriteNumberValue(Lun.Value);
            }
            if (Optional.IsDefined(BusType))
            {
                writer.WritePropertyName("busType"u8);
                writer.WriteStringValue(BusType);
            }
            if (Optional.IsDefined(VhdType))
            {
                writer.WritePropertyName("vhdType"u8);
                writer.WriteStringValue(VhdType);
            }
            if (Optional.IsDefined(TemplateDiskId))
            {
                writer.WritePropertyName("templateDiskId"u8);
                writer.WriteStringValue(TemplateDiskId);
            }
            if (Optional.IsDefined(StorageQoSPolicy))
            {
                writer.WritePropertyName("storageQoSPolicy"u8);
                if (StorageQoSPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageQoSPolicyDetails>)StorageQoSPolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CreateDiffDisk))
            {
                writer.WritePropertyName("createDiffDisk"u8);
                writer.WriteStringValue(CreateDiffDisk.Value.ToString());
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static VirtualDisk DeserializeVirtualDisk(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<string> diskId = default;
            Optional<int> diskSizeGB = default;
            Optional<int> maxDiskSizeGB = default;
            Optional<int> bus = default;
            Optional<int> lun = default;
            Optional<string> busType = default;
            Optional<string> vhdType = default;
            Optional<string> volumeType = default;
            Optional<string> vhdFormatType = default;
            Optional<string> templateDiskId = default;
            Optional<StorageQoSPolicyDetails> storageQoSPolicy = default;
            Optional<CreateDiffDisk> createDiffDisk = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxDiskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDiskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bus = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lun"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("busType"u8))
                {
                    busType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdType"u8))
                {
                    vhdType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("volumeType"u8))
                {
                    volumeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdFormatType"u8))
                {
                    vhdFormatType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("templateDiskId"u8))
                {
                    templateDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageQoSPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageQoSPolicy = StorageQoSPolicyDetails.DeserializeStorageQoSPolicyDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("createDiffDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createDiffDisk = new CreateDiffDisk(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualDisk(name.Value, displayName.Value, diskId.Value, Optional.ToNullable(diskSizeGB), Optional.ToNullable(maxDiskSizeGB), Optional.ToNullable(bus), Optional.ToNullable(lun), busType.Value, vhdType.Value, volumeType.Value, vhdFormatType.Value, templateDiskId.Value, storageQoSPolicy.Value, Optional.ToNullable(createDiffDisk), rawData);
        }

        VirtualDisk IModelJsonSerializable<VirtualDisk>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualDisk>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualDisk(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualDisk>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualDisk>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualDisk IModelSerializable<VirtualDisk>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualDisk>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualDisk(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualDisk"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualDisk"/> to convert. </param>
        public static implicit operator RequestContent(VirtualDisk model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualDisk"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualDisk(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualDisk(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
