// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Data flow debug resource. </summary>
    public partial class DataFlowDebugResource : SubResourceDebugResource
    {
        /// <summary> Initializes a new instance of DataFlowDebugResource. </summary>
        /// <param name="properties"> Data flow properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFlowDebugResource(DataFlow properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DataFlowDebugResource. </summary>
        /// <param name="name"> The resource name. </param>
        /// <param name="properties"> Data flow properties. </param>
        internal DataFlowDebugResource(string name, DataFlow properties) : base(name)
        {
            Properties = properties;
        }

        /// <summary> Data flow properties. </summary>
        public DataFlow Properties { get; set; }
    }
}
