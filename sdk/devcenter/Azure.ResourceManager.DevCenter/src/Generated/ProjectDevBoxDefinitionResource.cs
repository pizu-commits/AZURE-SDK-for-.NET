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

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A Class representing a ProjectDevBoxDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ProjectDevBoxDefinitionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetProjectDevBoxDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProjectResource" /> using the GetProjectDevBoxDefinition method.
    /// </summary>
    public partial class ProjectDevBoxDefinitionResource : BaseDevBoxDefinitionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ProjectDevBoxDefinitionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string projectName, string devBoxDefinitionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics;
        private readonly DevBoxDefinitionsRestOperations _projectDevBoxDefinitionDevBoxDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProjectDevBoxDefinitionResource"/> class for mocking. </summary>
        protected ProjectDevBoxDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ProjectDevBoxDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ProjectDevBoxDefinitionResource(ArmClient client, DevBoxDefinitionData data) : base(client, data)
        {
            _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string projectDevBoxDefinitionDevBoxDefinitionsApiVersion);
            _projectDevBoxDefinitionDevBoxDefinitionsRestClient = new DevBoxDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, projectDevBoxDefinitionDevBoxDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ProjectDevBoxDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ProjectDevBoxDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string projectDevBoxDefinitionDevBoxDefinitionsApiVersion);
            _projectDevBoxDefinitionDevBoxDefinitionsRestClient = new DevBoxDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, projectDevBoxDefinitionDevBoxDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevCenter/projects/devboxdefinitions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a Dev Box definition configured for a project
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}
        /// Operation Id: DevBoxDefinitions_GetByProject
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseDevBoxDefinitionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics.CreateScope("ProjectDevBoxDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _projectDevBoxDefinitionDevBoxDefinitionsRestClient.GetByProjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Dev Box definition configured for a project
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}
        /// Operation Id: DevBoxDefinitions_GetByProject
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<ProjectDevBoxDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ProjectDevBoxDefinitionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Gets a Dev Box definition configured for a project
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}
        /// Operation Id: DevBoxDefinitions_GetByProject
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseDevBoxDefinitionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics.CreateScope("ProjectDevBoxDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _projectDevBoxDefinitionDevBoxDefinitionsRestClient.GetByProject(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Dev Box definition configured for a project
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}
        /// Operation Id: DevBoxDefinitions_GetByProject
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<ProjectDevBoxDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((ProjectDevBoxDefinitionResource)result.Value, result.GetRawResponse());
        }
    }
}
