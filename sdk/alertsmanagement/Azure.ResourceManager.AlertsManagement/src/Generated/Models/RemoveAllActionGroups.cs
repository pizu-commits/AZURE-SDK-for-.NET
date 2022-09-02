// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// Indicates if all action groups should be removed.
    /// Serialized Name: RemoveAllActionGroups
    /// </summary>
    public partial class RemoveAllActionGroups : AlertProcessingAction
    {
        /// <summary> Initializes a new instance of RemoveAllActionGroups. </summary>
        public RemoveAllActionGroups()
        {
            ActionType = AlertProcessingActionType.RemoveAllActionGroups;
        }

        /// <summary> Initializes a new instance of RemoveAllActionGroups. </summary>
        /// <param name="actionType">
        /// Action that should be applied.
        /// Serialized Name: Action.actionType
        /// </param>
        internal RemoveAllActionGroups(AlertProcessingActionType actionType) : base(actionType)
        {
            ActionType = actionType;
        }
    }
}
