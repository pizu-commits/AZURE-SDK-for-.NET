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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchVmConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<BatchVmConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchVmConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchVmConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchVmConfiguration>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("imageReference"u8);
            if (ImageReference is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<BatchImageReference>)ImageReference).Serialize(writer, options);
            }
            writer.WritePropertyName("nodeAgentSkuId"u8);
            writer.WriteStringValue(NodeAgentSkuId);
            if (Optional.IsDefined(WindowsConfiguration))
            {
                writer.WritePropertyName("windowsConfiguration"u8);
                if (WindowsConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<WindowsConfiguration>)WindowsConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(DataDisks))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchVmDataDisk>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (Optional.IsDefined(ContainerConfiguration))
            {
                writer.WritePropertyName("containerConfiguration"u8);
                if (ContainerConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchVmContainerConfiguration>)ContainerConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DiskEncryptionConfiguration))
            {
                writer.WritePropertyName("diskEncryptionConfiguration"u8);
                if (DiskEncryptionConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DiskEncryptionConfiguration>)DiskEncryptionConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(NodePlacementConfiguration))
            {
                writer.WritePropertyName("nodePlacementConfiguration"u8);
                if (NodePlacementConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NodePlacementConfiguration>)NodePlacementConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchVmExtension>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OSDisk))
            {
                writer.WritePropertyName("osDisk"u8);
                if (OSDisk is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OSDisk>)OSDisk).Serialize(writer, options);
                }
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

        internal static BatchVmConfiguration DeserializeBatchVmConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchImageReference imageReference = default;
            string nodeAgentSkuId = default;
            Optional<WindowsConfiguration> windowsConfiguration = default;
            Optional<IList<BatchVmDataDisk>> dataDisks = default;
            Optional<string> licenseType = default;
            Optional<BatchVmContainerConfiguration> containerConfiguration = default;
            Optional<DiskEncryptionConfiguration> diskEncryptionConfiguration = default;
            Optional<NodePlacementConfiguration> nodePlacementConfiguration = default;
            Optional<IList<BatchVmExtension>> extensions = default;
            Optional<OSDisk> osDisk = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageReference"u8))
                {
                    imageReference = BatchImageReference.DeserializeBatchImageReference(property.Value);
                    continue;
                }
                if (property.NameEquals("nodeAgentSkuId"u8))
                {
                    nodeAgentSkuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsConfiguration = WindowsConfiguration.DeserializeWindowsConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchVmDataDisk> array = new List<BatchVmDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchVmDataDisk.DeserializeBatchVmDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerConfiguration = BatchVmContainerConfiguration.DeserializeBatchVmContainerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("diskEncryptionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionConfiguration = DiskEncryptionConfiguration.DeserializeDiskEncryptionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("nodePlacementConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodePlacementConfiguration = NodePlacementConfiguration.DeserializeNodePlacementConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("extensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchVmExtension> array = new List<BatchVmExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchVmExtension.DeserializeBatchVmExtension(item));
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = OSDisk.DeserializeOSDisk(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchVmConfiguration(imageReference, nodeAgentSkuId, windowsConfiguration.Value, Optional.ToList(dataDisks), licenseType.Value, containerConfiguration.Value, diskEncryptionConfiguration.Value, nodePlacementConfiguration.Value, Optional.ToList(extensions), osDisk.Value, rawData);
        }

        BatchVmConfiguration IModelJsonSerializable<BatchVmConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchVmConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchVmConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchVmConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchVmConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchVmConfiguration IModelSerializable<BatchVmConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchVmConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchVmConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchVmConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchVmConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(BatchVmConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchVmConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchVmConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchVmConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
