// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Maps.Geolocation
{
    public partial class CountryRegionResult : IUtf8JsonSerializable, IModelJsonSerializable<CountryRegionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CountryRegionResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CountryRegionResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CountryRegionResult>(this, options.Format);

            writer.WriteStartObject();
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

        internal static CountryRegionResult DeserializeCountryRegionResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CountryRegion> countryRegion = default;
            Optional<IPAddress> ipAddress = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countryRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    countryRegion = Geolocation.CountryRegion.DeserializeCountryRegion(property.Value);
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CountryRegionResult(countryRegion.Value, ipAddress.Value, rawData);
        }

        CountryRegionResult IModelJsonSerializable<CountryRegionResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CountryRegionResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCountryRegionResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CountryRegionResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CountryRegionResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CountryRegionResult IModelSerializable<CountryRegionResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CountryRegionResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCountryRegionResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CountryRegionResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CountryRegionResult"/> to convert. </param>
        public static implicit operator RequestContent(CountryRegionResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CountryRegionResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CountryRegionResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCountryRegionResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
