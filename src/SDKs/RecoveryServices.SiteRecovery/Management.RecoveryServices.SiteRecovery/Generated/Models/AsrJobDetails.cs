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
    /// This class represents job details based on specific job type.
    /// </summary>
    public partial class AsrJobDetails : JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the AsrJobDetails class.
        /// </summary>
        public AsrJobDetails() { }

        /// <summary>
        /// Initializes a new instance of the AsrJobDetails class.
        /// </summary>
        public AsrJobDetails(IDictionary<string, string> affectedObjectDetails = default(IDictionary<string, string>))
            : base(affectedObjectDetails)
        {
        }

    }
}
