// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationDetailPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AppliedScopeType))
            {
                writer.WritePropertyName("appliedScopeType");
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AppliedScopes))
            {
                writer.WritePropertyName("appliedScopes");
                writer.WriteStartArray();
                foreach (var item in AppliedScopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(InstanceFlexibility))
            {
                writer.WritePropertyName("instanceFlexibility");
                writer.WriteStringValue(InstanceFlexibility.Value.ToString());
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IsRenewEnabled))
            {
                writer.WritePropertyName("renew");
                writer.WriteBooleanValue(IsRenewEnabled.Value);
            }
            if (Optional.IsDefined(RenewProperties))
            {
                writer.WritePropertyName("renewProperties");
                writer.WriteObjectValue(RenewProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
