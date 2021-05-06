// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Cross-Origin Resource Sharing (CORS) settings for the app. </summary>
    public partial class CorsSettings
    {
        /// <summary> Initializes a new instance of CorsSettings. </summary>
        public CorsSettings()
        {
            AllowedOrigins = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CorsSettings. </summary>
        /// <param name="allowedOrigins">
        /// Gets or sets the list of origins that should be allowed to make cross-origin
        /// calls (for example: http://example.com:12345). Use &quot;*&quot; to allow all.
        /// </param>
        /// <param name="supportCredentials">
        /// Gets or sets whether CORS requests with credentials are allowed. See
        /// https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS#Requests_with_credentials
        /// for more details.
        /// </param>
        internal CorsSettings(IList<string> allowedOrigins, bool? supportCredentials)
        {
            AllowedOrigins = allowedOrigins;
            SupportCredentials = supportCredentials;
        }

        /// <summary>
        /// Gets or sets the list of origins that should be allowed to make cross-origin
        /// calls (for example: http://example.com:12345). Use &quot;*&quot; to allow all.
        /// </summary>
        public IList<string> AllowedOrigins { get; }
        /// <summary>
        /// Gets or sets whether CORS requests with credentials are allowed. See
        /// https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS#Requests_with_credentials
        /// for more details.
        /// </summary>
        public bool? SupportCredentials { get; set; }
    }
}
