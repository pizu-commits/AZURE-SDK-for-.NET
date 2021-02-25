// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.AccessControl.Models;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.AccessControl
{
    /// <summary> The RoleDefinitions service client. </summary>
    public partial class RoleDefinitionsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal RoleDefinitionsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of RoleDefinitionsClient for mocking. </summary>
        protected RoleDefinitionsClient()
        {
        }

        /// <summary> Initializes a new instance of RoleDefinitionsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal RoleDefinitionsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2020-08-01-preview")
        {
            RestClient = new RoleDefinitionsRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> List role definitions. </summary>
        /// <param name="isBuiltIn"> Is a Synapse Built-In Role or not. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<SynapseRoleDefinition>>> ListRoleDefinitionsAsync(bool? isBuiltIn = null, string scope = null, CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.ListRoleDefinitions");
            scope0.Start();
            try
            {
                return await RestClient.ListRoleDefinitionsAsync(isBuiltIn, scope, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List role definitions. </summary>
        /// <param name="isBuiltIn"> Is a Synapse Built-In Role or not. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<SynapseRoleDefinition>> ListRoleDefinitions(bool? isBuiltIn = null, string scope = null, CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.ListRoleDefinitions");
            scope0.Start();
            try
            {
                return RestClient.ListRoleDefinitions(isBuiltIn, scope, cancellationToken);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Get role definition by role definition Id. </summary>
        /// <param name="roleDefinitionId"> Synapse Built-In Role Definition Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseRoleDefinition>> GetRoleDefinitionByIdAsync(string roleDefinitionId, CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.GetRoleDefinitionById");
            scope0.Start();
            try
            {
                return await RestClient.GetRoleDefinitionByIdAsync(roleDefinitionId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Get role definition by role definition Id. </summary>
        /// <param name="roleDefinitionId"> Synapse Built-In Role Definition Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseRoleDefinition> GetRoleDefinitionById(string roleDefinitionId, CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.GetRoleDefinitionById");
            scope0.Start();
            try
            {
                return RestClient.GetRoleDefinitionById(roleDefinitionId, cancellationToken);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List rbac scopes. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<string>>> ListScopesAsync(CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.ListScopes");
            scope0.Start();
            try
            {
                return await RestClient.ListScopesAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List rbac scopes. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<string>> ListScopes(CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.ListScopes");
            scope0.Start();
            try
            {
                return RestClient.ListScopes(cancellationToken);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }
    }
}
