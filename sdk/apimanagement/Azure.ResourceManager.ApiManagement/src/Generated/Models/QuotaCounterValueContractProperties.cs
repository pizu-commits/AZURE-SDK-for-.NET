// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Quota counter value details. </summary>
    public partial class QuotaCounterValueContractProperties
    {
        /// <summary> Initializes a new instance of <see cref="QuotaCounterValueContractProperties"/>. </summary>
        internal QuotaCounterValueContractProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuotaCounterValueContractProperties"/>. </summary>
        /// <param name="callsCount"> Number of times Counter was called. </param>
        /// <param name="kbTransferred"> Data Transferred in KiloBytes. </param>
        internal QuotaCounterValueContractProperties(int? callsCount, double? kbTransferred)
        {
            CallsCount = callsCount;
            KbTransferred = kbTransferred;
        }

        /// <summary> Number of times Counter was called. </summary>
        public int? CallsCount { get; }
        /// <summary> Data Transferred in KiloBytes. </summary>
        public double? KbTransferred { get; }
    }
}
