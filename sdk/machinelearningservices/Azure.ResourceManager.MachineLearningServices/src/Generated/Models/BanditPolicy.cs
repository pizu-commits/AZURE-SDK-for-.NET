// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Defines an early termination policy based on slack criteria, and a frequency and delay interval for evaluation. </summary>
    public partial class BanditPolicy : EarlyTerminationPolicy
    {
        /// <summary> Initializes a new instance of BanditPolicy. </summary>
        public BanditPolicy()
        {
            PolicyType = EarlyTerminationPolicyType.Bandit;
        }

        /// <summary> Initializes a new instance of BanditPolicy. </summary>
        /// <param name="delayEvaluation"> Number of intervals by which to delay the first evaluation. </param>
        /// <param name="evaluationInterval"> Interval (number of runs) between policy evaluations. </param>
        /// <param name="policyType"> Name of policy configuration. </param>
        /// <param name="slackAmount"> Absolute distance allowed from the best performing run. </param>
        /// <param name="slackFactor"> Ratio of the allowed distance from the best performing run. </param>
        internal BanditPolicy(int? delayEvaluation, int? evaluationInterval, EarlyTerminationPolicyType policyType, float? slackAmount, float? slackFactor) : base(delayEvaluation, evaluationInterval, policyType)
        {
            SlackAmount = slackAmount;
            SlackFactor = slackFactor;
            PolicyType = policyType;
        }

        /// <summary> Absolute distance allowed from the best performing run. </summary>
        public float? SlackAmount { get; set; }
        /// <summary> Ratio of the allowed distance from the best performing run. </summary>
        public float? SlackFactor { get; set; }
    }
}
