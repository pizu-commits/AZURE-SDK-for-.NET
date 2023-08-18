// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> List of VmmServers. </summary>
    internal partial class VmmServerListResult
    {
        /// <summary> Initializes a new instance of VmmServerListResult. </summary>
        internal VmmServerListResult()
        {
            Value = new Core.ChangeTrackingList<ScVmmServerData>();
        }

        /// <summary> Initializes a new instance of VmmServerListResult. </summary>
        /// <param name="value"> List of VmmServers. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal VmmServerListResult(IReadOnlyList<ScVmmServerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of VmmServers. </summary>
        public IReadOnlyList<ScVmmServerData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
