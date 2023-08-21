// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Result of testing all routes. </summary>
    public partial class IotHubTestAllRoutesResult
    {
        /// <summary> Initializes a new instance of IotHubTestAllRoutesResult. </summary>
        internal IotHubTestAllRoutesResult()
        {
            Routes = new Core.ChangeTrackingList<IotHubMatchedRoute>();
        }

        /// <summary> Initializes a new instance of IotHubTestAllRoutesResult. </summary>
        /// <param name="routes"> JSON-serialized array of matched routes. </param>
        internal IotHubTestAllRoutesResult(IReadOnlyList<IotHubMatchedRoute> routes)
        {
            Routes = routes;
        }

        /// <summary> JSON-serialized array of matched routes. </summary>
        public IReadOnlyList<IotHubMatchedRoute> Routes { get; }
    }
}
