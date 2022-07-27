// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.PhoneNumbers
{
    internal partial class InternalPhoneNumbersRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of InternalPhoneNumbersRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://resourcename.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public InternalPhoneNumbersRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2022-01-11-preview2")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateSearchAvailablePhoneNumbersRequest(string countryCode, PhoneNumberSearchRequest body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/availablePhoneNumbers/countries/", false);
            uri.AppendPath(countryCode, true);
            uri.AppendPath("/:search", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="countryCode"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="body"> The phone number search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="countryCode"/> or <paramref name="body"/> is null. </exception>
        public async Task<ResponseWithHeaders<PhoneNumbersSearchAvailablePhoneNumbersHeaders>> SearchAvailablePhoneNumbersAsync(string countryCode, PhoneNumberSearchRequest body, CancellationToken cancellationToken = default)
        {
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateSearchAvailablePhoneNumbersRequest(countryCode, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumbersSearchAvailablePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="countryCode"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="body"> The phone number search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="countryCode"/> or <paramref name="body"/> is null. </exception>
        public ResponseWithHeaders<PhoneNumbersSearchAvailablePhoneNumbersHeaders> SearchAvailablePhoneNumbers(string countryCode, PhoneNumberSearchRequest body, CancellationToken cancellationToken = default)
        {
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateSearchAvailablePhoneNumbersRequest(countryCode, body);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumbersSearchAvailablePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSearchResultRequest(string searchId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/availablePhoneNumbers/searchResults/", false);
            uri.AppendPath(searchId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a phone number search result by search id. </summary>
        /// <param name="searchId"> The search Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchId"/> is null. </exception>
        public async Task<Response<PhoneNumberSearchResult>> GetSearchResultAsync(string searchId, CancellationToken cancellationToken = default)
        {
            if (searchId == null)
            {
                throw new ArgumentNullException(nameof(searchId));
            }

            using var message = CreateGetSearchResultRequest(searchId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PhoneNumberSearchResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PhoneNumberSearchResult.DeserializePhoneNumberSearchResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a phone number search result by search id. </summary>
        /// <param name="searchId"> The search Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchId"/> is null. </exception>
        public Response<PhoneNumberSearchResult> GetSearchResult(string searchId, CancellationToken cancellationToken = default)
        {
            if (searchId == null)
            {
                throw new ArgumentNullException(nameof(searchId));
            }

            using var message = CreateGetSearchResultRequest(searchId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PhoneNumberSearchResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PhoneNumberSearchResult.DeserializePhoneNumberSearchResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePurchasePhoneNumbersRequest(string searchId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/availablePhoneNumbers/:purchase", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new PhoneNumberPurchaseRequest()
            {
                SearchId = searchId
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Purchases phone numbers. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<PhoneNumbersPurchasePhoneNumbersHeaders>> PurchasePhoneNumbersAsync(string searchId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePurchasePhoneNumbersRequest(searchId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumbersPurchasePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Purchases phone numbers. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<PhoneNumbersPurchasePhoneNumbersHeaders> PurchasePhoneNumbers(string searchId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePurchasePhoneNumbersRequest(searchId);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumbersPurchasePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetOperationRequest(string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/phoneNumbers/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets an operation by its id. </summary>
        /// <param name="operationId"> The id of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public async Task<ResponseWithHeaders<PhoneNumberOperation, PhoneNumbersGetOperationHeaders>> GetOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetOperationRequest(operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumbersGetOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PhoneNumberOperation value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PhoneNumberOperation.DeserializePhoneNumberOperation(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets an operation by its id. </summary>
        /// <param name="operationId"> The id of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public ResponseWithHeaders<PhoneNumberOperation, PhoneNumbersGetOperationHeaders> GetOperation(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetOperationRequest(operationId);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumbersGetOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PhoneNumberOperation value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PhoneNumberOperation.DeserializePhoneNumberOperation(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelOperationRequest(string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/phoneNumbers/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Cancels an operation by its id. </summary>
        /// <param name="operationId"> The id of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public async Task<Response> CancelOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateCancelOperationRequest(operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Cancels an operation by its id. </summary>
        /// <param name="operationId"> The id of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public Response CancelOperation(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateCancelOperationRequest(operationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateCapabilitiesRequest(string phoneNumber, PhoneNumberCapabilityType? calling, PhoneNumberCapabilityType? sms)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/phoneNumbers/", false);
            uri.AppendPath(phoneNumber, true);
            uri.AppendPath("/capabilities", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            var model = new PhoneNumberCapabilitiesRequest()
            {
                Calling = calling,
                Sms = sms
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Updates the capabilities of a phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B, e.g. +11234567890. </param>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public async Task<ResponseWithHeaders<PhoneNumbersUpdateCapabilitiesHeaders>> UpdateCapabilitiesAsync(string phoneNumber, PhoneNumberCapabilityType? calling = null, PhoneNumberCapabilityType? sms = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateUpdateCapabilitiesRequest(phoneNumber, calling, sms);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumbersUpdateCapabilitiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the capabilities of a phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B, e.g. +11234567890. </param>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public ResponseWithHeaders<PhoneNumbersUpdateCapabilitiesHeaders> UpdateCapabilities(string phoneNumber, PhoneNumberCapabilityType? calling = null, PhoneNumberCapabilityType? sms = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateUpdateCapabilitiesRequest(phoneNumber, calling, sms);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumbersUpdateCapabilitiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetByNumberRequest(string phoneNumber)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/phoneNumbers/", false);
            uri.AppendPath(phoneNumber, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the details of the given purchased phone number. </summary>
        /// <param name="phoneNumber"> The purchased phone number whose details are to be fetched in E.164 format, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public async Task<Response<PurchasedPhoneNumber>> GetByNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateGetByNumberRequest(phoneNumber);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PurchasedPhoneNumber value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PurchasedPhoneNumber.DeserializePurchasedPhoneNumber(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the details of the given purchased phone number. </summary>
        /// <param name="phoneNumber"> The purchased phone number whose details are to be fetched in E.164 format, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public Response<PurchasedPhoneNumber> GetByNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateGetByNumberRequest(phoneNumber);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PurchasedPhoneNumber value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PurchasedPhoneNumber.DeserializePurchasedPhoneNumber(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateReleasePhoneNumberRequest(string phoneNumber)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/phoneNumbers/", false);
            uri.AppendPath(phoneNumber, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Releases a purchased phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be released, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public async Task<ResponseWithHeaders<PhoneNumbersReleasePhoneNumberHeaders>> ReleasePhoneNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateReleasePhoneNumberRequest(phoneNumber);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumbersReleasePhoneNumberHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Releases a purchased phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be released, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public ResponseWithHeaders<PhoneNumbersReleasePhoneNumberHeaders> ReleasePhoneNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateReleasePhoneNumberRequest(phoneNumber);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumbersReleasePhoneNumberHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListPhoneNumbersRequest(int? skip, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/phoneNumbers", false);
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            if (top != null)
            {
                uri.AppendQuery("top", top.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the list of all purchased phone numbers. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<PurchasedPhoneNumbers>> ListPhoneNumbersAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListPhoneNumbersRequest(skip, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PurchasedPhoneNumbers value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PurchasedPhoneNumbers.DeserializePurchasedPhoneNumbers(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of all purchased phone numbers. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PurchasedPhoneNumbers> ListPhoneNumbers(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListPhoneNumbersRequest(skip, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PurchasedPhoneNumbers value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PurchasedPhoneNumbers.DeserializePurchasedPhoneNumbers(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListPhoneNumbersNextPageRequest(string nextLink, int? skip, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendRawNextLink(nextLink, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the list of all purchased phone numbers. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<PurchasedPhoneNumbers>> ListPhoneNumbersNextPageAsync(string nextLink, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListPhoneNumbersNextPageRequest(nextLink, skip, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PurchasedPhoneNumbers value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PurchasedPhoneNumbers.DeserializePurchasedPhoneNumbers(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of all purchased phone numbers. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<PurchasedPhoneNumbers> ListPhoneNumbersNextPage(string nextLink, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListPhoneNumbersNextPageRequest(nextLink, skip, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PurchasedPhoneNumbers value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PurchasedPhoneNumbers.DeserializePurchasedPhoneNumbers(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
