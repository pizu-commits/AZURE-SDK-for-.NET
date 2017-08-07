// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EnvironmentsOperations.
    /// </summary>
    public static partial class EnvironmentsOperationsExtensions
    {
            /// <summary>
            /// List environments in a given user profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DtlEnvironmentInner>> ListAsync(this IEnvironmentsOperations operations, string resourceGroupName, string labName, string userName, ODataQuery<DtlEnvironmentInner> odataQuery = default(ODataQuery<DtlEnvironmentInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labName, userName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example:
            /// 'properties($select=deploymentProperties)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DtlEnvironmentInner> GetAsync(this IEnvironmentsOperations operations, string resourceGroupName, string labName, string userName, string name, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, labName, userName, name, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing environment. This operation can take a while
            /// to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='dtlEnvironment'>
            /// An environment, which is essentially an ARM template deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DtlEnvironmentInner> CreateOrUpdateAsync(this IEnvironmentsOperations operations, string resourceGroupName, string labName, string userName, string name, DtlEnvironmentInner dtlEnvironment, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labName, userName, name, dtlEnvironment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete environment. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IEnvironmentsOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or replace an existing environment. This operation can take a while
            /// to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='dtlEnvironment'>
            /// An environment, which is essentially an ARM template deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DtlEnvironmentInner> BeginCreateOrUpdateAsync(this IEnvironmentsOperations operations, string resourceGroupName, string labName, string userName, string name, DtlEnvironmentInner dtlEnvironment, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labName, userName, name, dtlEnvironment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete environment. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IEnvironmentsOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List environments in a given user profile.
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
            public static async Task<IPage<DtlEnvironmentInner>> ListNextAsync(this IEnvironmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
