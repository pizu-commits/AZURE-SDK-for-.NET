// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// This class represents the script action task details.
    /// </summary>
    public partial class ScriptActionTaskDetails : TaskTypeDetails
    {
        /// <summary>
        /// Initializes a new instance of the ScriptActionTaskDetails class.
        /// </summary>
        public ScriptActionTaskDetails() { }

        /// <summary>
        /// Initializes a new instance of the ScriptActionTaskDetails class.
        /// </summary>
        public ScriptActionTaskDetails(string name = default(string), string path = default(string), string output = default(string), bool? isPrimarySideScript = default(bool?))
        {
            Name = name;
            Path = path;
            Output = output;
            IsPrimarySideScript = isPrimarySideScript;
        }

        /// <summary>
        /// The name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The path.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// The output.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public string Output { get; set; }

        /// <summary>
        /// A value indicating whether it is a primary side script or not.
        /// </summary>
        [JsonProperty(PropertyName = "isPrimarySideScript")]
        public bool? IsPrimarySideScript { get; set; }

    }
}
