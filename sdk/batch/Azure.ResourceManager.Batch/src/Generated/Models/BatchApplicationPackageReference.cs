// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Link to an application package inside the batch account. </summary>
    public partial class BatchApplicationPackageReference
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageReference"/>. </summary>
        /// <param name="id"> The ID of the application package to install. This must be inside the same batch account as the pool. This can either be a reference to a specific version or the default version if one exists. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public BatchApplicationPackageReference(ResourceIdentifier id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageReference"/>. </summary>
        /// <param name="id"> The ID of the application package to install. This must be inside the same batch account as the pool. This can either be a reference to a specific version or the default version if one exists. </param>
        /// <param name="version"> If this is omitted, and no default version is specified for this application, the request fails with the error code InvalidApplicationPackageReferences. If you are calling the REST API directly, the HTTP status code is 409. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchApplicationPackageReference(ResourceIdentifier id, string version, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Version = version;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageReference"/> for deserialization. </summary>
        internal BatchApplicationPackageReference()
        {
        }

        /// <summary> The ID of the application package to install. This must be inside the same batch account as the pool. This can either be a reference to a specific version or the default version if one exists. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> If this is omitted, and no default version is specified for this application, the request fails with the error code InvalidApplicationPackageReferences. If you are calling the REST API directly, the HTTP status code is 409. </summary>
        public string Version { get; set; }
    }
}
