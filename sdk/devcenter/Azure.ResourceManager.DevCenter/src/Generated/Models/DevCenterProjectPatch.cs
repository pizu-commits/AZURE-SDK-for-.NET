// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The project properties for partial update. Properties not provided in the update request will not be changed. </summary>
    public partial class DevCenterProjectPatch : DevCenterTrackedResourceUpdate
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterProjectPatch"/>. </summary>
        public DevCenterProjectPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterProjectPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="devCenterId"> Resource Id of an associated DevCenter. </param>
        /// <param name="description"> Description of the project. </param>
        /// <param name="maxDevBoxesPerUser"> When specified, limits the maximum number of Dev Boxes a single user can create across all pools in the project. This will have no effect on existing Dev Boxes when reduced. </param>
        internal DevCenterProjectPatch(IDictionary<string, string> tags, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier devCenterId, string description, int? maxDevBoxesPerUser) : base(tags, location, serializedAdditionalRawData)
        {
            DevCenterId = devCenterId;
            Description = description;
            MaxDevBoxesPerUser = maxDevBoxesPerUser;
        }

        /// <summary> Resource Id of an associated DevCenter. </summary>
        public ResourceIdentifier DevCenterId { get; set; }
        /// <summary> Description of the project. </summary>
        public string Description { get; set; }
        /// <summary> When specified, limits the maximum number of Dev Boxes a single user can create across all pools in the project. This will have no effect on existing Dev Boxes when reduced. </summary>
        public int? MaxDevBoxesPerUser { get; set; }
    }
}
