// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagementPartner.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmManagementPartnerModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ManagementPartner.PartnerResponseData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Type of the partner. </param>
        /// <param name="partnerId"> This is the partner id. </param>
        /// <param name="partnerName"> This is the partner name. </param>
        /// <param name="tenantId"> This is the tenant id. </param>
        /// <param name="objectId"> This is the object id. </param>
        /// <param name="version"> This is the version. </param>
        /// <param name="updatedOn"> This is the DateTime when the partner was updated. </param>
        /// <param name="createdOn"> This is the DateTime when the partner was created. </param>
        /// <param name="state"> This is the partner state. </param>
        /// <returns> A new <see cref="ManagementPartner.PartnerResponseData"/> instance for mocking. </returns>
        public static PartnerResponseData PartnerResponseData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, int? etag = null, string partnerId = null, string partnerName = null, Guid? tenantId = null, string objectId = null, int? version = null, DateTimeOffset? updatedOn = null, DateTimeOffset? createdOn = null, ManagementPartnerState? state = null)
        {
            return new PartnerResponseData(
                id,
                name,
                resourceType,
                systemData,
                etag,
                partnerId,
                partnerName,
                tenantId,
                objectId,
                version,
                updatedOn,
                createdOn,
                state,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OperationResponse"/>. </summary>
        /// <param name="name"> this is the operation response name. </param>
        /// <param name="display"> this is the operation display. </param>
        /// <param name="origin"> the is operation response origin information. </param>
        /// <returns> A new <see cref="Models.OperationResponse"/> instance for mocking. </returns>
        public static OperationResponse OperationResponse(string name = null, OperationDisplay display = null, string origin = null)
        {
            return new OperationResponse(name, display, origin, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OperationDisplay"/>. </summary>
        /// <param name="provider"> the is management partner provider. </param>
        /// <param name="resource"> the is management partner resource. </param>
        /// <param name="operation"> the is management partner operation. </param>
        /// <param name="description"> the is management partner operation description. </param>
        /// <returns> A new <see cref="Models.OperationDisplay"/> instance for mocking. </returns>
        public static OperationDisplay OperationDisplay(string provider = null, string resource = null, string operation = null, string description = null)
        {
            return new OperationDisplay(provider, resource, operation, description, serializedAdditionalRawData: null);
        }
    }
}
