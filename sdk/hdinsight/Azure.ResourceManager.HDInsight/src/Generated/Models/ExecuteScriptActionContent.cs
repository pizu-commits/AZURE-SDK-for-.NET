// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The parameters for the script actions to execute on a running cluster.
    /// Serialized Name: ExecuteScriptActionParameters
    /// </summary>
    public partial class ExecuteScriptActionContent
    {
        /// <summary> Initializes a new instance of ExecuteScriptActionContent. </summary>
        /// <param name="persistOnSuccess">
        /// Gets or sets if the scripts needs to be persisted.
        /// Serialized Name: ExecuteScriptActionParameters.persistOnSuccess
        /// </param>
        public ExecuteScriptActionContent(bool persistOnSuccess)
        {
            ScriptActions = new ChangeTrackingList<RuntimeScriptAction>();
            PersistOnSuccess = persistOnSuccess;
        }

        /// <summary>
        /// The list of run time script actions.
        /// Serialized Name: ExecuteScriptActionParameters.scriptActions
        /// </summary>
        public IList<RuntimeScriptAction> ScriptActions { get; }
        /// <summary>
        /// Gets or sets if the scripts needs to be persisted.
        /// Serialized Name: ExecuteScriptActionParameters.persistOnSuccess
        /// </summary>
        public bool PersistOnSuccess { get; }
    }
}
