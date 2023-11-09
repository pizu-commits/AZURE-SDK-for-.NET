// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Sms channel. </summary>
    public partial class SmsChannelProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SmsChannelProperties"/>. </summary>
        /// <param name="phone"> The Sms phone. </param>
        /// <param name="accountSID"> The Sms account SID. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phone"/> or <paramref name="accountSID"/> is null. </exception>
        public SmsChannelProperties(string phone, string accountSID, bool isEnabled)
        {
            Argument.AssertNotNull(phone, nameof(phone));
            Argument.AssertNotNull(accountSID, nameof(accountSID));

            Phone = phone;
            AccountSID = accountSID;
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of <see cref="SmsChannelProperties"/>. </summary>
        /// <param name="phone"> The Sms phone. </param>
        /// <param name="accountSID"> The Sms account SID. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="authToken"> The Sms auth token. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="isValidated"> Whether this channel is validated for the bot. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SmsChannelProperties(string phone, string accountSID, string authToken, bool? isValidated, bool isEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Phone = phone;
            AccountSID = accountSID;
            AuthToken = authToken;
            IsValidated = isValidated;
            IsEnabled = isEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SmsChannelProperties"/> for deserialization. </summary>
        internal SmsChannelProperties()
        {
        }

        /// <summary> The Sms phone. </summary>
        public string Phone { get; set; }
        /// <summary> The Sms account SID. Value only returned through POST to the action Channel List API, otherwise empty. </summary>
        public string AccountSID { get; set; }
        /// <summary> The Sms auth token. Value only returned through POST to the action Channel List API, otherwise empty. </summary>
        public string AuthToken { get; set; }
        /// <summary> Whether this channel is validated for the bot. </summary>
        public bool? IsValidated { get; set; }
        /// <summary> Whether this channel is enabled for the bot. </summary>
        public bool IsEnabled { get; set; }
    }
}
