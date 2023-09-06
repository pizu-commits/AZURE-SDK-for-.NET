// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the ScriptCmdlet data model.
    /// A cmdlet available for script execution
    /// </summary>
    public partial class ScriptCmdletData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ScriptCmdletData"/>. </summary>
        public ScriptCmdletData()
        {
            Parameters = new ChangeTrackingList<ScriptParameter>();
        }

        /// <summary> Initializes a new instance of <see cref="ScriptCmdletData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description of the scripts functionality. </param>
        /// <param name="timeout"> Recommended time limit for execution. </param>
        /// <param name="parameters"> Parameters the script will accept. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptCmdletData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, TimeSpan? timeout, IReadOnlyList<ScriptParameter> parameters, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            Timeout = timeout;
            Parameters = parameters;
            _rawData = rawData;
        }

        /// <summary> Description of the scripts functionality. </summary>
        public string Description { get; }
        /// <summary> Recommended time limit for execution. </summary>
        public TimeSpan? Timeout { get; }
        /// <summary> Parameters the script will accept. </summary>
        public IReadOnlyList<ScriptParameter> Parameters { get; }
    }
}
