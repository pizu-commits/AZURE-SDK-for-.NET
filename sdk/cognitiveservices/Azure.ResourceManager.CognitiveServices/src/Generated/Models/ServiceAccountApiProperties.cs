// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The api properties for special APIs. </summary>
    public partial class ServiceAccountApiProperties
    {
        /// <summary> Initializes a new instance of ServiceAccountApiProperties. </summary>
        public ServiceAccountApiProperties()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of ServiceAccountApiProperties. </summary>
        /// <param name="qnaRuntimeEndpoint"> (QnAMaker Only) The runtime endpoint of QnAMaker. </param>
        /// <param name="qnaAzureSearchEndpointKey"> (QnAMaker Only) The Azure Search endpoint key of QnAMaker. </param>
        /// <param name="qnaAzureSearchEndpointId"> (QnAMaker Only) The Azure Search endpoint id of QnAMaker. </param>
        /// <param name="enableStatistics"> (Bing Search Only) The flag to enable statistics of Bing Search. </param>
        /// <param name="eventHubConnectionString"> (Personalization Only) The flag to enable statistics of Bing Search. </param>
        /// <param name="storageAccountConnectionString"> (Personalization Only) The storage account connection string. </param>
        /// <param name="aadClientId"> (Metrics Advisor Only) The Azure AD Client Id (Application Id). </param>
        /// <param name="aadTenantId"> (Metrics Advisor Only) The Azure AD Tenant Id. </param>
        /// <param name="superUser"> (Metrics Advisor Only) The super user of Metrics Advisor. </param>
        /// <param name="websiteName"> (Metrics Advisor Only) The website name of Metrics Advisor. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ServiceAccountApiProperties(string qnaRuntimeEndpoint, string qnaAzureSearchEndpointKey, ResourceIdentifier qnaAzureSearchEndpointId, bool? enableStatistics, string eventHubConnectionString, string storageAccountConnectionString, Guid? aadClientId, Guid? aadTenantId, string superUser, string websiteName, IDictionary<string, BinaryData> additionalProperties)
        {
            QnaRuntimeEndpoint = qnaRuntimeEndpoint;
            QnaAzureSearchEndpointKey = qnaAzureSearchEndpointKey;
            QnaAzureSearchEndpointId = qnaAzureSearchEndpointId;
            EnableStatistics = enableStatistics;
            EventHubConnectionString = eventHubConnectionString;
            StorageAccountConnectionString = storageAccountConnectionString;
            AadClientId = aadClientId;
            AadTenantId = aadTenantId;
            SuperUser = superUser;
            WebsiteName = websiteName;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> (QnAMaker Only) The runtime endpoint of QnAMaker. </summary>
        public string QnaRuntimeEndpoint { get; set; }
        /// <summary> (QnAMaker Only) The Azure Search endpoint key of QnAMaker. </summary>
        public string QnaAzureSearchEndpointKey { get; set; }
        /// <summary> (QnAMaker Only) The Azure Search endpoint id of QnAMaker. </summary>
        public ResourceIdentifier QnaAzureSearchEndpointId { get; set; }
        /// <summary> (Bing Search Only) The flag to enable statistics of Bing Search. </summary>
        public bool? EnableStatistics { get; set; }
        /// <summary> (Personalization Only) The flag to enable statistics of Bing Search. </summary>
        public string EventHubConnectionString { get; set; }
        /// <summary> (Personalization Only) The storage account connection string. </summary>
        public string StorageAccountConnectionString { get; set; }
        /// <summary> (Metrics Advisor Only) The Azure AD Client Id (Application Id). </summary>
        public Guid? AadClientId { get; set; }
        /// <summary> (Metrics Advisor Only) The Azure AD Tenant Id. </summary>
        public Guid? AadTenantId { get; set; }
        /// <summary> (Metrics Advisor Only) The super user of Metrics Advisor. </summary>
        public string SuperUser { get; set; }
        /// <summary> (Metrics Advisor Only) The website name of Metrics Advisor. </summary>
        public string WebsiteName { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
