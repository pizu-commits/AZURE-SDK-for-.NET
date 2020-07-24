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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Origin group comprising of origins is used for load balancing to
    /// origins when the content cannot be served from CDN.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OriginGroup : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the OriginGroup class.
        /// </summary>
        public OriginGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OriginGroup class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="healthProbeSettings">Health probe settings to the
        /// origin that is used to determine the health of the origin.</param>
        /// <param name="origins">The source of the content being delivered via
        /// CDN within given origin group.</param>
        /// <param
        /// name="trafficRestorationTimeToHealedOrNewEndpointsInMinutes">Time
        /// in minutes to shift the traffic to the endpoint gradually when an
        /// unhealthy endpoint comes healthy or a new endpoint is added.
        /// Default is 10 mins. This property is currently not
        /// supported.</param>
        /// <param name="responseBasedOriginErrorDetectionSettings">The JSON
        /// object that contains the properties to determine origin health
        /// using real requests/responses. This property is currently not
        /// supported.</param>
        /// <param name="resourceState">Resource status of the origin group.
        /// Possible values include: 'Creating', 'Active', 'Deleting'</param>
        /// <param name="provisioningState">Provisioning status of the origin
        /// group.</param>
        public OriginGroup(string id = default(string), string name = default(string), string type = default(string), HealthProbeParameters healthProbeSettings = default(HealthProbeParameters), IList<ResourceReference> origins = default(IList<ResourceReference>), int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes = default(int?), ResponseBasedOriginErrorDetectionParameters responseBasedOriginErrorDetectionSettings = default(ResponseBasedOriginErrorDetectionParameters), string resourceState = default(string), string provisioningState = default(string))
            : base(id, name, type)
        {
            HealthProbeSettings = healthProbeSettings;
            Origins = origins;
            TrafficRestorationTimeToHealedOrNewEndpointsInMinutes = trafficRestorationTimeToHealedOrNewEndpointsInMinutes;
            ResponseBasedOriginErrorDetectionSettings = responseBasedOriginErrorDetectionSettings;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets health probe settings to the origin that is used to
        /// determine the health of the origin.
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthProbeSettings")]
        public HealthProbeParameters HealthProbeSettings { get; set; }

        /// <summary>
        /// Gets or sets the source of the content being delivered via CDN
        /// within given origin group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.origins")]
        public IList<ResourceReference> Origins { get; set; }

        /// <summary>
        /// Gets or sets time in minutes to shift the traffic to the endpoint
        /// gradually when an unhealthy endpoint comes healthy or a new
        /// endpoint is added. Default is 10 mins. This property is currently
        /// not supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the JSON object that contains the properties to
        /// determine origin health using real requests/responses. This
        /// property is currently not supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.responseBasedOriginErrorDetectionSettings")]
        public ResponseBasedOriginErrorDetectionParameters ResponseBasedOriginErrorDetectionSettings { get; set; }

        /// <summary>
        /// Gets resource status of the origin group. Possible values include:
        /// 'Creating', 'Active', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets provisioning status of the origin group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HealthProbeSettings != null)
            {
                HealthProbeSettings.Validate();
            }
            if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes > 50)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "TrafficRestorationTimeToHealedOrNewEndpointsInMinutes", 50);
            }
            if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TrafficRestorationTimeToHealedOrNewEndpointsInMinutes", 0);
            }
            if (ResponseBasedOriginErrorDetectionSettings != null)
            {
                ResponseBasedOriginErrorDetectionSettings.Validate();
            }
        }
    }
}
