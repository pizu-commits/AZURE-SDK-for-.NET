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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A Class representing a ResourceHealthMetadataEntity along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ResourceHealthMetadataEntityResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetResourceHealthMetadataEntityResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetResourceHealthMetadataEntity method.
    /// </summary>
    public partial class ResourceHealthMetadataEntityResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceHealthMetadataEntityResource"/> instance. </summary>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string name)
        {
            var resourceId = $"/providers/Microsoft.ResourceHealth/metadata/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceHealthMetadataEntityMetadataClientDiagnostics;
        private readonly MetadataRestOperations _resourceHealthMetadataEntityMetadataRestClient;
        private readonly ResourceHealthMetadataEntityData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ResourceHealth/metadata";

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthMetadataEntityResource"/> class for mocking. </summary>
        protected ResourceHealthMetadataEntityResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthMetadataEntityResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceHealthMetadataEntityResource(ArmClient client, ResourceHealthMetadataEntityData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthMetadataEntityResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceHealthMetadataEntityResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceHealthMetadataEntityMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceHealthMetadataEntityMetadataApiVersion);
            _resourceHealthMetadataEntityMetadataRestClient = new MetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceHealthMetadataEntityMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceHealthMetadataEntityData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the list of metadata entities.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_GetEntity</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthMetadataEntityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceHealthMetadataEntityResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceHealthMetadataEntityMetadataClientDiagnostics.CreateScope("ResourceHealthMetadataEntityResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceHealthMetadataEntityMetadataRestClient.GetEntityAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthMetadataEntityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of metadata entities.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_GetEntity</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthMetadataEntityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceHealthMetadataEntityResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceHealthMetadataEntityMetadataClientDiagnostics.CreateScope("ResourceHealthMetadataEntityResource.Get");
            scope.Start();
            try
            {
                var response = _resourceHealthMetadataEntityMetadataRestClient.GetEntity(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthMetadataEntityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
