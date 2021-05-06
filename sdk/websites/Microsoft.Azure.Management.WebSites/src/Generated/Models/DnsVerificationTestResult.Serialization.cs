// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class DnsVerificationTestResultExtensions
    {
        public static string ToSerialString(this DnsVerificationTestResult value) => value switch
        {
            DnsVerificationTestResult.Passed => "Passed",
            DnsVerificationTestResult.Failed => "Failed",
            DnsVerificationTestResult.Skipped => "Skipped",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DnsVerificationTestResult value.")
        };

        public static DnsVerificationTestResult ToDnsVerificationTestResult(this string value)
        {
            if (string.Equals(value, "Passed", StringComparison.InvariantCultureIgnoreCase)) return DnsVerificationTestResult.Passed;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return DnsVerificationTestResult.Failed;
            if (string.Equals(value, "Skipped", StringComparison.InvariantCultureIgnoreCase)) return DnsVerificationTestResult.Skipped;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DnsVerificationTestResult value.");
        }
    }
}
