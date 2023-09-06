// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Defines the stop action properties. </summary>
    public partial class StopVirtualMachineContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StopVirtualMachineContent"/>. </summary>
        public StopVirtualMachineContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StopVirtualMachineContent"/>. </summary>
        /// <param name="skipShutdown"> Gets or sets a value indicating whether to request non-graceful VM shutdown. True value for this flag indicates non-graceful shutdown whereas false indicates otherwise. Defaults to false. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StopVirtualMachineContent(bool? skipShutdown, Dictionary<string, BinaryData> rawData)
        {
            SkipShutdown = skipShutdown;
            _rawData = rawData;
        }

        /// <summary> Gets or sets a value indicating whether to request non-graceful VM shutdown. True value for this flag indicates non-graceful shutdown whereas false indicates otherwise. Defaults to false. </summary>
        public bool? SkipShutdown { get; set; }
    }
}
