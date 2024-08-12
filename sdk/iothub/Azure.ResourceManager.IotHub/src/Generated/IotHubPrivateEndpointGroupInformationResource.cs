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

namespace Azure.ResourceManager.IotHub
{
    /// <summary>
    /// A Class representing an IotHubPrivateEndpointGroupInformation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="IotHubPrivateEndpointGroupInformationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetIotHubPrivateEndpointGroupInformationResource method.
    /// Otherwise you can get one from its parent resource <see cref="IotHubDescriptionResource"/> using the GetIotHubPrivateEndpointGroupInformation method.
    /// </summary>
    public partial class IotHubPrivateEndpointGroupInformationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="IotHubPrivateEndpointGroupInformationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="groupId"> The groupId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string groupId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/iotHubs/{resourceName}/privateLinkResources/{groupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient;
        private readonly IotHubPrivateEndpointGroupInformationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Devices/iotHubs/privateLinkResources";

        /// <summary> Initializes a new instance of the <see cref="IotHubPrivateEndpointGroupInformationResource"/> class for mocking. </summary>
        protected IotHubPrivateEndpointGroupInformationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotHubPrivateEndpointGroupInformationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal IotHubPrivateEndpointGroupInformationResource(ArmClient client, IotHubPrivateEndpointGroupInformationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="IotHubPrivateEndpointGroupInformationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IotHubPrivateEndpointGroupInformationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotHub", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string iotHubPrivateEndpointGroupInformationPrivateLinkResourcesApiVersion);
            _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotHubPrivateEndpointGroupInformationPrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IotHubPrivateEndpointGroupInformationData Data
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
        /// Get the specified private link resource for the given IotHub
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/iotHubs/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotHubPrivateEndpointGroupInformationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IotHubPrivateEndpointGroupInformationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics.CreateScope("IotHubPrivateEndpointGroupInformationResource.Get");
            scope.Start();
            try
            {
                var response = await _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotHubPrivateEndpointGroupInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified private link resource for the given IotHub
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/iotHubs/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotHubPrivateEndpointGroupInformationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IotHubPrivateEndpointGroupInformationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics.CreateScope("IotHubPrivateEndpointGroupInformationResource.Get");
            scope.Start();
            try
            {
                var response = _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotHubPrivateEndpointGroupInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
