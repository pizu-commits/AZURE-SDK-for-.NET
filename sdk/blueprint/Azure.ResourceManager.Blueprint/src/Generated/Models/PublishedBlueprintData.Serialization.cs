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
using Azure.ResourceManager.Blueprint.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Blueprint
{
    public partial class PublishedBlueprintData : IUtf8JsonSerializable, IModelJsonSerializable<PublishedBlueprintData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PublishedBlueprintData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PublishedBlueprintData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PublishedBlueprintData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(TargetScope))
            {
                writer.WritePropertyName("targetScope"u8);
                writer.WriteStringValue(TargetScope.Value.ToString());
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
                        ((IModelJsonSerializable<ParameterDefinition>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ResourceGroups))
            {
                writer.WritePropertyName("resourceGroups"u8);
                writer.WriteStartObject();
                foreach (var item in ResourceGroups)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ResourceGroupDefinition>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(BlueprintName))
            {
                writer.WritePropertyName("blueprintName"u8);
                writer.WriteStringValue(BlueprintName);
            }
            if (Optional.IsDefined(ChangeNotes))
            {
                writer.WritePropertyName("changeNotes"u8);
                writer.WriteStringValue(ChangeNotes);
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

        internal static PublishedBlueprintData DeserializePublishedBlueprintData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<BlueprintStatus> status = default;
            Optional<BlueprintTargetScope> targetScope = default;
            Optional<IDictionary<string, ParameterDefinition>> parameters = default;
            Optional<IDictionary<string, ResourceGroupDefinition>> resourceGroups = default;
            Optional<string> blueprintName = default;
            Optional<string> changeNotes = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = BlueprintStatus.DeserializeBlueprintStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetScope = new BlueprintTargetScope(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ParameterDefinition> dictionary = new Dictionary<string, ParameterDefinition>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ParameterDefinition.DeserializeParameterDefinition(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("resourceGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ResourceGroupDefinition> dictionary = new Dictionary<string, ResourceGroupDefinition>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ResourceGroupDefinition.DeserializeResourceGroupDefinition(property1.Value));
                            }
                            resourceGroups = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("blueprintName"u8))
                        {
                            blueprintName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("changeNotes"u8))
                        {
                            changeNotes = property0.Value.GetString();
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
            return new PublishedBlueprintData(id, name, type, systemData.Value, displayName.Value, description.Value, status.Value, Optional.ToNullable(targetScope), Optional.ToDictionary(parameters), Optional.ToDictionary(resourceGroups), blueprintName.Value, changeNotes.Value, rawData);
        }

        PublishedBlueprintData IModelJsonSerializable<PublishedBlueprintData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PublishedBlueprintData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePublishedBlueprintData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PublishedBlueprintData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PublishedBlueprintData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PublishedBlueprintData IModelSerializable<PublishedBlueprintData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PublishedBlueprintData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePublishedBlueprintData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PublishedBlueprintData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PublishedBlueprintData"/> to convert. </param>
        public static implicit operator RequestContent(PublishedBlueprintData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PublishedBlueprintData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PublishedBlueprintData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePublishedBlueprintData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
