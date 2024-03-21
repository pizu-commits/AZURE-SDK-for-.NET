// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Specifies the properties for connecting to a user-defined vectorizer. </summary>
    public partial class CustomWebApiParameters
    {
        /// <summary> Initializes a new instance of <see cref="CustomWebApiParameters"/>. </summary>
        public CustomWebApiParameters()
        {
            HttpHeaders = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomWebApiParameters"/>. </summary>
        /// <param name="uri"> The URI of the Web API providing the vectorizer. </param>
        /// <param name="httpHeaders"> The headers required to make the HTTP request. </param>
        /// <param name="httpMethod"> The method for the HTTP request. </param>
        /// <param name="timeout"> The desired timeout for the request. Default is 30 seconds. </param>
        /// <param name="authResourceId"> Applies to custom endpoints that connect to external code in an Azure function or some other application that provides the transformations. This value should be the application ID created for the function or app when it was registered with Azure Active Directory. When specified, the vectorization connects to the function or app using a managed ID (either system or user-assigned) of the search service and the access token of the function or app, using this value as the resource id for creating the scope of the access token. </param>
        /// <param name="authIdentity">
        /// The user-assigned managed identity used for outbound connections. If an authResourceId is provided and it's not specified, the system-assigned managed identity is used. On updates to the indexer, if the identity is unspecified, the value remains unchanged. If set to "none", the value of this property is cleared.
        /// Please note <see cref="SearchIndexerDataIdentity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SearchIndexerDataNoneIdentity"/> and <see cref="SearchIndexerDataUserAssignedIdentity"/>.
        /// </param>
        internal CustomWebApiParameters(Uri uri, IDictionary<string, string> httpHeaders, string httpMethod, TimeSpan? timeout, string authResourceId, SearchIndexerDataIdentity authIdentity)
        {
            Uri = uri;
            HttpHeaders = httpHeaders;
            HttpMethod = httpMethod;
            Timeout = timeout;
            AuthResourceId = authResourceId;
            AuthIdentity = authIdentity;
        }

        /// <summary> The URI of the Web API providing the vectorizer. </summary>
        public Uri Uri { get; set; }
        /// <summary> The headers required to make the HTTP request. </summary>
        public IDictionary<string, string> HttpHeaders { get; }
        /// <summary> The method for the HTTP request. </summary>
        public string HttpMethod { get; set; }
        /// <summary> The desired timeout for the request. Default is 30 seconds. </summary>
        public TimeSpan? Timeout { get; set; }
        /// <summary> Applies to custom endpoints that connect to external code in an Azure function or some other application that provides the transformations. This value should be the application ID created for the function or app when it was registered with Azure Active Directory. When specified, the vectorization connects to the function or app using a managed ID (either system or user-assigned) of the search service and the access token of the function or app, using this value as the resource id for creating the scope of the access token. </summary>
        public string AuthResourceId { get; set; }
        /// <summary>
        /// The user-assigned managed identity used for outbound connections. If an authResourceId is provided and it's not specified, the system-assigned managed identity is used. On updates to the indexer, if the identity is unspecified, the value remains unchanged. If set to "none", the value of this property is cleared.
        /// Please note <see cref="SearchIndexerDataIdentity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SearchIndexerDataNoneIdentity"/> and <see cref="SearchIndexerDataUserAssignedIdentity"/>.
        /// </summary>
        public SearchIndexerDataIdentity AuthIdentity { get; set; }
    }
}
