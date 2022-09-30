// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ReservationTransaction
    {
        internal static ReservationTransaction DeserializeReservationTransaction(JsonElement element)
        {
            Optional<IReadOnlyList<string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> eventDate = default;
            Optional<string> reservationOrderId = default;
            Optional<string> description = default;
            Optional<string> eventType = default;
            Optional<decimal> quantity = default;
            Optional<decimal> amount = default;
            Optional<string> currency = default;
            Optional<string> reservationOrderName = default;
            Optional<string> purchasingEnrollment = default;
            Optional<Guid> purchasingSubscriptionGuid = default;
            Optional<string> purchasingSubscriptionName = default;
            Optional<string> armSkuName = default;
            Optional<string> term = default;
            Optional<string> region = default;
            Optional<string> accountName = default;
            Optional<string> accountOwnerEmail = default;
            Optional<string> departmentName = default;
            Optional<string> costCenter = default;
            Optional<string> currentEnrollment = default;
            Optional<string> billingFrequency = default;
            Optional<int> billingMonth = default;
            Optional<decimal> monetaryCommitment = default;
            Optional<decimal> overage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("eventDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            eventDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("reservationOrderId"))
                        {
                            reservationOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eventType"))
                        {
                            eventType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("quantity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            quantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("amount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            amount = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("currency"))
                        {
                            currency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationOrderName"))
                        {
                            reservationOrderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasingEnrollment"))
                        {
                            purchasingEnrollment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasingSubscriptionGuid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            purchasingSubscriptionGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("purchasingSubscriptionName"))
                        {
                            purchasingSubscriptionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("armSkuName"))
                        {
                            armSkuName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("term"))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("region"))
                        {
                            region = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountName"))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountOwnerEmail"))
                        {
                            accountOwnerEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("departmentName"))
                        {
                            departmentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costCenter"))
                        {
                            costCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentEnrollment"))
                        {
                            currentEnrollment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingFrequency"))
                        {
                            billingFrequency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingMonth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingMonth = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("monetaryCommitment"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            monetaryCommitment = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("overage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            overage = property0.Value.GetDecimal();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ReservationTransaction(id, name, type, systemData.Value, Optional.ToNullable(eventDate), reservationOrderId.Value, description.Value, eventType.Value, Optional.ToNullable(quantity), Optional.ToNullable(amount), currency.Value, reservationOrderName.Value, purchasingEnrollment.Value, Optional.ToNullable(purchasingSubscriptionGuid), purchasingSubscriptionName.Value, armSkuName.Value, term.Value, region.Value, accountName.Value, accountOwnerEmail.Value, departmentName.Value, costCenter.Value, currentEnrollment.Value, billingFrequency.Value, Optional.ToNullable(billingMonth), Optional.ToNullable(monetaryCommitment), Optional.ToNullable(overage), Optional.ToList(tags));
        }
    }
}
