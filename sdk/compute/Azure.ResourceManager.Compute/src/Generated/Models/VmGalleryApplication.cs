// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the required information to reference a compute gallery application version. </summary>
    public partial class VmGalleryApplication
    {
        /// <summary> Initializes a new instance of VmGalleryApplication. </summary>
        /// <param name="packageReferenceId"> Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packageReferenceId"/> is null. </exception>
        public VmGalleryApplication(string packageReferenceId)
        {
            if (packageReferenceId == null)
            {
                throw new ArgumentNullException(nameof(packageReferenceId));
            }

            PackageReferenceId = packageReferenceId;
        }

        /// <summary> Initializes a new instance of VmGalleryApplication. </summary>
        /// <param name="tags"> Optional, Specifies a passthrough value for more generic context. </param>
        /// <param name="order"> Optional, Specifies the order in which the packages have to be installed. </param>
        /// <param name="packageReferenceId"> Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}. </param>
        /// <param name="configurationReference"> Optional, Specifies the uri to an azure blob that will replace the default configuration for the package if provided. </param>
        internal VmGalleryApplication(string tags, int? order, string packageReferenceId, string configurationReference)
        {
            Tags = tags;
            Order = order;
            PackageReferenceId = packageReferenceId;
            ConfigurationReference = configurationReference;
        }

        /// <summary> Optional, Specifies a passthrough value for more generic context. </summary>
        public string Tags { get; set; }
        /// <summary> Optional, Specifies the order in which the packages have to be installed. </summary>
        public int? Order { get; set; }
        /// <summary> Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}. </summary>
        public string PackageReferenceId { get; set; }
        /// <summary> Optional, Specifies the uri to an azure blob that will replace the default configuration for the package if provided. </summary>
        public string ConfigurationReference { get; set; }
    }
}
