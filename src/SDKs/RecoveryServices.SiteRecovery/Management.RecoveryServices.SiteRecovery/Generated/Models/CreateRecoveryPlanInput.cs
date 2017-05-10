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
    /// Create recovery plan input class.
    /// </summary>
    public partial class CreateRecoveryPlanInput
    {
        /// <summary>
        /// Initializes a new instance of the CreateRecoveryPlanInput class.
        /// </summary>
        public CreateRecoveryPlanInput() { }

        /// <summary>
        /// Initializes a new instance of the CreateRecoveryPlanInput class.
        /// </summary>
        public CreateRecoveryPlanInput(CreateRecoveryPlanInputProperties properties)
        {
            Properties = properties;
        }

        /// <summary>
        /// Recovery plan creation properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CreateRecoveryPlanInputProperties Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}
