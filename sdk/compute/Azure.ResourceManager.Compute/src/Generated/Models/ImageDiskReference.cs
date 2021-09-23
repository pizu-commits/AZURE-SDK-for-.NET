// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The source image used for creating the disk. </summary>
    public partial class ImageDiskReference : WritableSubResource
    {
        /// <summary> Initializes a new instance of ImageDiskReference. </summary>
        public ImageDiskReference()
        {
        }

        /// <summary> Initializes a new instance of ImageDiskReference. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="lun"> If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the image to use. For OS disks, this field is null. </param>
        internal ImageDiskReference(string id, int? lun) : base(id)
        {
            Lun = lun;
        }

        /// <summary> If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the image to use. For OS disks, this field is null. </summary>
        public int? Lun { get; set; }
    }
}
