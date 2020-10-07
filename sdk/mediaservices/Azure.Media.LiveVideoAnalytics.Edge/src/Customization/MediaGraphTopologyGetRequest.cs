// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    [CodeGenSuppress("MediaGraphTopologyGetRequest")]
    public partial class MediaGraphTopologyGetRequest
    {
        /// <summary> Initializes a new instance of MediaGraphTopologyGetRequest. </summary>
        public MediaGraphTopologyGetRequest(string name) : this(null, new ItemOperationBase(name))
        {
        }
    }
}
