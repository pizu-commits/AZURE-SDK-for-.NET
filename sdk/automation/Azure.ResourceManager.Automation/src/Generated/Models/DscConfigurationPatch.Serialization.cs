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
    public partial class DscConfigurationPatch : IUtf8JsonSerializable, IModelJsonSerializable<DscConfigurationPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DscConfigurationPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DscConfigurationPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscConfigurationPatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IsLogVerboseEnabled))
            {
                writer.WritePropertyName("logVerbose"u8);
                writer.WriteBooleanValue(IsLogVerboseEnabled.Value);
            }
            if (Optional.IsDefined(IsLogProgressEnabled))
            {
                writer.WritePropertyName("logProgress"u8);
                writer.WriteBooleanValue(IsLogProgressEnabled.Value);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                if (Source is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AutomationContentSource>)Source).Serialize(writer, options);
                }
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
                        ((IModelJsonSerializable<DscConfigurationParameterDefinition>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        internal static DscConfigurationPatch DeserializeDscConfigurationPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<bool> logVerbose = default;
            Optional<bool> logProgress = default;
            Optional<AutomationContentSource> source = default;
            Optional<IDictionary<string, DscConfigurationParameterDefinition>> parameters = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("logVerbose"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logVerbose = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("logProgress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logProgress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = AutomationContentSource.DeserializeAutomationContentSource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, DscConfigurationParameterDefinition> dictionary = new Dictionary<string, DscConfigurationParameterDefinition>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, DscConfigurationParameterDefinition.DeserializeDscConfigurationParameterDefinition(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
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
            return new DscConfigurationPatch(name.Value, Optional.ToDictionary(tags), Optional.ToNullable(logVerbose), Optional.ToNullable(logProgress), source.Value, Optional.ToDictionary(parameters), description.Value, rawData);
        }

        DscConfigurationPatch IModelJsonSerializable<DscConfigurationPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscConfigurationPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDscConfigurationPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DscConfigurationPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscConfigurationPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DscConfigurationPatch IModelSerializable<DscConfigurationPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscConfigurationPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDscConfigurationPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DscConfigurationPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DscConfigurationPatch"/> to convert. </param>
        public static implicit operator RequestContent(DscConfigurationPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DscConfigurationPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DscConfigurationPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDscConfigurationPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
