// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevBoxSchedule
    {
        /// <summary> Initializes a new instance of <see cref="DevBoxSchedule"/>. </summary>
        /// <param name="name"> Display name for the Schedule. </param>
        /// <param name="scheduleType"> Supported type this scheduled task represents. </param>
        /// <param name="scheduleFrequency"> The frequency of this scheduled task. </param>
        /// <param name="time"> The target time to trigger the action. The format is HH:MM. </param>
        /// <param name="timeZone"> The IANA timezone id at which the schedule should execute. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal DevBoxSchedule(string name, ScheduleType scheduleType, ScheduleFrequency scheduleFrequency, string time, string timeZone)
        {
            Name = name;
            ScheduleType = scheduleType;
            ScheduleFrequency = scheduleFrequency;
            Time = time;
            TimeZone = timeZone;
        }
    }
}
