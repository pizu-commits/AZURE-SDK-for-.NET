// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Search.Models
{
    internal static partial class SearchServicePrivateLinkServiceConnectionStatusExtensions
    {
        public static string ToSerialString(this SearchServicePrivateLinkServiceConnectionStatus value) => value switch
        {
            SearchServicePrivateLinkServiceConnectionStatus.Pending => "Pending",
            SearchServicePrivateLinkServiceConnectionStatus.Approved => "Approved",
            SearchServicePrivateLinkServiceConnectionStatus.Rejected => "Rejected",
            SearchServicePrivateLinkServiceConnectionStatus.Disconnected => "Disconnected",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchServicePrivateLinkServiceConnectionStatus value.")
        };

        public static SearchServicePrivateLinkServiceConnectionStatus ToSearchServicePrivateLinkServiceConnectionStatus(this string value)
        {
            if (string.Equals(value, "Pending", StringComparison.InvariantCultureIgnoreCase)) return SearchServicePrivateLinkServiceConnectionStatus.Pending;
            if (string.Equals(value, "Approved", StringComparison.InvariantCultureIgnoreCase)) return SearchServicePrivateLinkServiceConnectionStatus.Approved;
            if (string.Equals(value, "Rejected", StringComparison.InvariantCultureIgnoreCase)) return SearchServicePrivateLinkServiceConnectionStatus.Rejected;
            if (string.Equals(value, "Disconnected", StringComparison.InvariantCultureIgnoreCase)) return SearchServicePrivateLinkServiceConnectionStatus.Disconnected;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchServicePrivateLinkServiceConnectionStatus value.");
        }
    }
}
