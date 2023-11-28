// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties for creating a virtual machine. </summary>
    public partial class DevTestLabVmCreationContent
    {
        /// <summary> Initializes a new instance of <see cref="DevTestLabVmCreationContent"/>. </summary>
        public DevTestLabVmCreationContent()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Artifacts = new ChangeTrackingList<DevTestLabArtifactInstallInfo>();
            DataDiskParameters = new ChangeTrackingList<DevTestLabDataDiskProperties>();
            ScheduleParameters = new ChangeTrackingList<DevTestLabScheduleCreationParameter>();
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabVmCreationContent"/>. </summary>
        /// <param name="name"> The name of the virtual machine or environment. </param>
        /// <param name="location"> The location of the new virtual machine or environment. </param>
        /// <param name="tags"> The tags of the resource. </param>
        /// <param name="bulkCreationParameters"> The number of virtual machine instances to create. </param>
        /// <param name="notes"> The notes of the virtual machine. </param>
        /// <param name="ownerObjectId"> The object identifier of the owner of the virtual machine. </param>
        /// <param name="ownerUserPrincipalName"> The user principal name of the virtual machine owner. </param>
        /// <param name="createdOn"> The creation date of the virtual machine. </param>
        /// <param name="customImageId"> The custom image identifier of the virtual machine. </param>
        /// <param name="size"> The size of the virtual machine. </param>
        /// <param name="userName"> The user name of the virtual machine. </param>
        /// <param name="password"> The password of the virtual machine administrator. </param>
        /// <param name="sshKey"> The SSH key of the virtual machine administrator. </param>
        /// <param name="isAuthenticationWithSshKey"> Indicates whether this virtual machine uses an SSH key for authentication. </param>
        /// <param name="labSubnetName"> The lab subnet name of the virtual machine. </param>
        /// <param name="labVirtualNetworkId"> The lab virtual network identifier of the virtual machine. </param>
        /// <param name="disallowPublicIPAddress"> Indicates whether the virtual machine is to be created without a public IP address. </param>
        /// <param name="artifacts"> The artifacts to be installed on the virtual machine. </param>
        /// <param name="galleryImageReference"> The Microsoft Azure Marketplace image reference of the virtual machine. </param>
        /// <param name="planId"> The id of the plan associated with the virtual machine image. </param>
        /// <param name="networkInterface"> The network interface properties. </param>
        /// <param name="expireOn"> The expiration date for VM. </param>
        /// <param name="allowClaim"> Indicates whether another user can take ownership of the virtual machine. </param>
        /// <param name="storageType"> Storage type to use for virtual machine (i.e. Standard, Premium). </param>
        /// <param name="environmentId"> The resource ID of the environment that contains this virtual machine, if any. </param>
        /// <param name="dataDiskParameters"> New or existing data disks to attach to the virtual machine after creation. </param>
        /// <param name="scheduleParameters"> Virtual Machine schedules to be created. </param>
        internal DevTestLabVmCreationContent(string name, AzureLocation? location, IDictionary<string, string> tags, BulkCreationParameters bulkCreationParameters, string notes, string ownerObjectId, string ownerUserPrincipalName, DateTimeOffset? createdOn, string customImageId, string size, string userName, string password, string sshKey, bool? isAuthenticationWithSshKey, string labSubnetName, ResourceIdentifier labVirtualNetworkId, bool? disallowPublicIPAddress, IList<DevTestLabArtifactInstallInfo> artifacts, DevTestLabGalleryImageReference galleryImageReference, string planId, DevTestLabNetworkInterface networkInterface, DateTimeOffset? expireOn, bool? allowClaim, string storageType, string environmentId, IList<DevTestLabDataDiskProperties> dataDiskParameters, IList<DevTestLabScheduleCreationParameter> scheduleParameters)
        {
            Name = name;
            Location = location;
            Tags = tags;
            BulkCreationParameters = bulkCreationParameters;
            Notes = notes;
            OwnerObjectId = ownerObjectId;
            OwnerUserPrincipalName = ownerUserPrincipalName;
            CreatedOn = createdOn;
            CustomImageId = customImageId;
            Size = size;
            UserName = userName;
            Password = password;
            SshKey = sshKey;
            IsAuthenticationWithSshKey = isAuthenticationWithSshKey;
            LabSubnetName = labSubnetName;
            LabVirtualNetworkId = labVirtualNetworkId;
            DisallowPublicIPAddress = disallowPublicIPAddress;
            Artifacts = artifacts;
            GalleryImageReference = galleryImageReference;
            PlanId = planId;
            NetworkInterface = networkInterface;
            ExpireOn = expireOn;
            AllowClaim = allowClaim;
            StorageType = storageType;
            EnvironmentId = environmentId;
            DataDiskParameters = dataDiskParameters;
            ScheduleParameters = scheduleParameters;
        }

        /// <summary> The name of the virtual machine or environment. </summary>
        public string Name { get; set; }
        /// <summary> The location of the new virtual machine or environment. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The tags of the resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The number of virtual machine instances to create. </summary>
        internal BulkCreationParameters BulkCreationParameters { get; set; }
        /// <summary> The number of virtual machine instances to create. </summary>
        public int? BulkCreationParametersInstanceCount
        {
            get => BulkCreationParameters is null ? default : BulkCreationParameters.InstanceCount;
            set
            {
                if (BulkCreationParameters is null)
                    BulkCreationParameters = new BulkCreationParameters();
                BulkCreationParameters.InstanceCount = value;
            }
        }

        /// <summary> The notes of the virtual machine. </summary>
        public string Notes { get; set; }
        /// <summary> The object identifier of the owner of the virtual machine. </summary>
        public string OwnerObjectId { get; set; }
        /// <summary> The user principal name of the virtual machine owner. </summary>
        public string OwnerUserPrincipalName { get; set; }
        /// <summary> The creation date of the virtual machine. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The custom image identifier of the virtual machine. </summary>
        public string CustomImageId { get; set; }
        /// <summary> The size of the virtual machine. </summary>
        public string Size { get; set; }
        /// <summary> The user name of the virtual machine. </summary>
        public string UserName { get; set; }
        /// <summary> The password of the virtual machine administrator. </summary>
        public string Password { get; set; }
        /// <summary> The SSH key of the virtual machine administrator. </summary>
        public string SshKey { get; set; }
        /// <summary> Indicates whether this virtual machine uses an SSH key for authentication. </summary>
        public bool? IsAuthenticationWithSshKey { get; set; }
        /// <summary> The lab subnet name of the virtual machine. </summary>
        public string LabSubnetName { get; set; }
        /// <summary> The lab virtual network identifier of the virtual machine. </summary>
        public ResourceIdentifier LabVirtualNetworkId { get; set; }
        /// <summary> Indicates whether the virtual machine is to be created without a public IP address. </summary>
        public bool? DisallowPublicIPAddress { get; set; }
        /// <summary> The artifacts to be installed on the virtual machine. </summary>
        public IList<DevTestLabArtifactInstallInfo> Artifacts { get; }
        /// <summary> The Microsoft Azure Marketplace image reference of the virtual machine. </summary>
        public DevTestLabGalleryImageReference GalleryImageReference { get; set; }
        /// <summary> The id of the plan associated with the virtual machine image. </summary>
        public string PlanId { get; set; }
        /// <summary> The network interface properties. </summary>
        public DevTestLabNetworkInterface NetworkInterface { get; set; }
        /// <summary> The expiration date for VM. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Indicates whether another user can take ownership of the virtual machine. </summary>
        public bool? AllowClaim { get; set; }
        /// <summary> Storage type to use for virtual machine (i.e. Standard, Premium). </summary>
        public string StorageType { get; set; }
        /// <summary> The resource ID of the environment that contains this virtual machine, if any. </summary>
        public string EnvironmentId { get; set; }
        /// <summary> New or existing data disks to attach to the virtual machine after creation. </summary>
        public IList<DevTestLabDataDiskProperties> DataDiskParameters { get; }
        /// <summary> Virtual Machine schedules to be created. </summary>
        public IList<DevTestLabScheduleCreationParameter> ScheduleParameters { get; }
    }
}
