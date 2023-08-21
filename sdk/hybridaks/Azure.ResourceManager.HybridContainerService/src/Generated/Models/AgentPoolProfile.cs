// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> NodePool configuration. </summary>
    public partial class AgentPoolProfile
    {
        /// <summary> Initializes a new instance of AgentPoolProfile. </summary>
        public AgentPoolProfile()
        {
            AvailabilityZones = new Core.ChangeTrackingList<string>();
            NodeLabels = new Core.ChangeTrackingDictionary<string, string>();
            NodeTaints = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AgentPoolProfile. </summary>
        /// <param name="count"> Count - Number of agents to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1. </param>
        /// <param name="availabilityZones"> AvailabilityZones - The list of Availability zones to use for nodes. Datacenter racks modelled as zones. </param>
        /// <param name="maxCount"> The maximum number of nodes for auto-scaling. </param>
        /// <param name="maxPods"> The maximum number of pods that can run on a node. </param>
        /// <param name="minCount"> The minimum number of nodes for auto-scaling. </param>
        /// <param name="mode"> Mode - AgentPoolMode represents mode of an agent pool. Possible values include: 'System', 'LB', 'User'. Default is 'User'. </param>
        /// <param name="nodeLabels"> NodeLabels - Agent pool node labels to be persisted across all nodes in agent pool. </param>
        /// <param name="nodeTaints"> NodeTaints - Taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule. </param>
        /// <param name="osType"> OsType - OsType to be used to specify os type. Choose from Linux and Windows. Default to Linux. Possible values include: 'Linux', 'Windows'. </param>
        /// <param name="nodeImageVersion"> The version of node image. </param>
        /// <param name="vmSize"> VmSize - The size of the agent pool VMs. </param>
        /// <param name="cloudProviderProfile"> The underlying cloud infra provider properties. </param>
        internal AgentPoolProfile(int? count, IList<string> availabilityZones, int? maxCount, int? maxPods, int? minCount, Mode? mode, IDictionary<string, string> nodeLabels, IList<string> nodeTaints, OSType? osType, string nodeImageVersion, string vmSize, CloudProviderProfile cloudProviderProfile)
        {
            Count = count;
            AvailabilityZones = availabilityZones;
            MaxCount = maxCount;
            MaxPods = maxPods;
            MinCount = minCount;
            Mode = mode;
            NodeLabels = nodeLabels;
            NodeTaints = nodeTaints;
            OSType = osType;
            NodeImageVersion = nodeImageVersion;
            VmSize = vmSize;
            CloudProviderProfile = cloudProviderProfile;
        }

        /// <summary> Count - Number of agents to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1. </summary>
        public int? Count { get; set; }
        /// <summary> AvailabilityZones - The list of Availability zones to use for nodes. Datacenter racks modelled as zones. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> The maximum number of nodes for auto-scaling. </summary>
        public int? MaxCount { get; set; }
        /// <summary> The maximum number of pods that can run on a node. </summary>
        public int? MaxPods { get; set; }
        /// <summary> The minimum number of nodes for auto-scaling. </summary>
        public int? MinCount { get; set; }
        /// <summary> Mode - AgentPoolMode represents mode of an agent pool. Possible values include: 'System', 'LB', 'User'. Default is 'User'. </summary>
        public Mode? Mode { get; set; }
        /// <summary> NodeLabels - Agent pool node labels to be persisted across all nodes in agent pool. </summary>
        public IDictionary<string, string> NodeLabels { get; }
        /// <summary> NodeTaints - Taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule. </summary>
        public IList<string> NodeTaints { get; }
        /// <summary> OsType - OsType to be used to specify os type. Choose from Linux and Windows. Default to Linux. Possible values include: 'Linux', 'Windows'. </summary>
        public OSType? OSType { get; set; }
        /// <summary> The version of node image. </summary>
        public string NodeImageVersion { get; set; }
        /// <summary> VmSize - The size of the agent pool VMs. </summary>
        public string VmSize { get; set; }
        /// <summary> The underlying cloud infra provider properties. </summary>
        public CloudProviderProfile CloudProviderProfile { get; set; }
    }
}
