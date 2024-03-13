﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents.Framework
{
    /// <summary>The base class for all typed event requests and its related response and data model.</summary>
    /// <typeparam name="TResponse">The EventResponse related to the request.</typeparam>
    /// <typeparam name="TData">The EventData model related to the request.</typeparam>
    /// <seealso cref="AuthenticationEventResponse" />
    /// <seealso cref="AuthenticationEventData" />
    public abstract class AuthenticationEventRequest<TResponse, TData> : AuthenticationEventRequestBase
        where TResponse : AuthenticationEventResponse , new()
        where TData : AuthenticationEventData
    {
        /// <summary>Initializes a new instance of the <see cref="AuthenticationEventRequest{T, K}" /> class.</summary>
        /// <param name="request">The request.</param>
        internal AuthenticationEventRequest(HttpRequestMessage request) : base(request) { }
        /// <summary>Gets or sets the related EventResponse object.</summary>
        /// <value>The response.</value>
        ///
        [JsonPropertyName("response")]
        public TResponse Response { get; set; }

        /// <summary>Gets or sets the related EventData model.</summary>
        /// <value>The Json payload.</value>
        ///
        [JsonPropertyName("data")]
        [Required]
        public TData Data { get; set; }

        /// <summary>Validates the response and creates the IActionResult with the json payload based on the status of the request.</summary>
        /// <returns>IActionResult based on the EventStatus (UnauthorizedResult, BadRequestObjectResult or JsonResult).</returns>
        public async override Task<AuthenticationEventResponse> Completed()
        {
            try
            {
                if (RequestStatus == RequestStatusType.Failed || RequestStatus == RequestStatusType.ValidationError)
                {
                    return await Failed(new AuthenticationEventTriggerRequestValidationException(string.IsNullOrEmpty(StatusMessage) ? AuthenticationEventResource.Ex_Gen_Failure : StatusMessage)).ConfigureAwait(false);
                }
                else if (RequestStatus == RequestStatusType.TokenInvalid)
                {
                    Unauthorized();
                }
            }
            catch (Exception ex)
            {
                return await Failed(new AuthenticationEventTriggerRequestValidationException(ex.Message)).ConfigureAwait(false);
            }

            return Response;
        }

        /// <summary>
        /// Sets the response statuscode, reason phrase and body when we want to return failed.
        /// </summary>
        /// <param name="exception">The exception that is thrown</param>
        /// <returns>An authenticationeventresponse task</returns>
        public override Task<AuthenticationEventResponse> Failed(Exception exception)
        {
            if (Response == null)
            {
                Response = new TResponse();
            }

            Response.StatusCode = exception is AuthenticationEventTriggerValidationException ex ?
                ex.ExceptionStatusCode
                : System.Net.HttpStatusCode.InternalServerError;
            Response.ReasonPhrase = exception is AuthenticationEventTriggerValidationException authEx ?
                authEx.ReasonPhrase : "Internal Server Error";
            Response.Body = Helpers.GetFailedResponsePayload(exception);

            return Task.FromResult<AuthenticationEventResponse>(Response);
        }

        /// <summary>
        /// Sets the response statuscode to unauthorized and the reasonphrase and body to empty.
        /// </summary>
        private void Unauthorized()
        {
            // Set response as unauthorized when token is invalid
            Response.StatusCode = System.Net.HttpStatusCode.Unauthorized;
            Response.ReasonPhrase = "Unauthorized";
            Response.Body = string.Empty;
        }
    }
}