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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a CertificateOrderDetector along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CertificateOrderDetectorResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCertificateOrderDetectorResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServiceCertificateOrderResource" /> using the GetCertificateOrderDetector method.
    /// </summary>
    public partial class CertificateOrderDetectorResource : AppServiceDetectorResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CertificateOrderDetectorResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string certificateOrderName, string detectorName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics;
        private readonly CertificateOrdersDiagnosticsRestOperations _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CertificateOrderDetectorResource"/> class for mocking. </summary>
        protected CertificateOrderDetectorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CertificateOrderDetectorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CertificateOrderDetectorResource(ArmClient client, AppServiceDetectorData data) : base(client, data)
        {
            _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string certificateOrderDetectorCertificateOrdersDiagnosticsApiVersion);
            _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient = new CertificateOrdersDiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, certificateOrderDetectorCertificateOrdersDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="CertificateOrderDetectorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CertificateOrderDetectorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string certificateOrderDetectorCertificateOrdersDiagnosticsApiVersion);
            _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient = new CertificateOrdersDiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, certificateOrderDetectorCertificateOrdersDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CertificateRegistration/certificateOrders/detectors";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Microsoft.CertificateRegistration call to get a detector response from App Lens.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}
        /// Operation Id: CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse
        /// </summary>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<AppServiceDetectorResource>> GetCoreAsync(DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorResource.GetCore");
            scope.Start();
            try
            {
                var response = await _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, startTime, endTime, timeGrain, cancellationToken).ConfigureAwait(false);
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
        /// Description for Microsoft.CertificateRegistration call to get a detector response from App Lens.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}
        /// Operation Id: CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse
        /// </summary>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<CertificateOrderDetectorResource>> GetAsync(DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(startTime, endTime, timeGrain, cancellationToken).ConfigureAwait(false);
            return Response.FromValue((CertificateOrderDetectorResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Microsoft.CertificateRegistration call to get a detector response from App Lens.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}
        /// Operation Id: CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse
        /// </summary>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<AppServiceDetectorResource> GetCore(DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorResource.GetCore");
            scope.Start();
            try
            {
                var response = _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, startTime, endTime, timeGrain, cancellationToken);
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
        /// Description for Microsoft.CertificateRegistration call to get a detector response from App Lens.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}
        /// Operation Id: CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse
        /// </summary>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<CertificateOrderDetectorResource> Get(DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            var result = GetCore(startTime, endTime, timeGrain, cancellationToken);
            return Response.FromValue((CertificateOrderDetectorResource)result.Value, result.GetRawResponse());
        }
    }
}
