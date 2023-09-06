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

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleEligibilityScheduleRequestPropertiesTicketInfo : IUtf8JsonSerializable, IModelJsonSerializable<RoleEligibilityScheduleRequestPropertiesTicketInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RoleEligibilityScheduleRequestPropertiesTicketInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RoleEligibilityScheduleRequestPropertiesTicketInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleEligibilityScheduleRequestPropertiesTicketInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TicketNumber))
            {
                writer.WritePropertyName("ticketNumber"u8);
                writer.WriteStringValue(TicketNumber);
            }
            if (Optional.IsDefined(TicketSystem))
            {
                writer.WritePropertyName("ticketSystem"u8);
                writer.WriteStringValue(TicketSystem);
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

        internal static RoleEligibilityScheduleRequestPropertiesTicketInfo DeserializeRoleEligibilityScheduleRequestPropertiesTicketInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ticketNumber = default;
            Optional<string> ticketSystem = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ticketNumber"u8))
                {
                    ticketNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ticketSystem"u8))
                {
                    ticketSystem = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RoleEligibilityScheduleRequestPropertiesTicketInfo(ticketNumber.Value, ticketSystem.Value, rawData);
        }

        RoleEligibilityScheduleRequestPropertiesTicketInfo IModelJsonSerializable<RoleEligibilityScheduleRequestPropertiesTicketInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleEligibilityScheduleRequestPropertiesTicketInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleEligibilityScheduleRequestPropertiesTicketInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RoleEligibilityScheduleRequestPropertiesTicketInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleEligibilityScheduleRequestPropertiesTicketInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RoleEligibilityScheduleRequestPropertiesTicketInfo IModelSerializable<RoleEligibilityScheduleRequestPropertiesTicketInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleEligibilityScheduleRequestPropertiesTicketInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRoleEligibilityScheduleRequestPropertiesTicketInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RoleEligibilityScheduleRequestPropertiesTicketInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RoleEligibilityScheduleRequestPropertiesTicketInfo"/> to convert. </param>
        public static implicit operator RequestContent(RoleEligibilityScheduleRequestPropertiesTicketInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RoleEligibilityScheduleRequestPropertiesTicketInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RoleEligibilityScheduleRequestPropertiesTicketInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRoleEligibilityScheduleRequestPropertiesTicketInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
