// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing the FrontDoorCustomDomain data model.
    /// Friendly domain name mapping to the endpoint hostname that the customer provides for branding purposes, e.g. www.contoso.com.
    /// </summary>
    public partial class FrontDoorCustomDomainData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorCustomDomainData"/>. </summary>
        public FrontDoorCustomDomainData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorCustomDomainData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="profileName"> The name of the profile which holds the domain. </param>
        /// <param name="tlsSettings"> The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user's own certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default. </param>
        /// <param name="dnsZone"> Resource reference to the Azure DNS zone. </param>
        /// <param name="preValidatedCustomDomainResource"> Resource reference to the Azure resource where custom domain ownership was prevalidated. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        /// <param name="domainValidationState"> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation. </param>
        /// <param name="hostName"> The host name of the domain. Must be a domain name. </param>
        /// <param name="validationProperties"> Values the customer needs to validate domain ownership. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorCustomDomainData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string profileName, FrontDoorCustomDomainHttpsContent tlsSettings, WritableSubResource dnsZone, FrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId preValidatedCustomDomainResource, FrontDoorProvisioningState? provisioningState, FrontDoorDeploymentStatus? deploymentStatus, DomainValidationState? domainValidationState, string hostName, DomainValidationProperties validationProperties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProfileName = profileName;
            TlsSettings = tlsSettings;
            DnsZone = dnsZone;
            PreValidatedCustomDomainResource = preValidatedCustomDomainResource;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            DomainValidationState = domainValidationState;
            HostName = hostName;
            ValidationProperties = validationProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the profile which holds the domain. </summary>
        public string ProfileName { get; }
        /// <summary> The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user's own certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default. </summary>
        public FrontDoorCustomDomainHttpsContent TlsSettings { get; set; }
        /// <summary> Resource reference to the Azure DNS zone. </summary>
        internal WritableSubResource DnsZone { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DnsZoneId
        {
            get => DnsZone is null ? default : DnsZone.Id;
            set
            {
                if (DnsZone is null)
                    DnsZone = new WritableSubResource();
                DnsZone.Id = value;
            }
        }

        /// <summary> Resource reference to the Azure resource where custom domain ownership was prevalidated. </summary>
        internal FrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId PreValidatedCustomDomainResource { get; set; }
        /// <summary> Resource ID. </summary>
        public ResourceIdentifier PreValidatedCustomDomainResourceId
        {
            get => PreValidatedCustomDomainResource is null ? default : PreValidatedCustomDomainResource.Id;
            set
            {
                if (PreValidatedCustomDomainResource is null)
                    PreValidatedCustomDomainResource = new FrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId();
                PreValidatedCustomDomainResource.Id = value;
            }
        }

        /// <summary> Provisioning status. </summary>
        public FrontDoorProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public FrontDoorDeploymentStatus? DeploymentStatus { get; }
        /// <summary> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation. </summary>
        public DomainValidationState? DomainValidationState { get; }
        /// <summary> The host name of the domain. Must be a domain name. </summary>
        public string HostName { get; set; }
        /// <summary> Values the customer needs to validate domain ownership. </summary>
        public DomainValidationProperties ValidationProperties { get; }
    }
}
