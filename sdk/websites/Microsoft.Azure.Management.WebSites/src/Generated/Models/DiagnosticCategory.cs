// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Class representing detector definition. </summary>
    public partial class DiagnosticCategory : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of DiagnosticCategory. </summary>
        public DiagnosticCategory()
        {
        }

        /// <summary> Initializes a new instance of DiagnosticCategory. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="description"> Description of the diagnostic category. </param>
        internal DiagnosticCategory(string id, string name, string kind, string type, string description) : base(id, name, kind, type)
        {
            Description = description;
        }

        /// <summary> Description of the diagnostic category. </summary>
        public string Description { get; }
    }
}
