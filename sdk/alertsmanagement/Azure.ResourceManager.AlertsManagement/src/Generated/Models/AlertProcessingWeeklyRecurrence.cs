// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// Weekly recurrence object.
    /// Serialized Name: WeeklyRecurrence
    /// </summary>
    public partial class AlertProcessingWeeklyRecurrence : AlertProcessingRuleRecurrence
    {
        /// <summary> Initializes a new instance of AlertProcessingWeeklyRecurrence. </summary>
        /// <param name="daysOfWeek">
        /// Specifies the values for weekly recurrence pattern.
        /// Serialized Name: WeeklyRecurrence.daysOfWeek
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="daysOfWeek"/> is null. </exception>
        public AlertProcessingWeeklyRecurrence(IEnumerable<AlertsManagementDayOfWeek> daysOfWeek)
        {
            if (daysOfWeek == null)
            {
                throw new ArgumentNullException(nameof(daysOfWeek));
            }

            DaysOfWeek = daysOfWeek.ToList();
            RecurrenceType = RecurrenceType.Weekly;
        }

        /// <summary> Initializes a new instance of AlertProcessingWeeklyRecurrence. </summary>
        /// <param name="recurrenceType">
        /// Specifies when the recurrence should be applied.
        /// Serialized Name: AlertProcessingRuleRecurrence.recurrenceType
        /// </param>
        /// <param name="startOn">
        /// Start time for recurrence.
        /// Serialized Name: AlertProcessingRuleRecurrence.startTime
        /// </param>
        /// <param name="endOn">
        /// End time for recurrence.
        /// Serialized Name: AlertProcessingRuleRecurrence.endTime
        /// </param>
        /// <param name="daysOfWeek">
        /// Specifies the values for weekly recurrence pattern.
        /// Serialized Name: WeeklyRecurrence.daysOfWeek
        /// </param>
        internal AlertProcessingWeeklyRecurrence(RecurrenceType recurrenceType, DateTimeOffset? startOn, DateTimeOffset? endOn, IList<AlertsManagementDayOfWeek> daysOfWeek) : base(recurrenceType, startOn, endOn)
        {
            DaysOfWeek = daysOfWeek;
            RecurrenceType = recurrenceType;
        }

        /// <summary>
        /// Specifies the values for weekly recurrence pattern.
        /// Serialized Name: WeeklyRecurrence.daysOfWeek
        /// </summary>
        public IList<AlertsManagementDayOfWeek> DaysOfWeek { get; }
    }
}
