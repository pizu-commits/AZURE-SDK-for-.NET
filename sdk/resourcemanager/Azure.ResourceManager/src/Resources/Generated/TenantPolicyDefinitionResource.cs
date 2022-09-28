// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A Class representing a TenantPolicyDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TenantPolicyDefinitionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTenantPolicyDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetTenantPolicyDefinition method.
    /// </summary>
    public partial class TenantPolicyDefinitionResource : PolicyDefinitionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantPolicyDefinitionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string policyDefinitionName)
        {
            var resourceId = $"/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantPolicyDefinitionPolicyDefinitionsClientDiagnostics;
        private readonly PolicyDefinitionsRestOperations _tenantPolicyDefinitionPolicyDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantPolicyDefinitionResource"/> class for mocking. </summary>
        protected TenantPolicyDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantPolicyDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantPolicyDefinitionResource(ArmClient client, PolicyDefinitionData data) : base(client, data)
        {
            _tenantPolicyDefinitionPolicyDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantPolicyDefinitionPolicyDefinitionsApiVersion);
            _tenantPolicyDefinitionPolicyDefinitionsRestClient = new PolicyDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantPolicyDefinitionPolicyDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="TenantPolicyDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantPolicyDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantPolicyDefinitionPolicyDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantPolicyDefinitionPolicyDefinitionsApiVersion);
            _tenantPolicyDefinitionPolicyDefinitionsRestClient = new PolicyDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantPolicyDefinitionPolicyDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policyDefinitions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// This operation retrieves the built-in policy definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<PolicyDefinitionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("TenantPolicyDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _tenantPolicyDefinitionPolicyDefinitionsRestClient.GetBuiltInAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(PolicyDefinitionResource.GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the built-in policy definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<TenantPolicyDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((TenantPolicyDefinitionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// This operation retrieves the built-in policy definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<PolicyDefinitionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("TenantPolicyDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _tenantPolicyDefinitionPolicyDefinitionsRestClient.GetBuiltIn(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(PolicyDefinitionResource.GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the built-in policy definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<TenantPolicyDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((TenantPolicyDefinitionResource)result.Value, result.GetRawResponse());
        }
    }
}
