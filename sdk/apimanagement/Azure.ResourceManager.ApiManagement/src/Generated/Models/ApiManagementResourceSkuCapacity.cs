// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Describes scaling information of a SKU. </summary>
    public partial class ApiManagementResourceSkuCapacity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementResourceSkuCapacity"/>. </summary>
        internal ApiManagementResourceSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementResourceSkuCapacity"/>. </summary>
        /// <param name="minimum"> The minimum capacity. </param>
        /// <param name="maximum"> The maximum capacity that can be set. </param>
        /// <param name="default"> The default capacity. </param>
        /// <param name="scaleType"> The scale type applicable to the sku. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementResourceSkuCapacity(int? minimum, int? maximum, int? @default, ApiManagementResourceSkuCapacityScaleType? scaleType, Dictionary<string, BinaryData> rawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
            _rawData = rawData;
        }

        /// <summary> The minimum capacity. </summary>
        public int? Minimum { get; }
        /// <summary> The maximum capacity that can be set. </summary>
        public int? Maximum { get; }
        /// <summary> The default capacity. </summary>
        public int? Default { get; }
        /// <summary> The scale type applicable to the sku. </summary>
        public ApiManagementResourceSkuCapacityScaleType? ScaleType { get; }
    }
}
