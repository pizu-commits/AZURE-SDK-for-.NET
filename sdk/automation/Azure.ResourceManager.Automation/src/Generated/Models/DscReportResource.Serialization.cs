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
    public partial class DscReportResource : IUtf8JsonSerializable, IModelJsonSerializable<DscReportResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DscReportResource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DscReportResource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscReportResource>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(SourceInfo))
            {
                writer.WritePropertyName("sourceInfo"u8);
                writer.WriteStringValue(SourceInfo);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DscReportResourceNavigation>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ModuleName))
            {
                writer.WritePropertyName("moduleName"u8);
                writer.WriteStringValue(ModuleName);
            }
            if (Optional.IsDefined(ModuleVersion))
            {
                writer.WritePropertyName("moduleVersion"u8);
                writer.WriteStringValue(ModuleVersion);
            }
            if (Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resourceName"u8);
                writer.WriteStringValue(ResourceName);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteStringValue(Error);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(DurationInSeconds))
            {
                writer.WritePropertyName("durationInSeconds"u8);
                writer.WriteNumberValue(DurationInSeconds.Value);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartOn.Value, "O");
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

        internal static DscReportResource DeserializeDscReportResource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceId = default;
            Optional<string> sourceInfo = default;
            Optional<IReadOnlyList<DscReportResourceNavigation>> dependsOn = default;
            Optional<string> moduleName = default;
            Optional<string> moduleVersion = default;
            Optional<string> resourceName = default;
            Optional<string> error = default;
            Optional<string> status = default;
            Optional<double> durationInSeconds = default;
            Optional<DateTimeOffset> startDate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceInfo"u8))
                {
                    sourceInfo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DscReportResourceNavigation> array = new List<DscReportResourceNavigation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscReportResourceNavigation.DeserializeDscReportResourceNavigation(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("moduleName"u8))
                {
                    moduleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleVersion"u8))
                {
                    moduleVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("durationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInSeconds = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DscReportResource(resourceId.Value, sourceInfo.Value, Optional.ToList(dependsOn), moduleName.Value, moduleVersion.Value, resourceName.Value, error.Value, status.Value, Optional.ToNullable(durationInSeconds), Optional.ToNullable(startDate), rawData);
        }

        DscReportResource IModelJsonSerializable<DscReportResource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscReportResource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDscReportResource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DscReportResource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscReportResource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DscReportResource IModelSerializable<DscReportResource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DscReportResource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDscReportResource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DscReportResource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DscReportResource"/> to convert. </param>
        public static implicit operator RequestContent(DscReportResource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DscReportResource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DscReportResource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDscReportResource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
