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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedRestorableDroppedDbBackupShortTermRetentionPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="RestorableDroppedManagedDatabaseResource" /> using the GetManagedRestorableDroppedDbBackupShortTermRetentionPolicy method.
    /// </summary>
    public partial class ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource : BaseManagedBackupShortTermRetentionPolicyResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, ManagedShortTermRetentionPolicyName policyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics;
        private readonly ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource"/> class for mocking. </summary>
        protected ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(ArmClient client, ManagedBackupShortTermRetentionPolicyData data) : base(client, data)
        {
            _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesApiVersion);
            _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient = new ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesApiVersion);
            _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient = new ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/restorableDroppedDatabases/backupShortTermRetentionPolicies";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a dropped database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseManagedBackupShortTermRetentionPolicyResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets a dropped database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a dropped database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseManagedBackupShortTermRetentionPolicyResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Gets a dropped database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Sets a database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<BaseManagedBackupShortTermRetentionPolicyResource>> UpdateCoreAsync(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<BaseManagedBackupShortTermRetentionPolicyResource>(new BaseManagedBackupShortTermRetentionPolicyOperationSource(Client), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Sets a database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>> UpdateAsync(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            var result = await UpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new SqlArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>(Response.FromValue((ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource)result.Value, result.GetRawResponse()));
            }
            var operation = new SqlArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyOperationSource(Client), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Sets a database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<BaseManagedBackupShortTermRetentionPolicyResource> UpdateCore(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource.Update");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<BaseManagedBackupShortTermRetentionPolicyResource>(new BaseManagedBackupShortTermRetentionPolicyOperationSource(Client), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Sets a database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> Update(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            var result = UpdateCore(waitUntil, data, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new SqlArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>(Response.FromValue((ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource)result.Value, result.GetRawResponse()));
            }
            var operation = new SqlArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyOperationSource(Client), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }
    }
}
