// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
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
    /// VMware Azure specific enable protection input.
    /// </summary>
    [JsonObject("InMageAzureV2")]
    public partial class InMageAzureV2EnableProtectionInput : EnableProtectionProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2EnableProtectionInput class.
        /// </summary>
        public InMageAzureV2EnableProtectionInput() { }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2EnableProtectionInput class.
        /// </summary>
        public InMageAzureV2EnableProtectionInput(string storageAccountId, string masterTargetId = default(string), string processServerId = default(string), string runAsAccountId = default(string), string multiVmGroupId = default(string), string multiVmGroupName = default(string), IList<string> disksToInclude = default(IList<string>), string targetAzureNetworkId = default(string), string targetAzureSubnetId = default(string), string enableRDPOnTargetOption = default(string), string targetAzureVmName = default(string), string logStorageAccountId = default(string), string targetAzureV1ResourceGroupId = default(string), string targetAzureV2ResourceGroupId = default(string), string useManagedDisks = default(string))
        {
            MasterTargetId = masterTargetId;
            ProcessServerId = processServerId;
            StorageAccountId = storageAccountId;
            RunAsAccountId = runAsAccountId;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            DisksToInclude = disksToInclude;
            TargetAzureNetworkId = targetAzureNetworkId;
            TargetAzureSubnetId = targetAzureSubnetId;
            EnableRDPOnTargetOption = enableRDPOnTargetOption;
            TargetAzureVmName = targetAzureVmName;
            LogStorageAccountId = logStorageAccountId;
            TargetAzureV1ResourceGroupId = targetAzureV1ResourceGroupId;
            TargetAzureV2ResourceGroupId = targetAzureV2ResourceGroupId;
            UseManagedDisks = useManagedDisks;
        }

        /// <summary>
        /// The Master target Id.
        /// </summary>
        [JsonProperty(PropertyName = "masterTargetId")]
        public string MasterTargetId { get; set; }

        /// <summary>
        /// The Process Server Id.
        /// </summary>
        [JsonProperty(PropertyName = "processServerId")]
        public string ProcessServerId { get; set; }

        /// <summary>
        /// The storage account name.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// The CS account Id.
        /// </summary>
        [JsonProperty(PropertyName = "runAsAccountId")]
        public string RunAsAccountId { get; set; }

        /// <summary>
        /// The multi vm group Id.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupId")]
        public string MultiVmGroupId { get; set; }

        /// <summary>
        /// The multi vm group name.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVmGroupName { get; set; }

        /// <summary>
        /// The disks to include list.
        /// </summary>
        [JsonProperty(PropertyName = "disksToInclude")]
        public IList<string> DisksToInclude { get; set; }

        /// <summary>
        /// The selected target Azure network Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureNetworkId")]
        public string TargetAzureNetworkId { get; set; }

        /// <summary>
        /// The selected target Azure subnet Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureSubnetId")]
        public string TargetAzureSubnetId { get; set; }

        /// <summary>
        /// The selected option to enable RDP\\\\SSH on target vm after
        /// failover.
        /// String value of
        /// {SrsDataContract.EnableRDPOnTargetOption} enum.
        /// </summary>
        [JsonProperty(PropertyName = "enableRDPOnTargetOption")]
        public string EnableRDPOnTargetOption { get; set; }

        /// <summary>
        /// The target azure Vm Name.
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureVmName")]
        public string TargetAzureVmName { get; set; }

        /// <summary>
        /// The storage account to be used for logging
        /// during replication.
        /// </summary>
        [JsonProperty(PropertyName = "logStorageAccountId")]
        public string LogStorageAccountId { get; set; }

        /// <summary>
        /// The Id of the target resource group (for classic deployment) in
        /// which the
        /// failover VM is to be created.
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureV1ResourceGroupId")]
        public string TargetAzureV1ResourceGroupId { get; set; }

        /// <summary>
        /// The Id of the target resource group (for resource manager
        /// deployment) in
        /// which the failover VM is to be created.
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureV2ResourceGroupId")]
        public string TargetAzureV2ResourceGroupId { get; set; }

        /// <summary>
        /// A value indicating whether managed disks should be used during
        /// failover.
        /// </summary>
        [JsonProperty(PropertyName = "useManagedDisks")]
        public string UseManagedDisks { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (StorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountId");
            }
        }
    }
}
