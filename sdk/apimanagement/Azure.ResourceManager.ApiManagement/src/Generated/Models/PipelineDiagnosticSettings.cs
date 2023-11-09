// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Diagnostic settings for incoming/outgoing HTTP messages to the Gateway. </summary>
    public partial class PipelineDiagnosticSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PipelineDiagnosticSettings"/>. </summary>
        public PipelineDiagnosticSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PipelineDiagnosticSettings"/>. </summary>
        /// <param name="request"> Diagnostic settings for request. </param>
        /// <param name="response"> Diagnostic settings for response. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PipelineDiagnosticSettings(HttpMessageDiagnostic request, HttpMessageDiagnostic response, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Request = request;
            Response = response;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Diagnostic settings for request. </summary>
        public HttpMessageDiagnostic Request { get; set; }
        /// <summary> Diagnostic settings for response. </summary>
        public HttpMessageDiagnostic Response { get; set; }
    }
}
