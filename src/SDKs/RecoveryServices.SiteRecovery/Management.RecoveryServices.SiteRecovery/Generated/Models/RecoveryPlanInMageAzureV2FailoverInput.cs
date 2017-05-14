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
    /// Recovery plan InMageAzureV2 failover input.
    /// </summary>
    [JsonObject("InMageAzureV2")]
    public partial class RecoveryPlanInMageAzureV2FailoverInput : RecoveryPlanProviderSpecificFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanInMageAzureV2FailoverInput class.
        /// </summary>
        public RecoveryPlanInMageAzureV2FailoverInput() { }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanInMageAzureV2FailoverInput class.
        /// </summary>
        public RecoveryPlanInMageAzureV2FailoverInput(string vaultLocation, InMageV2RpRecoveryPointType recoveryPointType)
        {
            VaultLocation = vaultLocation;
            RecoveryPointType = recoveryPointType;
        }

        /// <summary>
        /// The vault location.
        /// </summary>
        [JsonProperty(PropertyName = "vaultLocation")]
        public string VaultLocation { get; set; }

        /// <summary>
        /// The recovery point type. Possible values include: 'Latest',
        /// 'LatestApplicationConsistent', 'LatestCrashConsistent',
        /// 'LatestProcessed'
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointType")]
        public InMageV2RpRecoveryPointType RecoveryPointType { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (VaultLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VaultLocation");
            }
        }
    }
}
