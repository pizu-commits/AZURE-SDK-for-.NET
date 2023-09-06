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
using Azure.ResourceManager.BillingBenefits.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BillingBenefits
{
    public partial class BillingBenefitsSavingsPlanData : IUtf8JsonSerializable, IModelJsonSerializable<BillingBenefitsSavingsPlanData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BillingBenefitsSavingsPlanData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BillingBenefitsSavingsPlanData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingBenefitsSavingsPlanData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            if (Sku is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<BillingBenefitsSku>)Sku).Serialize(writer, options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(BillingScopeId))
            {
                writer.WritePropertyName("billingScopeId"u8);
                writer.WriteStringValue(BillingScopeId);
            }
            if (Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (Optional.IsDefined(BillingPlan))
            {
                writer.WritePropertyName("billingPlan"u8);
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (Optional.IsDefined(AppliedScopeType))
            {
                writer.WritePropertyName("appliedScopeType"u8);
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (Optional.IsDefined(AppliedScopeProperties))
            {
                writer.WritePropertyName("appliedScopeProperties"u8);
                if (AppliedScopeProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BillingBenefitsAppliedScopeProperties>)AppliedScopeProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Commitment))
            {
                writer.WritePropertyName("commitment"u8);
                if (Commitment is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BillingBenefitsCommitment>)Commitment).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(BenefitStartOn))
            {
                writer.WritePropertyName("benefitStartTime"u8);
                writer.WriteStringValue(BenefitStartOn.Value, "O");
            }
            if (Optional.IsDefined(IsRenewed))
            {
                writer.WritePropertyName("renew"u8);
                writer.WriteBooleanValue(IsRenewed.Value);
            }
            if (Optional.IsDefined(RenewSource))
            {
                writer.WritePropertyName("renewSource"u8);
                writer.WriteStringValue(RenewSource);
            }
            if (Optional.IsDefined(RenewDestination))
            {
                writer.WritePropertyName("renewDestination"u8);
                writer.WriteStringValue(RenewDestination);
            }
            if (Optional.IsDefined(RenewProperties))
            {
                writer.WritePropertyName("renewProperties"u8);
                if (RenewProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RenewProperties>)RenewProperties).Serialize(writer, options);
                }
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

        internal static BillingBenefitsSavingsPlanData DeserializeBillingBenefitsSavingsPlanData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingBenefitsSku sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<BillingBenefitsProvisioningState> provisioningState = default;
            Optional<string> displayProvisioningState = default;
            Optional<ResourceIdentifier> billingScopeId = default;
            Optional<ResourceIdentifier> billingProfileId = default;
            Optional<string> customerId = default;
            Optional<ResourceIdentifier> billingAccountId = default;
            Optional<BillingBenefitsTerm> term = default;
            Optional<BillingBenefitsBillingPlan> billingPlan = default;
            Optional<BillingBenefitsAppliedScopeType> appliedScopeType = default;
            Optional<string> userFriendlyAppliedScopeType = default;
            Optional<BillingBenefitsAppliedScopeProperties> appliedScopeProperties = default;
            Optional<BillingBenefitsCommitment> commitment = default;
            Optional<DateTimeOffset> effectiveDateTime = default;
            Optional<DateTimeOffset> expiryDateTime = default;
            Optional<DateTimeOffset> purchaseDateTime = default;
            Optional<DateTimeOffset> benefitStartTime = default;
            Optional<BillingBenefitsExtendedStatusInfo> extendedStatusInfo = default;
            Optional<bool> renew = default;
            Optional<BillingBenefitsSavingsPlanUtilization> utilization = default;
            Optional<string> renewSource = default;
            Optional<string> renewDestination = default;
            Optional<RenewProperties> renewProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = BillingBenefitsSku.DeserializeBillingBenefitsSku(property.Value);
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new BillingBenefitsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayProvisioningState"u8))
                        {
                            displayProvisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingScopeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingScopeId = new ResourceIdentifier(property0.Value.GetString());
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
                        if (property0.NameEquals("customerId"u8))
                        {
                            customerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingAccountId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingAccountId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            term = new BillingBenefitsTerm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingPlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingPlan = new BillingBenefitsBillingPlan(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeType = new BillingBenefitsAppliedScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userFriendlyAppliedScopeType"u8))
                        {
                            userFriendlyAppliedScopeType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeProperties = BillingBenefitsAppliedScopeProperties.DeserializeBillingBenefitsAppliedScopeProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("commitment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            commitment = BillingBenefitsCommitment.DeserializeBillingBenefitsCommitment(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("effectiveDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            effectiveDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expiryDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiryDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("purchaseDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchaseDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("benefitStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            benefitStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("extendedStatusInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            extendedStatusInfo = BillingBenefitsExtendedStatusInfo.DeserializeBillingBenefitsExtendedStatusInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("renew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            renew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("utilization"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            utilization = BillingBenefitsSavingsPlanUtilization.DeserializeBillingBenefitsSavingsPlanUtilization(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("renewSource"u8))
                        {
                            renewSource = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("renewDestination"u8))
                        {
                            renewDestination = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("renewProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            renewProperties = RenewProperties.DeserializeRenewProperties(property0.Value);
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
            return new BillingBenefitsSavingsPlanData(id, name, type, systemData.Value, sku, displayName.Value, Optional.ToNullable(provisioningState), displayProvisioningState.Value, billingScopeId.Value, billingProfileId.Value, customerId.Value, billingAccountId.Value, Optional.ToNullable(term), Optional.ToNullable(billingPlan), Optional.ToNullable(appliedScopeType), userFriendlyAppliedScopeType.Value, appliedScopeProperties.Value, commitment.Value, Optional.ToNullable(effectiveDateTime), Optional.ToNullable(expiryDateTime), Optional.ToNullable(purchaseDateTime), Optional.ToNullable(benefitStartTime), extendedStatusInfo.Value, Optional.ToNullable(renew), utilization.Value, renewSource.Value, renewDestination.Value, renewProperties.Value, rawData);
        }

        BillingBenefitsSavingsPlanData IModelJsonSerializable<BillingBenefitsSavingsPlanData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingBenefitsSavingsPlanData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsSavingsPlanData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BillingBenefitsSavingsPlanData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingBenefitsSavingsPlanData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BillingBenefitsSavingsPlanData IModelSerializable<BillingBenefitsSavingsPlanData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingBenefitsSavingsPlanData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBillingBenefitsSavingsPlanData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BillingBenefitsSavingsPlanData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BillingBenefitsSavingsPlanData"/> to convert. </param>
        public static implicit operator RequestContent(BillingBenefitsSavingsPlanData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BillingBenefitsSavingsPlanData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BillingBenefitsSavingsPlanData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBillingBenefitsSavingsPlanData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
