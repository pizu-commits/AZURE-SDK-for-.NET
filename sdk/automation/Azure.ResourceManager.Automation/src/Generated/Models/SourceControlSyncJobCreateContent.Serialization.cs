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
    public partial class SourceControlSyncJobCreateContent : IUtf8JsonSerializable, IModelJsonSerializable<SourceControlSyncJobCreateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SourceControlSyncJobCreateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SourceControlSyncJobCreateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceControlSyncJobCreateContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("commitId"u8);
            writer.WriteStringValue(CommitId);
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

        internal static SourceControlSyncJobCreateContent DeserializeSourceControlSyncJobCreateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string commitId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("commitId"u8))
                        {
                            commitId = property0.Value.GetString();
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
            return new SourceControlSyncJobCreateContent(commitId, rawData);
        }

        SourceControlSyncJobCreateContent IModelJsonSerializable<SourceControlSyncJobCreateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceControlSyncJobCreateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceControlSyncJobCreateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SourceControlSyncJobCreateContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceControlSyncJobCreateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SourceControlSyncJobCreateContent IModelSerializable<SourceControlSyncJobCreateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceControlSyncJobCreateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSourceControlSyncJobCreateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SourceControlSyncJobCreateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SourceControlSyncJobCreateContent"/> to convert. </param>
        public static implicit operator RequestContent(SourceControlSyncJobCreateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SourceControlSyncJobCreateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SourceControlSyncJobCreateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSourceControlSyncJobCreateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
