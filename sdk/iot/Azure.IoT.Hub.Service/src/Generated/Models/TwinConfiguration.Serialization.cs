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

namespace Azure.IoT.Hub.Service.Models
{
    public partial class TwinConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<TwinConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TwinConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TwinConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TwinConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion"u8);
                writer.WriteStringValue(SchemaVersion);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartObject();
                foreach (var item in Labels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                if (Content is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConfigurationContent>)Content).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TargetCondition))
            {
                writer.WritePropertyName("targetCondition"u8);
                writer.WriteStringValue(TargetCondition);
            }
            if (Optional.IsDefined(CreatedTimeUtc))
            {
                writer.WritePropertyName("createdTimeUtc"u8);
                writer.WriteStringValue(CreatedTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(LastUpdatedTimeUtc))
            {
                writer.WritePropertyName("lastUpdatedTimeUtc"u8);
                writer.WriteStringValue(LastUpdatedTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(SystemMetrics))
            {
                writer.WritePropertyName("systemMetrics"u8);
                if (SystemMetrics is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConfigurationMetrics>)SystemMetrics).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                if (Metrics is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConfigurationMetrics>)Metrics).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(Etag);
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

        internal static TwinConfiguration DeserializeTwinConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> schemaVersion = default;
            Optional<IDictionary<string, string>> labels = default;
            Optional<ConfigurationContent> content = default;
            Optional<string> targetCondition = default;
            Optional<DateTimeOffset> createdTimeUtc = default;
            Optional<DateTimeOffset> lastUpdatedTimeUtc = default;
            Optional<int> priority = default;
            Optional<ConfigurationMetrics> systemMetrics = default;
            Optional<ConfigurationMetrics> metrics = default;
            Optional<string> etag = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaVersion"u8))
                {
                    schemaVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
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
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = ConfigurationContent.DeserializeConfigurationContent(property.Value);
                    continue;
                }
                if (property.NameEquals("targetCondition"u8))
                {
                    targetCondition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("systemMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemMetrics = ConfigurationMetrics.DeserializeConfigurationMetrics(property.Value);
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metrics = ConfigurationMetrics.DeserializeConfigurationMetrics(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TwinConfiguration(id.Value, schemaVersion.Value, Optional.ToDictionary(labels), content.Value, targetCondition.Value, Optional.ToNullable(createdTimeUtc), Optional.ToNullable(lastUpdatedTimeUtc), Optional.ToNullable(priority), systemMetrics.Value, metrics.Value, etag.Value, rawData);
        }

        TwinConfiguration IModelJsonSerializable<TwinConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TwinConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTwinConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TwinConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TwinConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TwinConfiguration IModelSerializable<TwinConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TwinConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTwinConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TwinConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TwinConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(TwinConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TwinConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TwinConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTwinConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
