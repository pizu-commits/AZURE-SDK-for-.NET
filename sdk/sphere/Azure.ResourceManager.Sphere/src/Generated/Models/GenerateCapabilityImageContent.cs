// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> Request of the action to create a signed device capability image. </summary>
    public partial class GenerateCapabilityImageContent
    {
        /// <summary> Initializes a new instance of <see cref="GenerateCapabilityImageContent"/>. </summary>
        /// <param name="capabilities"> List of capabilities to create. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilities"/> is null. </exception>
        public GenerateCapabilityImageContent(IEnumerable<SphereCapabilityType> capabilities)
        {
            Argument.AssertNotNull(capabilities, nameof(capabilities));

            Capabilities = capabilities.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GenerateCapabilityImageContent"/>. </summary>
        /// <param name="capabilities"> List of capabilities to create. </param>
        internal GenerateCapabilityImageContent(IList<SphereCapabilityType> capabilities)
        {
            Capabilities = capabilities;
        }

        /// <summary> List of capabilities to create. </summary>
        public IList<SphereCapabilityType> Capabilities { get; }
    }
}
