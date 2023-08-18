// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A list of the available script packages. </summary>
    internal partial class ScriptPackagesList
    {
        /// <summary> Initializes a new instance of ScriptPackagesList. </summary>
        internal ScriptPackagesList()
        {
            Value = new Core.ChangeTrackingList<ScriptPackageData>();
        }

        /// <summary> Initializes a new instance of ScriptPackagesList. </summary>
        /// <param name="value"> List of script package resources. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal ScriptPackagesList(IReadOnlyList<ScriptPackageData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of script package resources. </summary>
        public IReadOnlyList<ScriptPackageData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
