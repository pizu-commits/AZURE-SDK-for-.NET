// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Collection of all the Role addon on the Azure Stack Edge device. </summary>
    internal partial class AddonList
    {
        /// <summary> Initializes a new instance of AddonList. </summary>
        internal AddonList()
        {
            Value = new ChangeTrackingList<DataBoxEdgeRoleAddonData>();
        }

        /// <summary> Initializes a new instance of AddonList. </summary>
        /// <param name="value">
        /// The Value.
        /// Please note <see cref="DataBoxEdgeRoleAddonData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EdgeArcAddon"/> and <see cref="EdgeIotAddon"/>.
        /// </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal AddonList(IReadOnlyList<DataBoxEdgeRoleAddonData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The Value.
        /// Please note <see cref="DataBoxEdgeRoleAddonData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EdgeArcAddon"/> and <see cref="EdgeIotAddon"/>.
        /// </summary>
        public IReadOnlyList<DataBoxEdgeRoleAddonData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
