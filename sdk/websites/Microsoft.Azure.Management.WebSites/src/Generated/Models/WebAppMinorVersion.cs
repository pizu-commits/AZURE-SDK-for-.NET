// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Web App stack minor version. </summary>
    public partial class WebAppMinorVersion
    {
        /// <summary> Initializes a new instance of WebAppMinorVersion. </summary>
        internal WebAppMinorVersion()
        {
        }

        /// <summary> Initializes a new instance of WebAppMinorVersion. </summary>
        /// <param name="displayText"> Web App stack minor version (display only). </param>
        /// <param name="value"> Web App stack major version name. </param>
        /// <param name="stackSettings"> Settings associated with the minor version. </param>
        internal WebAppMinorVersion(string displayText, string value, WebAppRuntimes stackSettings)
        {
            DisplayText = displayText;
            Value = value;
            StackSettings = stackSettings;
        }

        /// <summary> Web App stack minor version (display only). </summary>
        public string DisplayText { get; }
        /// <summary> Web App stack major version name. </summary>
        public string Value { get; }
        /// <summary> Settings associated with the minor version. </summary>
        public WebAppRuntimes StackSettings { get; }
    }
}
