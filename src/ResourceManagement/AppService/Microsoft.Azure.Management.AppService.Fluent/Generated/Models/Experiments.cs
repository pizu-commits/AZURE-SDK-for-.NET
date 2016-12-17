// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Routing rules in production experiments.
    /// </summary>
    public partial class Experiments
    {
        /// <summary>
        /// Initializes a new instance of the Experiments class.
        /// </summary>
        public Experiments() { }

        /// <summary>
        /// Initializes a new instance of the Experiments class.
        /// </summary>
        /// <param name="rampUpRules">List of ramp-up rules.</param>
        public Experiments(System.Collections.Generic.IList<RampUpRule> rampUpRules = default(System.Collections.Generic.IList<RampUpRule>))
        {
            RampUpRules = rampUpRules;
        }

        /// <summary>
        /// Gets or sets list of ramp-up rules.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rampUpRules")]
        public System.Collections.Generic.IList<RampUpRule> RampUpRules { get; set; }

    }
}
