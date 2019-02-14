// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for OperationsStatus.
    /// </summary>
    public static partial class OperationsStatusExtensions
    {
            /// <summary>
            /// Returns the job details of the specified job on a data box edge/gateway
            /// device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The job name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            public static Job Get(this IOperationsStatus operations, string deviceName, string name, string resourceGroupName)
            {
                return operations.GetAsync(deviceName, name, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the job details of the specified job on a data box edge/gateway
            /// device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The job name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> GetAsync(this IOperationsStatus operations, string deviceName, string name, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(deviceName, name, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
