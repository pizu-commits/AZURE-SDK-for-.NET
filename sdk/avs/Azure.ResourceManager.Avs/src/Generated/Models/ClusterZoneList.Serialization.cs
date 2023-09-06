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
    internal partial class ClusterZoneList : IUtf8JsonSerializable, IModelJsonSerializable<ClusterZoneList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ClusterZoneList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ClusterZoneList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterZoneList>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AvsClusterZone>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static ClusterZoneList DeserializeClusterZoneList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AvsClusterZone>> zones = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvsClusterZone> array = new List<AvsClusterZone>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvsClusterZone.DeserializeAvsClusterZone(item));
                    }
                    zones = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ClusterZoneList(Optional.ToList(zones), rawData);
        }

        ClusterZoneList IModelJsonSerializable<ClusterZoneList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterZoneList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterZoneList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ClusterZoneList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterZoneList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ClusterZoneList IModelSerializable<ClusterZoneList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterZoneList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeClusterZoneList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ClusterZoneList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ClusterZoneList"/> to convert. </param>
        public static implicit operator RequestContent(ClusterZoneList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ClusterZoneList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ClusterZoneList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeClusterZoneList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
