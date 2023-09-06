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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningDatastoreCredentials : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningDatastoreCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningDatastoreCredentials>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningDatastoreCredentials>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningDatastoreCredentials>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("credentialsType"u8);
            writer.WriteStringValue(CredentialsType.ToString());
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

        internal static MachineLearningDatastoreCredentials DeserializeMachineLearningDatastoreCredentials(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("credentialsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AccountKey": return MachineLearningAccountKeyDatastoreCredentials.DeserializeMachineLearningAccountKeyDatastoreCredentials(element);
                    case "Certificate": return MachineLearningCertificateDatastoreCredentials.DeserializeMachineLearningCertificateDatastoreCredentials(element);
                    case "None": return MachineLearningNoneDatastoreCredentials.DeserializeMachineLearningNoneDatastoreCredentials(element);
                    case "Sas": return MachineLearningSasDatastoreCredentials.DeserializeMachineLearningSasDatastoreCredentials(element);
                    case "ServicePrincipal": return MachineLearningServicePrincipalDatastoreCredentials.DeserializeMachineLearningServicePrincipalDatastoreCredentials(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            CredentialsType credentialsType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentialsType"u8))
                {
                    credentialsType = new CredentialsType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownDatastoreCredentials(credentialsType, rawData);
        }

        MachineLearningDatastoreCredentials IModelJsonSerializable<MachineLearningDatastoreCredentials>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningDatastoreCredentials>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningDatastoreCredentials(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningDatastoreCredentials>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningDatastoreCredentials>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningDatastoreCredentials IModelSerializable<MachineLearningDatastoreCredentials>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningDatastoreCredentials>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningDatastoreCredentials(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningDatastoreCredentials"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningDatastoreCredentials"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningDatastoreCredentials model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningDatastoreCredentials"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningDatastoreCredentials(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningDatastoreCredentials(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
