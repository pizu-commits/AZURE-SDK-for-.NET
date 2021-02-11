// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    internal static partial class ResourceSkuRestrictionsReasonCodeExtensions
    {
        public static string ToSerialString(this ResourceSkuRestrictionsReasonCode value) => value switch
        {
            ResourceSkuRestrictionsReasonCode.QuotaId => "QuotaId",
            ResourceSkuRestrictionsReasonCode.NotAvailableForSubscription => "NotAvailableForSubscription",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResourceSkuRestrictionsReasonCode value.")
        };

        public static ResourceSkuRestrictionsReasonCode ToResourceSkuRestrictionsReasonCode(this string value)
        {
            if (string.Equals(value, "QuotaId", StringComparison.InvariantCultureIgnoreCase)) return ResourceSkuRestrictionsReasonCode.QuotaId;
            if (string.Equals(value, "NotAvailableForSubscription", StringComparison.InvariantCultureIgnoreCase)) return ResourceSkuRestrictionsReasonCode.NotAvailableForSubscription;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResourceSkuRestrictionsReasonCode value.");
        }
    }
}
