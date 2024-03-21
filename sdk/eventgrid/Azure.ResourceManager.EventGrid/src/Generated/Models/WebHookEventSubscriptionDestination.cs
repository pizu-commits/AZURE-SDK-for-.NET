// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Information about the webhook destination for an event subscription. </summary>
    public partial class WebHookEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary> Initializes a new instance of <see cref="WebHookEventSubscriptionDestination"/>. </summary>
        public WebHookEventSubscriptionDestination()
        {
            DeliveryAttributeMappings = new ChangeTrackingList<DeliveryAttributeMapping>();
            EndpointType = EndpointType.WebHook;
        }

        /// <summary> Initializes a new instance of <see cref="WebHookEventSubscriptionDestination"/>. </summary>
        /// <param name="endpointType"> Type of the endpoint for the event subscription destination. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="endpoint"> The URL that represents the endpoint of the destination of an event subscription. </param>
        /// <param name="baseEndpoint"> The base URL that represents the endpoint of the destination of an event subscription. </param>
        /// <param name="maxEventsPerBatch"> Maximum number of events per batch. </param>
        /// <param name="preferredBatchSizeInKilobytes"> Preferred batch size in Kilobytes. </param>
        /// <param name="azureActiveDirectoryTenantId"> The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests. </param>
        /// <param name="uriOrAzureActiveDirectoryApplicationId"> The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests. </param>
        /// <param name="deliveryAttributeMappings">
        /// Delivery attribute details.
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </param>
        /// <param name="minimumTlsVersionAllowed"> Minimum TLS version that should be supported by webhook endpoint. </param>
        internal WebHookEventSubscriptionDestination(EndpointType endpointType, IDictionary<string, BinaryData> serializedAdditionalRawData, Uri endpoint, Uri baseEndpoint, int? maxEventsPerBatch, int? preferredBatchSizeInKilobytes, Guid? azureActiveDirectoryTenantId, string uriOrAzureActiveDirectoryApplicationId, IList<DeliveryAttributeMapping> deliveryAttributeMappings, TlsVersion? minimumTlsVersionAllowed) : base(endpointType, serializedAdditionalRawData)
        {
            Endpoint = endpoint;
            BaseEndpoint = baseEndpoint;
            MaxEventsPerBatch = maxEventsPerBatch;
            PreferredBatchSizeInKilobytes = preferredBatchSizeInKilobytes;
            AzureActiveDirectoryTenantId = azureActiveDirectoryTenantId;
            UriOrAzureActiveDirectoryApplicationId = uriOrAzureActiveDirectoryApplicationId;
            DeliveryAttributeMappings = deliveryAttributeMappings;
            MinimumTlsVersionAllowed = minimumTlsVersionAllowed;
            EndpointType = endpointType;
        }

        /// <summary> The URL that represents the endpoint of the destination of an event subscription. </summary>
        public Uri Endpoint { get; set; }
        /// <summary> The base URL that represents the endpoint of the destination of an event subscription. </summary>
        public Uri BaseEndpoint { get; }
        /// <summary> Maximum number of events per batch. </summary>
        public int? MaxEventsPerBatch { get; set; }
        /// <summary> Preferred batch size in Kilobytes. </summary>
        public int? PreferredBatchSizeInKilobytes { get; set; }
        /// <summary> The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests. </summary>
        public Guid? AzureActiveDirectoryTenantId { get; set; }
        /// <summary> The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests. </summary>
        public string UriOrAzureActiveDirectoryApplicationId { get; set; }
        /// <summary>
        /// Delivery attribute details.
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </summary>
        public IList<DeliveryAttributeMapping> DeliveryAttributeMappings { get; }
        /// <summary> Minimum TLS version that should be supported by webhook endpoint. </summary>
        public TlsVersion? MinimumTlsVersionAllowed { get; set; }
    }
}
