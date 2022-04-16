// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _vaultClientDiagnostics;
        private VaultsRestOperations _vaultRestClient;
        private ClientDiagnostics _vaultsClientDiagnostics;
        private VaultsRestOperations _vaultsRestClient;
        private ClientDiagnostics _managedHsmClientDiagnostics;
        private ManagedHsmsRestOperations _managedHsmRestClient;
        private ClientDiagnostics _managedHsmsClientDiagnostics;
        private ManagedHsmsRestOperations _managedHsmsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics VaultClientDiagnostics => _vaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", VaultResource.ResourceType.Namespace, Diagnostics);
        private VaultsRestOperations VaultRestClient => _vaultRestClient ??= new VaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(VaultResource.ResourceType));
        private ClientDiagnostics VaultsClientDiagnostics => _vaultsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private VaultsRestOperations VaultsRestClient => _vaultsRestClient ??= new VaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ManagedHsmClientDiagnostics => _managedHsmClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", ManagedHsmResource.ResourceType.Namespace, Diagnostics);
        private ManagedHsmsRestOperations ManagedHsmRestClient => _managedHsmRestClient ??= new ManagedHsmsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ManagedHsmResource.ResourceType));
        private ClientDiagnostics ManagedHsmsClientDiagnostics => _managedHsmsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ManagedHsmsRestOperations ManagedHsmsRestClient => _managedHsmsRestClient ??= new ManagedHsmsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeletedVaultResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of DeletedVaultResources and their operations over a DeletedVaultResource. </returns>
        public virtual DeletedVaultCollection GetDeletedVaults()
        {
            return GetCachedClient(Client => new DeletedVaultCollection(Client, Id));
        }

        /// <summary> Gets a collection of DeletedManagedHsmResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of DeletedManagedHsmResources and their operations over a DeletedManagedHsmResource. </returns>
        public virtual DeletedManagedHsmCollection GetDeletedManagedHsms()
        {
            return GetCachedClient(Client => new DeletedManagedHsmCollection(Client, Id));
        }

        /// <summary>
        /// The List operation gets information about the vaults associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/vaults
        /// Operation Id: Vaults_ListBySubscription
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VaultResource> GetVaultsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VaultResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetVaults");
                scope.Start();
                try
                {
                    var response = await VaultRestClient.ListBySubscriptionAsync(Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VaultResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetVaults");
                scope.Start();
                try
                {
                    var response = await VaultRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// The List operation gets information about the vaults associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/vaults
        /// Operation Id: Vaults_ListBySubscription
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VaultResource> GetVaults(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<VaultResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetVaults");
                scope.Start();
                try
                {
                    var response = VaultRestClient.ListBySubscription(Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VaultResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetVaults");
                scope.Start();
                try
                {
                    var response = VaultRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets information about the deleted vaults in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedVaults
        /// Operation Id: Vaults_ListDeleted
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedVaultResource> GetDeletedVaultsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedVaultResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedVaults");
                scope.Start();
                try
                {
                    var response = await VaultsRestClient.ListDeletedAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedVaultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeletedVaultResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedVaults");
                scope.Start();
                try
                {
                    var response = await VaultsRestClient.ListDeletedNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedVaultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets information about the deleted vaults in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedVaults
        /// Operation Id: Vaults_ListDeleted
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedVaultResource> GetDeletedVaults(CancellationToken cancellationToken = default)
        {
            Page<DeletedVaultResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedVaults");
                scope.Start();
                try
                {
                    var response = VaultsRestClient.ListDeleted(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedVaultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeletedVaultResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedVaults");
                scope.Start();
                try
                {
                    var response = VaultsRestClient.ListDeletedNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedVaultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks that the vault name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkNameAvailability
        /// Operation Id: Vaults_CheckNameAvailability
        /// </summary>
        /// <param name="content"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameAvailabilityResult>> CheckKeyVaultNameAvailabilityAsync(VaultCheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckKeyVaultNameAvailability");
            scope.Start();
            try
            {
                var response = await VaultsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the vault name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkNameAvailability
        /// Operation Id: Vaults_CheckNameAvailability
        /// </summary>
        /// <param name="content"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResult> CheckKeyVaultNameAvailability(VaultCheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckKeyVaultNameAvailability");
            scope.Start();
            try
            {
                var response = VaultsRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The List operation gets information about the managed HSM Pools associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/managedHSMs
        /// Operation Id: ManagedHsms_ListBySubscription
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedHsmResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedHsmResource> GetManagedHsmsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedHsmResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedHsmClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedHsms");
                scope.Start();
                try
                {
                    var response = await ManagedHsmRestClient.ListBySubscriptionAsync(Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedHsmResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedHsmResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedHsmClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedHsms");
                scope.Start();
                try
                {
                    var response = await ManagedHsmRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedHsmResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// The List operation gets information about the managed HSM Pools associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/managedHSMs
        /// Operation Id: ManagedHsms_ListBySubscription
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedHsmResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedHsmResource> GetManagedHsms(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedHsmResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedHsmClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedHsms");
                scope.Start();
                try
                {
                    var response = ManagedHsmRestClient.ListBySubscription(Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedHsmResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedHsmResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedHsmClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedHsms");
                scope.Start();
                try
                {
                    var response = ManagedHsmRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedHsmResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// The List operation gets information about the deleted managed HSMs associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedManagedHSMs
        /// Operation Id: ManagedHsms_ListDeleted
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedManagedHsmResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedManagedHsmResource> GetDeletedManagedHsmsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedManagedHsmResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedHsmsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedManagedHsms");
                scope.Start();
                try
                {
                    var response = await ManagedHsmsRestClient.ListDeletedAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedManagedHsmResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeletedManagedHsmResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedHsmsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedManagedHsms");
                scope.Start();
                try
                {
                    var response = await ManagedHsmsRestClient.ListDeletedNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedManagedHsmResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// The List operation gets information about the deleted managed HSMs associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedManagedHSMs
        /// Operation Id: ManagedHsms_ListDeleted
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedManagedHsmResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedManagedHsmResource> GetDeletedManagedHsms(CancellationToken cancellationToken = default)
        {
            Page<DeletedManagedHsmResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedHsmsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedManagedHsms");
                scope.Start();
                try
                {
                    var response = ManagedHsmsRestClient.ListDeleted(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedManagedHsmResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeletedManagedHsmResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedHsmsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDeletedManagedHsms");
                scope.Start();
                try
                {
                    var response = ManagedHsmsRestClient.ListDeletedNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedManagedHsmResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
