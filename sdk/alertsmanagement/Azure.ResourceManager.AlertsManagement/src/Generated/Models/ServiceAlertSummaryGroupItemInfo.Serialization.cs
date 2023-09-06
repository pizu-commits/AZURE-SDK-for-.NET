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

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertSummaryGroupItemInfo : IUtf8JsonSerializable, IModelJsonSerializable<ServiceAlertSummaryGroupItemInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceAlertSummaryGroupItemInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceAlertSummaryGroupItemInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceAlertSummaryGroupItemInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(GroupedBy))
            {
                writer.WritePropertyName("groupedby"u8);
                writer.WriteStringValue(GroupedBy);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ServiceAlertSummaryGroupItemInfo>)item).Serialize(writer, options);
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

        internal static ServiceAlertSummaryGroupItemInfo DeserializeServiceAlertSummaryGroupItemInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<long> count = default;
            Optional<string> groupedby = default;
            Optional<IList<ServiceAlertSummaryGroupItemInfo>> values = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("groupedby"u8))
                {
                    groupedby = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAlertSummaryGroupItemInfo> array = new List<ServiceAlertSummaryGroupItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeServiceAlertSummaryGroupItemInfo(item));
                    }
                    values = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceAlertSummaryGroupItemInfo(name.Value, Optional.ToNullable(count), groupedby.Value, Optional.ToList(values), rawData);
        }

        ServiceAlertSummaryGroupItemInfo IModelJsonSerializable<ServiceAlertSummaryGroupItemInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceAlertSummaryGroupItemInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAlertSummaryGroupItemInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceAlertSummaryGroupItemInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceAlertSummaryGroupItemInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceAlertSummaryGroupItemInfo IModelSerializable<ServiceAlertSummaryGroupItemInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceAlertSummaryGroupItemInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceAlertSummaryGroupItemInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceAlertSummaryGroupItemInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceAlertSummaryGroupItemInfo"/> to convert. </param>
        public static implicit operator RequestContent(ServiceAlertSummaryGroupItemInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceAlertSummaryGroupItemInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceAlertSummaryGroupItemInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceAlertSummaryGroupItemInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
