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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="CertificateOrderDetectorResource" /> and their operations.
    /// Each <see cref="CertificateOrderDetectorResource" /> in the collection will belong to the same instance of <see cref="AppServiceCertificateOrderResource" />.
    /// To get a <see cref="CertificateOrderDetectorCollection" /> instance call the GetCertificateOrderDetectors method from an instance of <see cref="AppServiceCertificateOrderResource" />.
    /// </summary>
    public partial class CertificateOrderDetectorCollection : ArmCollection, IEnumerable<CertificateOrderDetectorResource>, IAsyncEnumerable<CertificateOrderDetectorResource>
    {
        private readonly ClientDiagnostics _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics;
        private readonly CertificateOrdersDiagnosticsRestOperations _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CertificateOrderDetectorCollection"/> class for mocking. </summary>
        protected CertificateOrderDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CertificateOrderDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CertificateOrderDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", CertificateOrderDetectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CertificateOrderDetectorResource.ResourceType, out string certificateOrderDetectorCertificateOrdersDiagnosticsApiVersion);
            _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient = new CertificateOrdersDiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, certificateOrderDetectorCertificateOrdersDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceCertificateOrderResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceCertificateOrderResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Microsoft.CertificateRegistration call to get a detector response from App Lens.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<CertificateOrderDetectorResource>> GetAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CertificateOrderDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Microsoft.CertificateRegistration call to get a detector response from App Lens.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<CertificateOrderDetectorResource> Get(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CertificateOrderDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Microsoft.CertificateRegistration to get the list of detectors for this RP.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateOrdersDiagnostics_ListAppServiceCertificateOrderDetectorResponse</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CertificateOrderDetectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CertificateOrderDetectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.CreateListAppServiceCertificateOrderDetectorResponseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.CreateListAppServiceCertificateOrderDetectorResponseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new CertificateOrderDetectorResource(Client, AppServiceDetectorData.DeserializeAppServiceDetectorData(e)), _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics, Pipeline, "CertificateOrderDetectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Microsoft.CertificateRegistration to get the list of detectors for this RP.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateOrdersDiagnostics_ListAppServiceCertificateOrderDetectorResponse</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CertificateOrderDetectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CertificateOrderDetectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.CreateListAppServiceCertificateOrderDetectorResponseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.CreateListAppServiceCertificateOrderDetectorResponseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new CertificateOrderDetectorResource(Client, AppServiceDetectorData.DeserializeAppServiceDetectorData(e)), _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics, Pipeline, "CertificateOrderDetectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<NullableResponse<CertificateOrderDetectorResource>> GetIfExistsAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CertificateOrderDetectorResource>(response.GetRawResponse());
                return Response.FromValue(new CertificateOrderDetectorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual NullableResponse<CertificateOrderDetectorResource> GetIfExists(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CertificateOrderDetectorResource>(response.GetRawResponse());
                return Response.FromValue(new CertificateOrderDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CertificateOrderDetectorResource> IEnumerable<CertificateOrderDetectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CertificateOrderDetectorResource> IAsyncEnumerable<CertificateOrderDetectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
