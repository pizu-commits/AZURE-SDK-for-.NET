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
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricSkuData : IUtf8JsonSerializable, IModelJsonSerializable<NetworkFabricSkuData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkFabricSkuData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkFabricSkuData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkFabricSkuData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxComputeRacks))
            {
                writer.WritePropertyName("maxComputeRacks"u8);
                writer.WriteNumberValue(MaxComputeRacks.Value);
            }
            if (Optional.IsDefined(MaximumServerCount))
            {
                writer.WritePropertyName("maximumServerCount"u8);
                writer.WriteNumberValue(MaximumServerCount.Value);
            }
            writer.WriteEndObject();
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

        internal static NetworkFabricSkuData DeserializeNetworkFabricSkuData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NetworkFabricSkuType> type0 = default;
            Optional<int> maxComputeRacks = default;
            Optional<int> maximumServerCount = default;
            Optional<IReadOnlyList<string>> supportedVersions = default;
            Optional<string> details = default;
            Optional<NetworkFabricProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new NetworkFabricSkuType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maxComputeRacks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxComputeRacks = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maximumServerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumServerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("supportedVersions"u8))
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
                            supportedVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            details = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkFabricSkuData(id, name, type, systemData.Value, Optional.ToNullable(type0), Optional.ToNullable(maxComputeRacks), Optional.ToNullable(maximumServerCount), Optional.ToList(supportedVersions), details.Value, Optional.ToNullable(provisioningState), rawData);
        }

        NetworkFabricSkuData IModelJsonSerializable<NetworkFabricSkuData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkFabricSkuData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricSkuData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkFabricSkuData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkFabricSkuData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkFabricSkuData IModelSerializable<NetworkFabricSkuData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkFabricSkuData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkFabricSkuData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkFabricSkuData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkFabricSkuData"/> to convert. </param>
        public static implicit operator RequestContent(NetworkFabricSkuData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkFabricSkuData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkFabricSkuData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkFabricSkuData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
