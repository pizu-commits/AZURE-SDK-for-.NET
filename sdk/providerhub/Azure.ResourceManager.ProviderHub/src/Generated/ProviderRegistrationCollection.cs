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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing a collection of <see cref="ProviderRegistrationResource"/> and their operations.
    /// Each <see cref="ProviderRegistrationResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="ProviderRegistrationCollection"/> instance call the GetProviderRegistrations method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class ProviderRegistrationCollection : ArmCollection, IEnumerable<ProviderRegistrationResource>, IAsyncEnumerable<ProviderRegistrationResource>
    {
        private readonly ClientDiagnostics _providerRegistrationClientDiagnostics;
        private readonly ProviderRegistrationsRestOperations _providerRegistrationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProviderRegistrationCollection"/> class for mocking. </summary>
        protected ProviderRegistrationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProviderRegistrationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProviderRegistrationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _providerRegistrationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", ProviderRegistrationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProviderRegistrationResource.ResourceType, out string providerRegistrationApiVersion);
            _providerRegistrationRestClient = new ProviderRegistrationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, providerRegistrationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the provider registration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="data"> The provider registration properties supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerNamespace"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ProviderRegistrationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string providerNamespace, ProviderRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _providerRegistrationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, providerNamespace, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<ProviderRegistrationResource>(new ProviderRegistrationOperationSource(Client), _providerRegistrationClientDiagnostics, Pipeline, _providerRegistrationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, providerNamespace, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates the provider registration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="data"> The provider registration properties supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerNamespace"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ProviderRegistrationResource> CreateOrUpdate(WaitUntil waitUntil, string providerNamespace, ProviderRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _providerRegistrationRestClient.CreateOrUpdate(Id.SubscriptionId, providerNamespace, data, cancellationToken);
                var operation = new ProviderHubArmOperation<ProviderRegistrationResource>(new ProviderRegistrationOperationSource(Client), _providerRegistrationClientDiagnostics, Pipeline, _providerRegistrationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, providerNamespace, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the provider registration details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerNamespace"/> is null. </exception>
        public virtual async Task<Response<ProviderRegistrationResource>> GetAsync(string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationCollection.Get");
            scope.Start();
            try
            {
                var response = await _providerRegistrationRestClient.GetAsync(Id.SubscriptionId, providerNamespace, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProviderRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the provider registration details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerNamespace"/> is null. </exception>
        public virtual Response<ProviderRegistrationResource> Get(string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationCollection.Get");
            scope.Start();
            try
            {
                var response = _providerRegistrationRestClient.Get(Id.SubscriptionId, providerNamespace, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProviderRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of the provider registrations in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProviderRegistrationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProviderRegistrationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _providerRegistrationRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _providerRegistrationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ProviderRegistrationResource(Client, ProviderRegistrationData.DeserializeProviderRegistrationData(e)), _providerRegistrationClientDiagnostics, Pipeline, "ProviderRegistrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of the provider registrations in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProviderRegistrationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProviderRegistrationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _providerRegistrationRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _providerRegistrationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ProviderRegistrationResource(Client, ProviderRegistrationData.DeserializeProviderRegistrationData(e)), _providerRegistrationClientDiagnostics, Pipeline, "ProviderRegistrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerNamespace"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _providerRegistrationRestClient.GetAsync(Id.SubscriptionId, providerNamespace, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerNamespace"/> is null. </exception>
        public virtual Response<bool> Exists(string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationCollection.Exists");
            scope.Start();
            try
            {
                var response = _providerRegistrationRestClient.Get(Id.SubscriptionId, providerNamespace, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerNamespace"/> is null. </exception>
        public virtual async Task<NullableResponse<ProviderRegistrationResource>> GetIfExistsAsync(string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _providerRegistrationRestClient.GetAsync(Id.SubscriptionId, providerNamespace, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ProviderRegistrationResource>(response.GetRawResponse());
                return Response.FromValue(new ProviderRegistrationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerNamespace"/> is null. </exception>
        public virtual NullableResponse<ProviderRegistrationResource> GetIfExists(string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _providerRegistrationRestClient.Get(Id.SubscriptionId, providerNamespace, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ProviderRegistrationResource>(response.GetRawResponse());
                return Response.FromValue(new ProviderRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProviderRegistrationResource> IEnumerable<ProviderRegistrationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProviderRegistrationResource> IAsyncEnumerable<ProviderRegistrationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
