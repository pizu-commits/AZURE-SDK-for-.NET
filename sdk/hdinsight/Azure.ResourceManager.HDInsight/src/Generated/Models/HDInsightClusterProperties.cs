// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The properties of cluster. </summary>
    public partial class HDInsightClusterProperties
    {
        /// <summary> Initializes a new instance of HDInsightClusterProperties. </summary>
        /// <param name="clusterDefinition"> The cluster definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterDefinition"/> is null. </exception>
        public HDInsightClusterProperties(HDInsightClusterDefinition clusterDefinition)
        {
            if (clusterDefinition == null)
            {
                throw new ArgumentNullException(nameof(clusterDefinition));
            }

            ClusterDefinition = clusterDefinition;
            Errors = new ChangeTrackingList<ResponseError>();
            ConnectivityEndpoints = new ChangeTrackingList<ConnectivityEndpoint>();
            PrivateLinkConfigurations = new ChangeTrackingList<HDInsightPrivateLinkConfiguration>();
            PrivateEndpointConnections = new ChangeTrackingList<HDInsightPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of HDInsightClusterProperties. </summary>
        /// <param name="clusterVersion"> The version of the cluster. </param>
        /// <param name="clusterHdpVersion"> The hdp version of the cluster. </param>
        /// <param name="osType"> The type of operating system. </param>
        /// <param name="tier"> The cluster tier. </param>
        /// <param name="clusterId"> The cluster id. </param>
        /// <param name="clusterDefinition"> The cluster definition. </param>
        /// <param name="kafkaRestProperties"> The cluster kafka rest proxy configuration. </param>
        /// <param name="securityProfile"> The security profile. </param>
        /// <param name="computeProfile"> The compute profile. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="createdOn"> The date on which the cluster was created. </param>
        /// <param name="clusterState"> The state of the cluster. </param>
        /// <param name="quotaInfo"> The quota information. </param>
        /// <param name="errors"> The list of errors. </param>
        /// <param name="connectivityEndpoints"> The list of connectivity endpoints. </param>
        /// <param name="diskEncryptionProperties"> The disk encryption properties. </param>
        /// <param name="encryptionInTransitProperties"> The encryption-in-transit properties. </param>
        /// <param name="storageProfile"> The storage profile. </param>
        /// <param name="minSupportedTlsVersion"> The minimal supported tls version. </param>
        /// <param name="excludedServicesConfig"> The excluded services config. </param>
        /// <param name="networkProperties"> The network properties. </param>
        /// <param name="computeIsolationProperties"> The compute isolation properties. </param>
        /// <param name="privateLinkConfigurations"> The private link configurations. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections. </param>
        internal HDInsightClusterProperties(string clusterVersion, string clusterHdpVersion, HDInsightOSType? osType, HDInsightTier? tier, string clusterId, HDInsightClusterDefinition clusterDefinition, KafkaRestProperties kafkaRestProperties, HDInsightSecurityProfile securityProfile, ComputeProfile computeProfile, HDInsightClusterProvisioningState? provisioningState, DateTimeOffset? createdOn, string clusterState, QuotaInfo quotaInfo, IList<ResponseError> errors, IList<ConnectivityEndpoint> connectivityEndpoints, HDInsightDiskEncryptionProperties diskEncryptionProperties, EncryptionInTransitProperties encryptionInTransitProperties, StorageProfile storageProfile, string minSupportedTlsVersion, ExcludedServicesConfig excludedServicesConfig, HDInsightClusterNetworkProperties networkProperties, HDInsightComputeIsolationProperties computeIsolationProperties, IList<HDInsightPrivateLinkConfiguration> privateLinkConfigurations, IReadOnlyList<HDInsightPrivateEndpointConnectionData> privateEndpointConnections)
        {
            ClusterVersion = clusterVersion;
            ClusterHdpVersion = clusterHdpVersion;
            OSType = osType;
            Tier = tier;
            ClusterId = clusterId;
            ClusterDefinition = clusterDefinition;
            KafkaRestProperties = kafkaRestProperties;
            SecurityProfile = securityProfile;
            ComputeProfile = computeProfile;
            ProvisioningState = provisioningState;
            CreatedOn = createdOn;
            ClusterState = clusterState;
            QuotaInfo = quotaInfo;
            Errors = errors;
            ConnectivityEndpoints = connectivityEndpoints;
            DiskEncryptionProperties = diskEncryptionProperties;
            EncryptionInTransitProperties = encryptionInTransitProperties;
            StorageProfile = storageProfile;
            MinSupportedTlsVersion = minSupportedTlsVersion;
            ExcludedServicesConfig = excludedServicesConfig;
            NetworkProperties = networkProperties;
            ComputeIsolationProperties = computeIsolationProperties;
            PrivateLinkConfigurations = privateLinkConfigurations;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary> The version of the cluster. </summary>
        public string ClusterVersion { get; set; }
        /// <summary> The hdp version of the cluster. </summary>
        public string ClusterHdpVersion { get; set; }
        /// <summary> The type of operating system. </summary>
        public HDInsightOSType? OSType { get; set; }
        /// <summary> The cluster tier. </summary>
        public HDInsightTier? Tier { get; set; }
        /// <summary> The cluster id. </summary>
        public string ClusterId { get; set; }
        /// <summary> The cluster definition. </summary>
        public HDInsightClusterDefinition ClusterDefinition { get; set; }
        /// <summary> The cluster kafka rest proxy configuration. </summary>
        public KafkaRestProperties KafkaRestProperties { get; set; }
        /// <summary> The security profile. </summary>
        public HDInsightSecurityProfile SecurityProfile { get; set; }
        /// <summary> The compute profile. </summary>
        internal ComputeProfile ComputeProfile { get; set; }
        /// <summary> The list of roles in the cluster. </summary>
        public IList<HDInsightClusterRole> ComputeRoles
        {
            get
            {
                if (ComputeProfile is null)
                    ComputeProfile = new ComputeProfile();
                return ComputeProfile.Roles;
            }
        }

        /// <summary> The provisioning state, which only appears in the response. </summary>
        public HDInsightClusterProvisioningState? ProvisioningState { get; set; }
        /// <summary> The date on which the cluster was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The state of the cluster. </summary>
        public string ClusterState { get; set; }
        /// <summary> The quota information. </summary>
        internal QuotaInfo QuotaInfo { get; set; }
        /// <summary> The cores used by the cluster. </summary>
        public int? QuotaInfoCoresUsed
        {
            get => QuotaInfo is null ? default : QuotaInfo.CoresUsed;
            set
            {
                if (QuotaInfo is null)
                    QuotaInfo = new QuotaInfo();
                QuotaInfo.CoresUsed = value;
            }
        }

        /// <summary> The list of errors. </summary>
        public IList<ResponseError> Errors { get; }
        /// <summary> The list of connectivity endpoints. </summary>
        public IList<ConnectivityEndpoint> ConnectivityEndpoints { get; }
        /// <summary> The disk encryption properties. </summary>
        public HDInsightDiskEncryptionProperties DiskEncryptionProperties { get; set; }
        /// <summary> The encryption-in-transit properties. </summary>
        internal EncryptionInTransitProperties EncryptionInTransitProperties { get; set; }
        /// <summary> Indicates whether or not inter cluster node communication is encrypted in transit. </summary>
        public bool? IsEncryptionInTransitEnabled
        {
            get => EncryptionInTransitProperties is null ? default : EncryptionInTransitProperties.IsEncryptionInTransitEnabled;
            set
            {
                if (EncryptionInTransitProperties is null)
                    EncryptionInTransitProperties = new EncryptionInTransitProperties();
                EncryptionInTransitProperties.IsEncryptionInTransitEnabled = value;
            }
        }

        /// <summary> The storage profile. </summary>
        internal StorageProfile StorageProfile { get; set; }
        /// <summary> The list of storage accounts in the cluster. </summary>
        public IList<HDInsightStorageAccountInfo> StorageAccounts
        {
            get
            {
                if (StorageProfile is null)
                    StorageProfile = new StorageProfile();
                return StorageProfile.StorageAccounts;
            }
        }

        /// <summary> The minimal supported tls version. </summary>
        public string MinSupportedTlsVersion { get; set; }
        /// <summary> The excluded services config. </summary>
        public ExcludedServicesConfig ExcludedServicesConfig { get; set; }
        /// <summary> The network properties. </summary>
        public HDInsightClusterNetworkProperties NetworkProperties { get; set; }
        /// <summary> The compute isolation properties. </summary>
        public HDInsightComputeIsolationProperties ComputeIsolationProperties { get; set; }
        /// <summary> The private link configurations. </summary>
        public IList<HDInsightPrivateLinkConfiguration> PrivateLinkConfigurations { get; }
        /// <summary> The list of private endpoint connections. </summary>
        public IReadOnlyList<HDInsightPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
