// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The SavingsPlanModelList. </summary>
    internal partial class SavingsPlanModelList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SavingsPlanModelList"/>. </summary>
        internal SavingsPlanModelList()
        {
            Value = new ChangeTrackingList<BillingBenefitsSavingsPlanData>();
        }

        /// <summary> Initializes a new instance of <see cref="SavingsPlanModelList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> Url to get the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SavingsPlanModelList(IReadOnlyList<BillingBenefitsSavingsPlanData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<BillingBenefitsSavingsPlanData> Value { get; }
        /// <summary> Url to get the next page. </summary>
        public string NextLink { get; }
    }
}
