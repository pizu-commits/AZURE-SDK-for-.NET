// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// IsNotNull Advanced Filter.
/// </summary>
public partial class IsNotNullAdvancedFilter : AdvancedFilter
{
    /// <summary>
    /// Creates a new IsNotNullAdvancedFilter.
    /// </summary>
    public IsNotNullAdvancedFilter() : base()
    {
        BicepValue<string>.DefineProperty(this, "operatorType", ["operatorType"], defaultValue: "IsNotNull");
    }
}
