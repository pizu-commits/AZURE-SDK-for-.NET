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
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a StaticSitePrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="StaticSitePrivateEndpointConnectionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetStaticSitePrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="StaticSiteResource"/> using the GetStaticSitePrivateEndpointConnection method.
    /// </summary>
    public partial class StaticSitePrivateEndpointConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StaticSitePrivateEndpointConnectionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="privateEndpointConnectionName"> The privateEndpointConnectionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSitePrivateEndpointConnectionStaticSitesRestClient;
        private readonly RemotePrivateEndpointConnectionARMResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/staticSites/privateEndpointConnections";

        /// <summary> Initializes a new instance of the <see cref="StaticSitePrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected StaticSitePrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSitePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StaticSitePrivateEndpointConnectionResource(ArmClient client, RemotePrivateEndpointConnectionARMResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSitePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSitePrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string staticSitePrivateEndpointConnectionStaticSitesApiVersion);
            _staticSitePrivateEndpointConnectionStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSitePrivateEndpointConnectionStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RemotePrivateEndpointConnectionARMResourceData Data
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
        /// Description for Gets a private endpoint connection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSitePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StaticSitePrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics.CreateScope("StaticSitePrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _staticSitePrivateEndpointConnectionStaticSitesRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSitePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a private endpoint connection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSitePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StaticSitePrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics.CreateScope("StaticSitePrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _staticSitePrivateEndpointConnectionStaticSitesRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSitePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a private endpoint connection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_DeletePrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSitePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<BinaryData>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics.CreateScope("StaticSitePrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _staticSitePrivateEndpointConnectionStaticSitesRestClient.DeletePrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<BinaryData>(new BinaryDataOperationSource(), _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics, Pipeline, _staticSitePrivateEndpointConnectionStaticSitesRestClient.CreateDeletePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a private endpoint connection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_DeletePrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSitePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<BinaryData> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics.CreateScope("StaticSitePrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _staticSitePrivateEndpointConnectionStaticSitesRestClient.DeletePrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation<BinaryData>(new BinaryDataOperationSource(), _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics, Pipeline, _staticSitePrivateEndpointConnectionStaticSitesRestClient.CreateDeletePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Approves or rejects a private endpoint connection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ApproveOrRejectPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSitePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> Request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSitePrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics.CreateScope("StaticSitePrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _staticSitePrivateEndpointConnectionStaticSitesRestClient.ApproveOrRejectPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSitePrivateEndpointConnectionResource>(new StaticSitePrivateEndpointConnectionOperationSource(Client), _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics, Pipeline, _staticSitePrivateEndpointConnectionStaticSitesRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Approves or rejects a private endpoint connection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ApproveOrRejectPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSitePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> Request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        public virtual ArmOperation<StaticSitePrivateEndpointConnectionResource> Update(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics.CreateScope("StaticSitePrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _staticSitePrivateEndpointConnectionStaticSitesRestClient.ApproveOrRejectPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSitePrivateEndpointConnectionResource>(new StaticSitePrivateEndpointConnectionOperationSource(Client), _staticSitePrivateEndpointConnectionStaticSitesClientDiagnostics, Pipeline, _staticSitePrivateEndpointConnectionStaticSitesRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
