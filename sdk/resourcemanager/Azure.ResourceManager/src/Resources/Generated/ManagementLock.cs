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

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a ManagementLock along with the instance operations that can be performed on it. </summary>
    public partial class ManagementLock : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagementLock"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string lockName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Authorization/locks/{lockName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managementLockClientDiagnostics;
        private readonly ManagementLocksRestOperations _managementLockRestClient;
        private readonly ManagementLockData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagementLock"/> class for mocking. </summary>
        protected ManagementLock()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagementLock"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagementLock(ArmClient client, ManagementLockData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementLock"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagementLock(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managementLockClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string managementLockApiVersion);
            _managementLockRestClient = new ManagementLocksRestOperations(_managementLockClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managementLockApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/locks";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagementLockData Data
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

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// ContextualPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// OperationId: ManagementLocks_GetByScope
        /// <summary> Get a management lock by scope. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagementLock>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLock.Get");
            scope.Start();
            try
            {
                var response = await _managementLockRestClient.GetByScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managementLockClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagementLock(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// ContextualPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// OperationId: ManagementLocks_GetByScope
        /// <summary> Get a management lock by scope. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagementLock> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLock.Get");
            scope.Start();
            try
            {
                var response = _managementLockRestClient.GetByScope(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _managementLockClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementLock(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// ContextualPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// OperationId: ManagementLocks_DeleteByScope
        /// <summary> Delete a management lock by scope. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLock.Delete");
            scope.Start();
            try
            {
                var response = await _managementLockRestClient.DeleteByScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// ContextualPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// OperationId: ManagementLocks_DeleteByScope
        /// <summary> Delete a management lock by scope. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLock.Delete");
            scope.Start();
            try
            {
                var response = _managementLockRestClient.DeleteByScope(Id.Parent, Id.Name, cancellationToken);
                var operation = new ResourcesArmOperation(response);
                if (waitForCompletion)
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
