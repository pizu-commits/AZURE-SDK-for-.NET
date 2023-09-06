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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class SwaggerCustomDynamicTreeCommand : IUtf8JsonSerializable, IModelJsonSerializable<SwaggerCustomDynamicTreeCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SwaggerCustomDynamicTreeCommand>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SwaggerCustomDynamicTreeCommand>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SwaggerCustomDynamicTreeCommand>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(ItemsPath))
            {
                writer.WritePropertyName("itemsPath"u8);
                writer.WriteStringValue(ItemsPath);
            }
            if (Optional.IsDefined(ItemValuePath))
            {
                writer.WritePropertyName("itemValuePath"u8);
                writer.WriteStringValue(ItemValuePath);
            }
            if (Optional.IsDefined(ItemTitlePath))
            {
                writer.WritePropertyName("itemTitlePath"u8);
                writer.WriteStringValue(ItemTitlePath);
            }
            if (Optional.IsDefined(ItemFullTitlePath))
            {
                writer.WritePropertyName("itemFullTitlePath"u8);
                writer.WriteStringValue(ItemFullTitlePath);
            }
            if (Optional.IsDefined(ItemIsParent))
            {
                writer.WritePropertyName("itemIsParent"u8);
                writer.WriteStringValue(ItemIsParent);
            }
            if (Optional.IsDefined(SelectableFilter))
            {
                writer.WritePropertyName("selectableFilter"u8);
                writer.WriteStringValue(SelectableFilter);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SwaggerCustomDynamicTreeParameterInfo>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
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

        internal static SwaggerCustomDynamicTreeCommand DeserializeSwaggerCustomDynamicTreeCommand(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> operationId = default;
            Optional<string> itemsPath = default;
            Optional<string> itemValuePath = default;
            Optional<string> itemTitlePath = default;
            Optional<string> itemFullTitlePath = default;
            Optional<string> itemIsParent = default;
            Optional<string> selectableFilter = default;
            Optional<IDictionary<string, SwaggerCustomDynamicTreeParameterInfo>> parameters = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemsPath"u8))
                {
                    itemsPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemValuePath"u8))
                {
                    itemValuePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemTitlePath"u8))
                {
                    itemTitlePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemFullTitlePath"u8))
                {
                    itemFullTitlePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemIsParent"u8))
                {
                    itemIsParent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectableFilter"u8))
                {
                    selectableFilter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SwaggerCustomDynamicTreeParameterInfo> dictionary = new Dictionary<string, SwaggerCustomDynamicTreeParameterInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SwaggerCustomDynamicTreeParameterInfo.DeserializeSwaggerCustomDynamicTreeParameterInfo(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SwaggerCustomDynamicTreeCommand(operationId.Value, itemsPath.Value, itemValuePath.Value, itemTitlePath.Value, itemFullTitlePath.Value, itemIsParent.Value, selectableFilter.Value, Optional.ToDictionary(parameters), rawData);
        }

        SwaggerCustomDynamicTreeCommand IModelJsonSerializable<SwaggerCustomDynamicTreeCommand>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SwaggerCustomDynamicTreeCommand>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSwaggerCustomDynamicTreeCommand(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SwaggerCustomDynamicTreeCommand>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SwaggerCustomDynamicTreeCommand>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SwaggerCustomDynamicTreeCommand IModelSerializable<SwaggerCustomDynamicTreeCommand>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SwaggerCustomDynamicTreeCommand>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSwaggerCustomDynamicTreeCommand(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SwaggerCustomDynamicTreeCommand"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SwaggerCustomDynamicTreeCommand"/> to convert. </param>
        public static implicit operator RequestContent(SwaggerCustomDynamicTreeCommand model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SwaggerCustomDynamicTreeCommand"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SwaggerCustomDynamicTreeCommand(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSwaggerCustomDynamicTreeCommand(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
