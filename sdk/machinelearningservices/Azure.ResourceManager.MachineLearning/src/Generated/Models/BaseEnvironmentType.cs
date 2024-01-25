// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Base environment type. </summary>
    public partial class BaseEnvironmentType : BaseEnvironmentSource
    {
        /// <summary> Initializes a new instance of <see cref="BaseEnvironmentType"/>. </summary>
        /// <param name="resourceId"> [Required] Resource id accepting ArmId or AzureMlId. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public BaseEnvironmentType(ResourceIdentifier resourceId)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            ResourceId = resourceId;
            BaseEnvironmentSourceType = BaseEnvironmentSourceType.EnvironmentAsset;
        }

        /// <summary> Initializes a new instance of <see cref="BaseEnvironmentType"/>. </summary>
        /// <param name="baseEnvironmentSourceType"> [Required] Base environment type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="resourceId"> [Required] Resource id accepting ArmId or AzureMlId. </param>
        internal BaseEnvironmentType(BaseEnvironmentSourceType baseEnvironmentSourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier resourceId) : base(baseEnvironmentSourceType, serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            BaseEnvironmentSourceType = baseEnvironmentSourceType;
        }

        /// <summary> Initializes a new instance of <see cref="BaseEnvironmentType"/> for deserialization. </summary>
        internal BaseEnvironmentType()
        {
        }

        /// <summary> [Required] Resource id accepting ArmId or AzureMlId. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
