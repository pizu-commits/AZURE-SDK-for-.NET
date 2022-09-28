// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> List of all new plans notifications for public offers. </summary>
    public partial class NewPlanNotificationListResult
    {
        /// <summary> Initializes a new instance of NewPlanNotificationListResult. </summary>
        internal NewPlanNotificationListResult()
        {
            NewPlansNotifications = new ChangeTrackingList<NewPlanNotification>();
        }

        /// <summary> Initializes a new instance of NewPlanNotificationListResult. </summary>
        /// <param name="newPlansNotifications"></param>
        internal NewPlanNotificationListResult(IReadOnlyList<NewPlanNotification> newPlansNotifications)
        {
            NewPlansNotifications = newPlansNotifications;
        }

        /// <summary> Gets the new plans notifications. </summary>
        public IReadOnlyList<NewPlanNotification> NewPlansNotifications { get; }
    }
}
