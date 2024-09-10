// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.SignalR;

/// <summary>
/// Upstream auth settings. If not set, no auth is used for upstream messages.
/// </summary>
public partial class SignalRUpstreamAuthSettings : ProvisioningConstruct
{
    /// <summary>
    /// Upstream auth type enum.
    /// </summary>
    public BicepValue<SignalRUpstreamAuthType> AuthType { get => _authType; set => _authType.Assign(value); }
    private readonly BicepValue<SignalRUpstreamAuthType> _authType;

    /// <summary>
    /// The Resource indicating the App ID URI of the target resource.
    /// It also appears in the aud (audience) claim of the issued
    /// token.
    /// </summary>
    public BicepValue<string> ManagedIdentityResource { get => _managedIdentityResource; set => _managedIdentityResource.Assign(value); }
    private readonly BicepValue<string> _managedIdentityResource;

    /// <summary>
    /// Creates a new SignalRUpstreamAuthSettings.
    /// </summary>
    public SignalRUpstreamAuthSettings()
    {
        _authType = BicepValue<SignalRUpstreamAuthType>.DefineProperty(this, "AuthType", ["type"]);
        _managedIdentityResource = BicepValue<string>.DefineProperty(this, "ManagedIdentityResource", ["managedIdentity", "resource"]);
    }
}
