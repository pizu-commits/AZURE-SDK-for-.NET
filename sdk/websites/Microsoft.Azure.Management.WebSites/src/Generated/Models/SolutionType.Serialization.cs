// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class SolutionTypeExtensions
    {
        public static string ToSerialString(this SolutionType value) => value switch
        {
            SolutionType.QuickSolution => "QuickSolution",
            SolutionType.DeepInvestigation => "DeepInvestigation",
            SolutionType.BestPractices => "BestPractices",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SolutionType value.")
        };

        public static SolutionType ToSolutionType(this string value)
        {
            if (string.Equals(value, "QuickSolution", StringComparison.InvariantCultureIgnoreCase)) return SolutionType.QuickSolution;
            if (string.Equals(value, "DeepInvestigation", StringComparison.InvariantCultureIgnoreCase)) return SolutionType.DeepInvestigation;
            if (string.Equals(value, "BestPractices", StringComparison.InvariantCultureIgnoreCase)) return SolutionType.BestPractices;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SolutionType value.");
        }
    }
}
