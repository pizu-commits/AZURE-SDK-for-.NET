// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of all MDE onboarding data resources. </summary>
    internal partial class MdeOnboardingDataList
    {
        /// <summary> Initializes a new instance of MdeOnboardingDataList. </summary>
        internal MdeOnboardingDataList()
        {
            Value = new ChangeTrackingList<MdeOnboardingDataData>();
        }

        /// <summary> Initializes a new instance of MdeOnboardingDataList. </summary>
        /// <param name="value"> List of the resources of the configuration or data needed to onboard the machine to MDE. </param>
        internal MdeOnboardingDataList(IReadOnlyList<MdeOnboardingDataData> value)
        {
            Value = value;
        }

        /// <summary> List of the resources of the configuration or data needed to onboard the machine to MDE. </summary>
        public IReadOnlyList<MdeOnboardingDataData> Value { get; }
    }
}
