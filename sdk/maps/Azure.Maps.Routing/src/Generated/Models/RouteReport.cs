// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    /// <summary> Reports the effective settings used in the current call. </summary>
    public partial class RouteReport
    {
        /// <summary> Initializes a new instance of RouteReport. </summary>
        internal RouteReport()
        {
            EffectiveSettings = new Core.ChangeTrackingList<EffectiveSetting>();
        }

        /// <summary> Initializes a new instance of RouteReport. </summary>
        /// <param name="effectiveSettings"> Effective parameters or data used when calling this Route API. </param>
        internal RouteReport(IReadOnlyList<EffectiveSetting> effectiveSettings)
        {
            EffectiveSettings = effectiveSettings;
        }

        /// <summary> Effective parameters or data used when calling this Route API. </summary>
        public IReadOnlyList<EffectiveSetting> EffectiveSettings { get; }
    }
}
