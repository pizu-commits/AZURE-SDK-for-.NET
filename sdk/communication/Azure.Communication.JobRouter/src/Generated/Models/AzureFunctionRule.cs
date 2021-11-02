// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> A rule providing a binding to an HTTP Triggered Azure Function. </summary>
    public partial class AzureFunctionRule : RouterRule
    {

        /// <summary> Initializes a new instance of AzureFunctionRule. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of Rule. </param>
        /// <param name="functionAppUrl"> URL for custom azure function. </param>
        /// <param name="functionName"> User-friendly name for function. </param>
        /// <param name="credential"> Credentials used to access Azure function rule. </param>
        internal AzureFunctionRule(string kind, string functionAppUrl, string functionName, AzureFunctionRuleCredential credential) : base(kind)
        {
            FunctionAppUrl = functionAppUrl;
            FunctionName = functionName;
            Credential = credential;
            Kind = kind ?? "azure-function-rule";
        }

        /// <summary> URL for custom azure function. </summary>
        public string FunctionAppUrl { get; set; }
        /// <summary> User-friendly name for function. </summary>
        public string FunctionName { get; set; }
        /// <summary> Credentials used to access Azure function rule. </summary>
        public AzureFunctionRuleCredential Credential { get; set; }
    }
}
