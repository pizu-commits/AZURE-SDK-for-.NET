// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.Serialization;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A Class representing a ResourceProvider along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ResourceProviderResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetResourceProviderResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetResourceProvider method.
    /// </summary>
    [DeserializationProxy(typeof(ResourceProviderData))]
    public partial class ResourceProviderResource : ArmResource, ResourceManager.IResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceProviderResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceProviderNamespace)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceProviderProvidersClientDiagnostics;
        private readonly ProvidersRestOperations _resourceProviderProvidersRestClient;
        private readonly ClientDiagnostics _providerResourceTypesClientDiagnostics;
        private readonly ProviderResourceTypesRestOperations _providerResourceTypesRestClient;
        private readonly ResourceProviderData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceProviderResource"/> class for mocking. </summary>
        protected ResourceProviderResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceProviderResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceProviderResource(ArmClient client, ResourceProviderData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceProviderResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceProviderResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceProviderProvidersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceProviderProvidersApiVersion);
            _resourceProviderProvidersRestClient = new ProvidersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceProviderProvidersApiVersion);
            _providerResourceTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _providerResourceTypesRestClient = new ProviderResourceTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/providers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceProviderData Data
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

        /// <summary> Gets a collection of FeatureResources in the ResourceProvider. </summary>
        /// <returns> An object representing collection of FeatureResources and their operations over a FeatureResource. </returns>
        public virtual FeatureCollection GetFeatures()
        {
            return GetCachedClient(Client => new FeatureCollection(Client, Id));
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<FeatureResource>> GetFeatureAsync(string featureName, CancellationToken cancellationToken = default)
        {
            return await GetFeatures().GetAsync(featureName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<FeatureResource> GetFeature(string featureName, CancellationToken cancellationToken = default)
        {
            return GetFeatures().Get(featureName, cancellationToken);
        }

        /// <summary>
        /// Gets the specified resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Providers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceProviderResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceProviderProvidersRestClient.GetAsync(Id.SubscriptionId, Id.Provider, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Providers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceProviderResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderResource.Get");
            scope.Start();
            try
            {
                var response = _resourceProviderProvidersRestClient.Get(Id.SubscriptionId, Id.Provider, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Unregisters a subscription from a resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/unregister</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Providers_Unregister</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceProviderResource>> UnregisterAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderResource.Unregister");
            scope.Start();
            try
            {
                var response = await _resourceProviderProvidersRestClient.UnregisterAsync(Id.SubscriptionId, Id.Provider, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Unregisters a subscription from a resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/unregister</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Providers_Unregister</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceProviderResource> Unregister(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderResource.Unregister");
            scope.Start();
            try
            {
                var response = _resourceProviderProvidersRestClient.Unregister(Id.SubscriptionId, Id.Provider, cancellationToken);
                return Response.FromValue(new ResourceProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the provider permissions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/providerPermissions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Providers_ProviderPermissions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProviderPermission" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProviderPermission> ProviderPermissionsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceProviderProvidersRestClient.CreateProviderPermissionsRequest(Id.SubscriptionId, Id.Provider);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ProviderPermission.DeserializeProviderPermission, _resourceProviderProvidersClientDiagnostics, Pipeline, "ResourceProviderResource.ProviderPermissions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the provider permissions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/providerPermissions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Providers_ProviderPermissions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProviderPermission" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProviderPermission> ProviderPermissions(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceProviderProvidersRestClient.CreateProviderPermissionsRequest(Id.SubscriptionId, Id.Provider);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, ProviderPermission.DeserializeProviderPermission, _resourceProviderProvidersClientDiagnostics, Pipeline, "ResourceProviderResource.ProviderPermissions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Registers a subscription with a resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/register</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Providers_Register</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The third party consent for S2S. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceProviderResource>> RegisterAsync(ProviderRegistrationContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderResource.Register");
            scope.Start();
            try
            {
                var response = await _resourceProviderProvidersRestClient.RegisterAsync(Id.SubscriptionId, Id.Provider, content, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Registers a subscription with a resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/register</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Providers_Register</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The third party consent for S2S. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceProviderResource> Register(ProviderRegistrationContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderResource.Register");
            scope.Start();
            try
            {
                var response = _resourceProviderProvidersRestClient.Register(Id.SubscriptionId, Id.Provider, content, cancellationToken);
                return Response.FromValue(new ResourceProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the resource types for a specified resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/resourceTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderResourceTypes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProviderResourceType" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProviderResourceType> GetProviderResourceTypesAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _providerResourceTypesRestClient.CreateListRequest(Id.SubscriptionId, Id.Provider, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ProviderResourceType.DeserializeProviderResourceType, _providerResourceTypesClientDiagnostics, Pipeline, "ResourceProviderResource.GetProviderResourceTypes", "value", null, cancellationToken);
        }

        /// <summary>
        /// List the resource types for a specified resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/resourceTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderResourceTypes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProviderResourceType" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProviderResourceType> GetProviderResourceTypes(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _providerResourceTypesRestClient.CreateListRequest(Id.SubscriptionId, Id.Provider, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, ProviderResourceType.DeserializeProviderResourceType, _providerResourceTypesClientDiagnostics, Pipeline, "ResourceProviderResource.GetProviderResourceTypes", "value", null, cancellationToken);
        }
    }
}
