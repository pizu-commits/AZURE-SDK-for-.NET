// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.FluidRelay.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableFluidRelayResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableFluidRelayResourceGroupResource"/> class for mocking. </summary>
        protected MockableFluidRelayResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableFluidRelayResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableFluidRelayResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of FluidRelayServerResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of FluidRelayServerResources and their operations over a FluidRelayServerResource. </returns>
        public virtual FluidRelayServerCollection GetFluidRelayServers()
        {
            return GetCachedClient(client => new FluidRelayServerCollection(client, Id));
        }

        /// <summary>
        /// Get a Fluid Relay server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayServerName"> The Fluid Relay server resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayServerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayServerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<FluidRelayServerResource>> GetFluidRelayServerAsync(string fluidRelayServerName, CancellationToken cancellationToken = default)
        {
            return await GetFluidRelayServers().GetAsync(fluidRelayServerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Fluid Relay server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayServerName"> The Fluid Relay server resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayServerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayServerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<FluidRelayServerResource> GetFluidRelayServer(string fluidRelayServerName, CancellationToken cancellationToken = default)
        {
            return GetFluidRelayServers().Get(fluidRelayServerName, cancellationToken);
        }
    }
}
