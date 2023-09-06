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
    public partial class DscCompilationJobCreateOrUpdateContent : IUtf8JsonSerializable, IModelJsonSerializable<DscCompilationJobCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DscCompilationJobCreateOrUpdateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DscCompilationJobCreateOrUpdateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscCompilationJobCreateOrUpdateContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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
            writer.WritePropertyName("configuration"u8);
            if (Configuration is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DscConfigurationAssociationProperty>)Configuration).Serialize(writer, options);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(IsIncrementNodeConfigurationBuildRequired))
            {
                writer.WritePropertyName("incrementNodeConfigurationBuild"u8);
                writer.WriteBooleanValue(IsIncrementNodeConfigurationBuildRequired.Value);
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

        internal static DscCompilationJobCreateOrUpdateContent DeserializeDscCompilationJobCreateOrUpdateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            DscConfigurationAssociationProperty configuration = default;
            Optional<IDictionary<string, string>> parameters = default;
            Optional<bool> incrementNodeConfigurationBuild = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("configuration"u8))
                        {
                            configuration = DscConfigurationAssociationProperty.DeserializeDscConfigurationAssociationProperty(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("incrementNodeConfigurationBuild"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            incrementNodeConfigurationBuild = property0.Value.GetBoolean();
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
            return new DscCompilationJobCreateOrUpdateContent(name.Value, Optional.ToNullable(location), Optional.ToDictionary(tags), configuration, Optional.ToDictionary(parameters), Optional.ToNullable(incrementNodeConfigurationBuild), rawData);
        }

        DscCompilationJobCreateOrUpdateContent IModelJsonSerializable<DscCompilationJobCreateOrUpdateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscCompilationJobCreateOrUpdateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDscCompilationJobCreateOrUpdateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DscCompilationJobCreateOrUpdateContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscCompilationJobCreateOrUpdateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DscCompilationJobCreateOrUpdateContent IModelSerializable<DscCompilationJobCreateOrUpdateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscCompilationJobCreateOrUpdateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDscCompilationJobCreateOrUpdateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DscCompilationJobCreateOrUpdateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DscCompilationJobCreateOrUpdateContent"/> to convert. </param>
        public static implicit operator RequestContent(DscCompilationJobCreateOrUpdateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DscCompilationJobCreateOrUpdateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DscCompilationJobCreateOrUpdateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDscCompilationJobCreateOrUpdateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
