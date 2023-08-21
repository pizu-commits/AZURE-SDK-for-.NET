// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> List result for components. </summary>
    internal partial class ComponentList
    {
        /// <summary> Initializes a new instance of ComponentList. </summary>
        internal ComponentList()
        {
            Value = new Core.ChangeTrackingList<SbomComponent>();
        }

        /// <summary> Initializes a new instance of ComponentList. </summary>
        /// <param name="value"> The list of components. </param>
        /// <param name="nextLink"> The uri to fetch the next page of asset. </param>
        internal ComponentList(IReadOnlyList<SbomComponent> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of components. </summary>
        public IReadOnlyList<SbomComponent> Value { get; }
        /// <summary> The uri to fetch the next page of asset. </summary>
        public string NextLink { get; }
    }
}
