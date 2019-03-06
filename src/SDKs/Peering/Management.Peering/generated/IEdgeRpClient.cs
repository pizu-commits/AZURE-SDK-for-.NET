// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// EdgeRp API
    /// </summary>
    public partial interface IEdgeRpClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The subscription id.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The API version
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IPeeringBgpCommunityListsOperations.
        /// </summary>
        IPeeringBgpCommunityListsOperations PeeringBgpCommunityLists { get; }

        /// <summary>
        /// Gets the IPeeringLocationsOperations.
        /// </summary>
        IPeeringLocationsOperations PeeringLocations { get; }

        /// <summary>
        /// Gets the IPeeringPartnersOperations.
        /// </summary>
        IPeeringPartnersOperations PeeringPartners { get; }

        /// <summary>
        /// Gets the IPeeringPrefixesOperations.
        /// </summary>
        IPeeringPrefixesOperations PeeringPrefixes { get; }

        /// <summary>
        /// Gets the IPrefixesOperations.
        /// </summary>
        IPrefixesOperations Prefixes { get; }

        /// <summary>
        /// Gets the IPeeringsOperations.
        /// </summary>
        IPeeringsOperations Peerings { get; }

        /// <summary>
        /// Gets the IPeeringLegacyPeeringsOperations.
        /// </summary>
        IPeeringLegacyPeeringsOperations PeeringLegacyPeerings { get; }

        /// <summary>
        /// Gets the IPeeringSubscribersOperations.
        /// </summary>
        IPeeringSubscribersOperations PeeringSubscribers { get; }

        /// <summary>
        /// Gets the ISubscribersOperations.
        /// </summary>
        ISubscribersOperations Subscribers { get; }

    }
}
