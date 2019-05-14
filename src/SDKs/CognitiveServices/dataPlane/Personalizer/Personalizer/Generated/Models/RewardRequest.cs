// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Reward given to a rank response.
    /// </summary>
    public partial class RewardRequest
    {
        /// <summary>
        /// Initializes a new instance of the RewardRequest class.
        /// </summary>
        public RewardRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RewardRequest class.
        /// </summary>
        /// <param name="value">Reward to be assigned to an action. Value
        /// should be between -1 and 1 inclusive.</param>
        public RewardRequest(double value)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reward to be assigned to an action. Value should be
        /// between -1 and 1 inclusive.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
