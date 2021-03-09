// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CanaryTrafficRegionRolloutConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CanaryTrafficRegionRolloutConfiguration class.
        /// </summary>
        public CanaryTrafficRegionRolloutConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CanaryTrafficRegionRolloutConfiguration class.
        /// </summary>
        public CanaryTrafficRegionRolloutConfiguration(IList<string> skipRegions = default(IList<string>), IList<string> regions = default(IList<string>))
        {
            SkipRegions = skipRegions;
            Regions = regions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skipRegions")]
        public IList<string> SkipRegions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regions")]
        public IList<string> Regions { get; set; }

    }
}
