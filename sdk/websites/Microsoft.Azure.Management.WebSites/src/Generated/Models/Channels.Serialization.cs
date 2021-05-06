// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class ChannelsExtensions
    {
        public static string ToSerialString(this Channels value) => value switch
        {
            Channels.Notification => "Notification",
            Channels.Api => "Api",
            Channels.Email => "Email",
            Channels.Webhook => "Webhook",
            Channels.All => "All",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Channels value.")
        };

        public static Channels ToChannels(this string value)
        {
            if (string.Equals(value, "Notification", StringComparison.InvariantCultureIgnoreCase)) return Channels.Notification;
            if (string.Equals(value, "Api", StringComparison.InvariantCultureIgnoreCase)) return Channels.Api;
            if (string.Equals(value, "Email", StringComparison.InvariantCultureIgnoreCase)) return Channels.Email;
            if (string.Equals(value, "Webhook", StringComparison.InvariantCultureIgnoreCase)) return Channels.Webhook;
            if (string.Equals(value, "All", StringComparison.InvariantCultureIgnoreCase)) return Channels.All;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Channels value.");
        }
    }
}
