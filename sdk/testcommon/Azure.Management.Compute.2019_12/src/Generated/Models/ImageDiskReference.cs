// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Compute.Models
{
    /// <summary> The source image used for creating the disk. </summary>
    public partial class ImageDiskReference
    {
        /// <summary> Initializes a new instance of ImageDiskReference. </summary>
        /// <param name="id"> A relative uri containing either a Platform Image Repository or user image reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public ImageDiskReference(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Initializes a new instance of ImageDiskReference. </summary>
        /// <param name="id"> A relative uri containing either a Platform Image Repository or user image reference. </param>
        /// <param name="lun"> If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the image to use. For OS disks, this field is null. </param>
        internal ImageDiskReference(string id, int? lun)
        {
            Id = id;
            Lun = lun;
        }

        /// <summary> A relative uri containing either a Platform Image Repository or user image reference. </summary>
        public string Id { get; set; }
        /// <summary> If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the image to use. For OS disks, this field is null. </summary>
        public int? Lun { get; set; }
    }
}
