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

namespace Azure.ResourceManager.Orbital
{
    /// <summary>
    /// A class representing a collection of <see cref="OrbitalContactResource" /> and their operations.
    /// Each <see cref="OrbitalContactResource" /> in the collection will belong to the same instance of <see cref="OrbitalSpacecraftResource" />.
    /// To get an <see cref="OrbitalContactCollection" /> instance call the GetOrbitalContacts method from an instance of <see cref="OrbitalSpacecraftResource" />.
    /// </summary>
    public partial class OrbitalContactCollection : ArmCollection, IEnumerable<OrbitalContactResource>, IAsyncEnumerable<OrbitalContactResource>
    {
        private readonly ClientDiagnostics _orbitalContactContactsClientDiagnostics;
        private readonly ContactsRestOperations _orbitalContactContactsRestClient;

        /// <summary> Initializes a new instance of the <see cref="OrbitalContactCollection"/> class for mocking. </summary>
        protected OrbitalContactCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OrbitalContactCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OrbitalContactCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _orbitalContactContactsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Orbital", OrbitalContactResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OrbitalContactResource.ResourceType, out string orbitalContactContactsApiVersion);
            _orbitalContactContactsRestClient = new ContactsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, orbitalContactContactsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OrbitalSpacecraftResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OrbitalSpacecraftResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a contact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}/contacts/{contactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Contacts_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="contactName"> Contact name. </param>
        /// <param name="data"> The parameters to provide for the created contact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contactName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OrbitalContactResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string contactName, OrbitalContactData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contactName, nameof(contactName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _orbitalContactContactsClientDiagnostics.CreateScope("OrbitalContactCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _orbitalContactContactsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contactName, data, cancellationToken).ConfigureAwait(false);
                var operation = new OrbitalArmOperation<OrbitalContactResource>(new OrbitalContactOperationSource(Client), _orbitalContactContactsClientDiagnostics, Pipeline, _orbitalContactContactsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contactName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a contact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}/contacts/{contactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Contacts_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="contactName"> Contact name. </param>
        /// <param name="data"> The parameters to provide for the created contact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contactName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OrbitalContactResource> CreateOrUpdate(WaitUntil waitUntil, string contactName, OrbitalContactData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contactName, nameof(contactName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _orbitalContactContactsClientDiagnostics.CreateScope("OrbitalContactCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _orbitalContactContactsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contactName, data, cancellationToken);
                var operation = new OrbitalArmOperation<OrbitalContactResource>(new OrbitalContactOperationSource(Client), _orbitalContactContactsClientDiagnostics, Pipeline, _orbitalContactContactsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contactName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified contact in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}/contacts/{contactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Contacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="contactName"> Contact name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contactName"/> is null. </exception>
        public virtual async Task<Response<OrbitalContactResource>> GetAsync(string contactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contactName, nameof(contactName));

            using var scope = _orbitalContactContactsClientDiagnostics.CreateScope("OrbitalContactCollection.Get");
            scope.Start();
            try
            {
                var response = await _orbitalContactContactsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contactName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OrbitalContactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified contact in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}/contacts/{contactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Contacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="contactName"> Contact name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contactName"/> is null. </exception>
        public virtual Response<OrbitalContactResource> Get(string contactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contactName, nameof(contactName));

            using var scope = _orbitalContactContactsClientDiagnostics.CreateScope("OrbitalContactCollection.Get");
            scope.Start();
            try
            {
                var response = _orbitalContactContactsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contactName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OrbitalContactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns list of contacts by spacecraftName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}/contacts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Contacts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrbitalContactResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OrbitalContactResource> GetAllAsync(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _orbitalContactContactsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _orbitalContactContactsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skiptoken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new OrbitalContactResource(Client, OrbitalContactData.DeserializeOrbitalContactData(e)), _orbitalContactContactsClientDiagnostics, Pipeline, "OrbitalContactCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of contacts by spacecraftName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}/contacts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Contacts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrbitalContactResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OrbitalContactResource> GetAll(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _orbitalContactContactsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _orbitalContactContactsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skiptoken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new OrbitalContactResource(Client, OrbitalContactData.DeserializeOrbitalContactData(e)), _orbitalContactContactsClientDiagnostics, Pipeline, "OrbitalContactCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}/contacts/{contactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Contacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="contactName"> Contact name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contactName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string contactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contactName, nameof(contactName));

            using var scope = _orbitalContactContactsClientDiagnostics.CreateScope("OrbitalContactCollection.Exists");
            scope.Start();
            try
            {
                var response = await _orbitalContactContactsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contactName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}/contacts/{contactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Contacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="contactName"> Contact name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contactName"/> is null. </exception>
        public virtual Response<bool> Exists(string contactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contactName, nameof(contactName));

            using var scope = _orbitalContactContactsClientDiagnostics.CreateScope("OrbitalContactCollection.Exists");
            scope.Start();
            try
            {
                var response = _orbitalContactContactsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contactName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OrbitalContactResource> IEnumerable<OrbitalContactResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OrbitalContactResource> IAsyncEnumerable<OrbitalContactResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
