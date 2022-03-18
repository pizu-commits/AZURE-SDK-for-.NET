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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a FeatureResource along with the instance operations that can be performed on it. </summary>
    public partial class FeatureResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="Feature"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceProviderNamespace, string featureName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _featureClientDiagnostics;
        private readonly FeaturesRestOperations _featureRestClient;
        private readonly FeatureData _data;

        /// <summary> Initializes a new instance of the <see cref="Feature"/> class for mocking. </summary>
        protected FeatureResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "Feature"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FeatureResource(ArmClient client, FeatureData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="Feature"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FeatureResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _featureClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string featureApiVersion);
            _featureRestClient = new FeaturesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, featureApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType.GetLastType() != "features")
            {
                throw new InvalidOperationException($"Invalid resourcetype found when intializing FeatureOperations: {id.ResourceType}");
            }
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/features";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FeatureData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// Operation Id: Features_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FeatureResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Get");
            scope.Start();
            try
            {
                var response = await _featureRestClient.GetAsync(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// Operation Id: Features_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FeatureResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Get");
            scope.Start();
            try
            {
                var response = _featureRestClient.Get(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Registers the preview feature for the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/register
        /// Operation Id: Features_Register
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FeatureResource>> RegisterAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Register");
            scope.Start();
            try
            {
                var response = await _featureRestClient.RegisterAsync(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Registers the preview feature for the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/register
        /// Operation Id: Features_Register
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FeatureResource> Register(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Register");
            scope.Start();
            try
            {
                var response = _featureRestClient.Register(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken);
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Unregisters the preview feature for the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/unregister
        /// Operation Id: Features_Unregister
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FeatureResource>> UnregisterAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Unregister");
            scope.Start();
            try
            {
                var response = await _featureRestClient.UnregisterAsync(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Unregisters the preview feature for the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/unregister
        /// Operation Id: Features_Unregister
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FeatureResource> Unregister(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Unregister");
            scope.Start();
            try
            {
                var response = _featureRestClient.Unregister(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken);
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
