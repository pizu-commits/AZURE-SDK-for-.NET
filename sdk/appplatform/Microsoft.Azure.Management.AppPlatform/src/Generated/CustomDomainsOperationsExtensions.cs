// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CustomDomainsOperations.
    /// </summary>
    public static partial class CustomDomainsOperationsExtensions
    {
            /// <summary>
            /// Get the custom domain of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='domainName'>
            /// The name of the custom domain resource.
            /// </param>
            public static CustomDomainResource Get(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, string domainName)
            {
                return operations.GetAsync(resourceGroupName, serviceName, appName, domainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the custom domain of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='domainName'>
            /// The name of the custom domain resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainResource> GetAsync(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, string domainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, appName, domainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update custom domain of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='domainName'>
            /// The name of the custom domain resource.
            /// </param>
            /// <param name='domainResource'>
            /// Parameters for the create or update operation
            /// </param>
            public static CustomDomainResource CreateOrUpdate(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, string domainName, CustomDomainResource domainResource)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, appName, domainName, domainResource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update custom domain of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='domainName'>
            /// The name of the custom domain resource.
            /// </param>
            /// <param name='domainResource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainResource> CreateOrUpdateAsync(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, string domainName, CustomDomainResource domainResource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, appName, domainName, domainResource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the custom domain of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='domainName'>
            /// The name of the custom domain resource.
            /// </param>
            public static void Delete(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, string domainName)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, appName, domainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the custom domain of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='domainName'>
            /// The name of the custom domain resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, string domainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, appName, domainName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update custom domain of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='domainName'>
            /// The name of the custom domain resource.
            /// </param>
            /// <param name='domainResource'>
            /// Parameters for the create or update operation
            /// </param>
            public static CustomDomainResource Patch(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, string domainName, CustomDomainResource domainResource)
            {
                return operations.PatchAsync(resourceGroupName, serviceName, appName, domainName, domainResource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update custom domain of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='domainName'>
            /// The name of the custom domain resource.
            /// </param>
            /// <param name='domainResource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainResource> PatchAsync(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, string domainName, CustomDomainResource domainResource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchWithHttpMessagesAsync(resourceGroupName, serviceName, appName, domainName, domainResource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the custom domains of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            public static IPage<CustomDomainResource> List(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName)
            {
                return operations.ListAsync(resourceGroupName, serviceName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the custom domains of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CustomDomainResource>> ListAsync(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, serviceName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check the resource name is valid as well as not in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='validatePayload'>
            /// </param>
            public static CustomDomainValidateResult Validate(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, CustomDomainValidatePayload validatePayload)
            {
                return operations.ValidateAsync(resourceGroupName, serviceName, appName, validatePayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check the resource name is valid as well as not in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='validatePayload'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainValidateResult> ValidateAsync(this ICustomDomainsOperations operations, string resourceGroupName, string serviceName, string appName, CustomDomainValidatePayload validatePayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateWithHttpMessagesAsync(resourceGroupName, serviceName, appName, validatePayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the custom domains of one lifecycle application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CustomDomainResource> ListNext(this ICustomDomainsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the custom domains of one lifecycle application.
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
            public static async Task<IPage<CustomDomainResource>> ListNextAsync(this ICustomDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
