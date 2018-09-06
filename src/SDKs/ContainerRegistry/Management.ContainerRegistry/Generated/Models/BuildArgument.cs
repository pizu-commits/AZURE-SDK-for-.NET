// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of a build argument.
    /// </summary>
    public partial class BuildArgument
    {
        /// <summary>
        /// Initializes a new instance of the BuildArgument class.
        /// </summary>
        public BuildArgument()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildArgument class.
        /// </summary>
        /// <param name="name">The name of the argument.</param>
        /// <param name="value">The value of the argument.</param>
        /// <param name="isSecret">Flag to indicate whether the argument
        /// represents a secret and want to be removed from build logs.</param>
        public BuildArgument(string name, string value, bool? isSecret = default(bool?))
        {
            Name = name;
            Value = value;
            IsSecret = isSecret;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for BuildArgument class.
        /// </summary>
        static BuildArgument()
        {
            Type = "DockerBuildArgument";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the argument.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the argument.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets flag to indicate whether the argument represents a
        /// secret and want to be removed from build logs.
        /// </summary>
        [JsonProperty(PropertyName = "isSecret")]
        public bool? IsSecret { get; set; }

        /// <summary>
        /// The type of the argument.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
