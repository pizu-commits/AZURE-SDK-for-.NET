// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Identity that will be used to access key vault for encryption at rest. </summary>
    internal partial class MachineLearningCmkIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningCmkIdentity"/>. </summary>
        public MachineLearningCmkIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningCmkIdentity"/>. </summary>
        /// <param name="userAssignedIdentity"> The ArmId of the user assigned identity that will be used to access the customer managed key vault. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningCmkIdentity(ResourceIdentifier userAssignedIdentity, Dictionary<string, BinaryData> rawData)
        {
            UserAssignedIdentity = userAssignedIdentity;
            _rawData = rawData;
        }

        /// <summary> The ArmId of the user assigned identity that will be used to access the customer managed key vault. </summary>
        public ResourceIdentifier UserAssignedIdentity { get; set; }
    }
}
