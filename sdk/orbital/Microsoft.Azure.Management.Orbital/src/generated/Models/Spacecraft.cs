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
    /// Customer creates a spacecraft resource to schedule a contact.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Spacecraft : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Spacecraft class.
        /// </summary>
        public Spacecraft()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Spacecraft class.
        /// </summary>
        /// <param name="noradId">NORAD ID of the spacecraft.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        /// <param name="authorizationStatus">Authorization status of
        /// spacecraft. Possible values include: 'Allowed', 'Pending',
        /// 'Denied'</param>
        /// <param name="authorizationStatusExtended">Details of the
        /// authorization status.</param>
        /// <param name="titleLine">Title line of Two Line Element
        /// (TLE).</param>
        /// <param name="tleLine1">Line 1 of Two Line Element (TLE).</param>
        /// <param name="tleLine2">Line 2 of Two Line Element (TLE).</param>
        /// <param name="links">Links of the Spacecraft</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public Spacecraft(string noradId, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceSystemData systemData = default(ResourceSystemData), AuthorizationStatus? authorizationStatus = default(AuthorizationStatus?), string authorizationStatusExtended = default(string), string titleLine = default(string), string tleLine1 = default(string), string tleLine2 = default(string), IList<SpacecraftLink> links = default(IList<SpacecraftLink>), string etag = default(string))
            : base(id, name, type, location, tags, systemData)
        {
            NoradId = noradId;
            AuthorizationStatus = authorizationStatus;
            AuthorizationStatusExtended = authorizationStatusExtended;
            TitleLine = titleLine;
            TleLine1 = tleLine1;
            TleLine2 = tleLine2;
            Links = links;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets NORAD ID of the spacecraft.
        /// </summary>
        [JsonProperty(PropertyName = "properties.noradId")]
        public string NoradId { get; set; }

        /// <summary>
        /// Gets authorization status of spacecraft. Possible values include:
        /// 'Allowed', 'Pending', 'Denied'
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationStatus")]
        public AuthorizationStatus? AuthorizationStatus { get; private set; }

        /// <summary>
        /// Gets details of the authorization status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationStatusExtended")]
        public string AuthorizationStatusExtended { get; private set; }

        /// <summary>
        /// Gets or sets title line of Two Line Element (TLE).
        /// </summary>
        [JsonProperty(PropertyName = "properties.titleLine")]
        public string TitleLine { get; set; }

        /// <summary>
        /// Gets or sets line 1 of Two Line Element (TLE).
        /// </summary>
        [JsonProperty(PropertyName = "properties.tleLine1")]
        public string TleLine1 { get; set; }

        /// <summary>
        /// Gets or sets line 2 of Two Line Element (TLE).
        /// </summary>
        [JsonProperty(PropertyName = "properties.tleLine2")]
        public string TleLine2 { get; set; }

        /// <summary>
        /// Gets or sets links of the Spacecraft
        /// </summary>
        [JsonProperty(PropertyName = "properties.links")]
        public IList<SpacecraftLink> Links { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
