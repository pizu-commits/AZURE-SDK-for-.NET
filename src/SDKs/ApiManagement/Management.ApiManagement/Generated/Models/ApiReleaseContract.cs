// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Api Release details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApiReleaseContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApiReleaseContract class.
        /// </summary>
        public ApiReleaseContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiReleaseContract class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management
        /// resource.</param>
        /// <param name="apiId">Identifier of the API the release belongs
        /// to.</param>
        /// <param name="createdDateTime">The time the API was released. The
        /// date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as
        /// specified by the ISO 8601 standard.</param>
        /// <param name="updatedDateTime">The time the API release was
        /// updated.</param>
        /// <param name="notes">Release Notes</param>
        public ApiReleaseContract(string id = default(string), string name = default(string), string type = default(string), string apiId = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? updatedDateTime = default(System.DateTime?), string notes = default(string))
            : base(id, name, type)
        {
            ApiId = apiId;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
            Notes = notes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identifier of the API the release belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiId")]
        public string ApiId { get; set; }

        /// <summary>
        /// Gets the time the API was released. The date conforms to the
        /// following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601
        /// standard.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDateTime")]
        public System.DateTime? CreatedDateTime { get; private set; }

        /// <summary>
        /// Gets the time the API release was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedDateTime")]
        public System.DateTime? UpdatedDateTime { get; private set; }

        /// <summary>
        /// Gets or sets release Notes
        /// </summary>
        [JsonProperty(PropertyName = "properties.notes")]
        public string Notes { get; set; }

    }
}
