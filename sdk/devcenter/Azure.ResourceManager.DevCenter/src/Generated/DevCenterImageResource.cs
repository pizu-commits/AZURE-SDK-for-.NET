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
    /// A Class representing a DevCenterImage along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DevCenterImageResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDevCenterImageResource method.
    /// Otherwise you can get one from its parent resource <see cref="DevCenterGalleryResource" /> using the GetDevCenterImage method.
    /// </summary>
    public partial class DevCenterImageResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DevCenterImageResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string devCenterName, string galleryName, string imageName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _devCenterImageImagesClientDiagnostics;
        private readonly ImagesRestOperations _devCenterImageImagesRestClient;
        private readonly DevCenterImageData _data;

        /// <summary> Initializes a new instance of the <see cref="DevCenterImageResource"/> class for mocking. </summary>
        protected DevCenterImageResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DevCenterImageResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DevCenterImageResource(ArmClient client, DevCenterImageData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DevCenterImageResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DevCenterImageResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devCenterImageImagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string devCenterImageImagesApiVersion);
            _devCenterImageImagesRestClient = new ImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devCenterImageImagesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevCenter/devcenters/galleries/images";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DevCenterImageData Data
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

        /// <summary> Gets a collection of ImageVersionResources in the DevCenterImage. </summary>
        /// <returns> An object representing collection of ImageVersionResources and their operations over a ImageVersionResource. </returns>
        public virtual ImageVersionCollection GetImageVersions()
        {
            return GetCachedClient(client => new ImageVersionCollection(client, Id));
        }

        /// <summary>
        /// Gets an image version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ImageVersionResource>> GetImageVersionAsync(string versionName, CancellationToken cancellationToken = default)
        {
            return await GetImageVersions().GetAsync(versionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an image version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ImageVersionResource> GetImageVersion(string versionName, CancellationToken cancellationToken = default)
        {
            return GetImageVersions().Get(versionName, cancellationToken);
        }

        /// <summary>
        /// Gets a gallery image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DevCenterImageResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _devCenterImageImagesClientDiagnostics.CreateScope("DevCenterImageResource.Get");
            scope.Start();
            try
            {
                var response = await _devCenterImageImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a gallery image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DevCenterImageResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _devCenterImageImagesClientDiagnostics.CreateScope("DevCenterImageResource.Get");
            scope.Start();
            try
            {
                var response = _devCenterImageImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
