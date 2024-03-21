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

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary>
    /// A Class representing a DeviceUpdatePrivateLink along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DeviceUpdatePrivateLinkResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDeviceUpdatePrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="DeviceUpdateAccountResource"/> using the GetDeviceUpdatePrivateLink method.
    /// </summary>
    public partial class DeviceUpdatePrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DeviceUpdatePrivateLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="groupId"> The groupId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string groupId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateLinkResources/{groupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _deviceUpdatePrivateLinkPrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _deviceUpdatePrivateLinkPrivateLinkResourcesRestClient;
        private readonly DeviceUpdatePrivateLinkData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DeviceUpdate/accounts/privateLinkResources";

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdatePrivateLinkResource"/> class for mocking. </summary>
        protected DeviceUpdatePrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdatePrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DeviceUpdatePrivateLinkResource(ArmClient client, DeviceUpdatePrivateLinkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdatePrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeviceUpdatePrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceUpdatePrivateLinkPrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string deviceUpdatePrivateLinkPrivateLinkResourcesApiVersion);
            _deviceUpdatePrivateLinkPrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceUpdatePrivateLinkPrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeviceUpdatePrivateLinkData Data
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
        /// Get the specified private link resource associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeviceUpdatePrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _deviceUpdatePrivateLinkPrivateLinkResourcesClientDiagnostics.CreateScope("DeviceUpdatePrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _deviceUpdatePrivateLinkPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdatePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified private link resource associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeviceUpdatePrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _deviceUpdatePrivateLinkPrivateLinkResourcesClientDiagnostics.CreateScope("DeviceUpdatePrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _deviceUpdatePrivateLinkPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdatePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
