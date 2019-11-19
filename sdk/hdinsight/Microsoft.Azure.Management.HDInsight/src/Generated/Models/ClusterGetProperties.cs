// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of cluster.
    /// </summary>
    public partial class ClusterGetProperties
    {
        /// <summary>
        /// Initializes a new instance of the ClusterGetProperties class.
        /// </summary>
        public ClusterGetProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterGetProperties class.
        /// </summary>
        /// <param name="clusterDefinition">The cluster definition.</param>
        /// <param name="clusterVersion">The version of the cluster.</param>
        /// <param name="osType">The type of operating system. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="tier">The cluster tier. Possible values include:
        /// 'Standard', 'Premium'</param>
        /// <param name="kafkaRestProperties">The cluster kafaka rest proxy
        /// configuration.</param>
        /// <param name="securityProfile">The security profile.</param>
        /// <param name="computeProfile">The compute profile.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response. Possible values include: 'InProgress',
        /// 'Failed', 'Succeeded', 'Canceled', 'Deleting'</param>
        /// <param name="createdDate">The date on which the cluster was
        /// created.</param>
        /// <param name="clusterState">The state of the cluster.</param>
        /// <param name="quotaInfo">The quota information.</param>
        /// <param name="errors">The list of errors.</param>
        /// <param name="connectivityEndpoints">The list of connectivity
        /// endpoints.</param>
        /// <param name="diskEncryptionProperties">The disk encryption
        /// properties.</param>
        public ClusterGetProperties(ClusterDefinition clusterDefinition, string clusterVersion = default(string), OSType? osType = default(OSType?), Tier? tier = default(Tier?), KafkaRestProperties kafkaRestProperties = default(KafkaRestProperties), SecurityProfile securityProfile = default(SecurityProfile), ComputeProfile computeProfile = default(ComputeProfile), HDInsightClusterProvisioningState? provisioningState = default(HDInsightClusterProvisioningState?), string createdDate = default(string), string clusterState = default(string), QuotaInfo quotaInfo = default(QuotaInfo), IList<Errors> errors = default(IList<Errors>), IList<ConnectivityEndpoint> connectivityEndpoints = default(IList<ConnectivityEndpoint>), DiskEncryptionProperties diskEncryptionProperties = default(DiskEncryptionProperties))
        {
            ClusterVersion = clusterVersion;
            OsType = osType;
            Tier = tier;
            ClusterDefinition = clusterDefinition;
            KafkaRestProperties = kafkaRestProperties;
            SecurityProfile = securityProfile;
            ComputeProfile = computeProfile;
            ProvisioningState = provisioningState;
            CreatedDate = createdDate;
            ClusterState = clusterState;
            QuotaInfo = quotaInfo;
            Errors = errors;
            ConnectivityEndpoints = connectivityEndpoints;
            DiskEncryptionProperties = diskEncryptionProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "clusterVersion")]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// Gets or sets the type of operating system. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public OSType? OsType { get; set; }

        /// <summary>
        /// Gets or sets the cluster tier. Possible values include: 'Standard',
        /// 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public Tier? Tier { get; set; }

        /// <summary>
        /// Gets or sets the cluster definition.
        /// </summary>
        [JsonProperty(PropertyName = "clusterDefinition")]
        public ClusterDefinition ClusterDefinition { get; set; }

        /// <summary>
        /// Gets or sets the cluster kafaka rest proxy configuration.
        /// </summary>
        [JsonProperty(PropertyName = "kafkaRestProperties")]
        public KafkaRestProperties KafkaRestProperties { get; set; }

        /// <summary>
        /// Gets or sets the security profile.
        /// </summary>
        [JsonProperty(PropertyName = "securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets the compute profile.
        /// </summary>
        [JsonProperty(PropertyName = "computeProfile")]
        public ComputeProfile ComputeProfile { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state, which only appears in the
        /// response. Possible values include: 'InProgress', 'Failed',
        /// 'Succeeded', 'Canceled', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public HDInsightClusterProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the date on which the cluster was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdDate")]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the state of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "clusterState")]
        public string ClusterState { get; set; }

        /// <summary>
        /// Gets or sets the quota information.
        /// </summary>
        [JsonProperty(PropertyName = "quotaInfo")]
        public QuotaInfo QuotaInfo { get; set; }

        /// <summary>
        /// Gets or sets the list of errors.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Errors> Errors { get; set; }

        /// <summary>
        /// Gets or sets the list of connectivity endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "connectivityEndpoints")]
        public IList<ConnectivityEndpoint> ConnectivityEndpoints { get; set; }

        /// <summary>
        /// Gets or sets the disk encryption properties.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionProperties")]
        public DiskEncryptionProperties DiskEncryptionProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ClusterDefinition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClusterDefinition");
            }
        }
    }
}
