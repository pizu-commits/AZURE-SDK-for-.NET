// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// Properties to configure Encryption.
/// </summary>
public partial class EventHubsEncryption : ProvisioningConstruct
{
    /// <summary>
    /// Properties of KeyVault.
    /// </summary>
    public BicepList<EventHubsKeyVaultProperties> KeyVaultProperties { get => _keyVaultProperties; set => _keyVaultProperties.Assign(value); }
    private readonly BicepList<EventHubsKeyVaultProperties> _keyVaultProperties;

    /// <summary>
    /// Enumerates the possible value of keySource for Encryption.
    /// </summary>
    public BicepValue<EventHubsKeySource> KeySource { get => _keySource; set => _keySource.Assign(value); }
    private readonly BicepValue<EventHubsKeySource> _keySource;

    /// <summary>
    /// Enable Infrastructure Encryption (Double Encryption).
    /// </summary>
    public BicepValue<bool> RequireInfrastructureEncryption { get => _requireInfrastructureEncryption; set => _requireInfrastructureEncryption.Assign(value); }
    private readonly BicepValue<bool> _requireInfrastructureEncryption;

    /// <summary>
    /// Creates a new EventHubsEncryption.
    /// </summary>
    public EventHubsEncryption()
    {
        _keyVaultProperties = BicepList<EventHubsKeyVaultProperties>.DefineProperty(this, "KeyVaultProperties", ["keyVaultProperties"]);
        _keySource = BicepValue<EventHubsKeySource>.DefineProperty(this, "KeySource", ["keySource"]);
        _requireInfrastructureEncryption = BicepValue<bool>.DefineProperty(this, "RequireInfrastructureEncryption", ["requireInfrastructureEncryption"]);
    }
}
