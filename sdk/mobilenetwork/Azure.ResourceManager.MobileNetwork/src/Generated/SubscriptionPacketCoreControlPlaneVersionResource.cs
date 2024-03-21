// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A Class representing a SubscriptionPacketCoreControlPlaneVersion along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SubscriptionPacketCoreControlPlaneVersionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSubscriptionPacketCoreControlPlaneVersionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSubscriptionPacketCoreControlPlaneVersion method.
    /// </summary>
    public partial class SubscriptionPacketCoreControlPlaneVersionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionPacketCoreControlPlaneVersionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="versionName"> The versionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string versionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics;
        private readonly PacketCoreControlPlaneVersionsRestOperations _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient;
        private readonly PacketCoreControlPlaneVersionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MobileNetwork/packetCoreControlPlaneVersions";

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPacketCoreControlPlaneVersionResource"/> class for mocking. </summary>
        protected SubscriptionPacketCoreControlPlaneVersionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPacketCoreControlPlaneVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionPacketCoreControlPlaneVersionResource(ArmClient client, PacketCoreControlPlaneVersionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPacketCoreControlPlaneVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionPacketCoreControlPlaneVersionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsApiVersion);
            _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient = new PacketCoreControlPlaneVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PacketCoreControlPlaneVersionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about the specified packet core control plane version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_GetBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionPacketCoreControlPlaneVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionPacketCoreControlPlaneVersionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("SubscriptionPacketCoreControlPlaneVersionResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.GetBySubscriptionAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPacketCoreControlPlaneVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified packet core control plane version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_GetBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionPacketCoreControlPlaneVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionPacketCoreControlPlaneVersionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("SubscriptionPacketCoreControlPlaneVersionResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.GetBySubscription(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPacketCoreControlPlaneVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
