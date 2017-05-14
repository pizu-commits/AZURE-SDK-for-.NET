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
    /// Input definition for test failover cleanup.
    /// </summary>
    public partial class TestFailoverCleanupInput
    {
        /// <summary>
        /// Initializes a new instance of the TestFailoverCleanupInput class.
        /// </summary>
        public TestFailoverCleanupInput() { }

        /// <summary>
        /// Initializes a new instance of the TestFailoverCleanupInput class.
        /// </summary>
        public TestFailoverCleanupInput(TestFailoverCleanupInputProperties properties)
        {
            Properties = properties;
        }

        /// <summary>
        /// Test failover cleanup input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public TestFailoverCleanupInputProperties Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
        }
    }
}
