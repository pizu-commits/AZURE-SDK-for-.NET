// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data used for requesting a Disk Inspection execution.
    /// </summary>
    public partial class RunDiskInspectionInput
    {
        /// <summary>
        /// Initializes a new instance of the RunDiskInspectionInput class.
        /// </summary>
        public RunDiskInspectionInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunDiskInspectionInput class.
        /// </summary>
        /// <param name="resourceId">Qualified name of the resource.</param>
        /// <param name="manifest">Name of manifest in order to trigger Disk
        /// Inspection.</param>
        /// <param name="uploadSasUri">SAS uri to the blob where results will
        /// be uploaded.</param>
        public RunDiskInspectionInput(string resourceId, string manifest, string uploadSasUri)
        {
            ResourceId = resourceId;
            Manifest = manifest;
            UploadSasUri = uploadSasUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets qualified name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets name of manifest in order to trigger Disk Inspection.
        /// </summary>
        [JsonProperty(PropertyName = "manifest")]
        public string Manifest { get; set; }

        /// <summary>
        /// Gets or sets SAS uri to the blob where results will be uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "uploadSasUri")]
        public string UploadSasUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
            if (Manifest == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Manifest");
            }
            if (UploadSasUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UploadSasUri");
            }
        }
    }
}
