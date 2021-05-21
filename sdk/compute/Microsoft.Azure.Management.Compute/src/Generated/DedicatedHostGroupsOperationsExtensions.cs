// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DedicatedHostGroupsOperations.
    /// </summary>
    public static partial class DedicatedHostGroupsOperationsExtensions
    {
            /// <summary>
            /// Create or update a dedicated host group. For details of Dedicated Host and
            /// Dedicated Host Groups please see [Dedicated Host Documentation]
            /// (https://go.microsoft.com/fwlink/?linkid=2082596)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hostGroupName'>
            /// The name of the dedicated host group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Dedicated Host Group.
            /// </param>
            public static DedicatedHostGroup CreateOrUpdate(this IDedicatedHostGroupsOperations operations, string resourceGroupName, string hostGroupName, DedicatedHostGroup parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, hostGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a dedicated host group. For details of Dedicated Host and
            /// Dedicated Host Groups please see [Dedicated Host Documentation]
            /// (https://go.microsoft.com/fwlink/?linkid=2082596)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hostGroupName'>
            /// The name of the dedicated host group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Dedicated Host Group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DedicatedHostGroup> CreateOrUpdateAsync(this IDedicatedHostGroupsOperations operations, string resourceGroupName, string hostGroupName, DedicatedHostGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hostGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an dedicated host group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hostGroupName'>
            /// The name of the dedicated host group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update Dedicated Host Group operation.
            /// </param>
            public static DedicatedHostGroup Update(this IDedicatedHostGroupsOperations operations, string resourceGroupName, string hostGroupName, DedicatedHostGroupUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, hostGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an dedicated host group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hostGroupName'>
            /// The name of the dedicated host group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update Dedicated Host Group operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DedicatedHostGroup> UpdateAsync(this IDedicatedHostGroupsOperations operations, string resourceGroupName, string hostGroupName, DedicatedHostGroupUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, hostGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a dedicated host group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hostGroupName'>
            /// The name of the dedicated host group.
            /// </param>
            public static void Delete(this IDedicatedHostGroupsOperations operations, string resourceGroupName, string hostGroupName)
            {
                operations.DeleteAsync(resourceGroupName, hostGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a dedicated host group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hostGroupName'>
            /// The name of the dedicated host group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDedicatedHostGroupsOperations operations, string resourceGroupName, string hostGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, hostGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves information about a dedicated host group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hostGroupName'>
            /// The name of the dedicated host group.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. The response shows the
            /// list of instance view of the dedicated hosts under the dedicated host
            /// group. Possible values include: 'instanceView'
            /// </param>
            public static DedicatedHostGroup Get(this IDedicatedHostGroupsOperations operations, string resourceGroupName, string hostGroupName, InstanceViewTypes? expand = default(InstanceViewTypes?))
            {
                return operations.GetAsync(resourceGroupName, hostGroupName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves information about a dedicated host group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hostGroupName'>
            /// The name of the dedicated host group.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. The response shows the
            /// list of instance view of the dedicated hosts under the dedicated host
            /// group. Possible values include: 'instanceView'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DedicatedHostGroup> GetAsync(this IDedicatedHostGroupsOperations operations, string resourceGroupName, string hostGroupName, InstanceViewTypes? expand = default(InstanceViewTypes?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, hostGroupName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the dedicated host groups in the specified resource group. Use
            /// the nextLink property in the response to get the next page of dedicated
            /// host groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<DedicatedHostGroup> ListByResourceGroup(this IDedicatedHostGroupsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the dedicated host groups in the specified resource group. Use
            /// the nextLink property in the response to get the next page of dedicated
            /// host groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DedicatedHostGroup>> ListByResourceGroupAsync(this IDedicatedHostGroupsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the dedicated host groups in the subscription. Use the
            /// nextLink property in the response to get the next page of dedicated host
            /// groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<DedicatedHostGroup> ListBySubscription(this IDedicatedHostGroupsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the dedicated host groups in the subscription. Use the
            /// nextLink property in the response to get the next page of dedicated host
            /// groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DedicatedHostGroup>> ListBySubscriptionAsync(this IDedicatedHostGroupsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the dedicated host groups in the specified resource group. Use
            /// the nextLink property in the response to get the next page of dedicated
            /// host groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DedicatedHostGroup> ListByResourceGroupNext(this IDedicatedHostGroupsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the dedicated host groups in the specified resource group. Use
            /// the nextLink property in the response to get the next page of dedicated
            /// host groups.
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
            public static async Task<IPage<DedicatedHostGroup>> ListByResourceGroupNextAsync(this IDedicatedHostGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the dedicated host groups in the subscription. Use the
            /// nextLink property in the response to get the next page of dedicated host
            /// groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DedicatedHostGroup> ListBySubscriptionNext(this IDedicatedHostGroupsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the dedicated host groups in the subscription. Use the
            /// nextLink property in the response to get the next page of dedicated host
            /// groups.
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
            public static async Task<IPage<DedicatedHostGroup>> ListBySubscriptionNextAsync(this IDedicatedHostGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
