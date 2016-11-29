// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Input of the custom domain to be validated.
    /// </summary>
    public partial class ValidateCustomDomainInput
    {
        /// <summary>
        /// Initializes a new instance of the ValidateCustomDomainInput class.
        /// </summary>
        public ValidateCustomDomainInput() { }

        /// <summary>
        /// Initializes a new instance of the ValidateCustomDomainInput class.
        /// </summary>
        /// <param name="hostName">The host name of the custom domain. Must be
        /// a domain name.</param>
        public ValidateCustomDomainInput(string hostName)
        {
            HostName = hostName;
        }

        /// <summary>
        /// Gets or sets the host name of the custom domain. Must be a domain
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HostName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "HostName");
            }
        }
    }
}
