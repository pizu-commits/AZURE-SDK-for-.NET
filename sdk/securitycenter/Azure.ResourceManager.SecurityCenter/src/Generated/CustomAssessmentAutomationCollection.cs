// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="CustomAssessmentAutomationResource"/> and their operations.
    /// Each <see cref="CustomAssessmentAutomationResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="CustomAssessmentAutomationCollection"/> instance call the GetCustomAssessmentAutomations method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class CustomAssessmentAutomationCollection : ArmCollection, IEnumerable<CustomAssessmentAutomationResource>, IAsyncEnumerable<CustomAssessmentAutomationResource>
    {
        private readonly ClientDiagnostics _customAssessmentAutomationClientDiagnostics;
        private readonly CustomAssessmentAutomationsRestOperations _customAssessmentAutomationRestClient;

        /// <summary> Initializes a new instance of the <see cref="CustomAssessmentAutomationCollection"/> class for mocking. </summary>
        protected CustomAssessmentAutomationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CustomAssessmentAutomationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CustomAssessmentAutomationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _customAssessmentAutomationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", CustomAssessmentAutomationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CustomAssessmentAutomationResource.ResourceType, out string customAssessmentAutomationApiVersion);
            _customAssessmentAutomationRestClient = new CustomAssessmentAutomationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, customAssessmentAutomationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a custom assessment automation for the provided subscription. Please note that providing an existing custom assessment automation will replace the existing record.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomAssessmentAutomationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customAssessmentAutomationName"> Name of the Custom Assessment Automation. </param>
        /// <param name="content"> Custom Assessment Automation body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customAssessmentAutomationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customAssessmentAutomationName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CustomAssessmentAutomationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string customAssessmentAutomationName, CustomAssessmentAutomationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customAssessmentAutomationName, nameof(customAssessmentAutomationName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _customAssessmentAutomationRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, customAssessmentAutomationName, content, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<CustomAssessmentAutomationResource>(Response.FromValue(new CustomAssessmentAutomationResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a custom assessment automation for the provided subscription. Please note that providing an existing custom assessment automation will replace the existing record.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomAssessmentAutomationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customAssessmentAutomationName"> Name of the Custom Assessment Automation. </param>
        /// <param name="content"> Custom Assessment Automation body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customAssessmentAutomationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customAssessmentAutomationName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CustomAssessmentAutomationResource> CreateOrUpdate(WaitUntil waitUntil, string customAssessmentAutomationName, CustomAssessmentAutomationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customAssessmentAutomationName, nameof(customAssessmentAutomationName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _customAssessmentAutomationRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, customAssessmentAutomationName, content, cancellationToken);
                var operation = new SecurityCenterArmOperation<CustomAssessmentAutomationResource>(Response.FromValue(new CustomAssessmentAutomationResource(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Gets a single custom assessment automation by name for the provided subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomAssessmentAutomationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customAssessmentAutomationName"> Name of the Custom Assessment Automation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customAssessmentAutomationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customAssessmentAutomationName"/> is null. </exception>
        public virtual async Task<Response<CustomAssessmentAutomationResource>> GetAsync(string customAssessmentAutomationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customAssessmentAutomationName, nameof(customAssessmentAutomationName));

            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationCollection.Get");
            scope.Start();
            try
            {
                var response = await _customAssessmentAutomationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customAssessmentAutomationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomAssessmentAutomationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a single custom assessment automation by name for the provided subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomAssessmentAutomationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customAssessmentAutomationName"> Name of the Custom Assessment Automation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customAssessmentAutomationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customAssessmentAutomationName"/> is null. </exception>
        public virtual Response<CustomAssessmentAutomationResource> Get(string customAssessmentAutomationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customAssessmentAutomationName, nameof(customAssessmentAutomationName));

            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationCollection.Get");
            scope.Start();
            try
            {
                var response = _customAssessmentAutomationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customAssessmentAutomationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomAssessmentAutomationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List custom assessment automations by provided subscription and resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomAssessmentAutomationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomAssessmentAutomationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CustomAssessmentAutomationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _customAssessmentAutomationRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _customAssessmentAutomationRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CustomAssessmentAutomationResource(Client, CustomAssessmentAutomationData.DeserializeCustomAssessmentAutomationData(e)), _customAssessmentAutomationClientDiagnostics, Pipeline, "CustomAssessmentAutomationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List custom assessment automations by provided subscription and resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomAssessmentAutomationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomAssessmentAutomationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CustomAssessmentAutomationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _customAssessmentAutomationRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _customAssessmentAutomationRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CustomAssessmentAutomationResource(Client, CustomAssessmentAutomationData.DeserializeCustomAssessmentAutomationData(e)), _customAssessmentAutomationClientDiagnostics, Pipeline, "CustomAssessmentAutomationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomAssessmentAutomationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customAssessmentAutomationName"> Name of the Custom Assessment Automation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customAssessmentAutomationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customAssessmentAutomationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string customAssessmentAutomationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customAssessmentAutomationName, nameof(customAssessmentAutomationName));

            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _customAssessmentAutomationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customAssessmentAutomationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomAssessmentAutomationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customAssessmentAutomationName"> Name of the Custom Assessment Automation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customAssessmentAutomationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customAssessmentAutomationName"/> is null. </exception>
        public virtual Response<bool> Exists(string customAssessmentAutomationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customAssessmentAutomationName, nameof(customAssessmentAutomationName));

            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationCollection.Exists");
            scope.Start();
            try
            {
                var response = _customAssessmentAutomationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customAssessmentAutomationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomAssessmentAutomationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customAssessmentAutomationName"> Name of the Custom Assessment Automation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customAssessmentAutomationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customAssessmentAutomationName"/> is null. </exception>
        public virtual async Task<NullableResponse<CustomAssessmentAutomationResource>> GetIfExistsAsync(string customAssessmentAutomationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customAssessmentAutomationName, nameof(customAssessmentAutomationName));

            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _customAssessmentAutomationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customAssessmentAutomationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CustomAssessmentAutomationResource>(response.GetRawResponse());
                return Response.FromValue(new CustomAssessmentAutomationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomAssessmentAutomationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customAssessmentAutomationName"> Name of the Custom Assessment Automation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customAssessmentAutomationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customAssessmentAutomationName"/> is null. </exception>
        public virtual NullableResponse<CustomAssessmentAutomationResource> GetIfExists(string customAssessmentAutomationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customAssessmentAutomationName, nameof(customAssessmentAutomationName));

            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _customAssessmentAutomationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customAssessmentAutomationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CustomAssessmentAutomationResource>(response.GetRawResponse());
                return Response.FromValue(new CustomAssessmentAutomationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CustomAssessmentAutomationResource> IEnumerable<CustomAssessmentAutomationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CustomAssessmentAutomationResource> IAsyncEnumerable<CustomAssessmentAutomationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
