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

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A Class representing a RoleAssignmentScheduleRequest along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="RoleAssignmentScheduleRequestResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetRoleAssignmentScheduleRequestResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetRoleAssignmentScheduleRequest method.
    /// </summary>
    public partial class RoleAssignmentScheduleRequestResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RoleAssignmentScheduleRequestResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="roleAssignmentScheduleRequestName"> The roleAssignmentScheduleRequestName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string roleAssignmentScheduleRequestName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _roleAssignmentScheduleRequestClientDiagnostics;
        private readonly RoleAssignmentScheduleRequestsRestOperations _roleAssignmentScheduleRequestRestClient;
        private readonly RoleAssignmentScheduleRequestData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/roleAssignmentScheduleRequests";

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleRequestResource"/> class for mocking. </summary>
        protected RoleAssignmentScheduleRequestResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleRequestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RoleAssignmentScheduleRequestResource(ArmClient client, RoleAssignmentScheduleRequestData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleRequestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RoleAssignmentScheduleRequestResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleAssignmentScheduleRequestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string roleAssignmentScheduleRequestApiVersion);
            _roleAssignmentScheduleRequestRestClient = new RoleAssignmentScheduleRequestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleAssignmentScheduleRequestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RoleAssignmentScheduleRequestData Data
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
        /// Get the specified role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleAssignmentScheduleRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RoleAssignmentScheduleRequestResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestResource.Get");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleAssignmentScheduleRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RoleAssignmentScheduleRequestResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestResource.Get");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleAssignmentScheduleRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the role assignment schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RoleAssignmentScheduleRequestResource>> UpdateAsync(WaitUntil waitUntil, RoleAssignmentScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestResource.Update");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestRestClient.CreateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AuthorizationArmOperation<RoleAssignmentScheduleRequestResource>(Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response), response.GetRawResponse()));
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
        /// Creates a role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleAssignmentScheduleRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the role assignment schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RoleAssignmentScheduleRequestResource> Update(WaitUntil waitUntil, RoleAssignmentScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestResource.Update");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestRestClient.Create(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new AuthorizationArmOperation<RoleAssignmentScheduleRequestResource>(Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response), response.GetRawResponse()));
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
        /// Cancels a pending role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Cancel</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleAssignmentScheduleRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestResource.Cancel");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestRestClient.CancelAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a pending role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Cancel</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleAssignmentScheduleRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Cancel(CancellationToken cancellationToken = default)
        {
            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestResource.Cancel");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestRestClient.Cancel(Id.Parent, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validates a new role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Validate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleAssignmentScheduleRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Parameters for the role assignment schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<RoleAssignmentScheduleRequestResource>> ValidateAsync(RoleAssignmentScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestResource.Validate");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestRestClient.ValidateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validates a new role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Validate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleAssignmentScheduleRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Parameters for the role assignment schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<RoleAssignmentScheduleRequestResource> Validate(RoleAssignmentScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestResource.Validate");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestRestClient.Validate(Id.Parent, Id.Name, data, cancellationToken);
                return Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
