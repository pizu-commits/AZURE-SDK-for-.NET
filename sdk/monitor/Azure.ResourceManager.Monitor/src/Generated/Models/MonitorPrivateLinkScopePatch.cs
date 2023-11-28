// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A container holding only the Tags for a resource, allowing the user to update the tags on a PrivateLinkScope instance. </summary>
    public partial class MonitorPrivateLinkScopePatch
    {
        /// <summary> Initializes a new instance of <see cref="MonitorPrivateLinkScopePatch"/>. </summary>
        public MonitorPrivateLinkScopePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
