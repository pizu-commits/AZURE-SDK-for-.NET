// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> App Service error response. </summary>
    internal partial class DefaultErrorResponse
    {
        /// <summary> Initializes a new instance of DefaultErrorResponse. </summary>
        internal DefaultErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of DefaultErrorResponse. </summary>
        /// <param name="error"> Error model. </param>
        internal DefaultErrorResponse(DefaultErrorResponseError error)
        {
            Error = error;
        }

        /// <summary> Error model. </summary>
        public DefaultErrorResponseError Error { get; }
    }
}
