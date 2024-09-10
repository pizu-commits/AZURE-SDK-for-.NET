// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// A rule governing the accessibility of a managed hsm pool from a specific
/// virtual network.
/// </summary>
public partial class ManagedHsmVirtualNetworkRule : ProvisioningConstruct
{
    /// <summary>
    /// Full resource id of a vnet subnet, such as
    /// &apos;/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1&apos;.
    /// </summary>
    public BicepValue<ResourceIdentifier> SubnetId { get => _subnetId; set => _subnetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _subnetId;

    /// <summary>
    /// Creates a new ManagedHsmVirtualNetworkRule.
    /// </summary>
    public ManagedHsmVirtualNetworkRule()
    {
        _subnetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "SubnetId", ["id"]);
    }
}
