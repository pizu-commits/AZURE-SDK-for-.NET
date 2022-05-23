// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SecurityUserConfigurationsOperations.
    /// </summary>
    public static partial class SecurityUserConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Lists all the network manager security user configurations in a network
            /// manager, in a paginated format.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkManagerName'>
            /// The name of the network manager.
            /// </param>
            /// <param name='top'>
            /// An optional query parameter which specifies the maximum number of records
            /// to be returned by the server.
            /// </param>
            /// <param name='skipToken'>
            /// SkipToken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skipToken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            public static IPage<SecurityUserConfiguration> List(this ISecurityUserConfigurationsOperations operations, string resourceGroupName, string networkManagerName, int? top = default(int?), string skipToken = default(string))
            {
                return operations.ListAsync(resourceGroupName, networkManagerName, top, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the network manager security user configurations in a network
            /// manager, in a paginated format.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkManagerName'>
            /// The name of the network manager.
            /// </param>
            /// <param name='top'>
            /// An optional query parameter which specifies the maximum number of records
            /// to be returned by the server.
            /// </param>
            /// <param name='skipToken'>
            /// SkipToken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skipToken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SecurityUserConfiguration>> ListAsync(this ISecurityUserConfigurationsOperations operations, string resourceGroupName, string networkManagerName, int? top = default(int?), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkManagerName, top, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a network manager security user configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkManagerName'>
            /// The name of the network manager.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the network manager Security Configuration.
            /// </param>
            public static SecurityUserConfiguration Get(this ISecurityUserConfigurationsOperations operations, string resourceGroupName, string networkManagerName, string configurationName)
            {
                return operations.GetAsync(resourceGroupName, networkManagerName, configurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a network manager security user configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkManagerName'>
            /// The name of the network manager.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the network manager Security Configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityUserConfiguration> GetAsync(this ISecurityUserConfigurationsOperations operations, string resourceGroupName, string networkManagerName, string configurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkManagerName, configurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a network manager security user configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='securityUserConfiguration'>
            /// The security user configuration to create or update
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkManagerName'>
            /// The name of the network manager.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the network manager Security Configuration.
            /// </param>
            public static SecurityUserConfiguration CreateOrUpdate(this ISecurityUserConfigurationsOperations operations, SecurityUserConfiguration securityUserConfiguration, string resourceGroupName, string networkManagerName, string configurationName)
            {
                return operations.CreateOrUpdateAsync(securityUserConfiguration, resourceGroupName, networkManagerName, configurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a network manager security user configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='securityUserConfiguration'>
            /// The security user configuration to create or update
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkManagerName'>
            /// The name of the network manager.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the network manager Security Configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityUserConfiguration> CreateOrUpdateAsync(this ISecurityUserConfigurationsOperations operations, SecurityUserConfiguration securityUserConfiguration, string resourceGroupName, string networkManagerName, string configurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(securityUserConfiguration, resourceGroupName, networkManagerName, configurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a network manager security user configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkManagerName'>
            /// The name of the network manager.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the network manager Security Configuration.
            /// </param>
            /// <param name='force'>
            /// Deletes the resource even if it is part of a deployed configuration. If the
            /// configuration has been deployed, the service will do a cleanup deployment
            /// in the background, prior to the delete.
            /// </param>
            public static SecurityUserConfigurationsDeleteHeaders Delete(this ISecurityUserConfigurationsOperations operations, string resourceGroupName, string networkManagerName, string configurationName, bool? force = default(bool?))
            {
                return operations.DeleteAsync(resourceGroupName, networkManagerName, configurationName, force).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a network manager security user configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkManagerName'>
            /// The name of the network manager.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the network manager Security Configuration.
            /// </param>
            /// <param name='force'>
            /// Deletes the resource even if it is part of a deployed configuration. If the
            /// configuration has been deployed, the service will do a cleanup deployment
            /// in the background, prior to the delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityUserConfigurationsDeleteHeaders> DeleteAsync(this ISecurityUserConfigurationsOperations operations, string resourceGroupName, string networkManagerName, string configurationName, bool? force = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkManagerName, configurationName, force, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Deletes a network manager security user configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkManagerName'>
            /// The name of the network manager.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the network manager Security Configuration.
            /// </param>
            /// <param name='force'>
            /// Deletes the resource even if it is part of a deployed configuration. If the
            /// configuration has been deployed, the service will do a cleanup deployment
            /// in the background, prior to the delete.
            /// </param>
            public static SecurityUserConfigurationsDeleteHeaders BeginDelete(this ISecurityUserConfigurationsOperations operations, string resourceGroupName, string networkManagerName, string configurationName, bool? force = default(bool?))
            {
                return operations.BeginDeleteAsync(resourceGroupName, networkManagerName, configurationName, force).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a network manager security user configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkManagerName'>
            /// The name of the network manager.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the network manager Security Configuration.
            /// </param>
            /// <param name='force'>
            /// Deletes the resource even if it is part of a deployed configuration. If the
            /// configuration has been deployed, the service will do a cleanup deployment
            /// in the background, prior to the delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityUserConfigurationsDeleteHeaders> BeginDeleteAsync(this ISecurityUserConfigurationsOperations operations, string resourceGroupName, string networkManagerName, string configurationName, bool? force = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkManagerName, configurationName, force, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists all the network manager security user configurations in a network
            /// manager, in a paginated format.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SecurityUserConfiguration> ListNext(this ISecurityUserConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the network manager security user configurations in a network
            /// manager, in a paginated format.
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
            public static async Task<IPage<SecurityUserConfiguration>> ListNextAsync(this ISecurityUserConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
