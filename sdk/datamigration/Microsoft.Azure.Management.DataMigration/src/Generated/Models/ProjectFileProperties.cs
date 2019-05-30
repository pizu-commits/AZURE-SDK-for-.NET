// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base class for file properties.
    /// </summary>
    public partial class ProjectFileProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProjectFileProperties class.
        /// </summary>
        public ProjectFileProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProjectFileProperties class.
        /// </summary>
        /// <param name="extension">Optional File extension. If submitted it
        /// should not have a leading period and must match the extension from
        /// filePath.</param>
        /// <param name="filePath">Relative path of this file resource. This
        /// property can be set when creating or updating the file
        /// resource.</param>
        /// <param name="lastModified">Modification DateTime.</param>
        /// <param name="mediaType">File content type. This property can be
        /// modified to reflect the file content type.</param>
        /// <param name="size">File size.</param>
        public ProjectFileProperties(string extension = default(string), string filePath = default(string), System.DateTimeOffset? lastModified = default(System.DateTimeOffset?), string mediaType = default(string), long? size = default(long?))
        {
            Extension = extension;
            FilePath = filePath;
            LastModified = lastModified;
            MediaType = mediaType;
            Size = size;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional File extension. If submitted it should not
        /// have a leading period and must match the extension from filePath.
        /// </summary>
        [JsonProperty(PropertyName = "extension")]
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets relative path of this file resource. This property can
        /// be set when creating or updating the file resource.
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets modification DateTime.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public System.DateTimeOffset? LastModified { get; private set; }

        /// <summary>
        /// Gets or sets file content type. This property can be modified to
        /// reflect the file content type.
        /// </summary>
        [JsonProperty(PropertyName = "mediaType")]
        public string MediaType { get; set; }

        /// <summary>
        /// Gets file size.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; private set; }

    }
}
