// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BillingBenefits
{
    public partial class BillingBenefitsSavingsPlanData : IUtf8JsonSerializable, IJsonModel<BillingBenefitsSavingsPlanData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingBenefitsSavingsPlanData>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<BillingBenefitsSavingsPlanData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DisplayProvisioningState))
                {
                    writer.WritePropertyName("displayProvisioningState"u8);
                    writer.WriteStringValue(DisplayProvisioningState);
                }
            }
            if (Optional.IsDefined(BillingScopeId))
            {
                writer.WritePropertyName("billingScopeId"u8);
                writer.WriteStringValue(BillingScopeId);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(BillingProfileId))
                {
                    writer.WritePropertyName("billingProfileId"u8);
                    writer.WriteStringValue(BillingProfileId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CustomerId))
                {
                    writer.WritePropertyName("customerId"u8);
                    writer.WriteStringValue(CustomerId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(BillingAccountId))
                {
                    writer.WritePropertyName("billingAccountId"u8);
                    writer.WriteStringValue(BillingAccountId);
                }
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
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(UserFriendlyAppliedScopeType))
                {
                    writer.WritePropertyName("userFriendlyAppliedScopeType"u8);
                    writer.WriteStringValue(UserFriendlyAppliedScopeType);
                }
            }
            if (Optional.IsDefined(AppliedScopeProperties))
            {
                writer.WritePropertyName("appliedScopeProperties"u8);
                writer.WriteObjectValue(AppliedScopeProperties);
            }
            if (Optional.IsDefined(Commitment))
            {
                writer.WritePropertyName("commitment"u8);
                writer.WriteObjectValue(Commitment);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(EffectOn))
                {
                    writer.WritePropertyName("effectiveDateTime"u8);
                    writer.WriteStringValue(EffectOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ExpireOn))
                {
                    writer.WritePropertyName("expiryDateTime"u8);
                    writer.WriteStringValue(ExpireOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PurchaseOn))
                {
                    writer.WritePropertyName("purchaseDateTime"u8);
                    writer.WriteStringValue(PurchaseOn.Value, "O");
                }
            }
            if (Optional.IsDefined(BenefitStartOn))
            {
                writer.WritePropertyName("benefitStartTime"u8);
                writer.WriteStringValue(BenefitStartOn.Value, "O");
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ExtendedStatusInfo))
                {
                    writer.WritePropertyName("extendedStatusInfo"u8);
                    writer.WriteObjectValue(ExtendedStatusInfo);
                }
            }
            if (Optional.IsDefined(IsRenewed))
            {
                writer.WritePropertyName("renew"u8);
                writer.WriteBooleanValue(IsRenewed.Value);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Utilization))
                {
                    writer.WritePropertyName("utilization"u8);
                    writer.WriteObjectValue(Utilization);
                }
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
                writer.WriteObjectValue(RenewProperties);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        BillingBenefitsSavingsPlanData IJsonModel<BillingBenefitsSavingsPlanData>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsSavingsPlanData(document.RootElement, options);
        }

        internal static BillingBenefitsSavingsPlanData DeserializeBillingBenefitsSavingsPlanData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

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
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BillingBenefitsSavingsPlanData(id, name, type, systemData.Value, sku, displayName.Value, Optional.ToNullable(provisioningState), displayProvisioningState.Value, billingScopeId.Value, billingProfileId.Value, customerId.Value, billingAccountId.Value, Optional.ToNullable(term), Optional.ToNullable(billingPlan), Optional.ToNullable(appliedScopeType), userFriendlyAppliedScopeType.Value, appliedScopeProperties.Value, commitment.Value, Optional.ToNullable(effectiveDateTime), Optional.ToNullable(expiryDateTime), Optional.ToNullable(purchaseDateTime), Optional.ToNullable(benefitStartTime), extendedStatusInfo.Value, Optional.ToNullable(renew), utilization.Value, renewSource.Value, renewDestination.Value, renewProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<BillingBenefitsSavingsPlanData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BillingBenefitsSavingsPlanData IModel<BillingBenefitsSavingsPlanData>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBillingBenefitsSavingsPlanData(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<BillingBenefitsSavingsPlanData>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
