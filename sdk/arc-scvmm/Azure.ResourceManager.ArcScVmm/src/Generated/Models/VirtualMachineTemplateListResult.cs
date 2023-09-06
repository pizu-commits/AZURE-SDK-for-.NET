// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> List of VirtualMachineTemplates. </summary>
    internal partial class VirtualMachineTemplateListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineTemplateListResult"/>. </summary>
        internal VirtualMachineTemplateListResult()
        {
            Value = new ChangeTrackingList<ScVmmVirtualMachineTemplateData>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineTemplateListResult"/>. </summary>
        /// <param name="value"> List of VirtualMachineTemplates. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineTemplateListResult(IReadOnlyList<ScVmmVirtualMachineTemplateData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of VirtualMachineTemplates. </summary>
        public IReadOnlyList<ScVmmVirtualMachineTemplateData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
