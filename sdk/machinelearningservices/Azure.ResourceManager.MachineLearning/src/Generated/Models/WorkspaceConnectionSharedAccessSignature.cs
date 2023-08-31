// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The WorkspaceConnectionSharedAccessSignature. </summary>
    internal partial class WorkspaceConnectionSharedAccessSignature
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkspaceConnectionSharedAccessSignature"/>. </summary>
        public WorkspaceConnectionSharedAccessSignature()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceConnectionSharedAccessSignature"/>. </summary>
        /// <param name="sas"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceConnectionSharedAccessSignature(string sas, Dictionary<string, BinaryData> rawData)
        {
            Sas = sas;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the sas. </summary>
        public string Sas { get; set; }
    }
}
