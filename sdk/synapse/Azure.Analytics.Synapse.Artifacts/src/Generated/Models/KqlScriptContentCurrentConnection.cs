// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The KqlScriptContentCurrentConnection. </summary>
    public partial class KqlScriptContentCurrentConnection
    {
        /// <summary> Initializes a new instance of KqlScriptContentCurrentConnection. </summary>
        public KqlScriptContentCurrentConnection()
        {
        }

        /// <summary> Initializes a new instance of KqlScriptContentCurrentConnection. </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        internal KqlScriptContentCurrentConnection(string name, string type)
        {
            Name = name;
            Type = type;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the type. </summary>
        public string Type { get; set; }
    }
}
