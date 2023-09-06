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

namespace Azure.ResourceManager.Automation.Models
{
    public partial class HybridRunbookWorkerGroupCreateOrUpdateContent : IUtf8JsonSerializable, IModelJsonSerializable<HybridRunbookWorkerGroupCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HybridRunbookWorkerGroupCreateOrUpdateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HybridRunbookWorkerGroupCreateOrUpdateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridRunbookWorkerGroupCreateOrUpdateContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                if (Credential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RunAsCredentialAssociationProperty>)Credential).Serialize(writer, options);
                }
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

        internal static HybridRunbookWorkerGroupCreateOrUpdateContent DeserializeHybridRunbookWorkerGroupCreateOrUpdateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<RunAsCredentialAssociationProperty> credential = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = RunAsCredentialAssociationProperty.DeserializeRunAsCredentialAssociationProperty(property0.Value);
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
            return new HybridRunbookWorkerGroupCreateOrUpdateContent(name.Value, credential.Value, rawData);
        }

        HybridRunbookWorkerGroupCreateOrUpdateContent IModelJsonSerializable<HybridRunbookWorkerGroupCreateOrUpdateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridRunbookWorkerGroupCreateOrUpdateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridRunbookWorkerGroupCreateOrUpdateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HybridRunbookWorkerGroupCreateOrUpdateContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridRunbookWorkerGroupCreateOrUpdateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HybridRunbookWorkerGroupCreateOrUpdateContent IModelSerializable<HybridRunbookWorkerGroupCreateOrUpdateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridRunbookWorkerGroupCreateOrUpdateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHybridRunbookWorkerGroupCreateOrUpdateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HybridRunbookWorkerGroupCreateOrUpdateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HybridRunbookWorkerGroupCreateOrUpdateContent"/> to convert. </param>
        public static implicit operator RequestContent(HybridRunbookWorkerGroupCreateOrUpdateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HybridRunbookWorkerGroupCreateOrUpdateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HybridRunbookWorkerGroupCreateOrUpdateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHybridRunbookWorkerGroupCreateOrUpdateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
