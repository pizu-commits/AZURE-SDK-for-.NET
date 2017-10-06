// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The target of the event.
    /// </summary>
    public partial class Target
    {
        /// <summary>
        /// Initializes a new instance of the Target class.
        /// </summary>
        public Target()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Target class.
        /// </summary>
        /// <param name="mediaType">The MIME type of the referenced
        /// object.</param>
        /// <param name="size">The number of bytes of the content. Same as
        /// Length field.</param>
        /// <param name="digest">The digest of the content, as defined by the
        /// Registry V2 HTTP API Specificiation.</param>
        /// <param name="length">The number of bytes of the content. Same as
        /// Size field.</param>
        /// <param name="repository">The repository name.</param>
        /// <param name="url">The direct URL to the content.</param>
        /// <param name="tag">The tag name.</param>
        public Target(string mediaType = default(string), long? size = default(long?), string digest = default(string), long? length = default(long?), string repository = default(string), string url = default(string), string tag = default(string))
        {
            MediaType = mediaType;
            Size = size;
            Digest = digest;
            Length = length;
            Repository = repository;
            Url = url;
            Tag = tag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the MIME type of the referenced object.
        /// </summary>
        [JsonProperty(PropertyName = "mediaType")]
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or sets the number of bytes of the content. Same as Length
        /// field.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or sets the digest of the content, as defined by the Registry
        /// V2 HTTP API Specificiation.
        /// </summary>
        [JsonProperty(PropertyName = "digest")]
        public string Digest { get; set; }

        /// <summary>
        /// Gets or sets the number of bytes of the content. Same as Size
        /// field.
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public long? Length { get; set; }

        /// <summary>
        /// Gets or sets the repository name.
        /// </summary>
        [JsonProperty(PropertyName = "repository")]
        public string Repository { get; set; }

        /// <summary>
        /// Gets or sets the direct URL to the content.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the tag name.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

    }
}
