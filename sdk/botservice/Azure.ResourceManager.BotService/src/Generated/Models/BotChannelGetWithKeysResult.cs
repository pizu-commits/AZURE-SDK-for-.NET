// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The ARM channel of list channel with keys operation response. </summary>
    public partial class BotChannelGetWithKeysResult : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BotChannelGetWithKeysResult"/>. </summary>
        /// <param name="location"> The location. </param>
        public BotChannelGetWithKeysResult(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BotChannelGetWithKeysResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource">
        /// The set of properties specific to bot channel resource
        /// Please note <see cref="BotChannelProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AcsChatChannel"/>, <see cref="AlexaChannel"/>, <see cref="DirectLineChannel"/>, <see cref="DirectLineSpeechChannel"/>, <see cref="EmailChannel"/>, <see cref="FacebookChannel"/>, <see cref="KikChannel"/>, <see cref="LineChannel"/>, <see cref="M365Extensions"/>, <see cref="MsTeamsChannel"/>, <see cref="Omnichannel"/>, <see cref="OutlookChannel"/>, <see cref="SearchAssistant"/>, <see cref="SkypeChannel"/>, <see cref="SlackChannel"/>, <see cref="SmsChannel"/>, <see cref="TelegramChannel"/>, <see cref="TelephonyChannel"/> and <see cref="WebChatChannel"/>.
        /// </param>
        /// <param name="setting"> Channel settings. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="entityTag"> Entity tag of the resource. </param>
        /// <param name="changedTime"> Changed time of the resource. </param>
        /// <param name="properties">
        /// The set of properties specific to bot channel resource
        /// Please note <see cref="BotChannelProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AcsChatChannel"/>, <see cref="AlexaChannel"/>, <see cref="DirectLineChannel"/>, <see cref="DirectLineSpeechChannel"/>, <see cref="EmailChannel"/>, <see cref="FacebookChannel"/>, <see cref="KikChannel"/>, <see cref="LineChannel"/>, <see cref="M365Extensions"/>, <see cref="MsTeamsChannel"/>, <see cref="Omnichannel"/>, <see cref="OutlookChannel"/>, <see cref="SearchAssistant"/>, <see cref="SkypeChannel"/>, <see cref="SlackChannel"/>, <see cref="SmsChannel"/>, <see cref="TelegramChannel"/>, <see cref="TelephonyChannel"/> and <see cref="WebChatChannel"/>.
        /// </param>
        /// <param name="sku"> Gets or sets the SKU of the resource. </param>
        /// <param name="kind"> Required. Gets or sets the Kind of the resource. </param>
        /// <param name="etag"> Entity Tag. </param>
        /// <param name="zones"> Entity zones. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BotChannelGetWithKeysResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BotChannelProperties resource, BotChannelSettings setting, string provisioningState, string entityTag, string changedTime, BotChannelProperties properties, BotServiceSku sku, BotServiceKind? kind, ETag? etag, IReadOnlyList<string> zones, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Resource = resource;
            Setting = setting;
            ProvisioningState = provisioningState;
            EntityTag = entityTag;
            ChangedTime = changedTime;
            Properties = properties;
            Sku = sku;
            Kind = kind;
            ETag = etag;
            Zones = zones;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BotChannelGetWithKeysResult"/> for deserialization. </summary>
        internal BotChannelGetWithKeysResult()
        {
        }

        /// <summary>
        /// The set of properties specific to bot channel resource
        /// Please note <see cref="BotChannelProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AcsChatChannel"/>, <see cref="AlexaChannel"/>, <see cref="DirectLineChannel"/>, <see cref="DirectLineSpeechChannel"/>, <see cref="EmailChannel"/>, <see cref="FacebookChannel"/>, <see cref="KikChannel"/>, <see cref="LineChannel"/>, <see cref="M365Extensions"/>, <see cref="MsTeamsChannel"/>, <see cref="Omnichannel"/>, <see cref="OutlookChannel"/>, <see cref="SearchAssistant"/>, <see cref="SkypeChannel"/>, <see cref="SlackChannel"/>, <see cref="SmsChannel"/>, <see cref="TelegramChannel"/>, <see cref="TelephonyChannel"/> and <see cref="WebChatChannel"/>.
        /// </summary>
        public BotChannelProperties Resource { get; set; }
        /// <summary> Channel settings. </summary>
        public BotChannelSettings Setting { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> Entity tag of the resource. </summary>
        public string EntityTag { get; set; }
        /// <summary> Changed time of the resource. </summary>
        public string ChangedTime { get; set; }
        /// <summary>
        /// The set of properties specific to bot channel resource
        /// Please note <see cref="BotChannelProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AcsChatChannel"/>, <see cref="AlexaChannel"/>, <see cref="DirectLineChannel"/>, <see cref="DirectLineSpeechChannel"/>, <see cref="EmailChannel"/>, <see cref="FacebookChannel"/>, <see cref="KikChannel"/>, <see cref="LineChannel"/>, <see cref="M365Extensions"/>, <see cref="MsTeamsChannel"/>, <see cref="Omnichannel"/>, <see cref="OutlookChannel"/>, <see cref="SearchAssistant"/>, <see cref="SkypeChannel"/>, <see cref="SlackChannel"/>, <see cref="SmsChannel"/>, <see cref="TelegramChannel"/>, <see cref="TelephonyChannel"/> and <see cref="WebChatChannel"/>.
        /// </summary>
        public BotChannelProperties Properties { get; set; }
        /// <summary> Gets or sets the SKU of the resource. </summary>
        public BotServiceSku Sku { get; set; }
        /// <summary> Required. Gets or sets the Kind of the resource. </summary>
        public BotServiceKind? Kind { get; set; }
        /// <summary> Entity Tag. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Entity zones. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
