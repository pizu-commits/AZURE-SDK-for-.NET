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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Attestation.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Attestation
{
    /// <summary>
    /// A class representing a collection of <see cref="AttestationProviderResource" /> and their operations.
    /// Each <see cref="AttestationProviderResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AttestationProviderCollection" /> instance call the GetAttestationProviders method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AttestationProviderCollection : ArmCollection, IEnumerable<AttestationProviderResource>, IAsyncEnumerable<AttestationProviderResource>
    {
        private readonly ClientDiagnostics _attestationProviderClientDiagnostics;
        private readonly AttestationProvidersRestOperations _attestationProviderRestClient;

        /// <summary> Initializes a new instance of the <see cref="AttestationProviderCollection"/> class for mocking. </summary>
        protected AttestationProviderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AttestationProviderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AttestationProviderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _attestationProviderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Attestation", AttestationProviderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AttestationProviderResource.ResourceType, out string attestationProviderApiVersion);
            _attestationProviderRestClient = new AttestationProvidersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, attestationProviderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new Attestation Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="content"> Client supplied parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AttestationProviderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string providerName, AttestationProviderCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _attestationProviderClientDiagnostics.CreateScope("AttestationProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _attestationProviderRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AttestationArmOperation<AttestationProviderResource>(Response.FromValue(new AttestationProviderResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new Attestation Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="content"> Client supplied parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AttestationProviderResource> CreateOrUpdate(WaitUntil waitUntil, string providerName, AttestationProviderCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _attestationProviderClientDiagnostics.CreateScope("AttestationProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _attestationProviderRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, providerName, content, cancellationToken);
                var operation = new AttestationArmOperation<AttestationProviderResource>(Response.FromValue(new AttestationProviderResource(Client, response), response.GetRawResponse()));
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
        /// Get the status of Attestation Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        public virtual async Task<Response<AttestationProviderResource>> GetAsync(string providerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));

            using var scope = _attestationProviderClientDiagnostics.CreateScope("AttestationProviderCollection.Get");
            scope.Start();
            try
            {
                var response = await _attestationProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AttestationProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the status of Attestation Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        public virtual Response<AttestationProviderResource> Get(string providerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));

            using var scope = _attestationProviderClientDiagnostics.CreateScope("AttestationProviderCollection.Get");
            scope.Start();
            try
            {
                var response = _attestationProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, providerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AttestationProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns attestation providers list in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AttestationProviderResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _attestationProviderRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AttestationProviderResource(Client, AttestationProviderData.DeserializeAttestationProviderData(e)), _attestationProviderClientDiagnostics, Pipeline, "AttestationProviderCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns attestation providers list in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AttestationProviderResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _attestationProviderRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, null, e => new AttestationProviderResource(Client, AttestationProviderData.DeserializeAttestationProviderData(e)), _attestationProviderClientDiagnostics, Pipeline, "AttestationProviderCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string providerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));

            using var scope = _attestationProviderClientDiagnostics.CreateScope("AttestationProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _attestationProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        public virtual Response<bool> Exists(string providerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));

            using var scope = _attestationProviderClientDiagnostics.CreateScope("AttestationProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = _attestationProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, providerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AttestationProviderResource> IEnumerable<AttestationProviderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AttestationProviderResource> IAsyncEnumerable<AttestationProviderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
