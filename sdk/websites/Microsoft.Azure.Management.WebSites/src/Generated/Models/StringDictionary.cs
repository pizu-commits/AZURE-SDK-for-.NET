// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> String dictionary resource. </summary>
    public partial class StringDictionary : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of StringDictionary. </summary>
        public StringDictionary()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of StringDictionary. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="properties"> Settings. </param>
        internal StringDictionary(string id, string name, string kind, string type, IDictionary<string, string> properties) : base(id, name, kind, type)
        {
            Properties = properties;
        }

        /// <summary> Settings. </summary>
        public IDictionary<string, string> Properties { get; }
    }
}
