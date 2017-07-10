// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApiProductOperations.
    /// </summary>
    public static partial class ApiProductOperationsExtensions
    {
            /// <summary>
            /// Lists all Products, which the API is part of.
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
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ProductContract> ListByApis(this IApiProductOperations operations, string resourceGroupName, string serviceName, string apiId, ODataQuery<ProductContract> odataQuery = default(ODataQuery<ProductContract>))
            {
                return operations.ListByApisAsync(resourceGroupName, serviceName, apiId, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Products, which the API is part of.
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
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProductContract>> ListByApisAsync(this IApiProductOperations operations, string resourceGroupName, string serviceName, string apiId, ODataQuery<ProductContract> odataQuery = default(ODataQuery<ProductContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByApisWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Products, which the API is part of.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProductContract> ListByApisNext(this IApiProductOperations operations, string nextPageLink)
            {
                return operations.ListByApisNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Products, which the API is part of.
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
            public static async Task<IPage<ProductContract>> ListByApisNextAsync(this IApiProductOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByApisNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
