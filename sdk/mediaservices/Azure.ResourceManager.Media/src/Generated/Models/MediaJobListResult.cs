// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A collection of Job items. </summary>
    internal partial class MediaJobListResult
    {
        /// <summary> Initializes a new instance of MediaJobListResult. </summary>
        internal MediaJobListResult()
        {
            Value = new Core.ChangeTrackingList<MediaJobData>();
        }

        /// <summary> Initializes a new instance of MediaJobListResult. </summary>
        /// <param name="value"> A collection of Job items. </param>
        /// <param name="odataNextLink"> A link to the next page of the collection (when the collection contains too many results to return in one response). </param>
        internal MediaJobListResult(IReadOnlyList<MediaJobData> value, string odataNextLink)
        {
            Value = value;
            OdataNextLink = odataNextLink;
        }

        /// <summary> A collection of Job items. </summary>
        public IReadOnlyList<MediaJobData> Value { get; }
        /// <summary> A link to the next page of the collection (when the collection contains too many results to return in one response). </summary>
        public string OdataNextLink { get; }
    }
}
