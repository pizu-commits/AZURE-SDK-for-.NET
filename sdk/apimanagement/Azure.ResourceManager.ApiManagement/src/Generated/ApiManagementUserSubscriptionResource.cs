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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiManagementUserSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ApiManagementUserSubscriptionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetApiManagementUserSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementUserResource" /> using the GetApiManagementUserSubscription method.
    /// </summary>
    public partial class ApiManagementUserSubscriptionResource : SubscriptionContractResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiManagementUserSubscriptionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string userId, string sid)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions/{sid}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics;
        private readonly UserSubscriptionRestOperations _apiManagementUserSubscriptionUserSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementUserSubscriptionResource"/> class for mocking. </summary>
        protected ApiManagementUserSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApiManagementUserSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiManagementUserSubscriptionResource(ArmClient client, SubscriptionContractData data) : base(client, data)
        {
            _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiManagementUserSubscriptionUserSubscriptionApiVersion);
            _apiManagementUserSubscriptionUserSubscriptionRestClient = new UserSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementUserSubscriptionUserSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementUserSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiManagementUserSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiManagementUserSubscriptionUserSubscriptionApiVersion);
            _apiManagementUserSubscriptionUserSubscriptionRestClient = new UserSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementUserSubscriptionUserSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/users/subscriptions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets the specified Subscription entity associated with a particular user.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions/{sid}
        /// Operation Id: UserSubscription_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<SubscriptionContractResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics.CreateScope("ApiManagementUserSubscriptionResource.GetCore");
            scope.Start();
            try
            {
                var response = await _apiManagementUserSubscriptionUserSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets the specified Subscription entity associated with a particular user.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions/{sid}
        /// Operation Id: UserSubscription_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<ApiManagementUserSubscriptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ApiManagementUserSubscriptionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets the specified Subscription entity associated with a particular user.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions/{sid}
        /// Operation Id: UserSubscription_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<SubscriptionContractResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics.CreateScope("ApiManagementUserSubscriptionResource.GetCore");
            scope.Start();
            try
            {
                var response = _apiManagementUserSubscriptionUserSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Gets the specified Subscription entity associated with a particular user.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions/{sid}
        /// Operation Id: UserSubscription_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<ApiManagementUserSubscriptionResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((ApiManagementUserSubscriptionResource)result.Value, result.GetRawResponse());
        }
    }
}
