// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Azure.Management.Network.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters that define the VM to check security groups for.
    /// </summary>
    public partial class SecurityGroupViewParameters
    {
        /// <summary>
        /// Initializes a new instance of the SecurityGroupViewParameters
        /// class.
        /// </summary>
        public SecurityGroupViewParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityGroupViewParameters
        /// class.
        /// </summary>
        /// <param name="targetResourceId">ID of the target VM.</param>
        public SecurityGroupViewParameters(string targetResourceId)
        {
            TargetResourceId = targetResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the target VM.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceId");
            }
        }
    }
}
