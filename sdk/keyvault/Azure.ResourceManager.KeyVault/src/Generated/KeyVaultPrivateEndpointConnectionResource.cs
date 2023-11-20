// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary>
    /// A Class representing a KeyVaultPrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="KeyVaultPrivateEndpointConnectionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetKeyVaultPrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="KeyVaultResource"/> using the GetKeyVaultPrivateEndpointConnection method.
    /// </summary>
    public partial class KeyVaultPrivateEndpointConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="KeyVaultPrivateEndpointConnectionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="vaultName"> The vaultName. </param>
        /// <param name="privateEndpointConnectionName"> The privateEndpointConnectionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsRestClient;
        private readonly KeyVaultPrivateEndpointConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="KeyVaultPrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected KeyVaultPrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KeyVaultPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal KeyVaultPrivateEndpointConnectionResource(ArmClient client, KeyVaultPrivateEndpointConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="KeyVaultPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal KeyVaultPrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KeyVault", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
            _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.KeyVault/vaults/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual KeyVaultPrivateEndpointConnectionData Data
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
        /// Gets the specified private endpoint connection associated with the key vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KeyVaultPrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("KeyVaultPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KeyVaultPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private endpoint connection associated with the key vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KeyVaultPrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("KeyVaultPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KeyVaultPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified private endpoint connection associated with the key vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<KeyVaultPrivateEndpointConnectionResource>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("KeyVaultPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new KeyVaultArmOperation<KeyVaultPrivateEndpointConnectionResource>(new KeyVaultPrivateEndpointConnectionOperationSource(Client), _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the specified private endpoint connection associated with the key vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<KeyVaultPrivateEndpointConnectionResource> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("KeyVaultPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new KeyVaultArmOperation<KeyVaultPrivateEndpointConnectionResource>(new KeyVaultPrivateEndpointConnectionOperationSource(Client), _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Updates the specified private endpoint connection associated with the key vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The intended state of private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KeyVaultPrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, KeyVaultPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("KeyVaultPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new KeyVaultArmOperation<KeyVaultPrivateEndpointConnectionResource>(Response.FromValue(new KeyVaultPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Updates the specified private endpoint connection associated with the key vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The intended state of private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KeyVaultPrivateEndpointConnectionResource> Update(WaitUntil waitUntil, KeyVaultPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("KeyVaultPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _keyVaultPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new KeyVaultArmOperation<KeyVaultPrivateEndpointConnectionResource>(Response.FromValue(new KeyVaultPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
