// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System.Linq;

    /// <summary>
    /// A Node Resource
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class NodeResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NodeResource class.
        /// </summary>
        public NodeResource() { }

        /// <summary>
        /// Initializes a new instance of the NodeResource class.
        /// </summary>
        /// <param name="id">ARM Resource ID</param>
        /// <param name="type">ARM Resource Type</param>
        /// <param name="name">ARM Resource Name</param>
        /// <param name="location">ARM Resource Location</param>
        /// <param name="tags">ARM Resource Tags</param>
        /// <param name="gatewayId">Id of the gateway</param>
        /// <param name="connectionName">myhost.domain.com</param>
        /// <param name="created">UTC date and time when node was first added
        /// to management service</param>
        /// <param name="updated">UTC date and time when node was last
        /// updated.</param>
        public NodeResource(string id = default(string), string type = default(string), string name = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string etag = default(string), string gatewayId = default(string), string connectionName = default(string), System.DateTime? created = default(System.DateTime?), System.DateTime? updated = default(System.DateTime?))
            : base(id, type, name, location, tags, etag)
        {
            GatewayId = gatewayId;
            ConnectionName = connectionName;
            Created = created;
            Updated = updated;
        }

        /// <summary>
        /// Gets or sets id of the gateway
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.gatewayId")]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or sets myhost.domain.com
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.connectionName")]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Gets or sets UTC date and time when node was first added to
        /// management service
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets UTC date and time when node was last updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.updated")]
        public System.DateTime? Updated { get; set; }

    }
}
