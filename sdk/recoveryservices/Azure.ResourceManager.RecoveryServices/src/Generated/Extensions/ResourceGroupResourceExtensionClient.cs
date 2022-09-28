// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServices.Models;

namespace Azure.ResourceManager.RecoveryServices
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _recoveryServicesClientDiagnostics;
        private RecoveryServicesRestOperations _recoveryServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics RecoveryServicesClientDiagnostics => _recoveryServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.RecoveryServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private RecoveryServicesRestOperations RecoveryServicesRestClient => _recoveryServicesRestClient ??= new RecoveryServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of VaultResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VaultResources and their operations over a VaultResource. </returns>
        public virtual VaultCollection GetVaults()
        {
            return GetCachedClient(Client => new VaultCollection(Client, Id));
        }

        /// <summary>
        /// API to check for resource name availability.
        /// A name is available if no other resource exists that has the same SubscriptionId, Resource Name and Type
        /// or if one or more such resources exist, each of these must be GC&apos;d and their time of deletion be more than 24 Hours Ago
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/locations/{location}/checkNameAvailability
        /// Operation Id: RecoveryServices_CheckNameAvailability
        /// </summary>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="content"> Contains information about Resource type and Resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityRecoveryServiceAsync(AzureLocation location, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = RecoveryServicesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CheckNameAvailabilityRecoveryService");
            scope.Start();
            try
            {
                var response = await RecoveryServicesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, Id.ResourceGroupName, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// API to check for resource name availability.
        /// A name is available if no other resource exists that has the same SubscriptionId, Resource Name and Type
        /// or if one or more such resources exist, each of these must be GC&apos;d and their time of deletion be more than 24 Hours Ago
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/locations/{location}/checkNameAvailability
        /// Operation Id: RecoveryServices_CheckNameAvailability
        /// </summary>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="content"> Contains information about Resource type and Resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResult> CheckNameAvailabilityRecoveryService(AzureLocation location, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = RecoveryServicesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CheckNameAvailabilityRecoveryService");
            scope.Start();
            try
            {
                var response = RecoveryServicesRestClient.CheckNameAvailability(Id.SubscriptionId, Id.ResourceGroupName, location, content, cancellationToken);
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
