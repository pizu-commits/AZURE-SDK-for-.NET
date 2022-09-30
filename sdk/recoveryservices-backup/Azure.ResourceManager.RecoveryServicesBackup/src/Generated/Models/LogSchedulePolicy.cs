// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Log policy schedule. </summary>
    public partial class LogSchedulePolicy : SchedulePolicy
    {
        /// <summary> Initializes a new instance of LogSchedulePolicy. </summary>
        public LogSchedulePolicy()
        {
            SchedulePolicyType = "LogSchedulePolicy";
        }

        /// <summary> Initializes a new instance of LogSchedulePolicy. </summary>
        /// <param name="schedulePolicyType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="scheduleFrequencyInMins"> Frequency of the log schedule operation of this policy in minutes. </param>
        internal LogSchedulePolicy(string schedulePolicyType, int? scheduleFrequencyInMins) : base(schedulePolicyType)
        {
            ScheduleFrequencyInMins = scheduleFrequencyInMins;
            SchedulePolicyType = schedulePolicyType ?? "LogSchedulePolicy";
        }

        /// <summary> Frequency of the log schedule operation of this policy in minutes. </summary>
        public int? ScheduleFrequencyInMins { get; set; }
    }
}
