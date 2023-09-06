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
using Azure.ResourceManager.HybridCompute;

namespace Azure.ResourceManager.HybridCompute.Models
{
    internal partial class HybridComputePrivateLinkScopeListResult : IUtf8JsonSerializable, IModelJsonSerializable<HybridComputePrivateLinkScopeListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HybridComputePrivateLinkScopeListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HybridComputePrivateLinkScopeListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridComputePrivateLinkScopeListResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<HybridComputePrivateLinkScopeData>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static HybridComputePrivateLinkScopeListResult DeserializeHybridComputePrivateLinkScopeListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<HybridComputePrivateLinkScopeData> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<HybridComputePrivateLinkScopeData> array = new List<HybridComputePrivateLinkScopeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridComputePrivateLinkScopeData.DeserializeHybridComputePrivateLinkScopeData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HybridComputePrivateLinkScopeListResult(value, nextLink.Value, rawData);
        }

        HybridComputePrivateLinkScopeListResult IModelJsonSerializable<HybridComputePrivateLinkScopeListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridComputePrivateLinkScopeListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputePrivateLinkScopeListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HybridComputePrivateLinkScopeListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridComputePrivateLinkScopeListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HybridComputePrivateLinkScopeListResult IModelSerializable<HybridComputePrivateLinkScopeListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridComputePrivateLinkScopeListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHybridComputePrivateLinkScopeListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HybridComputePrivateLinkScopeListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HybridComputePrivateLinkScopeListResult"/> to convert. </param>
        public static implicit operator RequestContent(HybridComputePrivateLinkScopeListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HybridComputePrivateLinkScopeListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HybridComputePrivateLinkScopeListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHybridComputePrivateLinkScopeListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
