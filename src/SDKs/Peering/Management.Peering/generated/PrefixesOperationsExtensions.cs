// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrefixesOperations.
    /// </summary>
    public static partial class PrefixesOperationsExtensions
    {
            /// <summary>
            /// Lists all the prefixes associated with the peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='peeringName'>
            /// The peering name.
            /// </param>
            public static IPage<PeeringPrefix> ListByPeering(this IPrefixesOperations operations, string resourceGroupName, string peeringName)
            {
                return operations.ListByPeeringAsync(resourceGroupName, peeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the prefixes associated with the peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='peeringName'>
            /// The peering name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PeeringPrefix>> ListByPeeringAsync(this IPrefixesOperations operations, string resourceGroupName, string peeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPeeringWithHttpMessagesAsync(resourceGroupName, peeringName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the prefixes associated with the peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PeeringPrefix> ListByPeeringNext(this IPrefixesOperations operations, string nextPageLink)
            {
                return operations.ListByPeeringNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the prefixes associated with the peering.
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
            public static async Task<IPage<PeeringPrefix>> ListByPeeringNextAsync(this IPrefixesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPeeringNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
