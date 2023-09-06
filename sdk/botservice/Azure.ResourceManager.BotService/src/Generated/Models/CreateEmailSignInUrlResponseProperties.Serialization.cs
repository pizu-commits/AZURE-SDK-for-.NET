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

namespace Azure.ResourceManager.BotService.Models
{
    internal partial class CreateEmailSignInUrlResponseProperties : IUtf8JsonSerializable, IModelJsonSerializable<CreateEmailSignInUrlResponseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CreateEmailSignInUrlResponseProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CreateEmailSignInUrlResponseProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateEmailSignInUrlResponseProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
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

        internal static CreateEmailSignInUrlResponseProperties DeserializeCreateEmailSignInUrlResponseProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> url = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CreateEmailSignInUrlResponseProperties(url.Value, rawData);
        }

        CreateEmailSignInUrlResponseProperties IModelJsonSerializable<CreateEmailSignInUrlResponseProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateEmailSignInUrlResponseProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateEmailSignInUrlResponseProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CreateEmailSignInUrlResponseProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateEmailSignInUrlResponseProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CreateEmailSignInUrlResponseProperties IModelSerializable<CreateEmailSignInUrlResponseProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateEmailSignInUrlResponseProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCreateEmailSignInUrlResponseProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CreateEmailSignInUrlResponseProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CreateEmailSignInUrlResponseProperties"/> to convert. </param>
        public static implicit operator RequestContent(CreateEmailSignInUrlResponseProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CreateEmailSignInUrlResponseProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CreateEmailSignInUrlResponseProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCreateEmailSignInUrlResponseProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
