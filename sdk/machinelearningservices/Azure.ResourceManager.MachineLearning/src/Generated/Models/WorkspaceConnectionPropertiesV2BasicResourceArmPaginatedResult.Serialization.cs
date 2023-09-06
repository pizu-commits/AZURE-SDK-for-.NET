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
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult : IUtf8JsonSerializable, IModelJsonSerializable<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>(this, options.Format);

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
                        ((IModelJsonSerializable<MachineLearningWorkspaceConnectionData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult DeserializeWorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MachineLearningWorkspaceConnectionData>> value = default;
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
                    List<MachineLearningWorkspaceConnectionData> array = new List<MachineLearningWorkspaceConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningWorkspaceConnectionData.DeserializeMachineLearningWorkspaceConnectionData(item));
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
            return new WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult IModelJsonSerializable<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult IModelSerializable<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult"/> to convert. </param>
        public static implicit operator RequestContent(WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
