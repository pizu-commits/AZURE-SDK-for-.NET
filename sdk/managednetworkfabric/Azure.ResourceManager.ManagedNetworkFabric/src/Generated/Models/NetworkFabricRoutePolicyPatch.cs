// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The Route Policy patch resource definition. </summary>
    public partial class NetworkFabricRoutePolicyPatch : NetworkRackPatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkFabricRoutePolicyPatch"/>. </summary>
        public NetworkFabricRoutePolicyPatch()
        {
            Statements = new ChangeTrackingList<RoutePolicyStatementProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricRoutePolicyPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="statements"> Route Policy statements. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricRoutePolicyPatch(IDictionary<string, string> tags, IList<RoutePolicyStatementProperties> statements, Dictionary<string, BinaryData> rawData) : base(tags, rawData)
        {
            Statements = statements;
        }

        /// <summary> Route Policy statements. </summary>
        public IList<RoutePolicyStatementProperties> Statements { get; }
    }
}
