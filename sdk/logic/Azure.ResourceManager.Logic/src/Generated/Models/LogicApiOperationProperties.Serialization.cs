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
    public partial class LogicApiOperationProperties : IUtf8JsonSerializable, IModelJsonSerializable<LogicApiOperationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogicApiOperationProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogicApiOperationProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility"u8);
                writer.WriteStringValue(Visibility);
            }
            if (Optional.IsDefined(Trigger))
            {
                writer.WritePropertyName("trigger"u8);
                writer.WriteStringValue(Trigger);
            }
            if (Optional.IsDefined(TriggerHint))
            {
                writer.WritePropertyName("triggerHint"u8);
                writer.WriteStringValue(TriggerHint);
            }
            if (Optional.IsDefined(IsPageable))
            {
                writer.WritePropertyName("pageable"u8);
                writer.WriteBooleanValue(IsPageable.Value);
            }
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                if (Annotation is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LogicApiOperationAnnotation>)Annotation).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Api))
            {
                writer.WritePropertyName("api"u8);
                if (Api is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LogicApiReference>)Api).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(InputsDefinition))
            {
                writer.WritePropertyName("inputsDefinition"u8);
                if (InputsDefinition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SwaggerSchema>)InputsDefinition).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(ResponsesDefinition))
            {
                writer.WritePropertyName("responsesDefinition"u8);
                writer.WriteStartObject();
                foreach (var item in ResponsesDefinition)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SwaggerSchema>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(IsWebhook))
            {
                writer.WritePropertyName("isWebhook"u8);
                writer.WriteBooleanValue(IsWebhook.Value);
            }
            if (Optional.IsDefined(IsNotification))
            {
                writer.WritePropertyName("isNotification"u8);
                writer.WriteBooleanValue(IsNotification.Value);
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

        internal static LogicApiOperationProperties DeserializeLogicApiOperationProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> summary = default;
            Optional<string> description = default;
            Optional<string> visibility = default;
            Optional<string> trigger = default;
            Optional<string> triggerHint = default;
            Optional<bool> pageable = default;
            Optional<LogicApiOperationAnnotation> annotation = default;
            Optional<LogicApiReference> api = default;
            Optional<SwaggerSchema> inputsDefinition = default;
            Optional<IDictionary<string, SwaggerSchema>> responsesDefinition = default;
            Optional<bool> isWebhook = default;
            Optional<bool> isNotification = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("visibility"u8))
                {
                    visibility = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trigger"u8))
                {
                    trigger = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerHint"u8))
                {
                    triggerHint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pageable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pageable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("annotation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    annotation = LogicApiOperationAnnotation.DeserializeLogicApiOperationAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("api"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    api = LogicApiReference.DeserializeLogicApiReference(property.Value);
                    continue;
                }
                if (property.NameEquals("inputsDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inputsDefinition = SwaggerSchema.DeserializeSwaggerSchema(property.Value);
                    continue;
                }
                if (property.NameEquals("responsesDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SwaggerSchema> dictionary = new Dictionary<string, SwaggerSchema>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SwaggerSchema.DeserializeSwaggerSchema(property0.Value));
                    }
                    responsesDefinition = dictionary;
                    continue;
                }
                if (property.NameEquals("isWebhook"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWebhook = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNotification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isNotification = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogicApiOperationProperties(summary.Value, description.Value, visibility.Value, trigger.Value, triggerHint.Value, Optional.ToNullable(pageable), annotation.Value, api.Value, inputsDefinition.Value, Optional.ToDictionary(responsesDefinition), Optional.ToNullable(isWebhook), Optional.ToNullable(isNotification), rawData);
        }

        LogicApiOperationProperties IModelJsonSerializable<LogicApiOperationProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiOperationProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogicApiOperationProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogicApiOperationProperties IModelSerializable<LogicApiOperationProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogicApiOperationProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LogicApiOperationProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LogicApiOperationProperties"/> to convert. </param>
        public static implicit operator RequestContent(LogicApiOperationProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LogicApiOperationProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LogicApiOperationProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogicApiOperationProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
