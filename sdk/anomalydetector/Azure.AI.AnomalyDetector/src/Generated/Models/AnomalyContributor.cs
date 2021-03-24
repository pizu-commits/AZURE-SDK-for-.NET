// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.AnomalyDetector
{
    /// <summary> The AnomalyContributor. </summary>
    public partial class AnomalyContributor
    {
        /// <summary> Initializes a new instance of AnomalyContributor. </summary>
        internal AnomalyContributor()
        {
        }

        /// <summary> Initializes a new instance of AnomalyContributor. </summary>
        /// <param name="contributionScore"> The higher the contribution score is, the more likely the variable to be the root cause of a anomaly. </param>
        /// <param name="variable"> Variable name of a contributor. </param>
        internal AnomalyContributor(float? contributionScore, string variable)
        {
            ContributionScore = contributionScore;
            Variable = variable;
        }

        /// <summary> The higher the contribution score is, the more likely the variable to be the root cause of a anomaly. </summary>
        public float? ContributionScore { get; }
        /// <summary> Variable name of a contributor. </summary>
        public string Variable { get; }
    }
}
