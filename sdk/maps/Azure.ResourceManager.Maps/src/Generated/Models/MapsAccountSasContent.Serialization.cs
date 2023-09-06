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

namespace Azure.ResourceManager.Maps.Models
{
    public partial class MapsAccountSasContent : IUtf8JsonSerializable, IModelJsonSerializable<MapsAccountSasContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MapsAccountSasContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MapsAccountSasContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapsAccountSasContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("signingKey"u8);
            writer.WriteStringValue(SigningKey.ToString());
            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            if (Optional.IsCollectionDefined(Regions))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartArray();
                foreach (var item in Regions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("maxRatePerSecond"u8);
            writer.WriteNumberValue(MaxRatePerSecond);
            writer.WritePropertyName("start"u8);
            writer.WriteStringValue(Start);
            writer.WritePropertyName("expiry"u8);
            writer.WriteStringValue(Expiry);
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

        internal static MapsAccountSasContent DeserializeMapsAccountSasContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MapsSigningKey signingKey = default;
            string principalId = default;
            Optional<IList<string>> regions = default;
            int maxRatePerSecond = default;
            string start = default;
            string expiry = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("signingKey"u8))
                {
                    signingKey = new MapsSigningKey(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regions"u8))
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
                    regions = array;
                    continue;
                }
                if (property.NameEquals("maxRatePerSecond"u8))
                {
                    maxRatePerSecond = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    expiry = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MapsAccountSasContent(signingKey, principalId, Optional.ToList(regions), maxRatePerSecond, start, expiry, rawData);
        }

        MapsAccountSasContent IModelJsonSerializable<MapsAccountSasContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapsAccountSasContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMapsAccountSasContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MapsAccountSasContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapsAccountSasContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MapsAccountSasContent IModelSerializable<MapsAccountSasContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapsAccountSasContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMapsAccountSasContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MapsAccountSasContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MapsAccountSasContent"/> to convert. </param>
        public static implicit operator RequestContent(MapsAccountSasContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MapsAccountSasContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MapsAccountSasContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMapsAccountSasContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
