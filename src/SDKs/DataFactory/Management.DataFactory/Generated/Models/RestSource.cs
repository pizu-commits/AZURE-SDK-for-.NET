// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity Rest service source.
    /// </summary>
    public partial class RestSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the RestSource class.
        /// </summary>
        public RestSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="httpRequestTimeout">The timeout (TimeSpan) to get an
        /// HTTP response. It is the timeout to get a response, not the timeout
        /// to read response data. Default value: 00:01:40. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="requestInterval">The time to await before sending next
        /// page request. </param>
        public RestSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object httpRequestTimeout = default(object), object requestInterval = default(object))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait)
        {
            HttpRequestTimeout = httpRequestTimeout;
            RequestInterval = requestInterval;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the timeout (TimeSpan) to get an HTTP response. It is
        /// the timeout to get a response, not the timeout to read response
        /// data. Default value: 00:01:40. Type: string (or Expression with
        /// resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "httpRequestTimeout")]
        public object HttpRequestTimeout { get; set; }

        /// <summary>
        /// Gets or sets the time to await before sending next page request.
        /// </summary>
        [JsonProperty(PropertyName = "requestInterval")]
        public object RequestInterval { get; set; }

    }
}
