// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Details of the estimated savings. </summary>
    public partial class ConsumptionSavingsProperties
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

        /// <summary> Initializes a new instance of <see cref="ConsumptionSavingsProperties"/>. </summary>
        internal ConsumptionSavingsProperties()
        {
            CalculatedSavings = new ChangeTrackingList<ConsumptionCalculatedSavingsProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionSavingsProperties"/>. </summary>
        /// <param name="calculatedSavings"> List of calculated savings. </param>
        /// <param name="lookBackPeriod"> Number of days of usage to look back used for computing the recommendation. </param>
        /// <param name="recommendedQuantity"> Number of recommended units of the resource. </param>
        /// <param name="reservationOrderTerm"> Term period of the reservation, ex: P1Y or P3Y. </param>
        /// <param name="savingsType"> Type of savings, ex: instance. </param>
        /// <param name="unitOfMeasure"> Measurement unit ex: hour etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsumptionSavingsProperties(IReadOnlyList<ConsumptionCalculatedSavingsProperties> calculatedSavings, int? lookBackPeriod, float? recommendedQuantity, string reservationOrderTerm, string savingsType, string unitOfMeasure, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CalculatedSavings = calculatedSavings;
            LookBackPeriod = lookBackPeriod;
            RecommendedQuantity = recommendedQuantity;
            ReservationOrderTerm = reservationOrderTerm;
            SavingsType = savingsType;
            UnitOfMeasure = unitOfMeasure;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of calculated savings. </summary>
        public IReadOnlyList<ConsumptionCalculatedSavingsProperties> CalculatedSavings { get; }
        /// <summary> Number of days of usage to look back used for computing the recommendation. </summary>
        public int? LookBackPeriod { get; }
        /// <summary> Number of recommended units of the resource. </summary>
        public float? RecommendedQuantity { get; }
        /// <summary> Term period of the reservation, ex: P1Y or P3Y. </summary>
        public string ReservationOrderTerm { get; }
        /// <summary> Type of savings, ex: instance. </summary>
        public string SavingsType { get; }
        /// <summary> Measurement unit ex: hour etc. </summary>
        public string UnitOfMeasure { get; }
    }
}
