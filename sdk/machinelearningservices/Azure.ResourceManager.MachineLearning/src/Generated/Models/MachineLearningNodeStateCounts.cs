// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Counts of various compute node states on the amlCompute. </summary>
    public partial class MachineLearningNodeStateCounts
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningNodeStateCounts"/>. </summary>
        internal MachineLearningNodeStateCounts()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningNodeStateCounts"/>. </summary>
        /// <param name="idleNodeCount"> Number of compute nodes in idle state. </param>
        /// <param name="runningNodeCount"> Number of compute nodes which are running jobs. </param>
        /// <param name="preparingNodeCount"> Number of compute nodes which are being prepared. </param>
        /// <param name="unusableNodeCount"> Number of compute nodes which are in unusable state. </param>
        /// <param name="leavingNodeCount"> Number of compute nodes which are leaving the amlCompute. </param>
        /// <param name="preemptedNodeCount"> Number of compute nodes which are in preempted state. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningNodeStateCounts(int? idleNodeCount, int? runningNodeCount, int? preparingNodeCount, int? unusableNodeCount, int? leavingNodeCount, int? preemptedNodeCount, Dictionary<string, BinaryData> rawData)
        {
            IdleNodeCount = idleNodeCount;
            RunningNodeCount = runningNodeCount;
            PreparingNodeCount = preparingNodeCount;
            UnusableNodeCount = unusableNodeCount;
            LeavingNodeCount = leavingNodeCount;
            PreemptedNodeCount = preemptedNodeCount;
            _rawData = rawData;
        }

        /// <summary> Number of compute nodes in idle state. </summary>
        public int? IdleNodeCount { get; }
        /// <summary> Number of compute nodes which are running jobs. </summary>
        public int? RunningNodeCount { get; }
        /// <summary> Number of compute nodes which are being prepared. </summary>
        public int? PreparingNodeCount { get; }
        /// <summary> Number of compute nodes which are in unusable state. </summary>
        public int? UnusableNodeCount { get; }
        /// <summary> Number of compute nodes which are leaving the amlCompute. </summary>
        public int? LeavingNodeCount { get; }
        /// <summary> Number of compute nodes which are in preempted state. </summary>
        public int? PreemptedNodeCount { get; }
    }
}
