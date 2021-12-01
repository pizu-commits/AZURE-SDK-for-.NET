// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdSecret and their operations over its parent. </summary>
    public partial class AfdSecretCollection : ArmCollection, IEnumerable<AfdSecret>, IAsyncEnumerable<AfdSecret>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AfdSecretsRestOperations _afdSecretsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdSecretCollection"/> class for mocking. </summary>
        protected AfdSecretCollection()
        {
        }

        /// <summary> Initializes a new instance of AfdSecretCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AfdSecretCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _afdSecretsRestClient = new AfdSecretsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Profile.ResourceType;

        // Collection level operations.

        /// <summary> Creates a new Secret within the specified profile. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="secret"> The Secret properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="secret"/> is null. </exception>
        public virtual AfdSecretCreateOperation CreateOrUpdate(string secretName, AfdSecretData secret, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }
            if (secret == null)
            {
                throw new ArgumentNullException(nameof(secret));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdSecretsRestClient.Create(Id.ResourceGroupName, Id.Name, secretName, secret, cancellationToken);
                var operation = new AfdSecretCreateOperation(Parent, _clientDiagnostics, Pipeline, _afdSecretsRestClient.CreateCreateRequest(Id.ResourceGroupName, Id.Name, secretName, secret).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new Secret within the specified profile. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="secret"> The Secret properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="secret"/> is null. </exception>
        public async virtual Task<AfdSecretCreateOperation> CreateOrUpdateAsync(string secretName, AfdSecretData secret, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }
            if (secret == null)
            {
                throw new ArgumentNullException(nameof(secret));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdSecretsRestClient.CreateAsync(Id.ResourceGroupName, Id.Name, secretName, secret, cancellationToken).ConfigureAwait(false);
                var operation = new AfdSecretCreateOperation(Parent, _clientDiagnostics, Pipeline, _afdSecretsRestClient.CreateCreateRequest(Id.ResourceGroupName, Id.Name, secretName, secret).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing Secret within a profile. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<AfdSecret> Get(string secretName, CancellationToken cancellationToken = default)
        {
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.Get");
            scope.Start();
            try
            {
                var response = _afdSecretsRestClient.Get(Id.ResourceGroupName, Id.Name, secretName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdSecret(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing Secret within a profile. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public async virtual Task<Response<AfdSecret>> GetAsync(string secretName, CancellationToken cancellationToken = default)
        {
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdSecretsRestClient.GetAsync(Id.ResourceGroupName, Id.Name, secretName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdSecret(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<AfdSecret> GetIfExists(string secretName, CancellationToken cancellationToken = default)
        {
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdSecretsRestClient.Get(Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AfdSecret>(null, response.GetRawResponse())
                    : Response.FromValue(new AfdSecret(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public async virtual Task<Response<AfdSecret>> GetIfExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _afdSecretsRestClient.GetAsync(Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AfdSecret>(null, response.GetRawResponse())
                    : Response.FromValue(new AfdSecret(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string secretName, CancellationToken cancellationToken = default)
        {
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(secretName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists existing AzureFrontDoor secrets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdSecret" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdSecret> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdSecret> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdSecretsRestClient.ListByProfile(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdSecret> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdSecretsRestClient.ListByProfileNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists existing AzureFrontDoor secrets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdSecret" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdSecret> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdSecret>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdSecretsRestClient.ListByProfileAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdSecret>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdSecretsRestClient.ListByProfileNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<AfdSecret> IEnumerable<AfdSecret>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdSecret> IAsyncEnumerable<AfdSecret>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, AfdSecret, AfdSecretData> Construct() { }
    }
}
