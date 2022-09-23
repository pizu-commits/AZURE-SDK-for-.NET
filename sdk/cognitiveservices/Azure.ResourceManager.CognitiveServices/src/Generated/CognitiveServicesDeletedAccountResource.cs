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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary>
    /// A Class representing a CognitiveServicesDeletedAccount along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CognitiveServicesDeletedAccountResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCognitiveServicesDeletedAccountResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetCognitiveServicesDeletedAccount method.
    /// </summary>
    public partial class CognitiveServicesDeletedAccountResource : BaseCognitiveServicesAccountResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CognitiveServicesDeletedAccountResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string resourceGroupName, string accountName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics;
        private readonly DeletedAccountsRestOperations _cognitiveServicesDeletedAccountDeletedAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesDeletedAccountResource"/> class for mocking. </summary>
        protected CognitiveServicesDeletedAccountResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CognitiveServicesDeletedAccountResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CognitiveServicesDeletedAccountResource(ArmClient client, CognitiveServicesAccountData data) : base(client, data)
        {
            _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cognitiveServicesDeletedAccountDeletedAccountsApiVersion);
            _cognitiveServicesDeletedAccountDeletedAccountsRestClient = new DeletedAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cognitiveServicesDeletedAccountDeletedAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesDeletedAccountResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CognitiveServicesDeletedAccountResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cognitiveServicesDeletedAccountDeletedAccountsApiVersion);
            _cognitiveServicesDeletedAccountDeletedAccountsRestClient = new DeletedAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cognitiveServicesDeletedAccountDeletedAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CognitiveServices/locations/resourceGroups/deletedAccounts";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Returns a Cognitive Services account specified by the parameters.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}
        /// Operation Id: DeletedAccounts_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseCognitiveServicesAccountResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("CognitiveServicesDeletedAccountResource.Get");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesDeletedAccountDeletedAccountsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a Cognitive Services account specified by the parameters.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}
        /// Operation Id: DeletedAccounts_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<CognitiveServicesDeletedAccountResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((CognitiveServicesDeletedAccountResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Returns a Cognitive Services account specified by the parameters.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}
        /// Operation Id: DeletedAccounts_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseCognitiveServicesAccountResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("CognitiveServicesDeletedAccountResource.Get");
            scope.Start();
            try
            {
                var response = _cognitiveServicesDeletedAccountDeletedAccountsRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a Cognitive Services account specified by the parameters.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}
        /// Operation Id: DeletedAccounts_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<CognitiveServicesDeletedAccountResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((CognitiveServicesDeletedAccountResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Deletes a Cognitive Services account from the resource group. 
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}
        /// Operation Id: DeletedAccounts_Purge
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("CognitiveServicesDeletedAccountResource.Delete");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesDeletedAccountDeletedAccountsRestClient.PurgeAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CognitiveServicesArmOperation(_cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics, Pipeline, _cognitiveServicesDeletedAccountDeletedAccountsRestClient.CreatePurgeRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Deletes a Cognitive Services account from the resource group. 
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}
        /// Operation Id: DeletedAccounts_Purge
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("CognitiveServicesDeletedAccountResource.Delete");
            scope.Start();
            try
            {
                var response = _cognitiveServicesDeletedAccountDeletedAccountsRestClient.Purge(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CognitiveServicesArmOperation(_cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics, Pipeline, _cognitiveServicesDeletedAccountDeletedAccountsRestClient.CreatePurgeRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
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
