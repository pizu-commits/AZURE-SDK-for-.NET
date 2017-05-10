// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
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
    /// The health error class.
    /// </summary>
    public partial class HealthError
    {
        /// <summary>
        /// Initializes a new instance of the HealthError class.
        /// </summary>
        public HealthError() { }

        /// <summary>
        /// Initializes a new instance of the HealthError class.
        /// </summary>
        public HealthError(string errorLevel = default(string), string errorCode = default(string), string errorMessage = default(string), string possibleCauses = default(string), string recommendedAction = default(string), DateTime? creationTimeUtc = default(DateTime?), string recoveryProviderErrorMessage = default(string), string entityId = default(string))
        {
            ErrorLevel = errorLevel;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            PossibleCauses = possibleCauses;
            RecommendedAction = recommendedAction;
            CreationTimeUtc = creationTimeUtc;
            RecoveryProviderErrorMessage = recoveryProviderErrorMessage;
            EntityId = entityId;
        }

        /// <summary>
        /// Level of error.
        /// </summary>
        [JsonProperty(PropertyName = "errorLevel")]
        public string ErrorLevel { get; set; }

        /// <summary>
        /// Error code.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Possible causes of error.
        /// </summary>
        [JsonProperty(PropertyName = "possibleCauses")]
        public string PossibleCauses { get; set; }

        /// <summary>
        /// Recommended action to resolve error.
        /// </summary>
        [JsonProperty(PropertyName = "recommendedAction")]
        public string RecommendedAction { get; set; }

        /// <summary>
        /// Error creation time (UTC)
        /// </summary>
        [JsonProperty(PropertyName = "creationTimeUtc")]
        public DateTime? CreationTimeUtc { get; set; }

        /// <summary>
        /// DRA error message.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryProviderErrorMessage")]
        public string RecoveryProviderErrorMessage { get; set; }

        /// <summary>
        /// ID of the entity.
        /// </summary>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }

    }
}
