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
    /// Recovery plan planned failover input properties.
    /// </summary>
    public partial class RecoveryPlanPlannedFailoverInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanPlannedFailoverInputProperties class.
        /// </summary>
        public RecoveryPlanPlannedFailoverInputProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanPlannedFailoverInputProperties class.
        /// </summary>
        public RecoveryPlanPlannedFailoverInputProperties(PossibleOperationsDirections failoverDirection, IList<RecoveryPlanProviderSpecificFailoverInput> providerSpecificDetails = default(IList<RecoveryPlanProviderSpecificFailoverInput>))
        {
            FailoverDirection = failoverDirection;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// The failover direction. Possible values include:
        /// 'PrimaryToRecovery', 'RecoveryToPrimary'
        /// </summary>
        [JsonProperty(PropertyName = "failoverDirection")]
        public PossibleOperationsDirections FailoverDirection { get; set; }

        /// <summary>
        /// The provider specific properties.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public IList<RecoveryPlanProviderSpecificFailoverInput> ProviderSpecificDetails { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
