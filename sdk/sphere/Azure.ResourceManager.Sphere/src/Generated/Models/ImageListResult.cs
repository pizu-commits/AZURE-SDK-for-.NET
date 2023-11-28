// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Sphere;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// The response of a Image list operation.
    /// Serialized Name: ImageListResult
    /// </summary>
    internal partial class ImageListResult
    {
        /// <summary> Initializes a new instance of <see cref="ImageListResult"/>. </summary>
        /// <param name="value">
        /// The Image items on this page
        /// Serialized Name: ImageListResult.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ImageListResult(IEnumerable<SphereImageData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ImageListResult"/>. </summary>
        /// <param name="value">
        /// The Image items on this page
        /// Serialized Name: ImageListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The link to the next page of items
        /// Serialized Name: ImageListResult.nextLink
        /// </param>
        internal ImageListResult(IReadOnlyList<SphereImageData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The Image items on this page
        /// Serialized Name: ImageListResult.value
        /// </summary>
        public IReadOnlyList<SphereImageData> Value { get; }
        /// <summary>
        /// The link to the next page of items
        /// Serialized Name: ImageListResult.nextLink
        /// </summary>
        public Uri NextLink { get; }
    }
}
