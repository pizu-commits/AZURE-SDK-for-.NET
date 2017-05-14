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
    /// Reports method status where exception was raised.
    /// </summary>
    public partial class MethodCallStatus
    {
        /// <summary>
        /// Initializes a new instance of the MethodCallStatus class.
        /// </summary>
        public MethodCallStatus() { }

        /// <summary>
        /// Initializes a new instance of the MethodCallStatus class.
        /// </summary>
        public MethodCallStatus(string isVirtual = default(string), IList<string> parameters = default(IList<string>), string containsGenericParameters = default(string))
        {
            IsVirtual = isVirtual;
            Parameters = parameters;
            ContainsGenericParameters = containsGenericParameters;
        }

        /// <summary>
        /// Gets a value indicating whether called method was virtual
        /// </summary>
        [JsonProperty(PropertyName = "isVirtual")]
        public string IsVirtual { get; set; }

        /// <summary>
        /// Gets parameter list passed to method.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<string> Parameters { get; set; }

        /// <summary>
        /// Gets a value indicating whether method container generic params.
        /// </summary>
        [JsonProperty(PropertyName = "containsGenericParameters")]
        public string ContainsGenericParameters { get; set; }

    }
}
