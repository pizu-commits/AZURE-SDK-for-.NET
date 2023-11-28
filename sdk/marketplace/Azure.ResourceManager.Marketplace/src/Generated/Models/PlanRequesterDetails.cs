// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Plan with requesters details. </summary>
    public partial class PlanRequesterDetails
    {
        /// <summary> Initializes a new instance of <see cref="PlanRequesterDetails"/>. </summary>
        internal PlanRequesterDetails()
        {
            Requesters = new ChangeTrackingList<PlanRequesterInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="PlanRequesterDetails"/>. </summary>
        /// <param name="planId"> Gets the plan id. </param>
        /// <param name="planDisplayName"> Gets the plan display name. </param>
        /// <param name="requesters"> Gets requesters details list. </param>
        internal PlanRequesterDetails(string planId, string planDisplayName, IReadOnlyList<PlanRequesterInfo> requesters)
        {
            PlanId = planId;
            PlanDisplayName = planDisplayName;
            Requesters = requesters;
        }

        /// <summary> Gets the plan id. </summary>
        public string PlanId { get; }
        /// <summary> Gets the plan display name. </summary>
        public string PlanDisplayName { get; }
        /// <summary> Gets requesters details list. </summary>
        public IReadOnlyList<PlanRequesterInfo> Requesters { get; }
    }
}
