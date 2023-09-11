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
using Azure.Core.Serialization;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A Class representing a DataPolicyManifest along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataPolicyManifestResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataPolicyManifestResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetDataPolicyManifest method.
    /// </summary>
    [DeserializationProxy(typeof(DataPolicyManifestData))]
    public partial class DataPolicyManifestResource : ArmResource, ResourceManager.IResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataPolicyManifestResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string policyMode)
        {
            var resourceId = $"/providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataPolicyManifestClientDiagnostics;
        private readonly DataPolicyManifestsRestOperations _dataPolicyManifestRestClient;
        private readonly DataPolicyManifestData _data;

        /// <summary> Initializes a new instance of the <see cref="DataPolicyManifestResource"/> class for mocking. </summary>
        protected DataPolicyManifestResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataPolicyManifestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataPolicyManifestResource(ArmClient client, DataPolicyManifestData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataPolicyManifestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataPolicyManifestResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataPolicyManifestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataPolicyManifestApiVersion);
            _dataPolicyManifestRestClient = new DataPolicyManifestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataPolicyManifestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/dataPolicyManifests";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataPolicyManifestData Data
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
        /// This operation retrieves the data policy manifest with the given policy mode.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataPolicyManifests_GetByPolicyMode</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataPolicyManifestResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataPolicyManifestClientDiagnostics.CreateScope("DataPolicyManifestResource.Get");
            scope.Start();
            try
            {
                var response = await _dataPolicyManifestRestClient.GetByPolicyModeAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataPolicyManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the data policy manifest with the given policy mode.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataPolicyManifests_GetByPolicyMode</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataPolicyManifestResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataPolicyManifestClientDiagnostics.CreateScope("DataPolicyManifestResource.Get");
            scope.Start();
            try
            {
                var response = _dataPolicyManifestRestClient.GetByPolicyMode(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataPolicyManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
