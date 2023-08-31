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
    public partial class MachineLearningWorkspaceNotebookAccessTokenResult : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningWorkspaceNotebookAccessTokenResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningWorkspaceNotebookAccessTokenResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningWorkspaceNotebookAccessTokenResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static MachineLearningWorkspaceNotebookAccessTokenResult DeserializeMachineLearningWorkspaceNotebookAccessTokenResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> notebookResourceId = default;
            Optional<string> hostName = default;
            Optional<string> publicDns = default;
            Optional<string> accessToken = default;
            Optional<string> tokenType = default;
            Optional<int> expiresIn = default;
            Optional<string> refreshToken = default;
            Optional<string> scope = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notebookResourceId"u8))
                {
                    notebookResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicDns"u8))
                {
                    publicDns = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenType"u8))
                {
                    tokenType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiresIn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresIn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("refreshToken"u8))
                {
                    refreshToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningWorkspaceNotebookAccessTokenResult(notebookResourceId.Value, hostName.Value, publicDns.Value, accessToken.Value, tokenType.Value, Optional.ToNullable(expiresIn), refreshToken.Value, scope.Value, rawData);
        }

        MachineLearningWorkspaceNotebookAccessTokenResult IModelJsonSerializable<MachineLearningWorkspaceNotebookAccessTokenResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningWorkspaceNotebookAccessTokenResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningWorkspaceNotebookAccessTokenResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningWorkspaceNotebookAccessTokenResult IModelSerializable<MachineLearningWorkspaceNotebookAccessTokenResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningWorkspaceNotebookAccessTokenResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningWorkspaceNotebookAccessTokenResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningWorkspaceNotebookAccessTokenResult"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningWorkspaceNotebookAccessTokenResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningWorkspaceNotebookAccessTokenResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningWorkspaceNotebookAccessTokenResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningWorkspaceNotebookAccessTokenResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
