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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricControllerPatch : IUtf8JsonSerializable, IModelJsonSerializable<NetworkFabricControllerPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkFabricControllerPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkFabricControllerPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkFabricControllerPatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
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
            if (Optional.IsCollectionDefined(InfrastructureExpressRouteConnections))
            {
                writer.WritePropertyName("infrastructureExpressRouteConnections"u8);
                writer.WriteStartArray();
                foreach (var item in InfrastructureExpressRouteConnections)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ExpressRouteConnectionInformation>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WorkloadExpressRouteConnections))
            {
                writer.WritePropertyName("workloadExpressRouteConnections"u8);
                writer.WriteStartArray();
                foreach (var item in WorkloadExpressRouteConnections)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ExpressRouteConnectionInformation>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static NetworkFabricControllerPatch DeserializeNetworkFabricControllerPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<ExpressRouteConnectionInformation>> infrastructureExpressRouteConnections = default;
            Optional<IList<ExpressRouteConnectionInformation>> workloadExpressRouteConnections = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("infrastructureExpressRouteConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteConnectionInformation> array = new List<ExpressRouteConnectionInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteConnectionInformation.DeserializeExpressRouteConnectionInformation(item));
                            }
                            infrastructureExpressRouteConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("workloadExpressRouteConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteConnectionInformation> array = new List<ExpressRouteConnectionInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteConnectionInformation.DeserializeExpressRouteConnectionInformation(item));
                            }
                            workloadExpressRouteConnections = array;
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
            return new NetworkFabricControllerPatch(Optional.ToDictionary(tags), Optional.ToList(infrastructureExpressRouteConnections), Optional.ToList(workloadExpressRouteConnections), rawData);
        }

        NetworkFabricControllerPatch IModelJsonSerializable<NetworkFabricControllerPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkFabricControllerPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricControllerPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkFabricControllerPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkFabricControllerPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkFabricControllerPatch IModelSerializable<NetworkFabricControllerPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkFabricControllerPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkFabricControllerPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkFabricControllerPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkFabricControllerPatch"/> to convert. </param>
        public static implicit operator RequestContent(NetworkFabricControllerPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkFabricControllerPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkFabricControllerPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkFabricControllerPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
