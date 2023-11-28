// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The list of cognitive services Commitment Plan Account Association operation response. </summary>
    internal partial class CommitmentPlanAccountAssociationListResult
    {
        /// <summary> Initializes a new instance of <see cref="CommitmentPlanAccountAssociationListResult"/>. </summary>
        internal CommitmentPlanAccountAssociationListResult()
        {
            Value = new ChangeTrackingList<CommitmentPlanAccountAssociationData>();
        }

        /// <summary> Initializes a new instance of <see cref="CommitmentPlanAccountAssociationListResult"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of Commitment Plan Account Association. </param>
        /// <param name="value"> Gets the list of Cognitive Services Commitment Plan Account Association and their properties. </param>
        internal CommitmentPlanAccountAssociationListResult(string nextLink, IReadOnlyList<CommitmentPlanAccountAssociationData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of Commitment Plan Account Association. </summary>
        public string NextLink { get; }
        /// <summary> Gets the list of Cognitive Services Commitment Plan Account Association and their properties. </summary>
        public IReadOnlyList<CommitmentPlanAccountAssociationData> Value { get; }
    }
}
