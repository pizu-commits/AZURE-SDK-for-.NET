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

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsPrivateCloudClusterVirtualMachineRestrictMovement : IUtf8JsonSerializable, IModelJsonSerializable<AvsPrivateCloudClusterVirtualMachineRestrictMovement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AvsPrivateCloudClusterVirtualMachineRestrictMovement>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AvsPrivateCloudClusterVirtualMachineRestrictMovement>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvsPrivateCloudClusterVirtualMachineRestrictMovement>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RestrictMovement))
            {
                writer.WritePropertyName("restrictMovement"u8);
                writer.WriteStringValue(RestrictMovement.Value.ToString());
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

        internal static AvsPrivateCloudClusterVirtualMachineRestrictMovement DeserializeAvsPrivateCloudClusterVirtualMachineRestrictMovement(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VirtualMachineRestrictMovementState> restrictMovement = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restrictMovement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restrictMovement = new VirtualMachineRestrictMovementState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AvsPrivateCloudClusterVirtualMachineRestrictMovement(Optional.ToNullable(restrictMovement), rawData);
        }

        AvsPrivateCloudClusterVirtualMachineRestrictMovement IModelJsonSerializable<AvsPrivateCloudClusterVirtualMachineRestrictMovement>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvsPrivateCloudClusterVirtualMachineRestrictMovement>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsPrivateCloudClusterVirtualMachineRestrictMovement(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AvsPrivateCloudClusterVirtualMachineRestrictMovement>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvsPrivateCloudClusterVirtualMachineRestrictMovement>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AvsPrivateCloudClusterVirtualMachineRestrictMovement IModelSerializable<AvsPrivateCloudClusterVirtualMachineRestrictMovement>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvsPrivateCloudClusterVirtualMachineRestrictMovement>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAvsPrivateCloudClusterVirtualMachineRestrictMovement(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AvsPrivateCloudClusterVirtualMachineRestrictMovement"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AvsPrivateCloudClusterVirtualMachineRestrictMovement"/> to convert. </param>
        public static implicit operator RequestContent(AvsPrivateCloudClusterVirtualMachineRestrictMovement model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AvsPrivateCloudClusterVirtualMachineRestrictMovement"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AvsPrivateCloudClusterVirtualMachineRestrictMovement(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAvsPrivateCloudClusterVirtualMachineRestrictMovement(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
