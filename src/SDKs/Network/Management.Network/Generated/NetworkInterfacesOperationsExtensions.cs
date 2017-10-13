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
    /// Extension methods for NetworkInterfacesOperations.
    /// </summary>
    public static partial class NetworkInterfacesOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            public static void Delete(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName)
            {
                operations.DeleteAsync(resourceGroupName, networkInterfaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets information about the specified network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            public static NetworkInterface Get(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, networkInterfaceName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterface> GetAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update network interface operation.
            /// </param>
            public static NetworkInterface CreateOrUpdate(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, networkInterfaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update network interface operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterface> CreateOrUpdateAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all network interfaces in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NetworkInterface> ListAll(this INetworkInterfacesOperations operations)
            {
                return operations.ListAllAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all network interfaces in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListAllAsync(this INetworkInterfacesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all network interfaces in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<NetworkInterface> List(this INetworkInterfacesOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all network interfaces in a resource group.
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
            public static async Task<IPage<NetworkInterface>> ListAsync(this INetworkInterfacesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all route tables applied to a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            public static EffectiveRouteListResult GetEffectiveRouteTable(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName)
            {
                return operations.GetEffectiveRouteTableAsync(resourceGroupName, networkInterfaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all route tables applied to a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EffectiveRouteListResult> GetEffectiveRouteTableAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEffectiveRouteTableWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all network security groups applied to a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            public static EffectiveNetworkSecurityGroupListResult ListEffectiveNetworkSecurityGroups(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName)
            {
                return operations.ListEffectiveNetworkSecurityGroupsAsync(resourceGroupName, networkInterfaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all network security groups applied to a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EffectiveNetworkSecurityGroupListResult> ListEffectiveNetworkSecurityGroupsAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListEffectiveNetworkSecurityGroupsWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about all network interfaces in a virtual machine in a
            /// virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='virtualmachineIndex'>
            /// The virtual machine index.
            /// </param>
            public static IPage<NetworkInterface> ListVirtualMachineScaleSetVMNetworkInterfaces(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex)
            {
                return operations.ListVirtualMachineScaleSetVMNetworkInterfacesAsync(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about all network interfaces in a virtual machine in a
            /// virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='virtualmachineIndex'>
            /// The virtual machine index.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListVirtualMachineScaleSetVMNetworkInterfacesAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVirtualMachineScaleSetVMNetworkInterfacesWithHttpMessagesAsync(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all network interfaces in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            public static IPage<NetworkInterface> ListVirtualMachineScaleSetNetworkInterfaces(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName)
            {
                return operations.ListVirtualMachineScaleSetNetworkInterfacesAsync(resourceGroupName, virtualMachineScaleSetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all network interfaces in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterface>> ListVirtualMachineScaleSetNetworkInterfacesAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVirtualMachineScaleSetNetworkInterfacesWithHttpMessagesAsync(resourceGroupName, virtualMachineScaleSetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the specified network interface in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='virtualmachineIndex'>
            /// The virtual machine index.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            public static NetworkInterface GetVirtualMachineScaleSetNetworkInterface(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex, string networkInterfaceName, string expand = default(string))
            {
                return operations.GetVirtualMachineScaleSetNetworkInterfaceAsync(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, networkInterfaceName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified network interface in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='virtualmachineIndex'>
            /// The virtual machine index.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterface> GetVirtualMachineScaleSetNetworkInterfaceAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex, string networkInterfaceName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetVirtualMachineScaleSetNetworkInterfaceWithHttpMessagesAsync(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, networkInterfaceName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            public static void BeginDelete(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, networkInterfaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update network interface operation.
            /// </param>
            public static NetworkInterface BeginCreateOrUpdate(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, networkInterfaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update network interface operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterface> BeginCreateOrUpdateAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all route tables applied to a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            public static EffectiveRouteListResult BeginGetEffectiveRouteTable(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName)
            {
                return operations.BeginGetEffectiveRouteTableAsync(resourceGroupName, networkInterfaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all route tables applied to a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EffectiveRouteListResult> BeginGetEffectiveRouteTableAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetEffectiveRouteTableWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all network security groups applied to a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            public static EffectiveNetworkSecurityGroupListResult BeginListEffectiveNetworkSecurityGroups(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName)
            {
                return operations.BeginListEffectiveNetworkSecurityGroupsAsync(resourceGroupName, networkInterfaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all network security groups applied to a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EffectiveNetworkSecurityGroupListResult> BeginListEffectiveNetworkSecurityGroupsAsync(this INetworkInterfacesOperations operations, string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListEffectiveNetworkSecurityGroupsWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all network interfaces in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkInterface> ListAllNext(this INetworkInterfacesOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all network interfaces in a subscription.
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
            public static async Task<IPage<NetworkInterface>> ListAllNextAsync(this INetworkInterfacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all network interfaces in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkInterface> ListNext(this INetworkInterfacesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all network interfaces in a resource group.
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
            public static async Task<IPage<NetworkInterface>> ListNextAsync(this INetworkInterfacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about all network interfaces in a virtual machine in a
            /// virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkInterface> ListVirtualMachineScaleSetVMNetworkInterfacesNext(this INetworkInterfacesOperations operations, string nextPageLink)
            {
                return operations.ListVirtualMachineScaleSetVMNetworkInterfacesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about all network interfaces in a virtual machine in a
            /// virtual machine scale set.
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
            public static async Task<IPage<NetworkInterface>> ListVirtualMachineScaleSetVMNetworkInterfacesNextAsync(this INetworkInterfacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVirtualMachineScaleSetVMNetworkInterfacesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all network interfaces in a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkInterface> ListVirtualMachineScaleSetNetworkInterfacesNext(this INetworkInterfacesOperations operations, string nextPageLink)
            {
                return operations.ListVirtualMachineScaleSetNetworkInterfacesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all network interfaces in a virtual machine scale set.
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
            public static async Task<IPage<NetworkInterface>> ListVirtualMachineScaleSetNetworkInterfacesNextAsync(this INetworkInterfacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVirtualMachineScaleSetNetworkInterfacesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
