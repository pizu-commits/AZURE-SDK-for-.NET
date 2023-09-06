// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Route Target Configuration. </summary>
    public partial class RouteTargetInformation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RouteTargetInformation"/>. </summary>
        public RouteTargetInformation()
        {
            ImportIPv4RouteTargets = new ChangeTrackingList<string>();
            ImportIPv6RouteTargets = new ChangeTrackingList<string>();
            ExportIPv4RouteTargets = new ChangeTrackingList<string>();
            ExportIPv6RouteTargets = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RouteTargetInformation"/>. </summary>
        /// <param name="importIPv4RouteTargets"> Route Targets to be applied for incoming routes into CE. </param>
        /// <param name="importIPv6RouteTargets"> Route Targets to be applied for incoming routes from CE. </param>
        /// <param name="exportIPv4RouteTargets"> Route Targets to be applied for outgoing routes into CE. </param>
        /// <param name="exportIPv6RouteTargets"> Route Targets to be applied for outgoing routes from CE. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteTargetInformation(IList<string> importIPv4RouteTargets, IList<string> importIPv6RouteTargets, IList<string> exportIPv4RouteTargets, IList<string> exportIPv6RouteTargets, Dictionary<string, BinaryData> rawData)
        {
            ImportIPv4RouteTargets = importIPv4RouteTargets;
            ImportIPv6RouteTargets = importIPv6RouteTargets;
            ExportIPv4RouteTargets = exportIPv4RouteTargets;
            ExportIPv6RouteTargets = exportIPv6RouteTargets;
            _rawData = rawData;
        }

        /// <summary> Route Targets to be applied for incoming routes into CE. </summary>
        public IList<string> ImportIPv4RouteTargets { get; }
        /// <summary> Route Targets to be applied for incoming routes from CE. </summary>
        public IList<string> ImportIPv6RouteTargets { get; }
        /// <summary> Route Targets to be applied for outgoing routes into CE. </summary>
        public IList<string> ExportIPv4RouteTargets { get; }
        /// <summary> Route Targets to be applied for outgoing routes from CE. </summary>
        public IList<string> ExportIPv6RouteTargets { get; }
    }
}
