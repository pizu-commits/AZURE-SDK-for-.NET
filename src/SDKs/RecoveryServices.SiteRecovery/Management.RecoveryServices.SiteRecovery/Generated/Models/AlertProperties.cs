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
    /// The proprties of an alert.
    /// </summary>
    public partial class AlertProperties
    {
        /// <summary>
        /// Initializes a new instance of the AlertProperties class.
        /// </summary>
        public AlertProperties() { }

        /// <summary>
        /// Initializes a new instance of the AlertProperties class.
        /// </summary>
        public AlertProperties(string sendToOwners = default(string), IList<string> customEmailAddresses = default(IList<string>), string locale = default(string))
        {
            SendToOwners = sendToOwners;
            CustomEmailAddresses = customEmailAddresses;
            Locale = locale;
        }

        /// <summary>
        /// A value indicating whether to send email to subscription
        /// administrator.
        /// </summary>
        [JsonProperty(PropertyName = "sendToOwners")]
        public string SendToOwners { get; set; }

        /// <summary>
        /// The custom email address for sending emails.
        /// </summary>
        [JsonProperty(PropertyName = "customEmailAddresses")]
        public IList<string> CustomEmailAddresses { get; set; }

        /// <summary>
        /// The locale for the email notification.
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

    }
}
