// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> A policy violation reported against a gallery artifact. </summary>
    public partial class PolicyViolation
    {
        /// <summary> Initializes a new instance of PolicyViolation. </summary>
        internal PolicyViolation()
        {
        }

        /// <summary> Initializes a new instance of PolicyViolation. </summary>
        /// <param name="category"> Describes the nature of the policy violation. </param>
        /// <param name="details"> Describes specific details about why this policy violation was reported. </param>
        internal PolicyViolation(PolicyViolationCategory? category, string details)
        {
            Category = category;
            Details = details;
        }

        /// <summary> Describes the nature of the policy violation. </summary>
        public PolicyViolationCategory? Category { get; }
        /// <summary> Describes specific details about why this policy violation was reported. </summary>
        public string Details { get; }
    }
}
