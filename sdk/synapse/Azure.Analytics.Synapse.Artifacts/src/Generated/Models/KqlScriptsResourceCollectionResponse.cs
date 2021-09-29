// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The KqlScriptsResourceCollectionResponse. </summary>
    internal partial class KqlScriptsResourceCollectionResponse
    {
        /// <summary> Initializes a new instance of KqlScriptsResourceCollectionResponse. </summary>
        internal KqlScriptsResourceCollectionResponse()
        {
            Value = new ChangeTrackingList<KqlScriptResource>();
        }

        /// <summary> Initializes a new instance of KqlScriptsResourceCollectionResponse. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal KqlScriptsResourceCollectionResponse(IReadOnlyList<KqlScriptResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<KqlScriptResource> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
