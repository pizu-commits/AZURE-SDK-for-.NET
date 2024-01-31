// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    /// <summary> The Custom Locations patchable resource definition. </summary>
    public partial class CustomLocationPatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomLocationPatch"/>. </summary>
        public CustomLocationPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            ClusterExtensionIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomLocationPatch"/>. </summary>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned, None. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="authentication"> This is optional input that contains the authentication that should be used to generate the namespace. </param>
        /// <param name="clusterExtensionIds"> Contains the reference to the add-on that contains charts to deploy CRDs and operators. </param>
        /// <param name="displayName"> Display name for the Custom Locations location. </param>
        /// <param name="hostResourceId"> Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions. </param>
        /// <param name="hostType"> Type of host the Custom Locations is referencing (Kubernetes, etc...). </param>
        /// <param name="namespace"> Kubernetes namespace that will be created on the specified cluster. </param>
        /// <param name="provisioningState"> Provisioning State for the Custom Location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomLocationPatch(ManagedServiceIdentity identity, IDictionary<string, string> tags, CustomLocationAuthentication authentication, IList<ResourceIdentifier> clusterExtensionIds, string displayName, ResourceIdentifier hostResourceId, CustomLocationHostType? hostType, string @namespace, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Tags = tags;
            Authentication = authentication;
            ClusterExtensionIds = clusterExtensionIds;
            DisplayName = displayName;
            HostResourceId = hostResourceId;
            HostType = hostType;
            Namespace = @namespace;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Identity for the resource. Current supported identity types: SystemAssigned, None. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> This is optional input that contains the authentication that should be used to generate the namespace. </summary>
        public CustomLocationAuthentication Authentication { get; set; }
        /// <summary> Contains the reference to the add-on that contains charts to deploy CRDs and operators. </summary>
        public IList<ResourceIdentifier> ClusterExtensionIds { get; }
        /// <summary> Display name for the Custom Locations location. </summary>
        public string DisplayName { get; set; }
        /// <summary> Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions. </summary>
        public ResourceIdentifier HostResourceId { get; set; }
        /// <summary> Type of host the Custom Locations is referencing (Kubernetes, etc...). </summary>
        public CustomLocationHostType? HostType { get; set; }
        /// <summary> Kubernetes namespace that will be created on the specified cluster. </summary>
        public string Namespace { get; set; }
        /// <summary> Provisioning State for the Custom Location. </summary>
        public string ProvisioningState { get; set; }
    }
}
