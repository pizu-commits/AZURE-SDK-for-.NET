// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.ServiceBus;
using Microsoft.WindowsAzure.Management.ServiceBus.Models;

namespace Microsoft.WindowsAzure.Management.ServiceBus
{
    /// <summary>
    /// The Service Bus Management API includes operations for managing Service
    /// Bus relays.
    /// </summary>
    internal partial class RelayOperations : IServiceOperations<ServiceBusManagementClient>, Microsoft.WindowsAzure.Management.ServiceBus.IRelayOperations
    {
        /// <summary>
        /// Initializes a new instance of the RelayOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal RelayOperations(ServiceBusManagementClient client)
        {
            this._client = client;
        }
        
        private ServiceBusManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.ServiceBus.ServiceBusManagementClient.
        /// </summary>
        public ServiceBusManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Gets the set of connection strings for a relay.
        /// </summary>
        /// <param name='namespaceName'>
        /// Required. The namespace name.
        /// </param>
        /// <param name='relayName'>
        /// Required. The relay name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The set of connection details for a service bus entity.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.ServiceBus.Models.ServiceBusConnectionDetailsResponse> GetConnectionDetailsAsync(string namespaceName, string relayName, CancellationToken cancellationToken)
        {
            // Validate
            if (namespaceName == null)
            {
                throw new ArgumentNullException("namespaceName");
            }
            if (relayName == null)
            {
                throw new ArgumentNullException("relayName");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("namespaceName", namespaceName);
                tracingParameters.Add("relayName", relayName);
                Tracing.Enter(invocationId, this, "GetConnectionDetailsAsync", tracingParameters);
            }
            
            // Construct URL
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/services/servicebus/namespaces/" + namespaceName.Trim() + "/Relays/" + relayName.Trim() + "/ConnectionDetails";
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2013-08-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Xml);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ServiceBusConnectionDetailsResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new ServiceBusConnectionDetailsResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement feedElement = responseDoc.Element(XName.Get("feed", "http://www.w3.org/2005/Atom"));
                    if (feedElement != null)
                    {
                        if (feedElement != null)
                        {
                            foreach (XElement entriesElement in feedElement.Elements(XName.Get("entry", "http://www.w3.org/2005/Atom")))
                            {
                                ServiceBusConnectionDetail entryInstance = new ServiceBusConnectionDetail();
                                result.ConnectionDetails.Add(entryInstance);
                                
                                XElement contentElement = entriesElement.Element(XName.Get("content", "http://www.w3.org/2005/Atom"));
                                if (contentElement != null)
                                {
                                    XElement connectionDetailElement = contentElement.Element(XName.Get("ConnectionDetail", "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"));
                                    if (connectionDetailElement != null)
                                    {
                                        XElement keyNameElement = connectionDetailElement.Element(XName.Get("KeyName", "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"));
                                        if (keyNameElement != null)
                                        {
                                            string keyNameInstance = keyNameElement.Value;
                                            entryInstance.KeyName = keyNameInstance;
                                        }
                                        
                                        XElement connectionStringElement = connectionDetailElement.Element(XName.Get("ConnectionString", "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"));
                                        if (connectionStringElement != null)
                                        {
                                            string connectionStringInstance = connectionStringElement.Value;
                                            entryInstance.ConnectionString = connectionStringInstance;
                                        }
                                        
                                        XElement authorizationTypeElement = connectionDetailElement.Element(XName.Get("AuthorizationType", "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"));
                                        if (authorizationTypeElement != null)
                                        {
                                            string authorizationTypeInstance = authorizationTypeElement.Value;
                                            entryInstance.AuthorizationType = authorizationTypeInstance;
                                        }
                                        
                                        XElement rightsSequenceElement = connectionDetailElement.Element(XName.Get("Rights", "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"));
                                        if (rightsSequenceElement != null)
                                        {
                                            foreach (XElement rightsElement in rightsSequenceElement.Elements(XName.Get("AccessRights", "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect")))
                                            {
                                                entryInstance.Rights.Add(((AccessRight)Enum.Parse(typeof(AccessRight), rightsElement.Value, true)));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
