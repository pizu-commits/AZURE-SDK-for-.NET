// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Authorization.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _classicAdministratorsClientDiagnostics;
        private ClassicAdministratorsRestOperations _classicAdministratorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ClassicAdministratorsClientDiagnostics => _classicAdministratorsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Authorization", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ClassicAdministratorsRestOperations ClassicAdministratorsRestClient => _classicAdministratorsRestClient ??= new ClassicAdministratorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets service administrator, account administrator, and co-administrators for the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/classicAdministrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClassicAdministrators_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AuthorizationClassicAdministrator" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AuthorizationClassicAdministrator> GetClassicAdministratorsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClassicAdministratorsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ClassicAdministratorsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, AuthorizationClassicAdministrator.DeserializeAuthorizationClassicAdministrator, ClassicAdministratorsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClassicAdministrators", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets service administrator, account administrator, and co-administrators for the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/classicAdministrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClassicAdministrators_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AuthorizationClassicAdministrator" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AuthorizationClassicAdministrator> GetClassicAdministrators(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClassicAdministratorsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ClassicAdministratorsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, AuthorizationClassicAdministrator.DeserializeAuthorizationClassicAdministrator, ClassicAdministratorsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClassicAdministrators", "value", "nextLink", cancellationToken);
        }
    }
}
