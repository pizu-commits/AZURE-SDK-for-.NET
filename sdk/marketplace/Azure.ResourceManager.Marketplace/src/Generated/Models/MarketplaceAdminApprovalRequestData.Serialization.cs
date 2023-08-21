// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    public partial class MarketplaceAdminApprovalRequestData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
            }
            if (Core.Optional.IsDefined(PublisherId))
            {
                writer.WritePropertyName("publisherId"u8);
                writer.WriteStringValue(PublisherId);
            }
            if (Core.Optional.IsDefined(AdminAction))
            {
                writer.WritePropertyName("adminAction"u8);
                writer.WriteStringValue(AdminAction.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(ApprovedPlans))
            {
                writer.WritePropertyName("approvedPlans"u8);
                writer.WriteStartArray();
                foreach (var item in ApprovedPlans)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(Comment))
            {
                writer.WritePropertyName("comment"u8);
                writer.WriteStringValue(Comment);
            }
            if (Core.Optional.IsDefined(Administrator))
            {
                writer.WritePropertyName("administrator"u8);
                writer.WriteStringValue(Administrator);
            }
            if (Core.Optional.IsCollectionDefined(CollectionIds))
            {
                writer.WritePropertyName("collectionIds"u8);
                writer.WriteStartArray();
                foreach (var item in CollectionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MarketplaceAdminApprovalRequestData DeserializeMarketplaceAdminApprovalRequestData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> offerId = default;
            Core.Optional<string> displayName = default;
            Core.Optional<string> publisherId = default;
            Core.Optional<MarketplaceAdminAction> adminAction = default;
            Core.Optional<IList<string>> approvedPlans = default;
            Core.Optional<string> comment = default;
            Core.Optional<string> administrator = default;
            Core.Optional<IReadOnlyList<PlanRequesterDetails>> plans = default;
            Core.Optional<IList<Guid>> collectionIds = default;
            Core.Optional<Uri> icon = default;
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
                        if (property0.NameEquals("offerId"u8))
                        {
                            offerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherId"u8))
                        {
                            publisherId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("adminAction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adminAction = new MarketplaceAdminAction(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("approvedPlans"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            approvedPlans = array;
                            continue;
                        }
                        if (property0.NameEquals("comment"u8))
                        {
                            comment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administrator"u8))
                        {
                            administrator = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("plans"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PlanRequesterDetails> array = new List<PlanRequesterDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PlanRequesterDetails.DeserializePlanRequesterDetails(item));
                            }
                            plans = array;
                            continue;
                        }
                        if (property0.NameEquals("collectionIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Guid> array = new List<Guid>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetGuid());
                            }
                            collectionIds = array;
                            continue;
                        }
                        if (property0.NameEquals("icon"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            icon = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MarketplaceAdminApprovalRequestData(id, name, type, systemData.Value, offerId.Value, displayName.Value, publisherId.Value, Core.Optional.ToNullable(adminAction), Core.Optional.ToList(approvedPlans), comment.Value, administrator.Value, Core.Optional.ToList(plans), Core.Optional.ToList(collectionIds), icon.Value);
        }
    }
}
