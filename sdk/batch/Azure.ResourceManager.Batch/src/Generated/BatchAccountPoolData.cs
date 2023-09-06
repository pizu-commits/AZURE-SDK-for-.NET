// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing the BatchAccountPool data model.
    /// Contains information about a pool.
    /// </summary>
    public partial class BatchAccountPoolData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchAccountPoolData"/>. </summary>
        public BatchAccountPoolData()
        {
            UserAccounts = new ChangeTrackingList<BatchUserAccount>();
            Metadata = new ChangeTrackingList<BatchAccountPoolMetadataItem>();
            Certificates = new ChangeTrackingList<BatchCertificateReference>();
            ApplicationPackages = new ChangeTrackingList<BatchApplicationPackageReference>();
            ApplicationLicenses = new ChangeTrackingList<string>();
            MountConfiguration = new ChangeTrackingList<BatchMountConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountPoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The type of identity used for the Batch Pool. Current supported identity types: UserAssigned, None. </param>
        /// <param name="displayName"> The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </param>
        /// <param name="lastModifiedOn"> This is the last time at which the pool level data, such as the targetDedicatedNodes or autoScaleSettings, changed. It does not factor in node-level changes such as a compute node changing state. </param>
        /// <param name="createdOn"> The creation time of the pool. </param>
        /// <param name="provisioningState"> The current state of the pool. </param>
        /// <param name="provisioningStateTransitOn"> The time at which the pool entered its current state. </param>
        /// <param name="allocationState"> Whether the pool is resizing. </param>
        /// <param name="allocationStateTransitionOn"> The time at which the pool entered its current allocation state. </param>
        /// <param name="vmSize"> For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series). </param>
        /// <param name="deploymentConfiguration"> Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS). </param>
        /// <param name="currentDedicatedNodes"> The number of dedicated compute nodes currently in the pool. </param>
        /// <param name="currentLowPriorityNodes"> The number of Spot/low-priority compute nodes currently in the pool. </param>
        /// <param name="scaleSettings"> Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes. </param>
        /// <param name="autoScaleRun"> This property is set only if the pool automatically scales, i.e. autoScaleSettings are used. </param>
        /// <param name="interNodeCommunication"> This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'. </param>
        /// <param name="networkConfiguration"> The network configuration for a pool. </param>
        /// <param name="taskSlotsPerNode"> The default value is 1. The maximum value is the smaller of 4 times the number of cores of the vmSize of the pool or 256. </param>
        /// <param name="taskSchedulingPolicy"> If not specified, the default is spread. </param>
        /// <param name="userAccounts"> The list of user accounts to be created on each node in the pool. </param>
        /// <param name="metadata"> The Batch service does not assign any meaning to metadata; it is solely for the use of user code. </param>
        /// <param name="startTask"> In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool. </param>
        /// <param name="certificates">
        /// For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
        ///
        /// Warning: This property is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// </param>
        /// <param name="applicationPackages"> Changes to application package references affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged. There is a maximum of 10 application package references on any given pool. </param>
        /// <param name="applicationLicenses"> The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail. </param>
        /// <param name="resizeOperationStatus"> Describes either the current operation (if the pool AllocationState is Resizing) or the previously completed operation (if the AllocationState is Steady). </param>
        /// <param name="mountConfiguration"> This supports Azure Files, NFS, CIFS/SMB, and Blobfuse. </param>
        /// <param name="targetNodeCommunicationMode"> If omitted, the default value is Default. </param>
        /// <param name="currentNodeCommunicationMode"> Determines how a pool communicates with the Batch service. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchAccountPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServiceIdentity identity, string displayName, DateTimeOffset? lastModifiedOn, DateTimeOffset? createdOn, BatchAccountPoolProvisioningState? provisioningState, DateTimeOffset? provisioningStateTransitOn, BatchAccountPoolAllocationState? allocationState, DateTimeOffset? allocationStateTransitionOn, string vmSize, BatchDeploymentConfiguration deploymentConfiguration, int? currentDedicatedNodes, int? currentLowPriorityNodes, BatchAccountPoolScaleSettings scaleSettings, BatchAccountPoolAutoScaleRun autoScaleRun, InterNodeCommunicationState? interNodeCommunication, BatchNetworkConfiguration networkConfiguration, int? taskSlotsPerNode, TaskSchedulingPolicy taskSchedulingPolicy, IList<BatchUserAccount> userAccounts, IList<BatchAccountPoolMetadataItem> metadata, BatchAccountPoolStartTask startTask, IList<BatchCertificateReference> certificates, IList<BatchApplicationPackageReference> applicationPackages, IList<string> applicationLicenses, BatchResizeOperationStatus resizeOperationStatus, IList<BatchMountConfiguration> mountConfiguration, NodeCommunicationMode? targetNodeCommunicationMode, NodeCommunicationMode? currentNodeCommunicationMode, ETag? etag, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            DisplayName = displayName;
            LastModifiedOn = lastModifiedOn;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            ProvisioningStateTransitOn = provisioningStateTransitOn;
            AllocationState = allocationState;
            AllocationStateTransitionOn = allocationStateTransitionOn;
            VmSize = vmSize;
            DeploymentConfiguration = deploymentConfiguration;
            CurrentDedicatedNodes = currentDedicatedNodes;
            CurrentLowPriorityNodes = currentLowPriorityNodes;
            ScaleSettings = scaleSettings;
            AutoScaleRun = autoScaleRun;
            InterNodeCommunication = interNodeCommunication;
            NetworkConfiguration = networkConfiguration;
            TaskSlotsPerNode = taskSlotsPerNode;
            TaskSchedulingPolicy = taskSchedulingPolicy;
            UserAccounts = userAccounts;
            Metadata = metadata;
            StartTask = startTask;
            Certificates = certificates;
            ApplicationPackages = applicationPackages;
            ApplicationLicenses = applicationLicenses;
            ResizeOperationStatus = resizeOperationStatus;
            MountConfiguration = mountConfiguration;
            TargetNodeCommunicationMode = targetNodeCommunicationMode;
            CurrentNodeCommunicationMode = currentNodeCommunicationMode;
            ETag = etag;
            _rawData = rawData;
        }

        /// <summary> The type of identity used for the Batch Pool. Current supported identity types: UserAssigned, None. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </summary>
        public string DisplayName { get; set; }
        /// <summary> This is the last time at which the pool level data, such as the targetDedicatedNodes or autoScaleSettings, changed. It does not factor in node-level changes such as a compute node changing state. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The creation time of the pool. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The current state of the pool. </summary>
        public BatchAccountPoolProvisioningState? ProvisioningState { get; }
        /// <summary> The time at which the pool entered its current state. </summary>
        public DateTimeOffset? ProvisioningStateTransitOn { get; }
        /// <summary> Whether the pool is resizing. </summary>
        public BatchAccountPoolAllocationState? AllocationState { get; }
        /// <summary> The time at which the pool entered its current allocation state. </summary>
        public DateTimeOffset? AllocationStateTransitionOn { get; }
        /// <summary> For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series). </summary>
        public string VmSize { get; set; }
        /// <summary> Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS). </summary>
        public BatchDeploymentConfiguration DeploymentConfiguration { get; set; }
        /// <summary> The number of dedicated compute nodes currently in the pool. </summary>
        public int? CurrentDedicatedNodes { get; }
        /// <summary> The number of Spot/low-priority compute nodes currently in the pool. </summary>
        public int? CurrentLowPriorityNodes { get; }
        /// <summary> Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes. </summary>
        public BatchAccountPoolScaleSettings ScaleSettings { get; set; }
        /// <summary> This property is set only if the pool automatically scales, i.e. autoScaleSettings are used. </summary>
        public BatchAccountPoolAutoScaleRun AutoScaleRun { get; }
        /// <summary> This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'. </summary>
        public InterNodeCommunicationState? InterNodeCommunication { get; set; }
        /// <summary> The network configuration for a pool. </summary>
        public BatchNetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary> The default value is 1. The maximum value is the smaller of 4 times the number of cores of the vmSize of the pool or 256. </summary>
        public int? TaskSlotsPerNode { get; set; }
        /// <summary> If not specified, the default is spread. </summary>
        internal TaskSchedulingPolicy TaskSchedulingPolicy { get; set; }
        /// <summary> How tasks should be distributed across compute nodes. </summary>
        public BatchNodeFillType? TaskSchedulingNodeFillType
        {
            get => TaskSchedulingPolicy is null ? default(BatchNodeFillType?) : TaskSchedulingPolicy.NodeFillType;
            set
            {
                TaskSchedulingPolicy = value.HasValue ? new TaskSchedulingPolicy(value.Value) : null;
            }
        }

        /// <summary> The list of user accounts to be created on each node in the pool. </summary>
        public IList<BatchUserAccount> UserAccounts { get; }
        /// <summary> The Batch service does not assign any meaning to metadata; it is solely for the use of user code. </summary>
        public IList<BatchAccountPoolMetadataItem> Metadata { get; }
        /// <summary> In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool. </summary>
        public BatchAccountPoolStartTask StartTask { get; set; }
        /// <summary>
        /// For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
        ///
        /// Warning: This property is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// </summary>
        public IList<BatchCertificateReference> Certificates { get; }
        /// <summary> Changes to application package references affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged. There is a maximum of 10 application package references on any given pool. </summary>
        public IList<BatchApplicationPackageReference> ApplicationPackages { get; }
        /// <summary> The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail. </summary>
        public IList<string> ApplicationLicenses { get; }
        /// <summary> Describes either the current operation (if the pool AllocationState is Resizing) or the previously completed operation (if the AllocationState is Steady). </summary>
        public BatchResizeOperationStatus ResizeOperationStatus { get; }
        /// <summary> This supports Azure Files, NFS, CIFS/SMB, and Blobfuse. </summary>
        public IList<BatchMountConfiguration> MountConfiguration { get; }
        /// <summary> If omitted, the default value is Default. </summary>
        public NodeCommunicationMode? TargetNodeCommunicationMode { get; set; }
        /// <summary> Determines how a pool communicates with the Batch service. </summary>
        public NodeCommunicationMode? CurrentNodeCommunicationMode { get; }
        /// <summary> The ETag of the resource, used for concurrency statements. </summary>
        public ETag? ETag { get; }
    }
}
