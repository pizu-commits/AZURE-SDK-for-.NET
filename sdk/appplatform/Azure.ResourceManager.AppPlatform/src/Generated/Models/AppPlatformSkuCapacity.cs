// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The SKU capacity. </summary>
    public partial class AppPlatformSkuCapacity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformSkuCapacity"/>. </summary>
        /// <param name="minimum"> Gets or sets the minimum. </param>
        internal AppPlatformSkuCapacity(int minimum)
        {
            Minimum = minimum;
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformSkuCapacity"/>. </summary>
        /// <param name="minimum"> Gets or sets the minimum. </param>
        /// <param name="maximum"> Gets or sets the maximum. </param>
        /// <param name="default"> Gets or sets the default. </param>
        /// <param name="scaleType"> Gets or sets the type of the scale. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformSkuCapacity(int minimum, int? maximum, int? @default, AppPlatformSkuScaleType? scaleType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformSkuCapacity"/> for deserialization. </summary>
        internal AppPlatformSkuCapacity()
        {
        }

        /// <summary> Gets or sets the minimum. </summary>
        public int Minimum { get; }
        /// <summary> Gets or sets the maximum. </summary>
        public int? Maximum { get; }
        /// <summary> Gets or sets the default. </summary>
        public int? Default { get; }
        /// <summary> Gets or sets the type of the scale. </summary>
        public AppPlatformSkuScaleType? ScaleType { get; }
    }
}
