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

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A Class representing a DataFactoryChangeDataCapture along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DataFactoryChangeDataCaptureResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDataFactoryChangeDataCaptureResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataFactoryResource"/> using the GetDataFactoryChangeDataCapture method.
    /// </summary>
    public partial class DataFactoryChangeDataCaptureResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataFactoryChangeDataCaptureResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="factoryName"> The factoryName. </param>
        /// <param name="changeDataCaptureName"> The changeDataCaptureName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string factoryName, string changeDataCaptureName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics;
        private readonly ChangeDataCaptureRestOperations _dataFactoryChangeDataCaptureChangeDataCaptureRestClient;
        private readonly DataFactoryChangeDataCaptureData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataFactory/factories/adfcdcs";

        /// <summary> Initializes a new instance of the <see cref="DataFactoryChangeDataCaptureResource"/> class for mocking. </summary>
        protected DataFactoryChangeDataCaptureResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryChangeDataCaptureResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataFactoryChangeDataCaptureResource(ArmClient client, DataFactoryChangeDataCaptureData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryChangeDataCaptureResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataFactoryChangeDataCaptureResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataFactoryChangeDataCaptureChangeDataCaptureApiVersion);
            _dataFactoryChangeDataCaptureChangeDataCaptureRestClient = new ChangeDataCaptureRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryChangeDataCaptureChangeDataCaptureApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataFactoryChangeDataCaptureData Data
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
        /// Gets a change data capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifNoneMatch"> ETag of the change data capture entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataFactoryChangeDataCaptureResource>> GetAsync(string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryChangeDataCaptureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a change data capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifNoneMatch"> ETag of the change data capture entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataFactoryChangeDataCaptureResource> Get(string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryChangeDataCaptureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a change data capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation(response);
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
        /// Deletes a change data capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Delete");
            scope.Start();
            try
            {
                var response = _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DataFactoryArmOperation(response);
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
        /// Creates or updates a change data capture resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Change data capture resource definition. </param>
        /// <param name="ifMatch"> ETag of the change data capture entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryChangeDataCaptureResource>> UpdateAsync(WaitUntil waitUntil, DataFactoryChangeDataCaptureData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Update");
            scope.Start();
            try
            {
                var response = await _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryChangeDataCaptureResource>(Response.FromValue(new DataFactoryChangeDataCaptureResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a change data capture resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Change data capture resource definition. </param>
        /// <param name="ifMatch"> ETag of the change data capture entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataFactoryChangeDataCaptureResource> Update(WaitUntil waitUntil, DataFactoryChangeDataCaptureData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Update");
            scope.Start();
            try
            {
                var response = _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryChangeDataCaptureResource>(Response.FromValue(new DataFactoryChangeDataCaptureResource(Client, response), response.GetRawResponse()));
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
        /// Starts a change data capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}/start</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_Start</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StartAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Start");
            scope.Start();
            try
            {
                var response = await _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.StartAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Starts a change data capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}/start</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_Start</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Start(CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Start");
            scope.Start();
            try
            {
                var response = _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.Start(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Stops a change data capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}/stop</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_Stop</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Stop");
            scope.Start();
            try
            {
                var response = await _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.StopAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Stops a change data capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}/stop</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_Stop</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Stop(CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Stop");
            scope.Start();
            try
            {
                var response = _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.Stop(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the current status for the change data capture resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}/status</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_Status</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> StatusAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Status");
            scope.Start();
            try
            {
                var response = await _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.StatusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the current status for the change data capture resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/adfcdcs/{changeDataCaptureName}/status</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChangeDataCapture_Status</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryChangeDataCaptureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> Status(CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryChangeDataCaptureChangeDataCaptureClientDiagnostics.CreateScope("DataFactoryChangeDataCaptureResource.Status");
            scope.Start();
            try
            {
                var response = _dataFactoryChangeDataCaptureChangeDataCaptureRestClient.Status(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
