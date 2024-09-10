// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// For example, between &apos;2022-12-23&apos; and &apos;2023-01-05&apos;.
/// </summary>
public partial class ContainerServiceDateSpan : ProvisioningConstruct
{
    /// <summary>
    /// The start date of the date span.
    /// </summary>
    public BicepValue<DateTimeOffset> Start { get => _start; set => _start.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _start;

    /// <summary>
    /// The end date of the date span.
    /// </summary>
    public BicepValue<DateTimeOffset> End { get => _end; set => _end.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _end;

    /// <summary>
    /// Creates a new ContainerServiceDateSpan.
    /// </summary>
    public ContainerServiceDateSpan()
    {
        _start = BicepValue<DateTimeOffset>.DefineProperty(this, "Start", ["start"]);
        _end = BicepValue<DateTimeOffset>.DefineProperty(this, "End", ["end"]);
    }
}
