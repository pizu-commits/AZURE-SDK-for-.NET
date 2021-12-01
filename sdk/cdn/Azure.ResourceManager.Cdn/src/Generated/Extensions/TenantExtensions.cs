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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    public static partial class TenantExtensions
    {
        private static CdnManagementRestOperations GetCdnManagementRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new CdnManagementRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        private static EdgeNodesRestOperations GetEdgeNodesRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, Uri endpoint = null)
        {
            return new EdgeNodesRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint);
        }

        /// <summary> Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityOutput>> CheckNameAvailabilityAsync(this Tenant tenant, CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            return await tenant.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("TenantExtensions.CheckNameAvailability");
                scope.Start();
                try
                {
                    var restOperations = GetCdnManagementRestOperations(clientDiagnostics, credential, options, pipeline, tenant.Id.SubscriptionId, baseUri);
                    var response = await restOperations.CheckNameAvailabilityAsync(checkNameAvailabilityInput, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public static Response<CheckNameAvailabilityOutput> CheckNameAvailability(this Tenant tenant, CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            return tenant.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("TenantExtensions.CheckNameAvailability");
                scope.Start();
                try
                {
                    var restOperations = GetCdnManagementRestOperations(clientDiagnostics, credential, options, pipeline, tenant.Id.SubscriptionId, baseUri);
                    var response = restOperations.CheckNameAvailability(checkNameAvailabilityInput, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Lists the EdgeNodes for this <see cref="Tenant" />. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EdgeNode> GetEdgeNodesAsync(this Tenant tenant, CancellationToken cancellationToken = default)
        {
            return tenant.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetEdgeNodesRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                async Task<Page<EdgeNode>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("TenantExtensions.GetEdgeNodes");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<EdgeNode>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("TenantExtensions.GetEdgeNodes");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
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
            );
        }

        /// <summary> Lists the EdgeNodes for this <see cref="Tenant" />. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<EdgeNode> GetEdgeNodes(this Tenant tenant, CancellationToken cancellationToken = default)
        {
            return tenant.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetEdgeNodesRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                Page<EdgeNode> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("TenantExtensions.GetEdgeNodes");
                    scope.Start();
                    try
                    {
                        var response = restOperations.List(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<EdgeNode> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("TenantExtensions.GetEdgeNodes");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListNextPage(nextLink, cancellationToken: cancellationToken);
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
            );
        }
    }
}
