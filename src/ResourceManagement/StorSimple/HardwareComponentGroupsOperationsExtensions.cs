// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HardwareComponentGroupsOperations.
    /// </summary>
    public static partial class HardwareComponentGroupsOperationsExtensions
    {
            /// <summary>
            /// Lists the hardware component groups at device-level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<HardwareComponentGroup>> ListByDeviceAsync(this IHardwareComponentGroupsOperations operations, string deviceName, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDeviceWithHttpMessagesAsync(deviceName, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Changes the power state of the controller.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name
            /// </param>
            /// <param name='hardwareComponentGroupName'>
            /// The hardware component group name.
            /// </param>
            /// <param name='parameters'>
            /// The controller power state change request.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ChangeControllerPowerStateAsync(this IHardwareComponentGroupsOperations operations, string deviceName, string hardwareComponentGroupName, ControllerPowerStateChangeRequestInner parameters, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ChangeControllerPowerStateWithHttpMessagesAsync(deviceName, hardwareComponentGroupName, parameters, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Changes the power state of the controller.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name
            /// </param>
            /// <param name='hardwareComponentGroupName'>
            /// The hardware component group name.
            /// </param>
            /// <param name='parameters'>
            /// The controller power state change request.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginChangeControllerPowerStateAsync(this IHardwareComponentGroupsOperations operations, string deviceName, string hardwareComponentGroupName, ControllerPowerStateChangeRequestInner parameters, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginChangeControllerPowerStateWithHttpMessagesAsync(deviceName, hardwareComponentGroupName, parameters, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
