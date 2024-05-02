// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevBoxActionDelayResult
    {
        /// <summary> Initializes a new instance of <see cref="DevBoxActionDelayResult"/>. </summary>
        /// <param name="actionName"> The name of the action. </param>
        /// <param name="delayStatus"> The result of the delay operation on this action. </param>
        /// <param name="action"> The delayed action. </param>
        /// <param name="error"> Information about the error that occurred. Only populated on error. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DevBoxActionDelayResult(string actionName, DevBoxActionDelayStatus delayStatus, DevBoxAction action, ResponseError error)
        {
            ActionName = actionName;
            DelayStatus = delayStatus;
            Action = action;
            Error = error;
        }
    }
}
