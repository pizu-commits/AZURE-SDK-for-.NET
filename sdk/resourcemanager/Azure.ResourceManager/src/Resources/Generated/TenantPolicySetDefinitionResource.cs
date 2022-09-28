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
    /// A Class representing a TenantPolicySetDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TenantPolicySetDefinitionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTenantPolicySetDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetTenantPolicySetDefinition method.
    /// </summary>
    public partial class TenantPolicySetDefinitionResource : PolicySetDefinitionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantPolicySetDefinitionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string policySetDefinitionName)
        {
            var resourceId = $"/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics;
        private readonly PolicySetDefinitionsRestOperations _tenantPolicySetDefinitionPolicySetDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantPolicySetDefinitionResource"/> class for mocking. </summary>
        protected TenantPolicySetDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantPolicySetDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantPolicySetDefinitionResource(ArmClient client, PolicySetDefinitionData data) : base(client, data)
        {
            _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantPolicySetDefinitionPolicySetDefinitionsApiVersion);
            _tenantPolicySetDefinitionPolicySetDefinitionsRestClient = new PolicySetDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantPolicySetDefinitionPolicySetDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="TenantPolicySetDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantPolicySetDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantPolicySetDefinitionPolicySetDefinitionsApiVersion);
            _tenantPolicySetDefinitionPolicySetDefinitionsRestClient = new PolicySetDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantPolicySetDefinitionPolicySetDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policySetDefinitions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// This operation retrieves the built-in policy set definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<PolicySetDefinitionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("TenantPolicySetDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _tenantPolicySetDefinitionPolicySetDefinitionsRestClient.GetBuiltInAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(PolicySetDefinitionResource.GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the built-in policy set definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<TenantPolicySetDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((TenantPolicySetDefinitionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// This operation retrieves the built-in policy set definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<PolicySetDefinitionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("TenantPolicySetDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _tenantPolicySetDefinitionPolicySetDefinitionsRestClient.GetBuiltIn(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(PolicySetDefinitionResource.GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the built-in policy set definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<TenantPolicySetDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((TenantPolicySetDefinitionResource)result.Value, result.GetRawResponse());
        }
    }
}
