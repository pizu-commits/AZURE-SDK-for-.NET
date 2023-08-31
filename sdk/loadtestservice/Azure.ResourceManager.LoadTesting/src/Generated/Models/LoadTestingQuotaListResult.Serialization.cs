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
using Azure.ResourceManager.LoadTesting;

namespace Azure.ResourceManager.LoadTesting.Models
{
    internal partial class LoadTestingQuotaListResult : IUtf8JsonSerializable, IModelJsonSerializable<LoadTestingQuotaListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LoadTestingQuotaListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LoadTestingQuotaListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static LoadTestingQuotaListResult DeserializeLoadTestingQuotaListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<LoadTestingQuotaData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadTestingQuotaData> array = new List<LoadTestingQuotaData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadTestingQuotaData.DeserializeLoadTestingQuotaData(item));
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
            return new LoadTestingQuotaListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        LoadTestingQuotaListResult IModelJsonSerializable<LoadTestingQuotaListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadTestingQuotaListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LoadTestingQuotaListResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LoadTestingQuotaListResult IModelSerializable<LoadTestingQuotaListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLoadTestingQuotaListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LoadTestingQuotaListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LoadTestingQuotaListResult"/> to convert. </param>
        public static implicit operator RequestContent(LoadTestingQuotaListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LoadTestingQuotaListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LoadTestingQuotaListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLoadTestingQuotaListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
