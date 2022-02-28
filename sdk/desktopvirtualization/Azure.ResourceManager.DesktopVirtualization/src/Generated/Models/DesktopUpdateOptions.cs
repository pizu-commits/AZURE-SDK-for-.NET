// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Desktop properties that can be patched. </summary>
    public partial class DesktopUpdateOptions
    {
        /// <summary> Initializes a new instance of DesktopUpdateOptions. </summary>
        public DesktopUpdateOptions()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> tags to be updated. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Description of Desktop. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of Desktop. </summary>
        public string FriendlyName { get; set; }
    }
}
