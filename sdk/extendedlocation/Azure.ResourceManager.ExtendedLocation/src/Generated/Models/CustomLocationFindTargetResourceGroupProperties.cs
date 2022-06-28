// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ExtendedLocation.Models
{
    /// <summary> The Find Target Resource Group operation request. </summary>
    public partial class CustomLocationFindTargetResourceGroupProperties
    {
        /// <summary> Initializes a new instance of CustomLocationFindTargetResourceGroupProperties. </summary>
        public CustomLocationFindTargetResourceGroupProperties()
        {
            Labels = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Labels of the custom resource, this is a map of {key,value} pairs. </summary>
        public IDictionary<string, string> Labels { get; }
    }
}
