// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the content link. </summary>
    public partial class AutomationContentLink
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AutomationContentLink"/>. </summary>
        public AutomationContentLink()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationContentLink"/>. </summary>
        /// <param name="uri"> Gets or sets the uri of the runbook content. </param>
        /// <param name="contentHash"> Gets or sets the hash. </param>
        /// <param name="version"> Gets or sets the version of the content. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationContentLink(Uri uri, AutomationContentHash contentHash, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Uri = uri;
            ContentHash = contentHash;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the uri of the runbook content. </summary>
        public Uri Uri { get; set; }
        /// <summary> Gets or sets the hash. </summary>
        public AutomationContentHash ContentHash { get; set; }
        /// <summary> Gets or sets the version of the content. </summary>
        public string Version { get; set; }
    }
}
