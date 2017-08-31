// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IaaS VM workload-specific restore.
    /// </summary>
    public partial class IaasVMRestoreRequest : RestoreRequest
    {
        /// <summary>
        /// Initializes a new instance of the IaasVMRestoreRequest class.
        /// </summary>
        public IaasVMRestoreRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IaasVMRestoreRequest class.
        /// </summary>
        /// <param name="recoveryPointId">ID of the backup copy to be
        /// recovered.</param>
        /// <param name="recoveryType">Type of this recovery. Possible values
        /// include: 'Invalid', 'OriginalLocation', 'AlternateLocation',
        /// 'RestoreDisks'</param>
        /// <param name="sourceResourceId">Fully qualified ARM ID of the VM
        /// which is being recovered.</param>
        /// <param name="targetVirtualMachineId">This is the complete ARM Id of
        /// the VM that will be created.
        /// For e.g.
        /// /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}</param>
        /// <param name="targetResourceGroupId">This is the ARM Id of the
        /// resource group that you want to create for this Virtual machine and
        /// other artifacts.
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}</param>
        /// <param name="storageAccountId">Fully qualified ARM ID of the
        /// storage account to which the VM has to be restored.</param>
        /// <param name="virtualNetworkId">This is the virtual network Id of
        /// the vnet that will be attached to the virtual machine.
        /// User will be validated for join action permissions in the linked
        /// access.</param>
        /// <param name="subnetId">Subnet ID, is the subnet ID associated with
        /// the to be restored VM. For Classic VMs it would be
        /// {VnetID}/Subnet/{SubnetName} and, for the Azure Resource Manager
        /// VMs it would be ARM resource ID used to represent the
        /// subnet.</param>
        /// <param name="targetDomainNameId">Fully qualified ARM ID of the
        /// domain name to be associated to the VM being restored. This applies
        /// only to Classic Virtual Machines.</param>
        /// <param name="region">Region in which the virtual machine is
        /// restored.</param>
        /// <param name="affinityGroup">Affinity group associated to VM to be
        /// restored. Used only for Classic Compute Virtual Machines.</param>
        /// <param name="createNewCloudService">Should a new cloud service be
        /// created while restoring the VM. If this is false, VM will be
        /// restored to the same cloud service as it was at the time of
        /// backup.</param>
        /// <param name="encryptionDetails">Details needed if the VM was
        /// encrypted at the time of backup.</param>
        public IaasVMRestoreRequest(string recoveryPointId = default(string), string recoveryType = default(string), string sourceResourceId = default(string), string targetVirtualMachineId = default(string), string targetResourceGroupId = default(string), string storageAccountId = default(string), string virtualNetworkId = default(string), string subnetId = default(string), string targetDomainNameId = default(string), string region = default(string), string affinityGroup = default(string), bool? createNewCloudService = default(bool?), bool? originalStorageAccountOption = default(bool?), EncryptionDetails encryptionDetails = default(EncryptionDetails))
        {
            RecoveryPointId = recoveryPointId;
            RecoveryType = recoveryType;
            SourceResourceId = sourceResourceId;
            TargetVirtualMachineId = targetVirtualMachineId;
            TargetResourceGroupId = targetResourceGroupId;
            StorageAccountId = storageAccountId;
            VirtualNetworkId = virtualNetworkId;
            SubnetId = subnetId;
            TargetDomainNameId = targetDomainNameId;
            Region = region;
            AffinityGroup = affinityGroup;
            CreateNewCloudService = createNewCloudService;
            OriginalStorageAccountOption = originalStorageAccountOption;
            EncryptionDetails = encryptionDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the backup copy to be recovered.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Gets or sets type of this recovery. Possible values include:
        /// 'Invalid', 'OriginalLocation', 'AlternateLocation', 'RestoreDisks'
        /// </summary>
        [JsonProperty(PropertyName = "recoveryType")]
        public string RecoveryType { get; set; }

        /// <summary>
        /// Gets or sets fully qualified ARM ID of the VM which is being
        /// recovered.
        /// </summary>
        [JsonProperty(PropertyName = "sourceResourceId")]
        public string SourceResourceId { get; set; }

        /// <summary>
        /// Gets or sets this is the complete ARM Id of the VM that will be
        /// created.
        /// For e.g.
        /// /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </summary>
        [JsonProperty(PropertyName = "targetVirtualMachineId")]
        public string TargetVirtualMachineId { get; set; }

        /// <summary>
        /// Gets or sets this is the ARM Id of the resource group that you want
        /// to create for this Virtual machine and other artifacts.
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroupId")]
        public string TargetResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets fully qualified ARM ID of the storage account to which
        /// the VM has to be restored.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets this is the virtual network Id of the vnet that will
        /// be attached to the virtual machine.
        /// User will be validated for join action permissions in the linked
        /// access.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkId")]
        public string VirtualNetworkId { get; set; }

        /// <summary>
        /// Gets or sets subnet ID, is the subnet ID associated with the to be
        /// restored VM. For Classic VMs it would be
        /// {VnetID}/Subnet/{SubnetName} and, for the Azure Resource Manager
        /// VMs it would be ARM resource ID used to represent the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets fully qualified ARM ID of the domain name to be
        /// associated to the VM being restored. This applies only to Classic
        /// Virtual Machines.
        /// </summary>
        [JsonProperty(PropertyName = "targetDomainNameId")]
        public string TargetDomainNameId { get; set; }

        /// <summary>
        /// Gets or sets region in which the virtual machine is restored.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets affinity group associated to VM to be restored. Used
        /// only for Classic Compute Virtual Machines.
        /// </summary>
        [JsonProperty(PropertyName = "affinityGroup")]
        public string AffinityGroup { get; set; }

        /// <summary>
        /// Gets or sets should a new cloud service be created while restoring
        /// the VM. If this is false, VM will be restored to the same cloud
        /// service as it was at the time of backup.
        /// </summary>
        [JsonProperty(PropertyName = "createNewCloudService")]
        public bool? CreateNewCloudService { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "originalStorageAccountOption")]
        public bool? OriginalStorageAccountOption { get; set; }

        /// <summary>
        /// Gets or sets details needed if the VM was encrypted at the time of
        /// backup.
        /// </summary>
        [JsonProperty(PropertyName = "encryptionDetails")]
        public EncryptionDetails EncryptionDetails { get; set; }

    }
}
