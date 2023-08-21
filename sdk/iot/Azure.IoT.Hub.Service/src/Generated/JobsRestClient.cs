// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.IoT.Hub.Service.Models;

namespace Azure.IoT.Hub.Service
{
    internal partial class JobsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of JobsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public JobsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2020-03-13")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://fully-qualified-iothubname.azure-devices.net");
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateCreateImportExportJobRequest(JobProperties jobProperties)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jobs/create", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(jobProperties);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new import or export job on the IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="jobProperties"> The job specifications. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobProperties"/> is null. </exception>
        public async Task<Response<JobProperties>> CreateImportExportJobAsync(JobProperties jobProperties, CancellationToken cancellationToken = default)
        {
            if (jobProperties == null)
            {
                throw new ArgumentNullException(nameof(jobProperties));
            }

            using var message = CreateCreateImportExportJobRequest(jobProperties);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobProperties.DeserializeJobProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new import or export job on the IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="jobProperties"> The job specifications. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobProperties"/> is null. </exception>
        public Response<JobProperties> CreateImportExportJob(JobProperties jobProperties, CancellationToken cancellationToken = default)
        {
            if (jobProperties == null)
            {
                throw new ArgumentNullException(nameof(jobProperties));
            }

            using var message = CreateCreateImportExportJobRequest(jobProperties);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobProperties.DeserializeJobProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetImportExportJobsRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jobs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the status of all import and export jobs in the IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<IReadOnlyList<JobProperties>>> GetImportExportJobsAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetImportExportJobsRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<JobProperties> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<JobProperties> array = new List<JobProperties>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(JobProperties.DeserializeJobProperties(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the status of all import and export jobs in the IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IReadOnlyList<JobProperties>> GetImportExportJobs(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetImportExportJobsRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<JobProperties> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<JobProperties> array = new List<JobProperties>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(JobProperties.DeserializeJobProperties(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetImportExportJobRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the status of an import or export job in the IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response<JobProperties>> GetImportExportJobAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetImportExportJobRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobProperties.DeserializeJobProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the status of an import or export job in the IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response<JobProperties> GetImportExportJob(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetImportExportJobRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobProperties.DeserializeJobProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetScheduledJobRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jobs/v2/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets details of a scheduled job from the IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response<JobResponse>> GetScheduledJobAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetScheduledJobRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobResponse.DeserializeJobResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets details of a scheduled job from the IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response<JobResponse> GetScheduledJob(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetScheduledJobRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobResponse.DeserializeJobResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateScheduledJobRequest(string id, JobRequest jobRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jobs/v2/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(jobRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new job to schedule twin updates or direct methods on the IoT Hub at a scheduled time. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="jobRequest"> The job request info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="jobRequest"/> is null. </exception>
        public async Task<Response<JobResponse>> CreateScheduledJobAsync(string id, JobRequest jobRequest, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (jobRequest == null)
            {
                throw new ArgumentNullException(nameof(jobRequest));
            }

            using var message = CreateCreateScheduledJobRequest(id, jobRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobResponse.DeserializeJobResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new job to schedule twin updates or direct methods on the IoT Hub at a scheduled time. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="jobRequest"> The job request info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="jobRequest"/> is null. </exception>
        public Response<JobResponse> CreateScheduledJob(string id, JobRequest jobRequest, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (jobRequest == null)
            {
                throw new ArgumentNullException(nameof(jobRequest));
            }

            using var message = CreateCreateScheduledJobRequest(id, jobRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobResponse.DeserializeJobResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelScheduledJobRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jobs/v2/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Cancels a scheduled job on the IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response<JobResponse>> CancelScheduledJobAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateCancelScheduledJobRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobResponse.DeserializeJobResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Cancels a scheduled job on the IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response<JobResponse> CancelScheduledJob(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateCancelScheduledJobRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobResponse.DeserializeJobResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateQueryScheduledJobsRequest(string jobType, string jobStatus)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/jobs/v2/query", false);
            if (jobType != null)
            {
                uri.AppendQuery("jobType", jobType, true);
            }
            if (jobStatus != null)
            {
                uri.AppendQuery("jobStatus", jobStatus, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the information about jobs using an IoT Hub query. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language for more information. </summary>
        /// <param name="jobType"> The job type. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs#querying-for-progress-on-jobs for a list of possible job types. </param>
        /// <param name="jobStatus"> The job status. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs#querying-for-progress-on-jobs for a list of possible statuses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<QueryResult>> QueryScheduledJobsAsync(string jobType = null, string jobStatus = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateQueryScheduledJobsRequest(jobType, jobStatus);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueryResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QueryResult.DeserializeQueryResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the information about jobs using an IoT Hub query. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language for more information. </summary>
        /// <param name="jobType"> The job type. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs#querying-for-progress-on-jobs for a list of possible job types. </param>
        /// <param name="jobStatus"> The job status. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs#querying-for-progress-on-jobs for a list of possible statuses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<QueryResult> QueryScheduledJobs(string jobType = null, string jobStatus = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateQueryScheduledJobsRequest(jobType, jobStatus);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueryResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QueryResult.DeserializeQueryResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
