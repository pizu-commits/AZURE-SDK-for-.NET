// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Resource operation. </summary>
    public partial class ResourceOperation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceOperation"/>. </summary>
        internal ResourceOperation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceOperation"/>. </summary>
        /// <param name="name"> Name of this operation. </param>
        /// <param name="display"> Display of the operation. </param>
        /// <param name="origin"> The operation origin. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceOperation(string name, ResourceOperationDisplay display, string origin, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Display = display;
            Origin = origin;
            _rawData = rawData;
        }

        /// <summary> Name of this operation. </summary>
        public string Name { get; }
        /// <summary> Display of the operation. </summary>
        public ResourceOperationDisplay Display { get; }
        /// <summary> The operation origin. </summary>
        public string Origin { get; }
    }
}
