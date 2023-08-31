// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Customized setup scripts. </summary>
    public partial class MachineLearningScriptsToExecute
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningScriptsToExecute"/>. </summary>
        public MachineLearningScriptsToExecute()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningScriptsToExecute"/>. </summary>
        /// <param name="startupScript"> Script that's run every time the machine starts. </param>
        /// <param name="creationScript"> Script that's run only once during provision of the compute. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningScriptsToExecute(MachineLearningScriptReference startupScript, MachineLearningScriptReference creationScript, Dictionary<string, BinaryData> rawData)
        {
            StartupScript = startupScript;
            CreationScript = creationScript;
            _rawData = rawData;
        }

        /// <summary> Script that's run every time the machine starts. </summary>
        public MachineLearningScriptReference StartupScript { get; set; }
        /// <summary> Script that's run only once during provision of the compute. </summary>
        public MachineLearningScriptReference CreationScript { get; set; }
    }
}
