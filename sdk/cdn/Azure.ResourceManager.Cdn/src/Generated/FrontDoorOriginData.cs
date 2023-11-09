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
    /// A class representing the FrontDoorOrigin data model.
    /// CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not have the requested content cached, they attempt to fetch it from one or more of the configured origins.
    /// </summary>
    public partial class FrontDoorOriginData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorOriginData"/>. </summary>
        public FrontDoorOriginData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorOriginData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="originGroupName"> The name of the origin group which contains this origin. </param>
        /// <param name="origin"> Resource reference to the Azure origin resource. </param>
        /// <param name="hostName"> The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint. </param>
        /// <param name="httpPort"> The value of the HTTP port. Must be between 1 and 65535. </param>
        /// <param name="httpsPort"> The value of the HTTPS port. Must be between 1 and 65535. </param>
        /// <param name="originHostHeader"> The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint. </param>
        /// <param name="priority"> Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5. </param>
        /// <param name="weight"> Weight of the origin in given origin group for load balancing. Must be between 1 and 1000. </param>
        /// <param name="sharedPrivateLinkResource"> The properties of the private link resource for private origin. </param>
        /// <param name="enabledState"> Whether to enable health probes to be made against backends defined under backendPools. Health probes can only be disabled if there is a single enabled backend in single enabled backend pool. </param>
        /// <param name="enforceCertificateNameCheck"> Whether to enable certificate name check at origin level. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorOriginData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string originGroupName, WritableSubResource origin, string hostName, int? httpPort, int? httpsPort, string originHostHeader, int? priority, int? weight, SharedPrivateLinkResourceProperties sharedPrivateLinkResource, EnabledState? enabledState, bool? enforceCertificateNameCheck, FrontDoorProvisioningState? provisioningState, FrontDoorDeploymentStatus? deploymentStatus, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            OriginGroupName = originGroupName;
            Origin = origin;
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            OriginHostHeader = originHostHeader;
            Priority = priority;
            Weight = weight;
            SharedPrivateLinkResource = sharedPrivateLinkResource;
            EnabledState = enabledState;
            EnforceCertificateNameCheck = enforceCertificateNameCheck;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the origin group which contains this origin. </summary>
        public string OriginGroupName { get; }
        /// <summary> Resource reference to the Azure origin resource. </summary>
        internal WritableSubResource Origin { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OriginId
        {
            get => Origin is null ? default : Origin.Id;
            set
            {
                if (Origin is null)
                    Origin = new WritableSubResource();
                Origin.Id = value;
            }
        }

        /// <summary> The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint. </summary>
        public string HostName { get; set; }
        /// <summary> The value of the HTTP port. Must be between 1 and 65535. </summary>
        public int? HttpPort { get; set; }
        /// <summary> The value of the HTTPS port. Must be between 1 and 65535. </summary>
        public int? HttpsPort { get; set; }
        /// <summary> The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint. </summary>
        public string OriginHostHeader { get; set; }
        /// <summary> Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5. </summary>
        public int? Priority { get; set; }
        /// <summary> Weight of the origin in given origin group for load balancing. Must be between 1 and 1000. </summary>
        public int? Weight { get; set; }
        /// <summary> The properties of the private link resource for private origin. </summary>
        public SharedPrivateLinkResourceProperties SharedPrivateLinkResource { get; set; }
        /// <summary> Whether to enable health probes to be made against backends defined under backendPools. Health probes can only be disabled if there is a single enabled backend in single enabled backend pool. </summary>
        public EnabledState? EnabledState { get; set; }
        /// <summary> Whether to enable certificate name check at origin level. </summary>
        public bool? EnforceCertificateNameCheck { get; set; }
        /// <summary> Provisioning status. </summary>
        public FrontDoorProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public FrontDoorDeploymentStatus? DeploymentStatus { get; }
    }
}
