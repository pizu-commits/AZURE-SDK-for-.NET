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
    /// A class representing the ApiManagementPortalDelegationSetting data model.
    /// Delegation settings for a developer portal.
    /// </summary>
    public partial class ApiManagementPortalDelegationSettingData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementPortalDelegationSettingData"/>. </summary>
        public ApiManagementPortalDelegationSettingData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementPortalDelegationSettingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="uri"> A delegation Url. </param>
        /// <param name="validationKey"> A base64-encoded validation key to validate, that a request is coming from Azure API Management. </param>
        /// <param name="subscriptions"> Subscriptions delegation settings. </param>
        /// <param name="userRegistration"> User registration delegation settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementPortalDelegationSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri uri, string validationKey, SubscriptionDelegationSettingProperties subscriptions, RegistrationDelegationSettingProperties userRegistration, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Uri = uri;
            ValidationKey = validationKey;
            Subscriptions = subscriptions;
            UserRegistration = userRegistration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A delegation Url. </summary>
        public Uri Uri { get; set; }
        /// <summary> A base64-encoded validation key to validate, that a request is coming from Azure API Management. </summary>
        public string ValidationKey { get; set; }
        /// <summary> Subscriptions delegation settings. </summary>
        internal SubscriptionDelegationSettingProperties Subscriptions { get; set; }
        /// <summary> Enable or disable delegation for subscriptions. </summary>
        public bool? IsSubscriptionDelegationEnabled
        {
            get => Subscriptions is null ? default : Subscriptions.IsSubscriptionDelegationEnabled;
            set
            {
                if (Subscriptions is null)
                    Subscriptions = new SubscriptionDelegationSettingProperties();
                Subscriptions.IsSubscriptionDelegationEnabled = value;
            }
        }

        /// <summary> User registration delegation settings. </summary>
        internal RegistrationDelegationSettingProperties UserRegistration { get; set; }
        /// <summary> Enable or disable delegation for user registration. </summary>
        public bool? IsUserRegistrationDelegationEnabled
        {
            get => UserRegistration is null ? default : UserRegistration.IsUserRegistrationDelegationEnabled;
            set
            {
                if (UserRegistration is null)
                    UserRegistration = new RegistrationDelegationSettingProperties();
                UserRegistration.IsUserRegistrationDelegationEnabled = value;
            }
        }
    }
}
