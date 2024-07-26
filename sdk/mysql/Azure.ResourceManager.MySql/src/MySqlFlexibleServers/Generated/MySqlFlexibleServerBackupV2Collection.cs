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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlFlexibleServerBackupV2Resource"/> and their operations.
    /// Each <see cref="MySqlFlexibleServerBackupV2Resource"/> in the collection will belong to the same instance of <see cref="MySqlFlexibleServerResource"/>.
    /// To get a <see cref="MySqlFlexibleServerBackupV2Collection"/> instance call the GetMySqlFlexibleServerBackupV2s method from an instance of <see cref="MySqlFlexibleServerResource"/>.
    /// </summary>
    public partial class MySqlFlexibleServerBackupV2Collection : ArmCollection, IEnumerable<MySqlFlexibleServerBackupV2Resource>, IAsyncEnumerable<MySqlFlexibleServerBackupV2Resource>
    {
        private readonly ClientDiagnostics _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics;
        private readonly LongRunningBackupRestOperations _mySqlFlexibleServerBackupV2LongRunningBackupRestClient;
        private readonly ClientDiagnostics _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics;
        private readonly LongRunningBackupsRestOperations _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerBackupV2Collection"/> class for mocking. </summary>
        protected MySqlFlexibleServerBackupV2Collection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerBackupV2Collection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlFlexibleServerBackupV2Collection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", MySqlFlexibleServerBackupV2Resource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlFlexibleServerBackupV2Resource.ResourceType, out string mySqlFlexibleServerBackupV2LongRunningBackupApiVersion);
            _mySqlFlexibleServerBackupV2LongRunningBackupRestClient = new LongRunningBackupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlFlexibleServerBackupV2LongRunningBackupApiVersion);
            _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", MySqlFlexibleServerBackupV2Resource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlFlexibleServerBackupV2Resource.ResourceType, out string mySqlFlexibleServerBackupV2LongRunningBackupsApiVersion);
            _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient = new LongRunningBackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlFlexibleServerBackupV2LongRunningBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MySqlFlexibleServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MySqlFlexibleServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create backup for a given server with specified backup name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackup_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="data"> The required parameters for creating and exporting backup of the given server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MySqlFlexibleServerBackupV2Resource>> CreateOrUpdateAsync(WaitUntil waitUntil, string backupName, MySqlFlexibleServerBackupV2Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerBackupV2LongRunningBackupRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FlexibleServersArmOperation<MySqlFlexibleServerBackupV2Resource>(new MySqlFlexibleServerBackupV2OperationSource(Client), _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics, Pipeline, _mySqlFlexibleServerBackupV2LongRunningBackupRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create backup for a given server with specified backup name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackup_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="data"> The required parameters for creating and exporting backup of the given server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MySqlFlexibleServerBackupV2Resource> CreateOrUpdate(WaitUntil waitUntil, string backupName, MySqlFlexibleServerBackupV2Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerBackupV2LongRunningBackupRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, data, cancellationToken);
                var operation = new FlexibleServersArmOperation<MySqlFlexibleServerBackupV2Resource>(new MySqlFlexibleServerBackupV2OperationSource(Client), _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics, Pipeline, _mySqlFlexibleServerBackupV2LongRunningBackupRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get backup for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<MySqlFlexibleServerBackupV2Resource>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Collection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerBackupV2Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get backup for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<MySqlFlexibleServerBackupV2Resource> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Collection.Get");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerBackupV2Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the backups for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackups_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerBackupV2Resource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlFlexibleServerBackupV2Resource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MySqlFlexibleServerBackupV2Resource(Client, MySqlFlexibleServerBackupV2Data.DeserializeMySqlFlexibleServerBackupV2Data(e)), _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics, Pipeline, "MySqlFlexibleServerBackupV2Collection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the backups for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackups_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerBackupV2Resource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlFlexibleServerBackupV2Resource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MySqlFlexibleServerBackupV2Resource(Client, MySqlFlexibleServerBackupV2Data.DeserializeMySqlFlexibleServerBackupV2Data(e)), _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics, Pipeline, "MySqlFlexibleServerBackupV2Collection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Collection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Collection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<NullableResponse<MySqlFlexibleServerBackupV2Resource>> GetIfExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MySqlFlexibleServerBackupV2Resource>(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerBackupV2Resource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual NullableResponse<MySqlFlexibleServerBackupV2Resource> GetIfExists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MySqlFlexibleServerBackupV2Resource>(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerBackupV2Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlFlexibleServerBackupV2Resource> IEnumerable<MySqlFlexibleServerBackupV2Resource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlFlexibleServerBackupV2Resource> IAsyncEnumerable<MySqlFlexibleServerBackupV2Resource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
