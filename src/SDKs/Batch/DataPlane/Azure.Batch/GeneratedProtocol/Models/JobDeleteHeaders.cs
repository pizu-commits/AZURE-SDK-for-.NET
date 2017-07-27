// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for Delete operation.
    /// </summary>
    public partial class JobDeleteHeaders
    {
        /// <summary>
        /// Initializes a new instance of the JobDeleteHeaders class.
        /// </summary>
        public JobDeleteHeaders() { }

        /// <summary>
        /// Initializes a new instance of the JobDeleteHeaders class.
        /// </summary>
        /// <param name="clientRequestId">The client-request-id provided by the
        /// client during the request. This will be returned only if the
        /// return-client-request-id parameter was set to true.</param>
        /// <param name="requestId">A unique identifier for the request that
        /// was made to the Batch service. If a request is consistently failing
        /// and you have verified that the request is properly formulated, you
        /// may use this value to report the error to Microsoft. In your
        /// report, include the value of this request ID, the approximate time
        /// that the request was made, the Batch account against which the
        /// request was made, and the region that account resides in.</param>
        public JobDeleteHeaders(string clientRequestId = default(string), string requestId = default(string))
        {
            this.ClientRequestId = clientRequestId;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Gets or sets the client-request-id provided by the client during
        /// the request. This will be returned only if the
        /// return-client-request-id parameter was set to true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "client-request-id")]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets a unique identifier for the request that was made to
        /// the Batch service. If a request is consistently failing and you
        /// have verified that the request is properly formulated, you may use
        /// this value to report the error to Microsoft. In your report,
        /// include the value of this request ID, the approximate time that the
        /// request was made, the Batch account against which the request was
        /// made, and the region that account resides in.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "request-id")]
        public string RequestId { get; set; }

    }
}
