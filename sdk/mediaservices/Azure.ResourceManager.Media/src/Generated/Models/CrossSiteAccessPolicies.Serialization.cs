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

namespace Azure.ResourceManager.Media.Models
{
    public partial class CrossSiteAccessPolicies : IUtf8JsonSerializable, IModelJsonSerializable<CrossSiteAccessPolicies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CrossSiteAccessPolicies>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CrossSiteAccessPolicies>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientAccessPolicy))
            {
                writer.WritePropertyName("clientAccessPolicy"u8);
                writer.WriteStringValue(ClientAccessPolicy);
            }
            if (Optional.IsDefined(CrossDomainPolicy))
            {
                writer.WritePropertyName("crossDomainPolicy"u8);
                writer.WriteStringValue(CrossDomainPolicy);
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

        internal static CrossSiteAccessPolicies DeserializeCrossSiteAccessPolicies(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientAccessPolicy = default;
            Optional<string> crossDomainPolicy = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientAccessPolicy"u8))
                {
                    clientAccessPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crossDomainPolicy"u8))
                {
                    crossDomainPolicy = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CrossSiteAccessPolicies(clientAccessPolicy.Value, crossDomainPolicy.Value, rawData);
        }

        CrossSiteAccessPolicies IModelJsonSerializable<CrossSiteAccessPolicies>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCrossSiteAccessPolicies(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CrossSiteAccessPolicies>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CrossSiteAccessPolicies IModelSerializable<CrossSiteAccessPolicies>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCrossSiteAccessPolicies(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CrossSiteAccessPolicies"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CrossSiteAccessPolicies"/> to convert. </param>
        public static implicit operator RequestContent(CrossSiteAccessPolicies model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CrossSiteAccessPolicies"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CrossSiteAccessPolicies(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCrossSiteAccessPolicies(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
