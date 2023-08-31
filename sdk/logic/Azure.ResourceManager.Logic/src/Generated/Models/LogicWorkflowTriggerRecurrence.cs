// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The workflow trigger recurrence. </summary>
    public partial class LogicWorkflowTriggerRecurrence
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerRecurrence"/>. </summary>
        public LogicWorkflowTriggerRecurrence()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerRecurrence"/>. </summary>
        /// <param name="frequency"> The frequency. </param>
        /// <param name="interval"> The interval. </param>
        /// <param name="startOn"> The start time. </param>
        /// <param name="endOn"> The end time. </param>
        /// <param name="timeZone"> The time zone. </param>
        /// <param name="schedule"> The recurrence schedule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowTriggerRecurrence(LogicWorkflowRecurrenceFrequency? frequency, int? interval, DateTimeOffset? startOn, DateTimeOffset? endOn, string timeZone, LogicWorkflowRecurrenceSchedule schedule, Dictionary<string, BinaryData> rawData)
        {
            Frequency = frequency;
            Interval = interval;
            StartOn = startOn;
            EndOn = endOn;
            TimeZone = timeZone;
            Schedule = schedule;
            _rawData = rawData;
        }

        /// <summary> The frequency. </summary>
        public LogicWorkflowRecurrenceFrequency? Frequency { get; set; }
        /// <summary> The interval. </summary>
        public int? Interval { get; set; }
        /// <summary> The start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> The end time. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> The time zone. </summary>
        public string TimeZone { get; set; }
        /// <summary> The recurrence schedule. </summary>
        public LogicWorkflowRecurrenceSchedule Schedule { get; set; }
    }
}
