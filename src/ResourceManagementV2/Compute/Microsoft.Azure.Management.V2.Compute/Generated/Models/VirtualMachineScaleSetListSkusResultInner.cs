// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The Virtual Machine Scale Set List Skus operation response.
    /// </summary>
    public partial class VirtualMachineScaleSetListSkusResultInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetListSkusResultInner class.
        /// </summary>
        public VirtualMachineScaleSetListSkusResultInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetListSkusResultInner class.
        /// </summary>
        /// <param name="value">the list of skus available for the virtual
        /// machine scale set.</param>
        /// <param name="nextLink">the uri to fetch the next page of Virtual
        /// Machine Scale Set Skus. Call ListNext() with this to fetch the
        /// next page of VMSS Skus.</param>
        public VirtualMachineScaleSetListSkusResultInner(IList<VirtualMachineScaleSetSku> value = default(IList<VirtualMachineScaleSetSku>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets the list of skus available for the virtual machine scale set.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<VirtualMachineScaleSetSku> Value { get; private set; }

        /// <summary>
        /// Gets or sets the uri to fetch the next page of Virtual Machine
        /// Scale Set Skus. Call ListNext() with this to fetch the next page
        /// of VMSS Skus.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
