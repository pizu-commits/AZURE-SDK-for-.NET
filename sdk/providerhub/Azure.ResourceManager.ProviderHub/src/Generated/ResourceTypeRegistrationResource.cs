// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A Class representing a ResourceTypeRegistration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ResourceTypeRegistrationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetResourceTypeRegistrationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProviderRegistrationResource"/> using the GetResourceTypeRegistration method.
    /// </summary>
    public partial class ResourceTypeRegistrationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceTypeRegistrationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="providerNamespace"> The providerNamespace. </param>
        /// <param name="resourceType"> The resourceType. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string providerNamespace, string resourceType)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceTypeRegistrationClientDiagnostics;
        private readonly ResourceTypeRegistrationsRestOperations _resourceTypeRegistrationRestClient;
        private readonly ResourceTypeRegistrationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ProviderHub/providerRegistrations/resourcetypeRegistrations";

        /// <summary> Initializes a new instance of the <see cref="ResourceTypeRegistrationResource"/> class for mocking. </summary>
        protected ResourceTypeRegistrationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceTypeRegistrationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceTypeRegistrationResource(ArmClient client, ResourceTypeRegistrationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceTypeRegistrationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceTypeRegistrationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceTypeRegistrationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceTypeRegistrationApiVersion);
            _resourceTypeRegistrationRestClient = new ResourceTypeRegistrationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceTypeRegistrationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceTypeRegistrationData Data
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

        /// <summary> Gets a collection of ResourceTypeSkuResources in the ResourceTypeRegistration. </summary>
        /// <returns> An object representing collection of ResourceTypeSkuResources and their operations over a ResourceTypeSkuResource. </returns>
        public virtual ResourceTypeSkuCollection GetResourceTypeSkus()
        {
            return GetCachedClient(client => new ResourceTypeSkuCollection(client, Id));
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ResourceTypeSkuResource>> GetResourceTypeSkuAsync(string sku, CancellationToken cancellationToken = default)
        {
            return await GetResourceTypeSkus().GetAsync(sku, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ResourceTypeSkuResource> GetResourceTypeSku(string sku, CancellationToken cancellationToken = default)
        {
            return GetResourceTypeSkus().Get(sku, cancellationToken);
        }

        /// <summary> Gets a collection of NestedResourceTypeFirstSkuResources in the ResourceTypeRegistration. </summary>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of NestedResourceTypeFirstSkuResources and their operations over a NestedResourceTypeFirstSkuResource. </returns>
        public virtual NestedResourceTypeFirstSkuCollection GetNestedResourceTypeFirstSkus(string nestedResourceTypeFirst)
        {
            return new NestedResourceTypeFirstSkuCollection(Client, Id, nestedResourceTypeFirst);
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/> or <paramref name="sku"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/> or <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NestedResourceTypeFirstSkuResource>> GetNestedResourceTypeFirstSkuAsync(string nestedResourceTypeFirst, string sku, CancellationToken cancellationToken = default)
        {
            return await GetNestedResourceTypeFirstSkus(nestedResourceTypeFirst).GetAsync(sku, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/> or <paramref name="sku"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/> or <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NestedResourceTypeFirstSkuResource> GetNestedResourceTypeFirstSku(string nestedResourceTypeFirst, string sku, CancellationToken cancellationToken = default)
        {
            return GetNestedResourceTypeFirstSkus(nestedResourceTypeFirst).Get(sku, cancellationToken);
        }

        /// <summary> Gets a collection of NestedResourceTypeSecondSkuResources in the ResourceTypeRegistration. </summary>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="nestedResourceTypeSecond"> The second child resource type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/> or <paramref name="nestedResourceTypeSecond"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/> or <paramref name="nestedResourceTypeSecond"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of NestedResourceTypeSecondSkuResources and their operations over a NestedResourceTypeSecondSkuResource. </returns>
        public virtual NestedResourceTypeSecondSkuCollection GetNestedResourceTypeSecondSkus(string nestedResourceTypeFirst, string nestedResourceTypeSecond)
        {
            return new NestedResourceTypeSecondSkuCollection(Client, Id, nestedResourceTypeFirst, nestedResourceTypeSecond);
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="nestedResourceTypeSecond"> The second child resource type. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/> or <paramref name="sku"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/> or <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NestedResourceTypeSecondSkuResource>> GetNestedResourceTypeSecondSkuAsync(string nestedResourceTypeFirst, string nestedResourceTypeSecond, string sku, CancellationToken cancellationToken = default)
        {
            return await GetNestedResourceTypeSecondSkus(nestedResourceTypeFirst, nestedResourceTypeSecond).GetAsync(sku, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="nestedResourceTypeSecond"> The second child resource type. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/> or <paramref name="sku"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/> or <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NestedResourceTypeSecondSkuResource> GetNestedResourceTypeSecondSku(string nestedResourceTypeFirst, string nestedResourceTypeSecond, string sku, CancellationToken cancellationToken = default)
        {
            return GetNestedResourceTypeSecondSkus(nestedResourceTypeFirst, nestedResourceTypeSecond).Get(sku, cancellationToken);
        }

        /// <summary> Gets a collection of NestedResourceTypeThirdSkuResources in the ResourceTypeRegistration. </summary>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="nestedResourceTypeSecond"> The second child resource type. </param>
        /// <param name="nestedResourceTypeThird"> The third child resource type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/> or <paramref name="nestedResourceTypeThird"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/> or <paramref name="nestedResourceTypeThird"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of NestedResourceTypeThirdSkuResources and their operations over a NestedResourceTypeThirdSkuResource. </returns>
        public virtual NestedResourceTypeThirdSkuCollection GetNestedResourceTypeThirdSkus(string nestedResourceTypeFirst, string nestedResourceTypeSecond, string nestedResourceTypeThird)
        {
            return new NestedResourceTypeThirdSkuCollection(Client, Id, nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird);
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="nestedResourceTypeSecond"> The second child resource type. </param>
        /// <param name="nestedResourceTypeThird"> The third child resource type. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/>, <paramref name="nestedResourceTypeThird"/> or <paramref name="sku"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/>, <paramref name="nestedResourceTypeThird"/> or <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NestedResourceTypeThirdSkuResource>> GetNestedResourceTypeThirdSkuAsync(string nestedResourceTypeFirst, string nestedResourceTypeSecond, string nestedResourceTypeThird, string sku, CancellationToken cancellationToken = default)
        {
            return await GetNestedResourceTypeThirdSkus(nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird).GetAsync(sku, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeThird</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeThirdSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="nestedResourceTypeSecond"> The second child resource type. </param>
        /// <param name="nestedResourceTypeThird"> The third child resource type. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/>, <paramref name="nestedResourceTypeThird"/> or <paramref name="sku"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/>, <paramref name="nestedResourceTypeThird"/> or <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NestedResourceTypeThirdSkuResource> GetNestedResourceTypeThirdSku(string nestedResourceTypeFirst, string nestedResourceTypeSecond, string nestedResourceTypeThird, string sku, CancellationToken cancellationToken = default)
        {
            return GetNestedResourceTypeThirdSkus(nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird).Get(sku, cancellationToken);
        }

        /// <summary>
        /// Gets a resource type details in the given subscription and provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceTypeRegistrationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceTypeRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceTypeRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a resource type details in the given subscription and provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceTypeRegistrationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationResource.Get");
            scope.Start();
            try
            {
                var response = _resourceTypeRegistrationRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceTypeRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a resource type
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationResource.Delete");
            scope.Start();
            try
            {
                var response = await _resourceTypeRegistrationRestClient.DeleteAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a resource type
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationResource.Delete");
            scope.Start();
            try
            {
                var response = _resourceTypeRegistrationRestClient.Delete(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ProviderHubArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required request body parameters supplied to the resource type registration CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ResourceTypeRegistrationResource>> UpdateAsync(WaitUntil waitUntil, ResourceTypeRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationResource.Update");
            scope.Start();
            try
            {
                var response = await _resourceTypeRegistrationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<ResourceTypeRegistrationResource>(new ResourceTypeRegistrationOperationSource(Client), _resourceTypeRegistrationClientDiagnostics, Pipeline, _resourceTypeRegistrationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required request body parameters supplied to the resource type registration CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ResourceTypeRegistrationResource> Update(WaitUntil waitUntil, ResourceTypeRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationResource.Update");
            scope.Start();
            try
            {
                var response = _resourceTypeRegistrationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ProviderHubArmOperation<ResourceTypeRegistrationResource>(new ResourceTypeRegistrationOperationSource(Client), _resourceTypeRegistrationClientDiagnostics, Pipeline, _resourceTypeRegistrationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
