// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevSpaces;

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> The ControllerList. </summary>
    internal partial class ControllerList
    {
        /// <summary> Initializes a new instance of ControllerList. </summary>
        internal ControllerList()
        {
            Value = new ChangeTrackingList<ControllerData>();
        }

        /// <summary> Initializes a new instance of ControllerList. </summary>
        /// <param name="value"> List of Azure Dev Spaces Controllers. </param>
        /// <param name="nextLink"> The URI that can be used to request the next page for list of Azure Dev Spaces Controllers. </param>
        internal ControllerList(IReadOnlyList<ControllerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Azure Dev Spaces Controllers. </summary>
        public IReadOnlyList<ControllerData> Value { get; }
        /// <summary> The URI that can be used to request the next page for list of Azure Dev Spaces Controllers. </summary>
        public string NextLink { get; }
    }
}
