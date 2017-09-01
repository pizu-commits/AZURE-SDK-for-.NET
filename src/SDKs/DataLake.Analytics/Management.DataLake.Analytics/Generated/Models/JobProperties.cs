// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The common Data Lake Analytics job properties.
    /// </summary>
    public partial class JobProperties
    {
        /// <summary>
        /// Initializes a new instance of the JobProperties class.
        /// </summary>
        public JobProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobProperties class.
        /// </summary>
        /// <param name="script">the script to run</param>
        /// <param name="runtimeVersion">the runtime version of the Data Lake
        /// Analytics engine to use for the specific type of job being
        /// run.</param>
        public JobProperties(string script, string runtimeVersion = default(string))
        {
            RuntimeVersion = runtimeVersion;
            Script = script;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the runtime version of the Data Lake Analytics engine
        /// to use for the specific type of job being run.
        /// </summary>
        [JsonProperty(PropertyName = "runtimeVersion")]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Gets or sets the script to run
        /// </summary>
        [JsonProperty(PropertyName = "script")]
        public string Script { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Script == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Script");
            }
        }
    }
}
