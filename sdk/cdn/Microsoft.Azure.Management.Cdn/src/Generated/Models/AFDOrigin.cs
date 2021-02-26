// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CDN origin is the source of the content being delivered via CDN. When
    /// the edge nodes represented by an endpoint do not have the requested
    /// content cached, they attempt to fetch it from one or more of the
    /// configured origins.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AFDOrigin : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the AFDOrigin class.
        /// </summary>
        public AFDOrigin()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AFDOrigin class.
        /// </summary>
        /// <param name="hostName">The address of the origin. Domain names,
        /// IPv4 addresses, and IPv6 addresses are supported.This should be
        /// unique across all origins in an endpoint.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="azureOrigin">Resource reference to the Azure origin
        /// resource.</param>
        /// <param name="httpPort">The value of the HTTP port. Must be between
        /// 1 and 65535.</param>
        /// <param name="httpsPort">The value of the HTTPS port. Must be
        /// between 1 and 65535.</param>
        /// <param name="originHostHeader">The host header value sent to the
        /// origin with each request. If you leave this blank, the request
        /// hostname determines this value. Azure CDN origins, such as Web
        /// Apps, Blob Storage, and Cloud Services require this host header
        /// value to match the origin hostname by default. This overrides the
        /// host header defined at Endpoint</param>
        /// <param name="priority">Priority of origin in given origin group for
        /// load balancing. Higher priorities will not be used for load
        /// balancing if any lower priority origin is healthy.Must be between 1
        /// and 5</param>
        /// <param name="weight">Weight of the origin in given origin group for
        /// load balancing. Must be between 1 and 1000</param>
        /// <param name="sharedPrivateLinkResource">The properties of the
        /// private link resource for private origin.</param>
        /// <param name="enabledState">Whether to enable health probes to be
        /// made against backends defined under backendPools. Health probes can
        /// only be disabled if there is a single enabled backend in single
        /// enabled backend pool. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="provisioningState">Provisioning status. Possible
        /// values include: 'Succeeded', 'Failed', 'Updating', 'Deleting',
        /// 'Creating'</param>
        /// <param name="deploymentStatus">Possible values include:
        /// 'NotStarted', 'InProgress', 'Succeeded', 'Failed'</param>
        public AFDOrigin(string hostName, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), ResourceReference azureOrigin = default(ResourceReference), int? httpPort = default(int?), int? httpsPort = default(int?), string originHostHeader = default(string), int? priority = default(int?), int? weight = default(int?), object sharedPrivateLinkResource = default(object), string enabledState = default(string), string provisioningState = default(string), string deploymentStatus = default(string))
            : base(id, name, type, systemData)
        {
            AzureOrigin = azureOrigin;
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            OriginHostHeader = originHostHeader;
            Priority = priority;
            Weight = weight;
            SharedPrivateLinkResource = sharedPrivateLinkResource;
            EnabledState = enabledState;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource reference to the Azure origin resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureOrigin")]
        public ResourceReference AzureOrigin { get; set; }

        /// <summary>
        /// Gets or sets the address of the origin. Domain names, IPv4
        /// addresses, and IPv6 addresses are supported.This should be unique
        /// across all origins in an endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTP port. Must be between 1 and
        /// 65535.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpPort")]
        public int? HttpPort { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTPS port. Must be between 1 and
        /// 65535.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpsPort")]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// Gets or sets the host header value sent to the origin with each
        /// request. If you leave this blank, the request hostname determines
        /// this value. Azure CDN origins, such as Web Apps, Blob Storage, and
        /// Cloud Services require this host header value to match the origin
        /// hostname by default. This overrides the host header defined at
        /// Endpoint
        /// </summary>
        [JsonProperty(PropertyName = "properties.originHostHeader")]
        public string OriginHostHeader { get; set; }

        /// <summary>
        /// Gets or sets priority of origin in given origin group for load
        /// balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets weight of the origin in given origin group for load
        /// balancing. Must be between 1 and 1000
        /// </summary>
        [JsonProperty(PropertyName = "properties.weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or sets the properties of the private link resource for
        /// private origin.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedPrivateLinkResource")]
        public object SharedPrivateLinkResource { get; set; }

        /// <summary>
        /// Gets or sets whether to enable health probes to be made against
        /// backends defined under backendPools. Health probes can only be
        /// disabled if there is a single enabled backend in single enabled
        /// backend pool. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledState")]
        public string EnabledState { get; set; }

        /// <summary>
        /// Gets provisioning status. Possible values include: 'Succeeded',
        /// 'Failed', 'Updating', 'Deleting', 'Creating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets possible values include: 'NotStarted', 'InProgress',
        /// 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deploymentStatus")]
        public string DeploymentStatus { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HostName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostName");
            }
            if (HttpPort != null)
            {
                if (HttpPort > 65535)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "HttpPort", 65535);
                }
                if (HttpPort < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "HttpPort", 1);
                }
            }
            if (HttpsPort != null)
            {
                if (HttpsPort > 65535)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "HttpsPort", 65535);
                }
                if (HttpsPort < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "HttpsPort", 1);
                }
            }
            if (Priority != null)
            {
                if (Priority > 5)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "Priority", 5);
                }
                if (Priority < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Priority", 1);
                }
            }
            if (Weight != null)
            {
                if (Weight > 1000)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "Weight", 1000);
                }
                if (Weight < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Weight", 1);
                }
            }
        }
    }
}
