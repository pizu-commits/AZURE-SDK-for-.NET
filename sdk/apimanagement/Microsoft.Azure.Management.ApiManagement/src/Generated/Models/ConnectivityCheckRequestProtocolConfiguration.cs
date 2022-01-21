// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Protocol-specific configuration.
    /// </summary>
    public partial class ConnectivityCheckRequestProtocolConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectivityCheckRequestProtocolConfiguration class.
        /// </summary>
        public ConnectivityCheckRequestProtocolConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectivityCheckRequestProtocolConfiguration class.
        /// </summary>
        /// <param name="hTTPConfiguration">Configuration for HTTP or HTTPS
        /// requests.</param>
        public ConnectivityCheckRequestProtocolConfiguration(ConnectivityCheckRequestProtocolConfigurationHTTPConfiguration hTTPConfiguration = default(ConnectivityCheckRequestProtocolConfigurationHTTPConfiguration))
        {
            HTTPConfiguration = hTTPConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets configuration for HTTP or HTTPS requests.
        /// </summary>
        [JsonProperty(PropertyName = "HTTPConfiguration")]
        public ConnectivityCheckRequestProtocolConfigurationHTTPConfiguration HTTPConfiguration { get; set; }

    }
}
