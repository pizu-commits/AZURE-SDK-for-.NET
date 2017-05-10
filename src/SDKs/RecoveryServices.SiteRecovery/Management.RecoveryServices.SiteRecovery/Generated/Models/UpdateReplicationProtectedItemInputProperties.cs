// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Update protected item input properties.
    /// </summary>
    public partial class UpdateReplicationProtectedItemInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateReplicationProtectedItemInputProperties class.
        /// </summary>
        public UpdateReplicationProtectedItemInputProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateReplicationProtectedItemInputProperties class.
        /// </summary>
        public UpdateReplicationProtectedItemInputProperties(string recoveryAzureVMName = default(string), string recoveryAzureVMSize = default(string), string selectedRecoveryAzureNetworkId = default(string), string enableRDPOnTargetOption = default(string), IList<VMNicInputDetails> vmNics = default(IList<VMNicInputDetails>), LicenseType? licenseType = default(LicenseType?), string recoveryAvailabilitySetId = default(string), UpdateReplicationProtectedItemProviderInput providerSpecificDetails = default(UpdateReplicationProtectedItemProviderInput))
        {
            RecoveryAzureVMName = recoveryAzureVMName;
            RecoveryAzureVMSize = recoveryAzureVMSize;
            SelectedRecoveryAzureNetworkId = selectedRecoveryAzureNetworkId;
            EnableRDPOnTargetOption = enableRDPOnTargetOption;
            VmNics = vmNics;
            LicenseType = licenseType;
            RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// Target azure VM name given by the user.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMName")]
        public string RecoveryAzureVMName { get; set; }

        /// <summary>
        /// Target Azure Vm size.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMSize")]
        public string RecoveryAzureVMSize { get; set; }

        /// <summary>
        /// Target Azure Network Id.
        /// </summary>
        [JsonProperty(PropertyName = "selectedRecoveryAzureNetworkId")]
        public string SelectedRecoveryAzureNetworkId { get; set; }

        /// <summary>
        /// The selected option to enable RDP\\\\SSH on target vm after
        /// failover.
        /// String value of
        /// {SrsDataContract.EnableRDPOnTargetOption} enum.
        /// </summary>
        [JsonProperty(PropertyName = "enableRDPOnTargetOption")]
        public string EnableRDPOnTargetOption { get; set; }

        /// <summary>
        /// The list of vm nic details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<VMNicInputDetails> VmNics { get; set; }

        /// <summary>
        /// LicenseType. Possible values include: 'NotSpecified',
        /// 'NoLicenseType', 'WindowsServer'
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public LicenseType? LicenseType { get; set; }

        /// <summary>
        /// The target availability set id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAvailabilitySetId")]
        public string RecoveryAvailabilitySetId { get; set; }

        /// <summary>
        /// The provider specific input to update replication protected item.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public UpdateReplicationProtectedItemProviderInput ProviderSpecificDetails { get; set; }

    }
}
