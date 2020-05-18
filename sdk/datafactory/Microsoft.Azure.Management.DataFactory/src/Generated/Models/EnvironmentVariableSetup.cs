// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The custom setup of setting environment variable.
    /// </summary>
    [Newtonsoft.Json.JsonObject("EnvironmentVariableSetup")]
    [Rest.Serialization.JsonTransformation]
    public partial class EnvironmentVariableSetup : CustomSetupBase
    {
        /// <summary>
        /// Initializes a new instance of the EnvironmentVariableSetup class.
        /// </summary>
        public EnvironmentVariableSetup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnvironmentVariableSetup class.
        /// </summary>
        /// <param name="variableName">The name of the environment
        /// variable.</param>
        /// <param name="variableValue">The value of the environment
        /// variable.</param>
        public EnvironmentVariableSetup(string variableName, string variableValue)
        {
            VariableName = variableName;
            VariableValue = variableValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the environment variable.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.variableName")]
        public string VariableName { get; set; }

        /// <summary>
        /// Gets or sets the value of the environment variable.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.variableValue")]
        public string VariableValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VariableName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VariableName");
            }
            if (VariableValue == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VariableValue");
            }
        }
    }
}
