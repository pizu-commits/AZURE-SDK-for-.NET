// MIT

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties related to service bus queue endpoint types.
    /// </summary>
    public partial class RoutingServiceBusQueueEndpointProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RoutingServiceBusQueueEndpointProperties class.
        /// </summary>
        public RoutingServiceBusQueueEndpointProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// RoutingServiceBusQueueEndpointProperties class.
        /// </summary>
        public RoutingServiceBusQueueEndpointProperties(string connectionString, string name, string subscriptionId = default(string), string resourceGroup = default(string))
        {
            ConnectionString = connectionString;
            Name = name;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
        }

        /// <summary>
        /// The connection string of the service bus queue endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// The name of the service bus queue endpoint. The name can only
        /// include alphanumeric characters, periods, underscores, hyphens
        /// and has a maximum length of 64 characters. The following names
        /// are reserved;  events, operationsMonitoringEvents,
        /// fileNotifications, $default. Endpoint names must be unique across
        /// endpoint types. The name need not be the same as the actual queue
        /// name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The subscription identifier of the service bus queue endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The name of the resource group of the service bus queue endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (this.Name != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.Name, "^[A-Za-z0-9-._]{1,64}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[A-Za-z0-9-._]{1,64}$");
                }
            }
        }
    }
}
