// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementNotification data model.
    /// Notification details.
    /// </summary>
    public partial class ApiManagementNotificationData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementNotificationData"/>. </summary>
        public ApiManagementNotificationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementNotificationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="title"> Title of the Notification. </param>
        /// <param name="description"> Description of the Notification. </param>
        /// <param name="recipients"> Recipient Parameter values. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementNotificationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string title, string description, RecipientsContractProperties recipients, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Title = title;
            Description = description;
            Recipients = recipients;
            _rawData = rawData;
        }

        /// <summary> Title of the Notification. </summary>
        public string Title { get; set; }
        /// <summary> Description of the Notification. </summary>
        public string Description { get; set; }
        /// <summary> Recipient Parameter values. </summary>
        public RecipientsContractProperties Recipients { get; set; }
    }
}
