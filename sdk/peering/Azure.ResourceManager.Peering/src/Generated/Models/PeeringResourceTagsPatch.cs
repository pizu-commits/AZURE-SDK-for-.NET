// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The resource tags. </summary>
    public partial class PeeringResourceTagsPatch
    {
        /// <summary> Initializes a new instance of <see cref="PeeringResourceTagsPatch"/>. </summary>
        public PeeringResourceTagsPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the tags, a dictionary of descriptors arm object. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
