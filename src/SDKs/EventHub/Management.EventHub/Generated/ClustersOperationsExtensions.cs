// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ClustersOperations.
    /// </summary>
    public static partial class ClustersOperationsExtensions
    {
            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            public static IPage<Cluster> ListByResourceGroup(this IClustersOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Cluster>> ListByResourceGroupAsync(this IClustersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the resource description of the specified Event Hubs Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            public static Cluster Get(this IClustersOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.GetAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the resource description of the specified Event Hubs Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> GetAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies mutable properties on the Event Hubs Cluster. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the Event Hubs Cluster which should be updated.
            /// </param>
            public static Cluster Patch(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters)
            {
                return operations.PatchAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies mutable properties on the Event Hubs Cluster. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the Event Hubs Cluster which should be updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> PatchAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies mutable properties on the Event Hubs Cluster. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the Event Hubs Cluster which should be updated.
            /// </param>
            public static Cluster BeginPatch(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters)
            {
                return operations.BeginPatchAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies mutable properties on the Event Hubs Cluster. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the Event Hubs Cluster which should be updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> BeginPatchAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPatchWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Cluster> ListByResourceGroupNext(this IClustersOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Cluster>> ListByResourceGroupNextAsync(this IClustersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
