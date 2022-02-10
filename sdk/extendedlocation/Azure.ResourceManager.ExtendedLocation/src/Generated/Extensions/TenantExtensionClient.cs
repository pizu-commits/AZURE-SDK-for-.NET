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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ExtendedLocation.Models;

namespace Azure.ResourceManager.ExtendedLocation
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    internal partial class TenantExtensionClient : ArmResource
    {
        private ClientDiagnostics _customLocationClientDiagnostics;
        private CustomLocationsRestOperations _customLocationRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantExtensionClient"/> class for mocking. </summary>
        protected TenantExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics CustomLocationClientDiagnostics => _customLocationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ExtendedLocation", CustomLocation.ResourceType.Namespace, DiagnosticOptions);
        private CustomLocationsRestOperations CustomLocationRestClient => _customLocationRestClient ??= new CustomLocationsRestOperations(CustomLocationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(CustomLocation.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            Client.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// RequestPath: /providers/Microsoft.ExtendedLocation/operations
        /// ContextualPath: /
        /// OperationId: CustomLocations_ListOperations
        /// <summary> Lists all available Custom Locations operations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomLocationOperation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CustomLocationOperation> GetOperationsCustomLocationsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CustomLocationOperation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = CustomLocationClientDiagnostics.CreateScope("TenantExtensionClient.GetOperationsCustomLocations");
                scope.Start();
                try
                {
                    var response = await CustomLocationRestClient.ListOperationsAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CustomLocationOperation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = CustomLocationClientDiagnostics.CreateScope("TenantExtensionClient.GetOperationsCustomLocations");
                scope.Start();
                try
                {
                    var response = await CustomLocationRestClient.ListOperationsNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.ExtendedLocation/operations
        /// ContextualPath: /
        /// OperationId: CustomLocations_ListOperations
        /// <summary> Lists all available Custom Locations operations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomLocationOperation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CustomLocationOperation> GetOperationsCustomLocations(CancellationToken cancellationToken = default)
        {
            Page<CustomLocationOperation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = CustomLocationClientDiagnostics.CreateScope("TenantExtensionClient.GetOperationsCustomLocations");
                scope.Start();
                try
                {
                    var response = CustomLocationRestClient.ListOperations(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CustomLocationOperation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = CustomLocationClientDiagnostics.CreateScope("TenantExtensionClient.GetOperationsCustomLocations");
                scope.Start();
                try
                {
                    var response = CustomLocationRestClient.ListOperationsNextPage(nextLink, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
