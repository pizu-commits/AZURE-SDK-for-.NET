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
    /// Extension methods for NetworkManagementClient.
    /// </summary>
    public static partial class NetworkManagementClientExtensions
    {
            /// <summary>
            /// Creates a Bastion Shareable Links for all the VMs specified in the request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='bslRequest'>
            /// Post request for all the Bastion Shareable Link endpoints.
            /// </param>
            public static IPage<BastionShareableLink> PutBastionShareableLink(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest)
            {
                return operations.PutBastionShareableLinkAsync(resourceGroupName, bastionHostName, bslRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a Bastion Shareable Links for all the VMs specified in the request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='bslRequest'>
            /// Post request for all the Bastion Shareable Link endpoints.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BastionShareableLink>> PutBastionShareableLinkAsync(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutBastionShareableLinkWithHttpMessagesAsync(resourceGroupName, bastionHostName, bslRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the Bastion Shareable Links for all the VMs specified in the
            /// request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='bslRequest'>
            /// Post request for all the Bastion Shareable Link endpoints.
            /// </param>
            public static void DeleteBastionShareableLink(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest)
            {
                operations.DeleteBastionShareableLinkAsync(resourceGroupName, bastionHostName, bslRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the Bastion Shareable Links for all the VMs specified in the
            /// request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='bslRequest'>
            /// Post request for all the Bastion Shareable Link endpoints.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteBastionShareableLinkAsync(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteBastionShareableLinkWithHttpMessagesAsync(resourceGroupName, bastionHostName, bslRequest, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Return the Bastion Shareable Links for all the VMs specified in the
            /// request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='bslRequest'>
            /// Post request for all the Bastion Shareable Link endpoints.
            /// </param>
            public static IPage<BastionShareableLink> GetBastionShareableLink(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest)
            {
                return operations.GetBastionShareableLinkAsync(resourceGroupName, bastionHostName, bslRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return the Bastion Shareable Links for all the VMs specified in the
            /// request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='bslRequest'>
            /// Post request for all the Bastion Shareable Link endpoints.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BastionShareableLink>> GetBastionShareableLinkAsync(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBastionShareableLinkWithHttpMessagesAsync(resourceGroupName, bastionHostName, bslRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            public static IPage<BastionActiveSession> GetActiveSessions(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName)
            {
                return operations.GetActiveSessionsAsync(resourceGroupName, bastionHostName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BastionActiveSession>> GetActiveSessionsAsync(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetActiveSessionsWithHttpMessagesAsync(resourceGroupName, bastionHostName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='sessionIds'>
            /// The list of sessionids to disconnect.
            /// </param>
            public static IPage<BastionSessionState> DisconnectActiveSessions(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, SessionIds sessionIds)
            {
                return operations.DisconnectActiveSessionsAsync(resourceGroupName, bastionHostName, sessionIds).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='sessionIds'>
            /// The list of sessionids to disconnect.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BastionSessionState>> DisconnectActiveSessionsAsync(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, SessionIds sessionIds, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DisconnectActiveSessionsWithHttpMessagesAsync(resourceGroupName, bastionHostName, sessionIds, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks whether a domain name in the cloudapp.azure.com zone is available
            /// for use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location of the domain name.
            /// </param>
            /// <param name='domainNameLabel'>
            /// The domain name to be verified. It must conform to the following regular
            /// expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$.
            /// </param>
            public static DnsNameAvailabilityResult CheckDnsNameAvailability(this INetworkManagementClient operations, string location, string domainNameLabel)
            {
                return operations.CheckDnsNameAvailabilityAsync(location, domainNameLabel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether a domain name in the cloudapp.azure.com zone is available
            /// for use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location of the domain name.
            /// </param>
            /// <param name='domainNameLabel'>
            /// The domain name to be verified. It must conform to the following regular
            /// expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DnsNameAvailabilityResult> CheckDnsNameAvailabilityAsync(this INetworkManagementClient operations, string location, string domainNameLabel, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckDnsNameAvailabilityWithHttpMessagesAsync(location, domainNameLabel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gives the supported security providers for the virtual wan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN for which supported security providers are
            /// needed.
            /// </param>
            public static VirtualWanSecurityProviders SupportedSecurityProviders(this INetworkManagementClient operations, string resourceGroupName, string virtualWANName)
            {
                return operations.SupportedSecurityProvidersAsync(resourceGroupName, virtualWANName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gives the supported security providers for the virtual wan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN for which supported security providers are
            /// needed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualWanSecurityProviders> SupportedSecurityProvidersAsync(this INetworkManagementClient operations, string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SupportedSecurityProvidersWithHttpMessagesAsync(resourceGroupName, virtualWANName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generates a unique VPN profile for P2S clients for VirtualWan and
            /// associated VpnServerConfiguration combination in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN whose associated VpnServerConfigurations is
            /// needed.
            /// </param>
            /// <param name='vpnClientParams'>
            /// Parameters supplied to the generate VirtualWan VPN profile generation
            /// operation.
            /// </param>
            public static VpnProfileResponse Generatevirtualwanvpnserverconfigurationvpnprofile(this INetworkManagementClient operations, string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams)
            {
                return operations.GeneratevirtualwanvpnserverconfigurationvpnprofileAsync(resourceGroupName, virtualWANName, vpnClientParams).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates a unique VPN profile for P2S clients for VirtualWan and
            /// associated VpnServerConfiguration combination in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN whose associated VpnServerConfigurations is
            /// needed.
            /// </param>
            /// <param name='vpnClientParams'>
            /// Parameters supplied to the generate VirtualWan VPN profile generation
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnProfileResponse> GeneratevirtualwanvpnserverconfigurationvpnprofileAsync(this INetworkManagementClient operations, string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GeneratevirtualwanvpnserverconfigurationvpnprofileWithHttpMessagesAsync(resourceGroupName, virtualWANName, vpnClientParams, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a Bastion Shareable Links for all the VMs specified in the request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='bslRequest'>
            /// Post request for all the Bastion Shareable Link endpoints.
            /// </param>
            public static IPage<BastionShareableLink> BeginPutBastionShareableLink(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest)
            {
                return operations.BeginPutBastionShareableLinkAsync(resourceGroupName, bastionHostName, bslRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a Bastion Shareable Links for all the VMs specified in the request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='bslRequest'>
            /// Post request for all the Bastion Shareable Link endpoints.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BastionShareableLink>> BeginPutBastionShareableLinkAsync(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPutBastionShareableLinkWithHttpMessagesAsync(resourceGroupName, bastionHostName, bslRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the Bastion Shareable Links for all the VMs specified in the
            /// request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='bslRequest'>
            /// Post request for all the Bastion Shareable Link endpoints.
            /// </param>
            public static void BeginDeleteBastionShareableLink(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest)
            {
                operations.BeginDeleteBastionShareableLinkAsync(resourceGroupName, bastionHostName, bslRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the Bastion Shareable Links for all the VMs specified in the
            /// request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='bslRequest'>
            /// Post request for all the Bastion Shareable Link endpoints.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteBastionShareableLinkAsync(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteBastionShareableLinkWithHttpMessagesAsync(resourceGroupName, bastionHostName, bslRequest, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            public static IPage<BastionActiveSession> BeginGetActiveSessions(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName)
            {
                return operations.BeginGetActiveSessionsAsync(resourceGroupName, bastionHostName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BastionActiveSession>> BeginGetActiveSessionsAsync(this INetworkManagementClient operations, string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetActiveSessionsWithHttpMessagesAsync(resourceGroupName, bastionHostName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generates a unique VPN profile for P2S clients for VirtualWan and
            /// associated VpnServerConfiguration combination in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN whose associated VpnServerConfigurations is
            /// needed.
            /// </param>
            /// <param name='vpnClientParams'>
            /// Parameters supplied to the generate VirtualWan VPN profile generation
            /// operation.
            /// </param>
            public static VpnProfileResponse BeginGeneratevirtualwanvpnserverconfigurationvpnprofile(this INetworkManagementClient operations, string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams)
            {
                return operations.BeginGeneratevirtualwanvpnserverconfigurationvpnprofileAsync(resourceGroupName, virtualWANName, vpnClientParams).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates a unique VPN profile for P2S clients for VirtualWan and
            /// associated VpnServerConfiguration combination in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN whose associated VpnServerConfigurations is
            /// needed.
            /// </param>
            /// <param name='vpnClientParams'>
            /// Parameters supplied to the generate VirtualWan VPN profile generation
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnProfileResponse> BeginGeneratevirtualwanvpnserverconfigurationvpnprofileAsync(this INetworkManagementClient operations, string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGeneratevirtualwanvpnserverconfigurationvpnprofileWithHttpMessagesAsync(resourceGroupName, virtualWANName, vpnClientParams, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a Bastion Shareable Links for all the VMs specified in the request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BastionShareableLink> PutBastionShareableLinkNext(this INetworkManagementClient operations, string nextPageLink)
            {
                return operations.PutBastionShareableLinkNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a Bastion Shareable Links for all the VMs specified in the request.
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
            public static async Task<IPage<BastionShareableLink>> PutBastionShareableLinkNextAsync(this INetworkManagementClient operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutBastionShareableLinkNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return the Bastion Shareable Links for all the VMs specified in the
            /// request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BastionShareableLink> GetBastionShareableLinkNext(this INetworkManagementClient operations, string nextPageLink)
            {
                return operations.GetBastionShareableLinkNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return the Bastion Shareable Links for all the VMs specified in the
            /// request.
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
            public static async Task<IPage<BastionShareableLink>> GetBastionShareableLinkNextAsync(this INetworkManagementClient operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBastionShareableLinkNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BastionActiveSession> GetActiveSessionsNext(this INetworkManagementClient operations, string nextPageLink)
            {
                return operations.GetActiveSessionsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
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
            public static async Task<IPage<BastionActiveSession>> GetActiveSessionsNextAsync(this INetworkManagementClient operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetActiveSessionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BastionSessionState> DisconnectActiveSessionsNext(this INetworkManagementClient operations, string nextPageLink)
            {
                return operations.DisconnectActiveSessionsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
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
            public static async Task<IPage<BastionSessionState>> DisconnectActiveSessionsNextAsync(this INetworkManagementClient operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DisconnectActiveSessionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a Bastion Shareable Links for all the VMs specified in the request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BastionShareableLink> BeginPutBastionShareableLinkNext(this INetworkManagementClient operations, string nextPageLink)
            {
                return operations.BeginPutBastionShareableLinkNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a Bastion Shareable Links for all the VMs specified in the request.
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
            public static async Task<IPage<BastionShareableLink>> BeginPutBastionShareableLinkNextAsync(this INetworkManagementClient operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPutBastionShareableLinkNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BastionActiveSession> BeginGetActiveSessionsNext(this INetworkManagementClient operations, string nextPageLink)
            {
                return operations.BeginGetActiveSessionsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the list of currently active sessions on the Bastion.
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
            public static async Task<IPage<BastionActiveSession>> BeginGetActiveSessionsNextAsync(this INetworkManagementClient operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetActiveSessionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
