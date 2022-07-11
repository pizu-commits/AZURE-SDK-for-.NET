// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    internal static partial class AccessRightExtensions
    {
        public static string ToSerialString(this AccessRight value) => value switch
        {
            AccessRight.Manage => "Manage",
            AccessRight.Send => "Send",
            AccessRight.Listen => "Listen",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccessRight value.")
        };

        public static AccessRight ToAccessRight(this string value)
        {
            if (string.Equals(value, "Manage", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.Manage;
            if (string.Equals(value, "Send", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.Send;
            if (string.Equals(value, "Listen", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.Listen;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccessRight value.");
        }
    }
}
