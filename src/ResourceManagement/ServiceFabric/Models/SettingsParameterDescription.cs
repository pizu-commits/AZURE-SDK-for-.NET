// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceFabric;
    using Microsoft.Azure.Management.ServiceFabric.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ServiceFabric settings under sections
    /// </summary>
    public partial class SettingsParameterDescription
    {
        /// <summary>
        /// Initializes a new instance of the SettingsParameterDescription
        /// class.
        /// </summary>
        public SettingsParameterDescription()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SettingsParameterDescription
        /// class.
        /// </summary>
        /// <param name="name">The name of settings property</param>
        /// <param name="value">The value of the property</param>
        public SettingsParameterDescription(string name, string value)
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of settings property
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the property
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

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
