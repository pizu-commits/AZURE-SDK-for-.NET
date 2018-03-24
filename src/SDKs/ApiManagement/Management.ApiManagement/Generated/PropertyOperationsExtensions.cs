// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PropertyOperations.
    /// </summary>
    public static partial class PropertyOperationsExtensions
    {
            /// <summary>
            /// Lists a collection of properties defined within a service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-properties" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<PropertyContract> ListByService(this IPropertyOperations operations, string resourceGroupName, string serviceName, ODataQuery<PropertyContract> odataQuery = default(ODataQuery<PropertyContract>))
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of properties defined within a service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-properties" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PropertyContract>> ListByServiceAsync(this IPropertyOperations operations, string resourceGroupName, string serviceName, ODataQuery<PropertyContract> odataQuery = default(ODataQuery<PropertyContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the property specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='propId'>
            /// Identifier of the property.
            /// </param>
            public static PropertyGetEntityTagHeaders GetEntityTag(this IPropertyOperations operations, string resourceGroupName, string serviceName, string propId)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, propId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the property specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='propId'>
            /// Identifier of the property.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PropertyGetEntityTagHeaders> GetEntityTagAsync(this IPropertyOperations operations, string resourceGroupName, string serviceName, string propId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, propId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the details of the property specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='propId'>
            /// Identifier of the property.
            /// </param>
            public static PropertyContract Get(this IPropertyOperations operations, string resourceGroupName, string serviceName, string propId)
            {
                return operations.GetAsync(resourceGroupName, serviceName, propId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the property specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='propId'>
            /// Identifier of the property.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PropertyContract> GetAsync(this IPropertyOperations operations, string resourceGroupName, string serviceName, string propId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, propId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a property.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='propId'>
            /// Identifier of the property.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static PropertyContract CreateOrUpdate(this IPropertyOperations operations, string resourceGroupName, string serviceName, string propId, PropertyContract parameters, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, propId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a property.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='propId'>
            /// Identifier of the property.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PropertyContract> CreateOrUpdateAsync(this IPropertyOperations operations, string resourceGroupName, string serviceName, string propId, PropertyContract parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, propId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specific property.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='propId'>
            /// Identifier of the property.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Update(this IPropertyOperations operations, string resourceGroupName, string serviceName, string propId, PropertyUpdateParameters parameters, string ifMatch)
            {
                operations.UpdateAsync(resourceGroupName, serviceName, propId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specific property.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='propId'>
            /// Identifier of the property.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IPropertyOperations operations, string resourceGroupName, string serviceName, string propId, PropertyUpdateParameters parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, propId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes specific property from the the API Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='propId'>
            /// Identifier of the property.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Delete(this IPropertyOperations operations, string resourceGroupName, string serviceName, string propId, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, propId, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes specific property from the the API Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='propId'>
            /// Identifier of the property.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPropertyOperations operations, string resourceGroupName, string serviceName, string propId, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, propId, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists a collection of properties defined within a service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-properties" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PropertyContract> ListByServiceNext(this IPropertyOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of properties defined within a service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-properties" />
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
            public static async Task<IPage<PropertyContract>> ListByServiceNextAsync(this IPropertyOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
