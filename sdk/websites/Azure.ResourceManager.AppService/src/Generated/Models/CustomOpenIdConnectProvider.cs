// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the custom Open ID Connect provider. </summary>
    public partial class CustomOpenIdConnectProvider
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomOpenIdConnectProvider"/>. </summary>
        public CustomOpenIdConnectProvider()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomOpenIdConnectProvider"/>. </summary>
        /// <param name="isEnabled"> &lt;code&gt;false&lt;/code&gt; if the custom Open ID provider provider should not be enabled; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the app registration for the custom Open ID Connect provider. </param>
        /// <param name="login"> The configuration settings of the login flow of the custom Open ID Connect provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomOpenIdConnectProvider(bool? isEnabled, OpenIdConnectRegistration registration, OpenIdConnectLogin login, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Registration = registration;
            Login = login;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the custom Open ID provider provider should not be enabled; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The configuration settings of the app registration for the custom Open ID Connect provider. </summary>
        public OpenIdConnectRegistration Registration { get; set; }
        /// <summary> The configuration settings of the login flow of the custom Open ID Connect provider. </summary>
        public OpenIdConnectLogin Login { get; set; }
    }
}
