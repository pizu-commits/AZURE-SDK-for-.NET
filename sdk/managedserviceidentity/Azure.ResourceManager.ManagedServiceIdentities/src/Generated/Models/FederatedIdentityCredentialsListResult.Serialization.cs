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
using Azure.ResourceManager.ManagedServiceIdentities;

namespace Azure.ResourceManager.ManagedServiceIdentities.Models
{
    internal partial class FederatedIdentityCredentialsListResult : IUtf8JsonSerializable, IModelJsonSerializable<FederatedIdentityCredentialsListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FederatedIdentityCredentialsListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FederatedIdentityCredentialsListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FederatedIdentityCredentialsListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
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
                        ((IModelJsonSerializable<FederatedIdentityCredentialData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
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

        internal static FederatedIdentityCredentialsListResult DeserializeFederatedIdentityCredentialsListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<FederatedIdentityCredentialData>> value = default;
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
                    List<FederatedIdentityCredentialData> array = new List<FederatedIdentityCredentialData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FederatedIdentityCredentialData.DeserializeFederatedIdentityCredentialData(item));
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
            return new FederatedIdentityCredentialsListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        FederatedIdentityCredentialsListResult IModelJsonSerializable<FederatedIdentityCredentialsListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FederatedIdentityCredentialsListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFederatedIdentityCredentialsListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FederatedIdentityCredentialsListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FederatedIdentityCredentialsListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FederatedIdentityCredentialsListResult IModelSerializable<FederatedIdentityCredentialsListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FederatedIdentityCredentialsListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFederatedIdentityCredentialsListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FederatedIdentityCredentialsListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FederatedIdentityCredentialsListResult"/> to convert. </param>
        public static implicit operator RequestContent(FederatedIdentityCredentialsListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FederatedIdentityCredentialsListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FederatedIdentityCredentialsListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFederatedIdentityCredentialsListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
