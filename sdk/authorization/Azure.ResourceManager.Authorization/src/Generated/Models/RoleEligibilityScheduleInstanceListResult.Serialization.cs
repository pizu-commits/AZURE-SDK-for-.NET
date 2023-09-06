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
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    internal partial class RoleEligibilityScheduleInstanceListResult : IUtf8JsonSerializable, IModelJsonSerializable<RoleEligibilityScheduleInstanceListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RoleEligibilityScheduleInstanceListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RoleEligibilityScheduleInstanceListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleEligibilityScheduleInstanceListResult>(this, options.Format);

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
                        ((IModelJsonSerializable<RoleEligibilityScheduleInstanceData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static RoleEligibilityScheduleInstanceListResult DeserializeRoleEligibilityScheduleInstanceListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RoleEligibilityScheduleInstanceData>> value = default;
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
                    List<RoleEligibilityScheduleInstanceData> array = new List<RoleEligibilityScheduleInstanceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleEligibilityScheduleInstanceData.DeserializeRoleEligibilityScheduleInstanceData(item));
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
            return new RoleEligibilityScheduleInstanceListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        RoleEligibilityScheduleInstanceListResult IModelJsonSerializable<RoleEligibilityScheduleInstanceListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleEligibilityScheduleInstanceListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleEligibilityScheduleInstanceListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RoleEligibilityScheduleInstanceListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleEligibilityScheduleInstanceListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RoleEligibilityScheduleInstanceListResult IModelSerializable<RoleEligibilityScheduleInstanceListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleEligibilityScheduleInstanceListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRoleEligibilityScheduleInstanceListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RoleEligibilityScheduleInstanceListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RoleEligibilityScheduleInstanceListResult"/> to convert. </param>
        public static implicit operator RequestContent(RoleEligibilityScheduleInstanceListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RoleEligibilityScheduleInstanceListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RoleEligibilityScheduleInstanceListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRoleEligibilityScheduleInstanceListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
