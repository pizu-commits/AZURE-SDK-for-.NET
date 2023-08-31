// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The recurrence schedule occurrence. </summary>
    public partial class LogicWorkflowRecurrenceScheduleOccurrence
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRecurrenceScheduleOccurrence"/>. </summary>
        public LogicWorkflowRecurrenceScheduleOccurrence()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRecurrenceScheduleOccurrence"/>. </summary>
        /// <param name="day"> The day of the week. </param>
        /// <param name="occurrence"> The occurrence. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowRecurrenceScheduleOccurrence(LogicWorkflowDayOfWeek? day, int? occurrence, Dictionary<string, BinaryData> rawData)
        {
            Day = day;
            Occurrence = occurrence;
            _rawData = rawData;
        }

        /// <summary> The day of the week. </summary>
        public LogicWorkflowDayOfWeek? Day { get; set; }
        /// <summary> The occurrence. </summary>
        public int? Occurrence { get; set; }
    }
}
