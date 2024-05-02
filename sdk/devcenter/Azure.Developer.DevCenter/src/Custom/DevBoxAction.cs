// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevBoxAction
    {
        /// <summary> Initializes a new instance of <see cref="DevBoxAction"/>. </summary>
        /// <param name="name"> The name of the action. </param>
        /// <param name="actionType"> The action that will be taken. </param>
        /// <param name="sourceId"> The id of the resource which triggered this action. </param>
        /// <param name="suspendedUntil"> The earliest time that the action could occur (UTC). </param>
        /// <param name="nextAction"> Details about the next run of this action. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DevBoxAction(string name, DevBoxActionType actionType, string sourceId, DateTimeOffset? suspendedUntil, DevBoxNextAction nextAction)
        {
            Name = name;
            ActionType = actionType;
            SourceId = sourceId;
            SuspendedUntil = suspendedUntil;
            NextAction = nextAction;
        }
    }
}
