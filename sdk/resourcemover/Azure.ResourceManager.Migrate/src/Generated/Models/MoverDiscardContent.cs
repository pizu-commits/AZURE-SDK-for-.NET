// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary>
    /// Defines the request body for discard operation.
    /// Serialized Name: DiscardRequest
    /// </summary>
    public partial class MoverDiscardContent
    {
        /// <summary> Initializes a new instance of MoverDiscardContent. </summary>
        /// <param name="moveResources">
        /// Gets or sets the list of resource Id&apos;s, by default it accepts move resource id&apos;s unless the input type is switched via moveResourceInputType property.
        /// Serialized Name: DiscardRequest.moveResources
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResources"/> is null. </exception>
        public MoverDiscardContent(IEnumerable<string> moveResources)
        {
            if (moveResources == null)
            {
                throw new ArgumentNullException(nameof(moveResources));
            }

            MoveResources = moveResources.ToList();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the operation needs to only run pre-requisite.
        /// Serialized Name: DiscardRequest.validateOnly
        /// </summary>
        public bool? ValidateOnly { get; set; }
        /// <summary>
        /// Gets or sets the list of resource Id&apos;s, by default it accepts move resource id&apos;s unless the input type is switched via moveResourceInputType property.
        /// Serialized Name: DiscardRequest.moveResources
        /// </summary>
        public IList<string> MoveResources { get; }
        /// <summary>
        /// Defines the move resource input type.
        /// Serialized Name: DiscardRequest.moveResourceInputType
        /// </summary>
        public MoveResourceInputType? MoveResourceInputType { get; set; }
    }
}
