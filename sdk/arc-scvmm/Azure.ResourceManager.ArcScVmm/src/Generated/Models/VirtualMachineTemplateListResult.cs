// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> List of VirtualMachineTemplates. </summary>
    internal partial class VirtualMachineTemplateListResult
    {
        /// <summary> Initializes a new instance of VirtualMachineTemplateListResult. </summary>
        internal VirtualMachineTemplateListResult()
        {
            Value = new Core.ChangeTrackingList<ScVmmVirtualMachineTemplateData>();
        }

        /// <summary> Initializes a new instance of VirtualMachineTemplateListResult. </summary>
        /// <param name="value"> List of VirtualMachineTemplates. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal VirtualMachineTemplateListResult(IReadOnlyList<ScVmmVirtualMachineTemplateData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of VirtualMachineTemplates. </summary>
        public IReadOnlyList<ScVmmVirtualMachineTemplateData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
