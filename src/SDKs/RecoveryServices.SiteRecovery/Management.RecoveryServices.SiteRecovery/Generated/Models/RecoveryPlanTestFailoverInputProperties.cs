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
    /// Recovery plan test failover input properties.
    /// </summary>
    public partial class RecoveryPlanTestFailoverInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanTestFailoverInputProperties class.
        /// </summary>
        public RecoveryPlanTestFailoverInputProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanTestFailoverInputProperties class.
        /// </summary>
        public RecoveryPlanTestFailoverInputProperties(PossibleOperationsDirections failoverDirection, string networkType, string networkId = default(string), string skipTestFailoverCleanup = default(string), IList<RecoveryPlanProviderSpecificFailoverInput> providerSpecificDetails = default(IList<RecoveryPlanProviderSpecificFailoverInput>))
        {
            FailoverDirection = failoverDirection;
            NetworkType = networkType;
            NetworkId = networkId;
            SkipTestFailoverCleanup = skipTestFailoverCleanup;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// The failover direction. Possible values include:
        /// 'PrimaryToRecovery', 'RecoveryToPrimary'
        /// </summary>
        [JsonProperty(PropertyName = "failoverDirection")]
        public PossibleOperationsDirections FailoverDirection { get; set; }

        /// <summary>
        /// The network type to be used for test failover.
        /// </summary>
        [JsonProperty(PropertyName = "networkType")]
        public string NetworkType { get; set; }

        /// <summary>
        /// The Id of the network to be used for test failover.
        /// </summary>
        [JsonProperty(PropertyName = "networkId")]
        public string NetworkId { get; set; }

        /// <summary>
        /// A value indicating whether the test failover cleanup is to be
        /// skipped.
        /// </summary>
        [JsonProperty(PropertyName = "skipTestFailoverCleanup")]
        public string SkipTestFailoverCleanup { get; set; }

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
            if (NetworkType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NetworkType");
            }
        }
    }
}
