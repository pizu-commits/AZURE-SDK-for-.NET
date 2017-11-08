// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningCompute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about a system service deployed in the cluster
    /// </summary>
    public partial class SystemService
    {
        /// <summary>
        /// Initializes a new instance of the SystemService class.
        /// </summary>
        public SystemService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SystemService class.
        /// </summary>
        /// <param name="systemServiceType">The system service type. Possible
        /// values include: 'None', 'ScoringFrontEnd', 'BatchFrontEnd'</param>
        /// <param name="publicIpAddress">The public IP address of the system
        /// service</param>
        /// <param name="version">The state of the system service</param>
        public SystemService(string systemServiceType, string publicIpAddress = default(string), string version = default(string))
        {
            SystemServiceType = systemServiceType;
            PublicIpAddress = publicIpAddress;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the system service type. Possible values include:
        /// 'None', 'ScoringFrontEnd', 'BatchFrontEnd'
        /// </summary>
        [JsonProperty(PropertyName = "systemServiceType")]
        public string SystemServiceType { get; set; }

        /// <summary>
        /// Gets the public IP address of the system service
        /// </summary>
        [JsonProperty(PropertyName = "publicIpAddress")]
        public string PublicIpAddress { get; private set; }

        /// <summary>
        /// Gets the state of the system service
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SystemServiceType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SystemServiceType");
            }
        }
    }
}
