// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The billing meters.
    /// Serialized Name: BillingMeters
    /// </summary>
    public partial class HDInsightBillingMeters
    {
        /// <summary> Initializes a new instance of HDInsightBillingMeters. </summary>
        internal HDInsightBillingMeters()
        {
        }

        /// <summary> Initializes a new instance of HDInsightBillingMeters. </summary>
        /// <param name="meterParameter">
        /// The virtual machine sizes.
        /// Serialized Name: BillingMeters.meterParameter
        /// </param>
        /// <param name="meter">
        /// The HDInsight meter guid.
        /// Serialized Name: BillingMeters.meter
        /// </param>
        /// <param name="unit">
        /// The unit of meter, VMHours or CoreHours.
        /// Serialized Name: BillingMeters.unit
        /// </param>
        internal HDInsightBillingMeters(string meterParameter, string meter, string unit)
        {
            MeterParameter = meterParameter;
            Meter = meter;
            Unit = unit;
        }

        /// <summary>
        /// The virtual machine sizes.
        /// Serialized Name: BillingMeters.meterParameter
        /// </summary>
        public string MeterParameter { get; }
        /// <summary>
        /// The HDInsight meter guid.
        /// Serialized Name: BillingMeters.meter
        /// </summary>
        public string Meter { get; }
        /// <summary>
        /// The unit of meter, VMHours or CoreHours.
        /// Serialized Name: BillingMeters.unit
        /// </summary>
        public string Unit { get; }
    }
}
