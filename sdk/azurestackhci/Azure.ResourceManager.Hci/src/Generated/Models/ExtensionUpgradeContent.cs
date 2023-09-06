// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Describes the parameters for Extension upgrade. </summary>
    public partial class ExtensionUpgradeContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExtensionUpgradeContent"/>. </summary>
        public ExtensionUpgradeContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtensionUpgradeContent"/>. </summary>
        /// <param name="targetVersion"> Extension Upgrade Target Version. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtensionUpgradeContent(string targetVersion, Dictionary<string, BinaryData> rawData)
        {
            TargetVersion = targetVersion;
            _rawData = rawData;
        }

        /// <summary> Extension Upgrade Target Version. </summary>
        public string TargetVersion { get; set; }
    }
}
