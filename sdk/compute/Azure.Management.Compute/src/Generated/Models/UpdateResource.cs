// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> The Update Resource model definition. </summary>
    public partial class UpdateResource
    {
        /// <summary> Initializes a new instance of UpdateResource. </summary>
        public UpdateResource()
        {
        }

        /// <summary> Initializes a new instance of UpdateResource. </summary>
        /// <param name="tags"> Resource tags. </param>
        internal UpdateResource(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; set; }
    }
}
