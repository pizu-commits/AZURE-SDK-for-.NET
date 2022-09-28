// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CustomRolloutStatus. </summary>
    public partial class CustomRolloutStatus
    {
        /// <summary> Initializes a new instance of CustomRolloutStatus. </summary>
        public CustomRolloutStatus()
        {
            CompletedRegions = new ChangeTrackingList<string>();
            FailedOrSkippedRegions = new ChangeTrackingDictionary<string, ExtendedErrorInfo>();
        }

        /// <summary> Initializes a new instance of CustomRolloutStatus. </summary>
        /// <param name="completedRegions"></param>
        /// <param name="failedOrSkippedRegions"> Dictionary of &lt;ExtendedErrorInfo&gt;. </param>
        internal CustomRolloutStatus(IList<string> completedRegions, IDictionary<string, ExtendedErrorInfo> failedOrSkippedRegions)
        {
            CompletedRegions = completedRegions;
            FailedOrSkippedRegions = failedOrSkippedRegions;
        }

        /// <summary> Gets the completed regions. </summary>
        public IList<string> CompletedRegions { get; }
        /// <summary> Dictionary of &lt;ExtendedErrorInfo&gt;. </summary>
        public IDictionary<string, ExtendedErrorInfo> FailedOrSkippedRegions { get; }
    }
}
