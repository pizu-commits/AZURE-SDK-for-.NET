// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create job schedule operation. </summary>
    public partial class AutomationJobScheduleCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="AutomationJobScheduleCreateOrUpdateContent"/>. </summary>
        /// <param name="schedule"> Gets or sets the schedule. </param>
        /// <param name="runbook"> Gets or sets the runbook. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/> or <paramref name="runbook"/> is null. </exception>
        public AutomationJobScheduleCreateOrUpdateContent(ScheduleAssociationProperty schedule, RunbookAssociationProperty runbook)
        {
            Argument.AssertNotNull(schedule, nameof(schedule));
            Argument.AssertNotNull(runbook, nameof(runbook));

            Schedule = schedule;
            Runbook = runbook;
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationJobScheduleCreateOrUpdateContent"/>. </summary>
        /// <param name="schedule"> Gets or sets the schedule. </param>
        /// <param name="runbook"> Gets or sets the runbook. </param>
        /// <param name="runOn"> Gets or sets the hybrid worker group that the scheduled job should run on. </param>
        /// <param name="parameters"> Gets or sets a list of job properties. </param>
        internal AutomationJobScheduleCreateOrUpdateContent(ScheduleAssociationProperty schedule, RunbookAssociationProperty runbook, string runOn, IDictionary<string, string> parameters)
        {
            Schedule = schedule;
            Runbook = runbook;
            RunOn = runOn;
            Parameters = parameters;
        }

        /// <summary> Gets or sets the schedule. </summary>
        internal ScheduleAssociationProperty Schedule { get; }
        /// <summary> Gets or sets the name of the Schedule. </summary>
        public string ScheduleName
        {
            get => Schedule?.Name;
        }

        /// <summary> Gets or sets the runbook. </summary>
        internal RunbookAssociationProperty Runbook { get; }
        /// <summary> Gets or sets the name of the runbook. </summary>
        public string RunbookName
        {
            get => Runbook?.Name;
        }

        /// <summary> Gets or sets the hybrid worker group that the scheduled job should run on. </summary>
        public string RunOn { get; set; }
        /// <summary> Gets or sets a list of job properties. </summary>
        public IDictionary<string, string> Parameters { get; set; }
    }
}
