// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Orbital.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Customer creates a Contact Profile Resource, which will contain all of
    /// the configurations required for scheduling a contact.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ContactProfile : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ContactProfile class.
        /// </summary>
        public ContactProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContactProfile class.
        /// </summary>
        /// <param name="links">Links of the Contact Profile</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        /// <param name="minimumViableContactDuration">Minimum viable contact
        /// duration in ISO 8601 format.</param>
        /// <param name="minimumElevationDegrees">Minimum viable elevation for
        /// the contact in decimal degrees.</param>
        /// <param name="autoTrackingConfiguration">Auto track configuration.
        /// Possible values include: 'disabled', 'xBand', 'sBand'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ContactProfile(IList<ContactProfileLink> links, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceSystemData systemData = default(ResourceSystemData), string minimumViableContactDuration = default(string), double? minimumElevationDegrees = default(double?), AutoTrackingConfiguration? autoTrackingConfiguration = default(AutoTrackingConfiguration?), string etag = default(string))
            : base(id, name, type, location, tags, systemData)
        {
            MinimumViableContactDuration = minimumViableContactDuration;
            MinimumElevationDegrees = minimumElevationDegrees;
            AutoTrackingConfiguration = autoTrackingConfiguration;
            Links = links;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets minimum viable contact duration in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minimumViableContactDuration")]
        public string MinimumViableContactDuration { get; set; }

        /// <summary>
        /// Gets or sets minimum viable elevation for the contact in decimal
        /// degrees.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minimumElevationDegrees")]
        public double? MinimumElevationDegrees { get; set; }

        /// <summary>
        /// Gets or sets auto track configuration. Possible values include:
        /// 'disabled', 'xBand', 'sBand'
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoTrackingConfiguration")]
        public AutoTrackingConfiguration? AutoTrackingConfiguration { get; set; }

        /// <summary>
        /// Gets or sets links of the Contact Profile
        /// </summary>
        [JsonProperty(PropertyName = "properties.links")]
        public IList<ContactProfileLink> Links { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
