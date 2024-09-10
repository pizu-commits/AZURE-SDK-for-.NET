// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Represents available Sku pricing tiers.
/// </summary>
public partial class NamespaceSku : ProvisioningConstruct
{
    /// <summary>
    /// The name of the SKU.
    /// </summary>
    public BicepValue<EventGridSkuName> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<EventGridSkuName> _name;

    /// <summary>
    /// Specifies the number of Throughput Units that defines the capacity for
    /// the namespace. The property default value is             1 which
    /// signifies 1 Throughput Unit = 1MB/s ingress and 2MB/s egress per
    /// namespace. Min capacity is 1 and             max allowed capacity is
    /// 20.
    /// </summary>
    public BicepValue<int> Capacity { get => _capacity; set => _capacity.Assign(value); }
    private readonly BicepValue<int> _capacity;

    /// <summary>
    /// Creates a new NamespaceSku.
    /// </summary>
    public NamespaceSku()
    {
        _name = BicepValue<EventGridSkuName>.DefineProperty(this, "Name", ["name"]);
        _capacity = BicepValue<int>.DefineProperty(this, "Capacity", ["capacity"]);
    }
}
