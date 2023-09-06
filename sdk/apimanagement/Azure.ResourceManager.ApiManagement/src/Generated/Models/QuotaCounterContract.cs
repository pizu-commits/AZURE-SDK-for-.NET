// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Quota counter details. </summary>
    public partial class QuotaCounterContract
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QuotaCounterContract"/>. </summary>
        /// <param name="counterKey"> The Key value of the Counter. Must not be empty. </param>
        /// <param name="periodKey"> Identifier of the Period for which the counter was collected. Must not be empty. </param>
        /// <param name="periodStartOn">
        /// The date of the start of Counter Period. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="periodEndOn">
        /// The date of the end of Counter Period. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="counterKey"/> or <paramref name="periodKey"/> is null. </exception>
        internal QuotaCounterContract(string counterKey, string periodKey, DateTimeOffset periodStartOn, DateTimeOffset periodEndOn)
        {
            Argument.AssertNotNull(counterKey, nameof(counterKey));
            Argument.AssertNotNull(periodKey, nameof(periodKey));

            CounterKey = counterKey;
            PeriodKey = periodKey;
            PeriodStartOn = periodStartOn;
            PeriodEndOn = periodEndOn;
        }

        /// <summary> Initializes a new instance of <see cref="QuotaCounterContract"/>. </summary>
        /// <param name="counterKey"> The Key value of the Counter. Must not be empty. </param>
        /// <param name="periodKey"> Identifier of the Period for which the counter was collected. Must not be empty. </param>
        /// <param name="periodStartOn">
        /// The date of the start of Counter Period. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="periodEndOn">
        /// The date of the end of Counter Period. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="value"> Quota Value Properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaCounterContract(string counterKey, string periodKey, DateTimeOffset periodStartOn, DateTimeOffset periodEndOn, QuotaCounterValueContractProperties value, Dictionary<string, BinaryData> rawData)
        {
            CounterKey = counterKey;
            PeriodKey = periodKey;
            PeriodStartOn = periodStartOn;
            PeriodEndOn = periodEndOn;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="QuotaCounterContract"/> for deserialization. </summary>
        internal QuotaCounterContract()
        {
        }

        /// <summary> The Key value of the Counter. Must not be empty. </summary>
        public string CounterKey { get; }
        /// <summary> Identifier of the Period for which the counter was collected. Must not be empty. </summary>
        public string PeriodKey { get; }
        /// <summary>
        /// The date of the start of Counter Period. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset PeriodStartOn { get; }
        /// <summary>
        /// The date of the end of Counter Period. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset PeriodEndOn { get; }
        /// <summary> Quota Value Properties. </summary>
        public QuotaCounterValueContractProperties Value { get; }
    }
}
