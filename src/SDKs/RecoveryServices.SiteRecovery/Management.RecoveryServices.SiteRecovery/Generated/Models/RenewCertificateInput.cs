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
    /// Certificate renewal input.
    /// </summary>
    public partial class RenewCertificateInput
    {
        /// <summary>
        /// Initializes a new instance of the RenewCertificateInput class.
        /// </summary>
        public RenewCertificateInput() { }

        /// <summary>
        /// Initializes a new instance of the RenewCertificateInput class.
        /// </summary>
        public RenewCertificateInput(RenewCertificateInputProperties properties = default(RenewCertificateInputProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// Renew certificate input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RenewCertificateInputProperties Properties { get; set; }

    }
}
