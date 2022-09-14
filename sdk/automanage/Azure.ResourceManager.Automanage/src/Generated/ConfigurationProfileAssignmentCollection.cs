// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing a collection of <see cref="ConfigurationProfileAssignmentResource" /> and their operations.
    /// Each <see cref="ConfigurationProfileAssignmentResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="ConfigurationProfileAssignmentCollection" /> instance call the GetConfigurationProfileAssignments method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class ConfigurationProfileAssignmentCollection : ArmCollection, IEnumerable<ConfigurationProfileAssignmentResource>, IAsyncEnumerable<ConfigurationProfileAssignmentResource>
    {
        private readonly ClientDiagnostics _configurationProfileAssignmentClientDiagnostics;
        private readonly ConfigurationProfileAssignmentsRestOperations _configurationProfileAssignmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConfigurationProfileAssignmentCollection"/> class for mocking. </summary>
        protected ConfigurationProfileAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConfigurationProfileAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConfigurationProfileAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _configurationProfileAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", ConfigurationProfileAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ConfigurationProfileAssignmentResource.ResourceType, out string configurationProfileAssignmentApiVersion);
            _configurationProfileAssignmentRestClient = new ConfigurationProfileAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, configurationProfileAssignmentApiVersion);
        }

        /// <summary>
        /// Creates an association between a VM and Automanage configuration profile
        /// Request Path: /{scope}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}
        /// Operation Id: ConfigurationProfileAssignments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationProfileAssignmentName"> Name of the configuration profile assignment. Only default is supported. </param>
        /// <param name="data"> Parameters supplied to the create or update configuration profile assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ConfigurationProfileAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationProfileAssignmentName, ConfigurationProfileAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _configurationProfileAssignmentRestClient.CreateOrUpdateAsync(Id, configurationProfileAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AutomanageArmOperation<ConfigurationProfileAssignmentResource>(Response.FromValue(new ConfigurationProfileAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Creates an association between a VM and Automanage configuration profile
        /// Request Path: /{scope}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}
        /// Operation Id: ConfigurationProfileAssignments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationProfileAssignmentName"> Name of the configuration profile assignment. Only default is supported. </param>
        /// <param name="data"> Parameters supplied to the create or update configuration profile assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ConfigurationProfileAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string configurationProfileAssignmentName, ConfigurationProfileAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _configurationProfileAssignmentRestClient.CreateOrUpdate(Id, configurationProfileAssignmentName, data, cancellationToken);
                var operation = new AutomanageArmOperation<ConfigurationProfileAssignmentResource>(Response.FromValue(new ConfigurationProfileAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Get information about a configuration profile assignment
        /// Request Path: /{scope}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}
        /// Operation Id: ConfigurationProfileAssignments_Get
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual async Task<Response<ConfigurationProfileAssignmentResource>> GetAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _configurationProfileAssignmentRestClient.GetAsync(Id, configurationProfileAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a configuration profile assignment
        /// Request Path: /{scope}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}
        /// Operation Id: ConfigurationProfileAssignments_Get
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual Response<ConfigurationProfileAssignmentResource> Get(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _configurationProfileAssignmentRestClient.Get(Id, configurationProfileAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of configuration profile assignments
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments
        /// Operation Id: ConfigurationProfileAssignments_ListByVirtualMachines
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfileAssignments
        /// Operation Id: ConfigurationProfileAssignments_List
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automanage/configurationProfileAssignments
        /// Operation Id: ConfigurationProfileAssignments_ListBySubscription
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments
        /// Operation Id: ConfigurationProfileAssignments_ListByMachineName
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments
        /// Operation Id: ConfigurationProfileAssignments_ListByClusterName
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigurationProfileAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfigurationProfileAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == "Microsoft.Compute/virtualMachines")
            {
                async Task<Page<ConfigurationProfileAssignmentResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _configurationProfileAssignmentRestClient.ListByVirtualMachinesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileAssignmentResource(Client, value)), null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
            }
            else if (Id.ResourceType == ResourceGroupResource.ResourceType)
            {
                async Task<Page<ConfigurationProfileAssignmentResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _configurationProfileAssignmentRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileAssignmentResource(Client, value)), null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                async Task<Page<ConfigurationProfileAssignmentResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _configurationProfileAssignmentRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileAssignmentResource(Client, value)), null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
            }
            else if (Id.ResourceType == "Microsoft.HybridCompute/machines")
            {
                async Task<Page<ConfigurationProfileAssignmentResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _configurationProfileAssignmentRestClient.ListByMachineNameAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileAssignmentResource(Client, value)), null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
            }
            else if (Id.ResourceType == "Microsoft.AzureStackHci/clusters")
            {
                async Task<Page<ConfigurationProfileAssignmentResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _configurationProfileAssignmentRestClient.ListByClusterNameAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileAssignmentResource(Client, value)), null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
            }
            else
            {
                throw new InvalidOperationException($"{Id.ResourceType} is not supported here");
            }
        }

        /// <summary>
        /// Get list of configuration profile assignments
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments
        /// Operation Id: ConfigurationProfileAssignments_ListByVirtualMachines
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfileAssignments
        /// Operation Id: ConfigurationProfileAssignments_List
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automanage/configurationProfileAssignments
        /// Operation Id: ConfigurationProfileAssignments_ListBySubscription
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments
        /// Operation Id: ConfigurationProfileAssignments_ListByMachineName
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments
        /// Operation Id: ConfigurationProfileAssignments_ListByClusterName
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigurationProfileAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfigurationProfileAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == "Microsoft.Compute/virtualMachines")
            {
                Page<ConfigurationProfileAssignmentResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _configurationProfileAssignmentRestClient.ListByVirtualMachines(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileAssignmentResource(Client, value)), null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
            }
            else if (Id.ResourceType == ResourceGroupResource.ResourceType)
            {
                Page<ConfigurationProfileAssignmentResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _configurationProfileAssignmentRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileAssignmentResource(Client, value)), null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                Page<ConfigurationProfileAssignmentResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _configurationProfileAssignmentRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileAssignmentResource(Client, value)), null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
            }
            else if (Id.ResourceType == "Microsoft.HybridCompute/machines")
            {
                Page<ConfigurationProfileAssignmentResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _configurationProfileAssignmentRestClient.ListByMachineName(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileAssignmentResource(Client, value)), null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
            }
            else if (Id.ResourceType == "Microsoft.AzureStackHci/clusters")
            {
                Page<ConfigurationProfileAssignmentResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _configurationProfileAssignmentRestClient.ListByClusterName(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileAssignmentResource(Client, value)), null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
            }
            else
            {
                throw new InvalidOperationException($"{Id.ResourceType} is not supported here");
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{scope}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}
        /// Operation Id: ConfigurationProfileAssignments_Get
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _configurationProfileAssignmentRestClient.GetAsync(Id, configurationProfileAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /{scope}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}
        /// Operation Id: ConfigurationProfileAssignments_Get
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _configurationProfileAssignmentClientDiagnostics.CreateScope("ConfigurationProfileAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _configurationProfileAssignmentRestClient.Get(Id, configurationProfileAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConfigurationProfileAssignmentResource> IEnumerable<ConfigurationProfileAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConfigurationProfileAssignmentResource> IAsyncEnumerable<ConfigurationProfileAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
