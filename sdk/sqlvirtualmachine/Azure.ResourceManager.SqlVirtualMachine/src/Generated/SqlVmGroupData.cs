// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SqlVirtualMachine.Models;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    /// <summary>
    /// A class representing the SqlVmGroup data model.
    /// A SQL virtual machine group.
    /// </summary>
    public partial class SqlVmGroupData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlVmGroupData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SqlVmGroupData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlVmGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state to track the async operation status. </param>
        /// <param name="sqlImageOffer"> SQL image offer. Examples may include SQL2016-WS2016, SQL2017-WS2016. </param>
        /// <param name="sqlImageSku"> SQL image sku. </param>
        /// <param name="scaleType"> Scale type. </param>
        /// <param name="clusterManagerType"> Type of cluster manager: Windows Server Failover Cluster (WSFC), implied by the scale type of the group and the OS type. </param>
        /// <param name="clusterConfiguration"> Cluster type. </param>
        /// <param name="windowsServerFailoverClusterDomainProfile"> Cluster Active Directory domain profile. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlVmGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string provisioningState, string sqlImageOffer, SqlVmGroupImageSku? sqlImageSku, SqlVmGroupScaleType? scaleType, SqlVmClusterManagerType? clusterManagerType, SqlVmClusterConfiguration? clusterConfiguration, WindowsServerFailoverClusterDomainProfile windowsServerFailoverClusterDomainProfile, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            SqlImageOffer = sqlImageOffer;
            SqlImageSku = sqlImageSku;
            ScaleType = scaleType;
            ClusterManagerType = clusterManagerType;
            ClusterConfiguration = clusterConfiguration;
            WindowsServerFailoverClusterDomainProfile = windowsServerFailoverClusterDomainProfile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SqlVmGroupData"/> for deserialization. </summary>
        internal SqlVmGroupData()
        {
        }

        /// <summary> Provisioning state to track the async operation status. </summary>
        public string ProvisioningState { get; }
        /// <summary> SQL image offer. Examples may include SQL2016-WS2016, SQL2017-WS2016. </summary>
        public string SqlImageOffer { get; set; }
        /// <summary> SQL image sku. </summary>
        public SqlVmGroupImageSku? SqlImageSku { get; set; }
        /// <summary> Scale type. </summary>
        public SqlVmGroupScaleType? ScaleType { get; }
        /// <summary> Type of cluster manager: Windows Server Failover Cluster (WSFC), implied by the scale type of the group and the OS type. </summary>
        public SqlVmClusterManagerType? ClusterManagerType { get; }
        /// <summary> Cluster type. </summary>
        public SqlVmClusterConfiguration? ClusterConfiguration { get; }
        /// <summary> Cluster Active Directory domain profile. </summary>
        public WindowsServerFailoverClusterDomainProfile WindowsServerFailoverClusterDomainProfile { get; set; }
    }
}
