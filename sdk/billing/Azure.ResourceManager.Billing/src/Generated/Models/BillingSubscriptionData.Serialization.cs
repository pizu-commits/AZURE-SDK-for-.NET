// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Billing.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing
{
    public partial class BillingSubscriptionData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AutoRenew))
            {
                writer.WritePropertyName("autoRenew"u8);
                writer.WriteStringValue(AutoRenew.Value.ToString());
            }
            if (Core.Optional.IsDefined(BeneficiaryTenantId))
            {
                writer.WritePropertyName("beneficiaryTenantId"u8);
                writer.WriteStringValue(BeneficiaryTenantId);
            }
            if (Core.Optional.IsDefined(BillingFrequency))
            {
                writer.WritePropertyName("billingFrequency"u8);
                writer.WriteStringValue(BillingFrequency);
            }
            if (Core.Optional.IsDefined(BillingProfileId))
            {
                writer.WritePropertyName("billingProfileId"u8);
                writer.WriteStringValue(BillingProfileId);
            }
            if (Core.Optional.IsDefined(ConsumptionCostCenter))
            {
                writer.WritePropertyName("consumptionCostCenter"u8);
                writer.WriteStringValue(ConsumptionCostCenter);
            }
            if (Core.Optional.IsDefined(CustomerId))
            {
                writer.WritePropertyName("customerId"u8);
                writer.WriteStringValue(CustomerId);
            }
            if (Core.Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Core.Optional.IsDefined(InvoiceSectionId))
            {
                writer.WritePropertyName("invoiceSectionId"u8);
                writer.WriteStringValue(InvoiceSectionId);
            }
            if (Core.Optional.IsDefined(ProductTypeId))
            {
                writer.WritePropertyName("productTypeId"u8);
                writer.WriteStringValue(ProductTypeId);
            }
            if (Core.Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (Core.Optional.IsDefined(SkuId))
            {
                writer.WritePropertyName("skuId"u8);
                writer.WriteStringValue(SkuId);
            }
            if (Core.Optional.IsDefined(TermDuration))
            {
                writer.WritePropertyName("termDuration"u8);
                writer.WriteStringValue(TermDuration.Value, "P");
            }
            writer.WritePropertyName("enrollmentAccountSubscriptionDetails"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BillingSubscriptionData DeserializeBillingSubscriptionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<BillingSubscriptionAutoRenewState> autoRenew = default;
            Core.Optional<string> beneficiaryTenantId = default;
            Core.Optional<string> billingFrequency = default;
            Core.Optional<ResourceIdentifier> billingProfileId = default;
            Core.Optional<IReadOnlyDictionary<string, string>> billingPolicies = default;
            Core.Optional<string> billingProfileDisplayName = default;
            Core.Optional<string> billingProfileName = default;
            Core.Optional<string> consumptionCostCenter = default;
            Core.Optional<string> customerId = default;
            Core.Optional<string> customerDisplayName = default;
            Core.Optional<string> displayName = default;
            Core.Optional<string> enrollmentAccountId = default;
            Core.Optional<string> enrollmentAccountDisplayName = default;
            Core.Optional<ResourceIdentifier> invoiceSectionId = default;
            Core.Optional<string> invoiceSectionDisplayName = default;
            Core.Optional<string> invoiceSectionName = default;
            Core.Optional<BillingAmount> lastMonthCharges = default;
            Core.Optional<BillingAmount> monthToDateCharges = default;
            Core.Optional<NextBillingCycleDetails> nextBillingCycleDetails = default;
            Core.Optional<string> offerId = default;
            Core.Optional<string> productCategory = default;
            Core.Optional<string> productType = default;
            Core.Optional<string> productTypeId = default;
            Core.Optional<DateTimeOffset> purchaseDate = default;
            Core.Optional<long> quantity = default;
            Core.Optional<CreatedSubscriptionReseller> reseller = default;
            Core.Optional<SubscriptionRenewalTermDetails> renewalTermDetails = default;
            Core.Optional<string> skuDescription = default;
            Core.Optional<string> skuId = default;
            Core.Optional<BillingSubscriptionStatus> status = default;
            Core.Optional<string> subscriptionId = default;
            Core.Optional<IReadOnlyList<string>> suspensionReasons = default;
            Core.Optional<TimeSpan> termDuration = default;
            Core.Optional<DateTimeOffset> termStartDate = default;
            Core.Optional<DateTimeOffset> termEndDate = default;
            Core.Optional<SubscriptionEnrollmentAccountStatus> subscriptionEnrollmentAccountStatus = default;
            Core.Optional<DateTimeOffset> enrollmentAccountStartDate = default;
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
                        if (property0.NameEquals("autoRenew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoRenew = new BillingSubscriptionAutoRenewState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("beneficiaryTenantId"u8))
                        {
                            beneficiaryTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingFrequency"u8))
                        {
                            billingFrequency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingProfileId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingPolicies"u8))
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
                            billingPolicies = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("billingProfileDisplayName"u8))
                        {
                            billingProfileDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileName"u8))
                        {
                            billingProfileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consumptionCostCenter"u8))
                        {
                            consumptionCostCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customerId"u8))
                        {
                            customerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customerDisplayName"u8))
                        {
                            customerDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enrollmentAccountId"u8))
                        {
                            enrollmentAccountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enrollmentAccountDisplayName"u8))
                        {
                            enrollmentAccountDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            invoiceSectionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionDisplayName"u8))
                        {
                            invoiceSectionDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionName"u8))
                        {
                            invoiceSectionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastMonthCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastMonthCharges = BillingAmount.DeserializeBillingAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("monthToDateCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monthToDateCharges = BillingAmount.DeserializeBillingAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("nextBillingCycleDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextBillingCycleDetails = NextBillingCycleDetails.DeserializeNextBillingCycleDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("offerId"u8))
                        {
                            offerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productCategory"u8))
                        {
                            productCategory = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productType"u8))
                        {
                            productType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productTypeId"u8))
                        {
                            productTypeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchaseDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchaseDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quantity = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("reseller"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reseller = CreatedSubscriptionReseller.DeserializeCreatedSubscriptionReseller(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("renewalTermDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            renewalTermDetails = SubscriptionRenewalTermDetails.DeserializeSubscriptionRenewalTermDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("skuDescription"u8))
                        {
                            skuDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("skuId"u8))
                        {
                            skuId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new BillingSubscriptionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"u8))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("suspensionReasons"u8))
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
                            suspensionReasons = array;
                            continue;
                        }
                        if (property0.NameEquals("termDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            termDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("termStartDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            termStartDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("termEndDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            termEndDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("enrollmentAccountSubscriptionDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("subscriptionEnrollmentAccountStatus"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    subscriptionEnrollmentAccountStatus = new SubscriptionEnrollmentAccountStatus(property1.Value.GetString());
                                    continue;
                                }
                                if (property1.NameEquals("enrollmentAccountStartDate"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    enrollmentAccountStartDate = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BillingSubscriptionData(id, name, type, systemData.Value, Core.Optional.ToNullable(autoRenew), beneficiaryTenantId.Value, billingFrequency.Value, billingProfileId.Value, Core.Optional.ToDictionary(billingPolicies), billingProfileDisplayName.Value, billingProfileName.Value, consumptionCostCenter.Value, customerId.Value, customerDisplayName.Value, displayName.Value, enrollmentAccountId.Value, enrollmentAccountDisplayName.Value, invoiceSectionId.Value, invoiceSectionDisplayName.Value, invoiceSectionName.Value, lastMonthCharges.Value, monthToDateCharges.Value, nextBillingCycleDetails.Value, offerId.Value, productCategory.Value, productType.Value, productTypeId.Value, Core.Optional.ToNullable(purchaseDate), Core.Optional.ToNullable(quantity), reseller.Value, renewalTermDetails.Value, skuDescription.Value, skuId.Value, Core.Optional.ToNullable(status), subscriptionId.Value, Core.Optional.ToList(suspensionReasons), Core.Optional.ToNullable(termDuration), Core.Optional.ToNullable(termStartDate), Core.Optional.ToNullable(termEndDate), Core.Optional.ToNullable(subscriptionEnrollmentAccountStatus), Core.Optional.ToNullable(enrollmentAccountStartDate));
        }
    }
}
