// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Queues.Models;

namespace Azure.Storage.Queues
{
    internal partial class MessageIdRestClient
    {
        private string url;
        private Enum2 version;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of MessageIdRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> The URL of the service account, queue or message that is the target of the desired operation. </param>
        /// <param name="version"> Specifies the version of the operation to use for this request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public MessageIdRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url, Enum2 version)
        {
            this.url = url ?? throw new ArgumentNullException(nameof(url));
            this.version = version;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateUpdateRequest(string messageid, string popReceipt, int visibilitytimeout, int? timeout, QueueMessage queueMessage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/messages/", false);
            uri.AppendPath(messageid, true);
            uri.AppendQuery("popreceipt", popReceipt, true);
            uri.AppendQuery("visibilitytimeout", visibilitytimeout, true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version.ToString());
            request.Headers.Add("Accept", "application/xml");
            if (queueMessage != null)
            {
                request.Headers.Add("Content-Type", "application/xml");
                var content = new XmlWriterContent();
                content.XmlWriter.WriteObjectValue(queueMessage, "QueueMessage");
                request.Content = content;
            }
            return message;
        }

        /// <summary> The Update operation was introduced with version 2011-08-18 of the Queue service API. The Update Message operation updates the visibility timeout of a message. You can also use this operation to update the contents of a message. A message must be in a format that can be included in an XML request with UTF-8 encoding, and the encoded message can be up to 64KB in size. </summary>
        /// <param name="messageid"> The container name. </param>
        /// <param name="popReceipt"> Required. Specifies the valid pop receipt value returned from an earlier call to the Get Messages or Update Message operation. </param>
        /// <param name="visibilitytimeout"> Optional. Specifies the new visibility timeout value, in seconds, relative to server time. The default value is 30 seconds. A specified value must be larger than or equal to 1 second, and cannot be larger than 7 days, or larger than 2 hours on REST protocol versions prior to version 2011-08-18. The visibility timeout of a message can be set to a value later than the expiry time. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="queueMessage"> A Message object which can be stored in a Queue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageid"/> or <paramref name="popReceipt"/> is null. </exception>
        public async Task<ResponseWithHeaders<MessageIdUpdateHeaders>> UpdateAsync(string messageid, string popReceipt, int visibilitytimeout, int? timeout = null, QueueMessage queueMessage = null, CancellationToken cancellationToken = default)
        {
            if (messageid == null)
            {
                throw new ArgumentNullException(nameof(messageid));
            }
            if (popReceipt == null)
            {
                throw new ArgumentNullException(nameof(popReceipt));
            }

            using var message = CreateUpdateRequest(messageid, popReceipt, visibilitytimeout, timeout, queueMessage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new MessageIdUpdateHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The Update operation was introduced with version 2011-08-18 of the Queue service API. The Update Message operation updates the visibility timeout of a message. You can also use this operation to update the contents of a message. A message must be in a format that can be included in an XML request with UTF-8 encoding, and the encoded message can be up to 64KB in size. </summary>
        /// <param name="messageid"> The container name. </param>
        /// <param name="popReceipt"> Required. Specifies the valid pop receipt value returned from an earlier call to the Get Messages or Update Message operation. </param>
        /// <param name="visibilitytimeout"> Optional. Specifies the new visibility timeout value, in seconds, relative to server time. The default value is 30 seconds. A specified value must be larger than or equal to 1 second, and cannot be larger than 7 days, or larger than 2 hours on REST protocol versions prior to version 2011-08-18. The visibility timeout of a message can be set to a value later than the expiry time. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="queueMessage"> A Message object which can be stored in a Queue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageid"/> or <paramref name="popReceipt"/> is null. </exception>
        public ResponseWithHeaders<MessageIdUpdateHeaders> Update(string messageid, string popReceipt, int visibilitytimeout, int? timeout = null, QueueMessage queueMessage = null, CancellationToken cancellationToken = default)
        {
            if (messageid == null)
            {
                throw new ArgumentNullException(nameof(messageid));
            }
            if (popReceipt == null)
            {
                throw new ArgumentNullException(nameof(popReceipt));
            }

            using var message = CreateUpdateRequest(messageid, popReceipt, visibilitytimeout, timeout, queueMessage);
            _pipeline.Send(message, cancellationToken);
            var headers = new MessageIdUpdateHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string messageid, string popReceipt, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/messages/", false);
            uri.AppendPath(messageid, true);
            uri.AppendQuery("popreceipt", popReceipt, true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version.ToString());
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> The Delete operation deletes the specified message. </summary>
        /// <param name="messageid"> The container name. </param>
        /// <param name="popReceipt"> Required. Specifies the valid pop receipt value returned from an earlier call to the Get Messages or Update Message operation. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageid"/> or <paramref name="popReceipt"/> is null. </exception>
        public async Task<ResponseWithHeaders<MessageIdDeleteHeaders>> DeleteAsync(string messageid, string popReceipt, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (messageid == null)
            {
                throw new ArgumentNullException(nameof(messageid));
            }
            if (popReceipt == null)
            {
                throw new ArgumentNullException(nameof(popReceipt));
            }

            using var message = CreateDeleteRequest(messageid, popReceipt, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new MessageIdDeleteHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The Delete operation deletes the specified message. </summary>
        /// <param name="messageid"> The container name. </param>
        /// <param name="popReceipt"> Required. Specifies the valid pop receipt value returned from an earlier call to the Get Messages or Update Message operation. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageid"/> or <paramref name="popReceipt"/> is null. </exception>
        public ResponseWithHeaders<MessageIdDeleteHeaders> Delete(string messageid, string popReceipt, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (messageid == null)
            {
                throw new ArgumentNullException(nameof(messageid));
            }
            if (popReceipt == null)
            {
                throw new ArgumentNullException(nameof(popReceipt));
            }

            using var message = CreateDeleteRequest(messageid, popReceipt, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new MessageIdDeleteHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
