// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Quota;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmQuotaModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Quota.CurrentUsagesBaseData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Usage properties for the specified resource. </param>
        /// <returns> A new <see cref="Quota.CurrentUsagesBaseData"/> instance for mocking. </returns>
        public static CurrentUsagesBaseData CurrentUsagesBaseData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, QuotaUsagesProperties properties = null)
        {
            return new CurrentUsagesBaseData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaUsagesProperties"/>. </summary>
        /// <param name="usages"> The quota limit properties for this resource. </param>
        /// <param name="unit"> The units for the quota usage, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation. </param>
        /// <param name="name"> Resource name provided by the resource provider. Use this property name when requesting quota. </param>
        /// <param name="resourceTypeName"> The name of the resource type. Optional field. </param>
        /// <param name="quotaPeriod">
        /// The time period for the summary of the quota usage values. For example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because it is not relevant for all resources such as compute.
        /// </param>
        /// <param name="isQuotaApplicable"> States if quota can be requested for this resource. </param>
        /// <param name="properties"> Additional properties for the specific resource provider. </param>
        /// <returns> A new <see cref="Models.QuotaUsagesProperties"/> instance for mocking. </returns>
        public static QuotaUsagesProperties QuotaUsagesProperties(QuotaUsagesObject usages = null, string unit = null, QuotaRequestResourceName name = null, string resourceTypeName = null, TimeSpan? quotaPeriod = null, bool? isQuotaApplicable = null, BinaryData properties = null)
        {
            return new QuotaUsagesProperties(
                usages,
                unit,
                name,
                resourceTypeName,
                quotaPeriod,
                isQuotaApplicable,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaUsagesObject"/>. </summary>
        /// <param name="value"> The usages value. </param>
        /// <param name="usagesType"> The quota or usages limit types. </param>
        /// <returns> A new <see cref="Models.QuotaUsagesObject"/> instance for mocking. </returns>
        public static QuotaUsagesObject QuotaUsagesObject(int value = default, QuotaUsagesType? usagesType = null)
        {
            return new QuotaUsagesObject(value, usagesType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaRequestResourceName"/>. </summary>
        /// <param name="value"> Resource name. </param>
        /// <param name="localizedValue"> Resource display name. </param>
        /// <returns> A new <see cref="Models.QuotaRequestResourceName"/> instance for mocking. </returns>
        public static QuotaRequestResourceName QuotaRequestResourceName(string value = null, string localizedValue = null)
        {
            return new QuotaRequestResourceName(value, localizedValue, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ServiceErrorDetail"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <returns> A new <see cref="Models.ServiceErrorDetail"/> instance for mocking. </returns>
        public static ServiceErrorDetail ServiceErrorDetail(string code = null, string message = null)
        {
            return new ServiceErrorDetail(code, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Quota.CurrentQuotaLimitBaseData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Quota properties for the specified resource, based on the API called, Quotas or Usages. </param>
        /// <returns> A new <see cref="Quota.CurrentQuotaLimitBaseData"/> instance for mocking. </returns>
        public static CurrentQuotaLimitBaseData CurrentQuotaLimitBaseData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, QuotaProperties properties = null)
        {
            return new CurrentQuotaLimitBaseData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaProperties"/>. </summary>
        /// <param name="limit">
        /// Resource quota limit properties.
        /// Please note <see cref="Models.QuotaLimitJsonObject"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="QuotaLimitObject"/>.
        /// </param>
        /// <param name="unit"> The quota units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation. </param>
        /// <param name="name"> Resource name provided by the resource provider. Use this property name when requesting quota. </param>
        /// <param name="resourceTypeName"> The name of the resource type. Optional field. </param>
        /// <param name="quotaPeriod">
        /// The time period over which the quota usage values are summarized. For example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because, for some resources like compute, the period is irrelevant.
        /// </param>
        /// <param name="isQuotaApplicable"> States if quota can be requested for this resource. </param>
        /// <param name="properties"> Additional properties for the specific resource provider. </param>
        /// <returns> A new <see cref="Models.QuotaProperties"/> instance for mocking. </returns>
        public static QuotaProperties QuotaProperties(QuotaLimitJsonObject limit = null, string unit = null, QuotaRequestResourceName name = null, string resourceTypeName = null, TimeSpan? quotaPeriod = null, bool? isQuotaApplicable = null, BinaryData properties = null)
        {
            return new QuotaProperties(
                limit,
                unit,
                name,
                resourceTypeName,
                quotaPeriod,
                isQuotaApplicable,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaLimitJsonObject"/>. </summary>
        /// <param name="limitObjectType"> The limit object type. </param>
        /// <returns> A new <see cref="Models.QuotaLimitJsonObject"/> instance for mocking. </returns>
        public static QuotaLimitJsonObject QuotaLimitJsonObject(string limitObjectType = "Unknown")
        {
            return new UnknownLimitJsonObject(limitObjectType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Quota.QuotaRequestDetailData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The quota request status. </param>
        /// <param name="message"> User-friendly status message. </param>
        /// <param name="error"> Error details of the quota request. </param>
        /// <param name="requestSubmitOn"> The quota request submission time. The date conforms to the following format specified by the ISO 8601 standard: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="value"> Quota request details. </param>
        /// <returns> A new <see cref="Quota.QuotaRequestDetailData"/> instance for mocking. </returns>
        public static QuotaRequestDetailData QuotaRequestDetailData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, QuotaRequestState? provisioningState = null, string message = null, ServiceErrorDetail error = null, DateTimeOffset? requestSubmitOn = null, IEnumerable<QuotaSubRequestDetail> value = null)
        {
            value ??= new List<QuotaSubRequestDetail>();

            return new QuotaRequestDetailData(
                id,
                name,
                resourceType,
                systemData,
                provisioningState,
                message,
                error,
                requestSubmitOn,
                value?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaSubRequestDetail"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceTypeName"> Resource type for which the quota properties were requested. </param>
        /// <param name="unit"> Quota limit units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation. </param>
        /// <param name="provisioningState"> The quota request status. </param>
        /// <param name="message"> User-friendly status message. </param>
        /// <param name="subRequestId"> Quota request ID. </param>
        /// <param name="limit">
        /// Resource quota limit properties.
        /// Please note <see cref="Models.QuotaLimitJsonObject"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="QuotaLimitObject"/>.
        /// </param>
        /// <returns> A new <see cref="Models.QuotaSubRequestDetail"/> instance for mocking. </returns>
        public static QuotaSubRequestDetail QuotaSubRequestDetail(QuotaRequestResourceName name = null, string resourceTypeName = null, string unit = null, QuotaRequestState? provisioningState = null, string message = null, Guid? subRequestId = null, QuotaLimitJsonObject limit = null)
        {
            return new QuotaSubRequestDetail(
                name,
                resourceTypeName,
                unit,
                provisioningState,
                message,
                subRequestId,
                limit,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaOperationResult"/>. </summary>
        /// <param name="name"></param>
        /// <param name="display"></param>
        /// <param name="origin"></param>
        /// <returns> A new <see cref="Models.QuotaOperationResult"/> instance for mocking. </returns>
        public static QuotaOperationResult QuotaOperationResult(string name = null, QuotaOperationDisplay display = null, string origin = null)
        {
            return new QuotaOperationResult(name, display, origin, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaOperationDisplay"/>. </summary>
        /// <param name="provider"> Provider name. </param>
        /// <param name="resource"> Resource name. </param>
        /// <param name="operation"> Operation name. </param>
        /// <param name="description"> Operation description. </param>
        /// <returns> A new <see cref="Models.QuotaOperationDisplay"/> instance for mocking. </returns>
        public static QuotaOperationDisplay QuotaOperationDisplay(string provider = null, string resource = null, string operation = null, string description = null)
        {
            return new QuotaOperationDisplay(provider, resource, operation, description, serializedAdditionalRawData: null);
        }
    }
}
