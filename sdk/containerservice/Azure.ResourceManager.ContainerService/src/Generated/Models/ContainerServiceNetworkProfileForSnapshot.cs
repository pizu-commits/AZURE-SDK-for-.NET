// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> network profile for managed cluster snapshot, these properties are read only. </summary>
    public partial class ContainerServiceNetworkProfileForSnapshot
    {
        /// <summary> Initializes a new instance of <see cref="ContainerServiceNetworkProfileForSnapshot"/>. </summary>
        internal ContainerServiceNetworkProfileForSnapshot()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNetworkProfileForSnapshot"/>. </summary>
        /// <param name="networkPlugin"> networkPlugin for managed cluster snapshot. </param>
        /// <param name="networkPluginMode"> NetworkPluginMode for managed cluster snapshot. </param>
        /// <param name="networkPolicy"> networkPolicy for managed cluster snapshot. </param>
        /// <param name="networkMode"> networkMode for managed cluster snapshot. </param>
        /// <param name="loadBalancerSku"> loadBalancerSku for managed cluster snapshot. </param>
        internal ContainerServiceNetworkProfileForSnapshot(ContainerServiceNetworkPlugin? networkPlugin, ContainerServiceNetworkPluginMode? networkPluginMode, ContainerServiceNetworkPolicy? networkPolicy, ContainerServiceNetworkMode? networkMode, ContainerServiceLoadBalancerSku? loadBalancerSku)
        {
            NetworkPlugin = networkPlugin;
            NetworkPluginMode = networkPluginMode;
            NetworkPolicy = networkPolicy;
            NetworkMode = networkMode;
            LoadBalancerSku = loadBalancerSku;
        }

        /// <summary> networkPlugin for managed cluster snapshot. </summary>
        public ContainerServiceNetworkPlugin? NetworkPlugin { get; }
        /// <summary> NetworkPluginMode for managed cluster snapshot. </summary>
        public ContainerServiceNetworkPluginMode? NetworkPluginMode { get; }
        /// <summary> networkPolicy for managed cluster snapshot. </summary>
        public ContainerServiceNetworkPolicy? NetworkPolicy { get; }
        /// <summary> networkMode for managed cluster snapshot. </summary>
        public ContainerServiceNetworkMode? NetworkMode { get; }
        /// <summary> loadBalancerSku for managed cluster snapshot. </summary>
        public ContainerServiceLoadBalancerSku? LoadBalancerSku { get; }
    }
}
