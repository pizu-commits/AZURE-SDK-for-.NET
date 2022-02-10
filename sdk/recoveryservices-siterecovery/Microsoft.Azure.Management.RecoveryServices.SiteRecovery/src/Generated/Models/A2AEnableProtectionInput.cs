// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A2A enable protection input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2AEnableProtectionInput : EnableProtectionProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the A2AEnableProtectionInput class.
        /// </summary>
        public A2AEnableProtectionInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AEnableProtectionInput class.
        /// </summary>
        /// <param name="fabricObjectId">The fabric specific object Id of the
        /// virtual machine.</param>
        /// <param name="recoveryContainerId">The recovery container
        /// Id.</param>
        /// <param name="recoveryResourceGroupId">The recovery resource group
        /// Id. Valid for V2 scenarios.</param>
        /// <param name="recoveryCloudServiceId">The recovery cloud service Id.
        /// Valid for V1 scenarios.</param>
        /// <param name="recoveryAvailabilitySetId">The recovery availability
        /// set Id.</param>
        /// <param name="recoveryProximityPlacementGroupId">The recovery
        /// proximity placement group Id.</param>
        /// <param name="vmDisks">The list of vm disk details.</param>
        /// <param name="vmManagedDisks">The list of vm managed disk
        /// details.</param>
        /// <param name="multiVmGroupName">The multi vm group name.</param>
        /// <param name="multiVmGroupId">The multi vm group id.</param>
        /// <param name="recoveryBootDiagStorageAccountId">The boot diagnostic
        /// storage account.</param>
        /// <param name="diskEncryptionInfo">The recovery disk encryption
        /// information (for two pass flows).</param>
        /// <param name="recoveryAvailabilityZone">The recovery availability
        /// zone.</param>
        /// <param name="recoveryExtendedLocation">The recovery extended
        /// location.</param>
        /// <param name="recoveryAzureNetworkId">The recovery Azure virtual
        /// network ARM id.</param>
        /// <param name="recoverySubnetName">The recovery subnet name.</param>
        /// <param name="recoveryVirtualMachineScaleSetId">The virtual machine
        /// scale set Id.</param>
        /// <param name="recoveryCapacityReservationGroupId">The recovery
        /// capacity reservation group Id.</param>
        public A2AEnableProtectionInput(string fabricObjectId, string recoveryContainerId = default(string), string recoveryResourceGroupId = default(string), string recoveryCloudServiceId = default(string), string recoveryAvailabilitySetId = default(string), string recoveryProximityPlacementGroupId = default(string), IList<A2AVmDiskInputDetails> vmDisks = default(IList<A2AVmDiskInputDetails>), IList<A2AVmManagedDiskInputDetails> vmManagedDisks = default(IList<A2AVmManagedDiskInputDetails>), string multiVmGroupName = default(string), string multiVmGroupId = default(string), string recoveryBootDiagStorageAccountId = default(string), DiskEncryptionInfo diskEncryptionInfo = default(DiskEncryptionInfo), string recoveryAvailabilityZone = default(string), ExtendedLocation recoveryExtendedLocation = default(ExtendedLocation), string recoveryAzureNetworkId = default(string), string recoverySubnetName = default(string), string recoveryVirtualMachineScaleSetId = default(string), string recoveryCapacityReservationGroupId = default(string))
        {
            FabricObjectId = fabricObjectId;
            RecoveryContainerId = recoveryContainerId;
            RecoveryResourceGroupId = recoveryResourceGroupId;
            RecoveryCloudServiceId = recoveryCloudServiceId;
            RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            RecoveryProximityPlacementGroupId = recoveryProximityPlacementGroupId;
            VmDisks = vmDisks;
            VmManagedDisks = vmManagedDisks;
            MultiVmGroupName = multiVmGroupName;
            MultiVmGroupId = multiVmGroupId;
            RecoveryBootDiagStorageAccountId = recoveryBootDiagStorageAccountId;
            DiskEncryptionInfo = diskEncryptionInfo;
            RecoveryAvailabilityZone = recoveryAvailabilityZone;
            RecoveryExtendedLocation = recoveryExtendedLocation;
            RecoveryAzureNetworkId = recoveryAzureNetworkId;
            RecoverySubnetName = recoverySubnetName;
            RecoveryVirtualMachineScaleSetId = recoveryVirtualMachineScaleSetId;
            RecoveryCapacityReservationGroupId = recoveryCapacityReservationGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fabric specific object Id of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "fabricObjectId")]
        public string FabricObjectId { get; set; }

        /// <summary>
        /// Gets or sets the recovery container Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryContainerId")]
        public string RecoveryContainerId { get; set; }

        /// <summary>
        /// Gets or sets the recovery resource group Id. Valid for V2
        /// scenarios.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryResourceGroupId")]
        public string RecoveryResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the recovery cloud service Id. Valid for V1 scenarios.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryCloudServiceId")]
        public string RecoveryCloudServiceId { get; set; }

        /// <summary>
        /// Gets or sets the recovery availability set Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAvailabilitySetId")]
        public string RecoveryAvailabilitySetId { get; set; }

        /// <summary>
        /// Gets or sets the recovery proximity placement group Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryProximityPlacementGroupId")]
        public string RecoveryProximityPlacementGroupId { get; set; }

        /// <summary>
        /// Gets or sets the list of vm disk details.
        /// </summary>
        [JsonProperty(PropertyName = "vmDisks")]
        public IList<A2AVmDiskInputDetails> VmDisks { get; set; }

        /// <summary>
        /// Gets or sets the list of vm managed disk details.
        /// </summary>
        [JsonProperty(PropertyName = "vmManagedDisks")]
        public IList<A2AVmManagedDiskInputDetails> VmManagedDisks { get; set; }

        /// <summary>
        /// Gets or sets the multi vm group name.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVmGroupName { get; set; }

        /// <summary>
        /// Gets or sets the multi vm group id.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupId")]
        public string MultiVmGroupId { get; set; }

        /// <summary>
        /// Gets or sets the boot diagnostic storage account.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryBootDiagStorageAccountId")]
        public string RecoveryBootDiagStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the recovery disk encryption information (for two pass
        /// flows).
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionInfo")]
        public DiskEncryptionInfo DiskEncryptionInfo { get; set; }

        /// <summary>
        /// Gets or sets the recovery availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAvailabilityZone")]
        public string RecoveryAvailabilityZone { get; set; }

        /// <summary>
        /// Gets or sets the recovery extended location.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryExtendedLocation")]
        public ExtendedLocation RecoveryExtendedLocation { get; set; }

        /// <summary>
        /// Gets or sets the recovery Azure virtual network ARM id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureNetworkId")]
        public string RecoveryAzureNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the recovery subnet name.
        /// </summary>
        [JsonProperty(PropertyName = "recoverySubnetName")]
        public string RecoverySubnetName { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryVirtualMachineScaleSetId")]
        public string RecoveryVirtualMachineScaleSetId { get; set; }

        /// <summary>
        /// Gets or sets the recovery capacity reservation group Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryCapacityReservationGroupId")]
        public string RecoveryCapacityReservationGroupId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FabricObjectId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FabricObjectId");
            }
            if (VmDisks != null)
            {
                foreach (var element in VmDisks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (VmManagedDisks != null)
            {
                foreach (var element1 in VmManagedDisks)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (RecoveryExtendedLocation != null)
            {
                RecoveryExtendedLocation.Validate();
            }
        }
    }
}
