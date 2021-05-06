// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Function App stack major version. </summary>
    public partial class FunctionAppMajorVersion
    {
        /// <summary> Initializes a new instance of FunctionAppMajorVersion. </summary>
        internal FunctionAppMajorVersion()
        {
            MinorVersions = new ChangeTrackingList<FunctionAppMinorVersion>();
        }

        /// <summary> Initializes a new instance of FunctionAppMajorVersion. </summary>
        /// <param name="displayText"> Function App stack major version (display only). </param>
        /// <param name="value"> Function App stack major version name. </param>
        /// <param name="minorVersions"> Minor versions associated with the major version. </param>
        internal FunctionAppMajorVersion(string displayText, string value, IReadOnlyList<FunctionAppMinorVersion> minorVersions)
        {
            DisplayText = displayText;
            Value = value;
            MinorVersions = minorVersions;
        }

        /// <summary> Function App stack major version (display only). </summary>
        public string DisplayText { get; }
        /// <summary> Function App stack major version name. </summary>
        public string Value { get; }
        /// <summary> Minor versions associated with the major version. </summary>
        public IReadOnlyList<FunctionAppMinorVersion> MinorVersions { get; }
    }
}
