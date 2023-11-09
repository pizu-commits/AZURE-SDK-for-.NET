// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An Application Insights component available features. </summary>
    public partial class ApplicationInsightsComponentAvailableFeatures
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentAvailableFeatures"/>. </summary>
        internal ApplicationInsightsComponentAvailableFeatures()
        {
            Result = new ChangeTrackingList<ApplicationInsightsComponentFeature>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentAvailableFeatures"/>. </summary>
        /// <param name="result"> A list of Application Insights component feature. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationInsightsComponentAvailableFeatures(IReadOnlyList<ApplicationInsightsComponentFeature> result, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Result = result;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of Application Insights component feature. </summary>
        public IReadOnlyList<ApplicationInsightsComponentFeature> Result { get; }
    }
}
