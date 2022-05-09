// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The API error. </summary>
    internal partial class ExceptionResponse
    {
        /// <summary> Initializes a new instance of ExceptionResponse. </summary>
        internal ExceptionResponse()
        {
        }

        /// <summary> Initializes a new instance of ExceptionResponse. </summary>
        /// <param name="error"> The API error details. </param>
        internal ExceptionResponse(ServiceError error)
        {
            Error = error;
        }

        /// <summary> The API error details. </summary>
        public ServiceError Error { get; }
    }
}
