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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiDiagnostic along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ApiDiagnosticResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetApiDiagnosticResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiResource" /> using the GetApiDiagnostic method.
    /// </summary>
    public partial class ApiDiagnosticResource : DiagnosticContractResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiDiagnosticResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string diagnosticId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiDiagnosticClientDiagnostics;
        private readonly ApiDiagnosticRestOperations _apiDiagnosticRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiDiagnosticResource"/> class for mocking. </summary>
        protected ApiDiagnosticResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApiDiagnosticResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiDiagnosticResource(ArmClient client, DiagnosticContractData data) : base(client, data)
        {
            _apiDiagnosticClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiDiagnosticApiVersion);
            _apiDiagnosticRestClient = new ApiDiagnosticRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiDiagnosticApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ApiDiagnosticResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiDiagnosticResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiDiagnosticClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiDiagnosticApiVersion);
            _apiDiagnosticRestClient = new ApiDiagnosticRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiDiagnosticApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/apis/diagnostics";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets the details of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<DiagnosticContractResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticResource.Get");
            scope.Start();
            try
            {
                var response = await _apiDiagnosticRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets the details of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<ApiDiagnosticResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ApiDiagnosticResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets the details of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<DiagnosticContractResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticResource.Get");
            scope.Start();
            try
            {
                var response = _apiDiagnosticRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Gets the details of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<ApiDiagnosticResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((ApiDiagnosticResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Deletes the specified Diagnostic from an API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticResource.Delete");
            scope.Start();
            try
            {
                var response = await _apiDiagnosticRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation(response);
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
        /// Deletes the specified Diagnostic from an API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticResource.Delete");
            scope.Start();
            try
            {
                var response = _apiDiagnosticRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation(response);
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

        /// <summary>
        /// The core implementation for operation Update
        /// Updates the details of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Update
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Diagnostic Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<Response<DiagnosticContractResource>> UpdateCoreAsync(ETag ifMatch, DiagnosticContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticResource.Update");
            scope.Start();
            try
            {
                var response = await _apiDiagnosticRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the details of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Update
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Diagnostic Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<Response<ApiDiagnosticResource>> UpdateAsync(ETag ifMatch, DiagnosticContractData data, CancellationToken cancellationToken = default)
        {
            var result = await UpdateCoreAsync(ifMatch, data, cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ApiDiagnosticResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Updates the details of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Update
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Diagnostic Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override Response<DiagnosticContractResource> UpdateCore(ETag ifMatch, DiagnosticContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticResource.Update");
            scope.Start();
            try
            {
                var response = _apiDiagnosticRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, data, cancellationToken);
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the details of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Update
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Diagnostic Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new Response<ApiDiagnosticResource> Update(ETag ifMatch, DiagnosticContractData data, CancellationToken cancellationToken = default)
        {
            var result = UpdateCore(ifMatch, data, cancellationToken);
            return Response.FromValue((ApiDiagnosticResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation GetEntityTag
        /// Gets the entity state (Etag) version of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_GetEntityTag
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<bool>> GetEntityTagCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _apiDiagnosticRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation GetEntityTag
        /// Gets the entity state (Etag) version of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_GetEntityTag
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<bool> GetEntityTagCore(CancellationToken cancellationToken = default)
        {
            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _apiDiagnosticRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
