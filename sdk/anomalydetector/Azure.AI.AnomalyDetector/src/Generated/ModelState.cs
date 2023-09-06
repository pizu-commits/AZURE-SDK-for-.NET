// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Model status. </summary>
    public partial class ModelState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of ModelState. </summary>
        public ModelState()
        {
            EpochIds = new ChangeTrackingList<int>();
            TrainLosses = new ChangeTrackingList<float>();
            ValidationLosses = new ChangeTrackingList<float>();
            LatenciesInSeconds = new ChangeTrackingList<float>();
        }

        /// <summary> Initializes a new instance of ModelState. </summary>
        /// <param name="epochIds">
        /// Number of passes of the entire training dataset that the
        /// algorithm has completed.
        /// </param>
        /// <param name="trainLosses">
        /// List of metrics used to assess how the model fits the training data for each
        /// epoch.
        /// </param>
        /// <param name="validationLosses">
        /// List of metrics used to assess how the model fits the validation set for each
        /// epoch.
        /// </param>
        /// <param name="latenciesInSeconds"> Latency for each epoch. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ModelState(IList<int> epochIds, IList<float> trainLosses, IList<float> validationLosses, IList<float> latenciesInSeconds, Dictionary<string, BinaryData> rawData)
        {
            EpochIds = epochIds;
            TrainLosses = trainLosses;
            ValidationLosses = validationLosses;
            LatenciesInSeconds = latenciesInSeconds;
            _rawData = rawData;
        }

        /// <summary>
        /// Number of passes of the entire training dataset that the
        /// algorithm has completed.
        /// </summary>
        public IList<int> EpochIds { get; }
        /// <summary>
        /// List of metrics used to assess how the model fits the training data for each
        /// epoch.
        /// </summary>
        public IList<float> TrainLosses { get; }
        /// <summary>
        /// List of metrics used to assess how the model fits the validation set for each
        /// epoch.
        /// </summary>
        public IList<float> ValidationLosses { get; }
        /// <summary> Latency for each epoch. </summary>
        public IList<float> LatenciesInSeconds { get; }
    }
}
