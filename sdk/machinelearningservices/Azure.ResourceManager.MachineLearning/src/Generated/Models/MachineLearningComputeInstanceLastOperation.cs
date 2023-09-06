// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The last operation on ComputeInstance. </summary>
    public partial class MachineLearningComputeInstanceLastOperation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeInstanceLastOperation"/>. </summary>
        internal MachineLearningComputeInstanceLastOperation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeInstanceLastOperation"/>. </summary>
        /// <param name="operationName"> Name of the last operation. </param>
        /// <param name="operationOn"> Time of the last operation. </param>
        /// <param name="operationStatus"> Operation status. </param>
        /// <param name="operationTrigger"> Trigger of operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningComputeInstanceLastOperation(MachineLearningOperationName? operationName, DateTimeOffset? operationOn, MachineLearningOperationStatus? operationStatus, MachineLearningOperationTrigger? operationTrigger, Dictionary<string, BinaryData> rawData)
        {
            OperationName = operationName;
            OperationOn = operationOn;
            OperationStatus = operationStatus;
            OperationTrigger = operationTrigger;
            _rawData = rawData;
        }

        /// <summary> Name of the last operation. </summary>
        public MachineLearningOperationName? OperationName { get; }
        /// <summary> Time of the last operation. </summary>
        public DateTimeOffset? OperationOn { get; }
        /// <summary> Operation status. </summary>
        public MachineLearningOperationStatus? OperationStatus { get; }
        /// <summary> Trigger of operation. </summary>
        public MachineLearningOperationTrigger? OperationTrigger { get; }
    }
}
