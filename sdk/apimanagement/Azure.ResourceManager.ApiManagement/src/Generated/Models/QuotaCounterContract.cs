// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Quota counter details. </summary>
    public partial class QuotaCounterContract
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

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
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaCounterContract(string counterKey, string periodKey, DateTimeOffset periodStartOn, DateTimeOffset periodEndOn, QuotaCounterValueContractProperties value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CounterKey = counterKey;
            PeriodKey = periodKey;
            PeriodStartOn = periodStartOn;
            PeriodEndOn = periodEndOn;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
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
