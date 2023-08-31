// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> Gets the workflow trigger callback URL query parameters. </summary>
    public partial class LogicWorkflowTriggerCallbackQueryParameterInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerCallbackQueryParameterInfo"/>. </summary>
        internal LogicWorkflowTriggerCallbackQueryParameterInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerCallbackQueryParameterInfo"/>. </summary>
        /// <param name="apiVersion"> The api version. </param>
        /// <param name="sp"> The SAS permissions. </param>
        /// <param name="sv"> The SAS version. </param>
        /// <param name="sig"> The SAS signature. </param>
        /// <param name="se"> The SAS timestamp. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowTriggerCallbackQueryParameterInfo(string apiVersion, string sp, string sv, string sig, string se, Dictionary<string, BinaryData> rawData)
        {
            ApiVersion = apiVersion;
            Sp = sp;
            Sv = sv;
            Sig = sig;
            Se = se;
            _rawData = rawData;
        }

        /// <summary> The api version. </summary>
        public string ApiVersion { get; }
        /// <summary> The SAS permissions. </summary>
        public string Sp { get; }
        /// <summary> The SAS version. </summary>
        public string Sv { get; }
        /// <summary> The SAS signature. </summary>
        public string Sig { get; }
        /// <summary> The SAS timestamp. </summary>
        public string Se { get; }
    }
}
