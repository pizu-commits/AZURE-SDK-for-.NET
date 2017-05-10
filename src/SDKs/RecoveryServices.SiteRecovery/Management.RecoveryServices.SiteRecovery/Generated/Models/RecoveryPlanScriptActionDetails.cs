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
    /// Recovery plan script action details.
    /// </summary>
    [JsonObject("ScriptActionDetails")]
    public partial class RecoveryPlanScriptActionDetails : RecoveryPlanActionDetails
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanScriptActionDetails
        /// class.
        /// </summary>
        public RecoveryPlanScriptActionDetails() { }

        /// <summary>
        /// Initializes a new instance of the RecoveryPlanScriptActionDetails
        /// class.
        /// </summary>
        public RecoveryPlanScriptActionDetails(string path, RecoveryPlanActionLocation fabricLocation, string timeout = default(string))
        {
            Path = path;
            Timeout = timeout;
            FabricLocation = fabricLocation;
        }

        /// <summary>
        /// The script path.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// The script timeout.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// The fabric location. Possible values include: 'Primary', 'Recovery'
        /// </summary>
        [JsonProperty(PropertyName = "fabricLocation")]
        public RecoveryPlanActionLocation FabricLocation { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
        }
    }
}
