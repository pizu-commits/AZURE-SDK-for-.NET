// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    /// <summary>
    /// A class representing a collection of <see cref="FederatedIdentityCredentialResource"/> and their operations.
    /// Each <see cref="FederatedIdentityCredentialResource"/> in the collection will belong to the same instance of <see cref="UserAssignedIdentityResource"/>.
    /// To get a <see cref="FederatedIdentityCredentialCollection"/> instance call the GetFederatedIdentityCredentials method from an instance of <see cref="UserAssignedIdentityResource"/>.
    /// </summary>
    public partial class FederatedIdentityCredentialCollection : ArmCollection, IEnumerable<FederatedIdentityCredentialResource>, IAsyncEnumerable<FederatedIdentityCredentialResource>
    {
        private readonly ClientDiagnostics _federatedIdentityCredentialClientDiagnostics;
        private readonly FederatedIdentityCredentialsRestOperations _federatedIdentityCredentialRestClient;

        /// <summary> Initializes a new instance of the <see cref="FederatedIdentityCredentialCollection"/> class for mocking. </summary>
        protected FederatedIdentityCredentialCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FederatedIdentityCredentialCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FederatedIdentityCredentialCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _federatedIdentityCredentialClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedServiceIdentities", FederatedIdentityCredentialResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FederatedIdentityCredentialResource.ResourceType, out string federatedIdentityCredentialApiVersion);
            _federatedIdentityCredentialRestClient = new FederatedIdentityCredentialsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, federatedIdentityCredentialApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != UserAssignedIdentityResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, UserAssignedIdentityResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a federated identity credential under the specified user assigned identity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FederatedIdentityCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="federatedIdentityCredentialResourceName"> The name of the federated identity credential resource. </param>
        /// <param name="data"> Parameters to create or update the federated identity credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="federatedIdentityCredentialResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="federatedIdentityCredentialResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FederatedIdentityCredentialResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string federatedIdentityCredentialResourceName, FederatedIdentityCredentialData data, CancellationToken cancellationToken = default)
        {
            if (federatedIdentityCredentialResourceName == null)
            {
                throw new ArgumentNullException(nameof(federatedIdentityCredentialResourceName));
            }
            if (federatedIdentityCredentialResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(federatedIdentityCredentialResourceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _federatedIdentityCredentialRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, federatedIdentityCredentialResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedServiceIdentitiesArmOperation<FederatedIdentityCredentialResource>(Response.FromValue(new FederatedIdentityCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a federated identity credential under the specified user assigned identity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FederatedIdentityCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="federatedIdentityCredentialResourceName"> The name of the federated identity credential resource. </param>
        /// <param name="data"> Parameters to create or update the federated identity credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="federatedIdentityCredentialResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="federatedIdentityCredentialResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FederatedIdentityCredentialResource> CreateOrUpdate(WaitUntil waitUntil, string federatedIdentityCredentialResourceName, FederatedIdentityCredentialData data, CancellationToken cancellationToken = default)
        {
            if (federatedIdentityCredentialResourceName == null)
            {
                throw new ArgumentNullException(nameof(federatedIdentityCredentialResourceName));
            }
            if (federatedIdentityCredentialResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(federatedIdentityCredentialResourceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _federatedIdentityCredentialRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, federatedIdentityCredentialResourceName, data, cancellationToken);
                var operation = new ManagedServiceIdentitiesArmOperation<FederatedIdentityCredentialResource>(Response.FromValue(new FederatedIdentityCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Gets the federated identity credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FederatedIdentityCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="federatedIdentityCredentialResourceName"> The name of the federated identity credential resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="federatedIdentityCredentialResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="federatedIdentityCredentialResourceName"/> is null. </exception>
        public virtual async Task<Response<FederatedIdentityCredentialResource>> GetAsync(string federatedIdentityCredentialResourceName, CancellationToken cancellationToken = default)
        {
            if (federatedIdentityCredentialResourceName == null)
            {
                throw new ArgumentNullException(nameof(federatedIdentityCredentialResourceName));
            }
            if (federatedIdentityCredentialResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(federatedIdentityCredentialResourceName));
            }

            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = await _federatedIdentityCredentialRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, federatedIdentityCredentialResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FederatedIdentityCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the federated identity credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FederatedIdentityCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="federatedIdentityCredentialResourceName"> The name of the federated identity credential resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="federatedIdentityCredentialResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="federatedIdentityCredentialResourceName"/> is null. </exception>
        public virtual Response<FederatedIdentityCredentialResource> Get(string federatedIdentityCredentialResourceName, CancellationToken cancellationToken = default)
        {
            if (federatedIdentityCredentialResourceName == null)
            {
                throw new ArgumentNullException(nameof(federatedIdentityCredentialResourceName));
            }
            if (federatedIdentityCredentialResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(federatedIdentityCredentialResourceName));
            }

            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = _federatedIdentityCredentialRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, federatedIdentityCredentialResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FederatedIdentityCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the federated identity credentials under the specified user assigned identity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FederatedIdentityCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FederatedIdentityCredentialResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FederatedIdentityCredentialResource> GetAllAsync(int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _federatedIdentityCredentialRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _federatedIdentityCredentialRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FederatedIdentityCredentialResource(Client, FederatedIdentityCredentialData.DeserializeFederatedIdentityCredentialData(e)), _federatedIdentityCredentialClientDiagnostics, Pipeline, "FederatedIdentityCredentialCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the federated identity credentials under the specified user assigned identity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FederatedIdentityCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FederatedIdentityCredentialResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FederatedIdentityCredentialResource> GetAll(int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _federatedIdentityCredentialRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _federatedIdentityCredentialRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FederatedIdentityCredentialResource(Client, FederatedIdentityCredentialData.DeserializeFederatedIdentityCredentialData(e)), _federatedIdentityCredentialClientDiagnostics, Pipeline, "FederatedIdentityCredentialCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FederatedIdentityCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="federatedIdentityCredentialResourceName"> The name of the federated identity credential resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="federatedIdentityCredentialResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="federatedIdentityCredentialResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string federatedIdentityCredentialResourceName, CancellationToken cancellationToken = default)
        {
            if (federatedIdentityCredentialResourceName == null)
            {
                throw new ArgumentNullException(nameof(federatedIdentityCredentialResourceName));
            }
            if (federatedIdentityCredentialResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(federatedIdentityCredentialResourceName));
            }

            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = await _federatedIdentityCredentialRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, federatedIdentityCredentialResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FederatedIdentityCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="federatedIdentityCredentialResourceName"> The name of the federated identity credential resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="federatedIdentityCredentialResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="federatedIdentityCredentialResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string federatedIdentityCredentialResourceName, CancellationToken cancellationToken = default)
        {
            if (federatedIdentityCredentialResourceName == null)
            {
                throw new ArgumentNullException(nameof(federatedIdentityCredentialResourceName));
            }
            if (federatedIdentityCredentialResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(federatedIdentityCredentialResourceName));
            }

            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = _federatedIdentityCredentialRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, federatedIdentityCredentialResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FederatedIdentityCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="federatedIdentityCredentialResourceName"> The name of the federated identity credential resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="federatedIdentityCredentialResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="federatedIdentityCredentialResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<FederatedIdentityCredentialResource>> GetIfExistsAsync(string federatedIdentityCredentialResourceName, CancellationToken cancellationToken = default)
        {
            if (federatedIdentityCredentialResourceName == null)
            {
                throw new ArgumentNullException(nameof(federatedIdentityCredentialResourceName));
            }
            if (federatedIdentityCredentialResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(federatedIdentityCredentialResourceName));
            }

            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _federatedIdentityCredentialRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, federatedIdentityCredentialResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FederatedIdentityCredentialResource>(response.GetRawResponse());
                return Response.FromValue(new FederatedIdentityCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FederatedIdentityCredentialResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="federatedIdentityCredentialResourceName"> The name of the federated identity credential resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="federatedIdentityCredentialResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="federatedIdentityCredentialResourceName"/> is null. </exception>
        public virtual NullableResponse<FederatedIdentityCredentialResource> GetIfExists(string federatedIdentityCredentialResourceName, CancellationToken cancellationToken = default)
        {
            if (federatedIdentityCredentialResourceName == null)
            {
                throw new ArgumentNullException(nameof(federatedIdentityCredentialResourceName));
            }
            if (federatedIdentityCredentialResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(federatedIdentityCredentialResourceName));
            }

            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _federatedIdentityCredentialRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, federatedIdentityCredentialResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FederatedIdentityCredentialResource>(response.GetRawResponse());
                return Response.FromValue(new FederatedIdentityCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FederatedIdentityCredentialResource> IEnumerable<FederatedIdentityCredentialResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FederatedIdentityCredentialResource> IAsyncEnumerable<FederatedIdentityCredentialResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
