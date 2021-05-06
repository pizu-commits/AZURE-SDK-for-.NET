// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class ConnectionStringTypeExtensions
    {
        public static string ToSerialString(this ConnectionStringType value) => value switch
        {
            ConnectionStringType.MySql => "MySql",
            ConnectionStringType.SQLServer => "SQLServer",
            ConnectionStringType.SQLAzure => "SQLAzure",
            ConnectionStringType.Custom => "Custom",
            ConnectionStringType.NotificationHub => "NotificationHub",
            ConnectionStringType.ServiceBus => "ServiceBus",
            ConnectionStringType.EventHub => "EventHub",
            ConnectionStringType.ApiHub => "ApiHub",
            ConnectionStringType.DocDb => "DocDb",
            ConnectionStringType.RedisCache => "RedisCache",
            ConnectionStringType.PostgreSQL => "PostgreSQL",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ConnectionStringType value.")
        };

        public static ConnectionStringType ToConnectionStringType(this string value)
        {
            if (string.Equals(value, "MySql", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.MySql;
            if (string.Equals(value, "SQLServer", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.SQLServer;
            if (string.Equals(value, "SQLAzure", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.SQLAzure;
            if (string.Equals(value, "Custom", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.Custom;
            if (string.Equals(value, "NotificationHub", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.NotificationHub;
            if (string.Equals(value, "ServiceBus", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.ServiceBus;
            if (string.Equals(value, "EventHub", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.EventHub;
            if (string.Equals(value, "ApiHub", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.ApiHub;
            if (string.Equals(value, "DocDb", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.DocDb;
            if (string.Equals(value, "RedisCache", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.RedisCache;
            if (string.Equals(value, "PostgreSQL", StringComparison.InvariantCultureIgnoreCase)) return ConnectionStringType.PostgreSQL;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ConnectionStringType value.");
        }
    }
}
