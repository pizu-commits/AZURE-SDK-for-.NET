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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel along with the instance operations that can be performed on it. </summary>
    public partial class ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, string sensitivityLabelSource)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics;
        private readonly ManagedDatabaseSensitivityLabelsRestOperations _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient;
        private readonly SensitivityLabelData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(ArmClient client, SensitivityLabelData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsApiVersion);
            _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient = new ManagedDatabaseSensitivityLabelsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/schemas/tables/columns/sensitivityLabels";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SensitivityLabelData Data
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
        /// Gets the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: ManagedDatabaseSensitivityLabels_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name.ToSensitivityLabelSource(), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: ManagedDatabaseSensitivityLabels_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name.ToSensitivityLabelSource(), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/current
        /// Operation Id: ManagedDatabaseSensitivityLabels_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.Delete");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(response);
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
        /// Deletes the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/current
        /// Operation Id: ManagedDatabaseSensitivityLabels_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.Delete");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new SqlArmOperation(response);
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
    }
}
