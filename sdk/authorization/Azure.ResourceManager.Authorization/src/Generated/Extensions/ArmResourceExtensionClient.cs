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
    /// <summary> A class to add extension methods to ArmResource. </summary>
    internal partial class ArmResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _eligibleChildResourcesClientDiagnostics;
        private EligibleChildResourcesRestOperations _eligibleChildResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ArmResourceExtensionClient"/> class for mocking. </summary>
        protected ArmResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArmResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ArmResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics EligibleChildResourcesClientDiagnostics => _eligibleChildResourcesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Authorization", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private EligibleChildResourcesRestOperations EligibleChildResourcesRestClient => _eligibleChildResourcesRestClient ??= new EligibleChildResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DenyAssignmentResources in the ArmResource. </summary>
        /// <returns> An object representing collection of DenyAssignmentResources and their operations over a DenyAssignmentResource. </returns>
        public virtual DenyAssignmentCollection GetDenyAssignments()
        {
            return GetCachedClient(Client => new DenyAssignmentCollection(Client, Id));
        }

        /// <summary> Gets a collection of RoleAssignmentResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleAssignmentResources and their operations over a RoleAssignmentResource. </returns>
        public virtual RoleAssignmentCollection GetRoleAssignments()
        {
            return GetCachedClient(Client => new RoleAssignmentCollection(Client, Id));
        }

        /// <summary> Gets a collection of AuthorizationRoleDefinitionResources in the ArmResource. </summary>
        /// <returns> An object representing collection of AuthorizationRoleDefinitionResources and their operations over a AuthorizationRoleDefinitionResource. </returns>
        public virtual AuthorizationRoleDefinitionCollection GetAuthorizationRoleDefinitions()
        {
            return GetCachedClient(Client => new AuthorizationRoleDefinitionCollection(Client, Id));
        }

        /// <summary> Gets a collection of RoleAssignmentScheduleResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleAssignmentScheduleResources and their operations over a RoleAssignmentScheduleResource. </returns>
        public virtual RoleAssignmentScheduleCollection GetRoleAssignmentSchedules()
        {
            return GetCachedClient(Client => new RoleAssignmentScheduleCollection(Client, Id));
        }

        /// <summary> Gets a collection of RoleAssignmentScheduleInstanceResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleAssignmentScheduleInstanceResources and their operations over a RoleAssignmentScheduleInstanceResource. </returns>
        public virtual RoleAssignmentScheduleInstanceCollection GetRoleAssignmentScheduleInstances()
        {
            return GetCachedClient(Client => new RoleAssignmentScheduleInstanceCollection(Client, Id));
        }

        /// <summary> Gets a collection of RoleAssignmentScheduleRequestResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleAssignmentScheduleRequestResources and their operations over a RoleAssignmentScheduleRequestResource. </returns>
        public virtual RoleAssignmentScheduleRequestCollection GetRoleAssignmentScheduleRequests()
        {
            return GetCachedClient(Client => new RoleAssignmentScheduleRequestCollection(Client, Id));
        }

        /// <summary> Gets a collection of RoleEligibilityScheduleResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleEligibilityScheduleResources and their operations over a RoleEligibilityScheduleResource. </returns>
        public virtual RoleEligibilityScheduleCollection GetRoleEligibilitySchedules()
        {
            return GetCachedClient(Client => new RoleEligibilityScheduleCollection(Client, Id));
        }

        /// <summary> Gets a collection of RoleEligibilityScheduleInstanceResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleEligibilityScheduleInstanceResources and their operations over a RoleEligibilityScheduleInstanceResource. </returns>
        public virtual RoleEligibilityScheduleInstanceCollection GetRoleEligibilityScheduleInstances()
        {
            return GetCachedClient(Client => new RoleEligibilityScheduleInstanceCollection(Client, Id));
        }

        /// <summary> Gets a collection of RoleEligibilityScheduleRequestResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleEligibilityScheduleRequestResources and their operations over a RoleEligibilityScheduleRequestResource. </returns>
        public virtual RoleEligibilityScheduleRequestCollection GetRoleEligibilityScheduleRequests()
        {
            return GetCachedClient(Client => new RoleEligibilityScheduleRequestCollection(Client, Id));
        }

        /// <summary> Gets a collection of RoleManagementPolicyResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleManagementPolicyResources and their operations over a RoleManagementPolicyResource. </returns>
        public virtual RoleManagementPolicyCollection GetRoleManagementPolicies()
        {
            return GetCachedClient(Client => new RoleManagementPolicyCollection(Client, Id));
        }

        /// <summary> Gets a collection of RoleManagementPolicyAssignmentResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleManagementPolicyAssignmentResources and their operations over a RoleManagementPolicyAssignmentResource. </returns>
        public virtual RoleManagementPolicyAssignmentCollection GetRoleManagementPolicyAssignments()
        {
            return GetCachedClient(Client => new RoleManagementPolicyAssignmentCollection(Client, Id));
        }

        /// <summary>
        /// Get the child resources of a resource on which user has eligible access
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/eligibleChildResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EligibleChildResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=resourceType+eq+'Subscription' to filter on only resource of type = 'Subscription'. Use $filter=resourceType+eq+'subscription'+or+resourceType+eq+'resourcegroup' to filter on resource of type = 'Subscription' or 'ResourceGroup'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EligibleChildResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EligibleChildResource> GetEligibleChildResourcesAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EligibleChildResourcesRestClient.CreateGetRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EligibleChildResourcesRestClient.CreateGetNextPageRequest(nextLink, Id, filter);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, EligibleChildResource.DeserializeEligibleChildResource, EligibleChildResourcesClientDiagnostics, Pipeline, "ArmResourceExtensionClient.GetEligibleChildResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the child resources of a resource on which user has eligible access
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/eligibleChildResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EligibleChildResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=resourceType+eq+'Subscription' to filter on only resource of type = 'Subscription'. Use $filter=resourceType+eq+'subscription'+or+resourceType+eq+'resourcegroup' to filter on resource of type = 'Subscription' or 'ResourceGroup'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EligibleChildResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EligibleChildResource> GetEligibleChildResources(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EligibleChildResourcesRestClient.CreateGetRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EligibleChildResourcesRestClient.CreateGetNextPageRequest(nextLink, Id, filter);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, EligibleChildResource.DeserializeEligibleChildResource, EligibleChildResourcesClientDiagnostics, Pipeline, "ArmResourceExtensionClient.GetEligibleChildResources", "value", "nextLink", cancellationToken);
        }
    }
}
