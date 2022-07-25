// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// Gets the workflow trigger callback URL query parameters.
    /// Serialized Name: WorkflowTriggerListCallbackUrlQueries
    /// </summary>
    public partial class LogicAppWorkflowTriggerCallbackQueryparameterInfo
    {
        /// <summary> Initializes a new instance of LogicAppWorkflowTriggerCallbackQueryparameterInfo. </summary>
        internal LogicAppWorkflowTriggerCallbackQueryparameterInfo()
        {
        }

        /// <summary> Initializes a new instance of LogicAppWorkflowTriggerCallbackQueryparameterInfo. </summary>
        /// <param name="apiVersion">
        /// The api version.
        /// Serialized Name: WorkflowTriggerListCallbackUrlQueries.api-version
        /// </param>
        /// <param name="sp">
        /// The SAS permissions.
        /// Serialized Name: WorkflowTriggerListCallbackUrlQueries.sp
        /// </param>
        /// <param name="sv">
        /// The SAS version.
        /// Serialized Name: WorkflowTriggerListCallbackUrlQueries.sv
        /// </param>
        /// <param name="sig">
        /// The SAS signature.
        /// Serialized Name: WorkflowTriggerListCallbackUrlQueries.sig
        /// </param>
        /// <param name="se">
        /// The SAS timestamp.
        /// Serialized Name: WorkflowTriggerListCallbackUrlQueries.se
        /// </param>
        internal LogicAppWorkflowTriggerCallbackQueryparameterInfo(string apiVersion, string sp, string sv, string sig, string se)
        {
            ApiVersion = apiVersion;
            Sp = sp;
            Sv = sv;
            Sig = sig;
            Se = se;
        }

        /// <summary>
        /// The api version.
        /// Serialized Name: WorkflowTriggerListCallbackUrlQueries.api-version
        /// </summary>
        public string ApiVersion { get; }
        /// <summary>
        /// The SAS permissions.
        /// Serialized Name: WorkflowTriggerListCallbackUrlQueries.sp
        /// </summary>
        public string Sp { get; }
        /// <summary>
        /// The SAS version.
        /// Serialized Name: WorkflowTriggerListCallbackUrlQueries.sv
        /// </summary>
        public string Sv { get; }
        /// <summary>
        /// The SAS signature.
        /// Serialized Name: WorkflowTriggerListCallbackUrlQueries.sig
        /// </summary>
        public string Sig { get; }
        /// <summary>
        /// The SAS timestamp.
        /// Serialized Name: WorkflowTriggerListCallbackUrlQueries.se
        /// </summary>
        public string Se { get; }
    }
}
