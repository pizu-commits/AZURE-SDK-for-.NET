// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TenantConfigurationOperations.
    /// </summary>
    public static partial class TenantConfigurationOperationsExtensions
    {
            /// <summary>
            /// This operation applies changes from the specified Git branch to the
            /// configuration database. This is a long running operation and could take
            /// several minutes to complete.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-configuration-repository-git/#to-deploy-any-service-configuration-changes-to-the-api-management-service-instance" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Deploy Configuration parameters.
            /// </param>
            public static OperationResultContract Deploy(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, DeployConfigurationParameters parameters)
            {
                return operations.DeployAsync(resourceGroupName, serviceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation applies changes from the specified Git branch to the
            /// configuration database. This is a long running operation and could take
            /// several minutes to complete.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-configuration-repository-git/#to-deploy-any-service-configuration-changes-to-the-api-management-service-instance" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Deploy Configuration parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationResultContract> DeployAsync(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeployWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation creates a commit with the current configuration snapshot to
            /// the specified branch in the repository. This is a long running operation
            /// and could take several minutes to complete.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-configuration-repository-git/#to-save-the-service-configuration-to-the-git-repository" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Save Configuration parameters.
            /// </param>
            public static OperationResultContract Save(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, SaveConfigurationParameter parameters)
            {
                return operations.SaveAsync(resourceGroupName, serviceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation creates a commit with the current configuration snapshot to
            /// the specified branch in the repository. This is a long running operation
            /// and could take several minutes to complete.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-configuration-repository-git/#to-save-the-service-configuration-to-the-git-repository" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Save Configuration parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationResultContract> SaveAsync(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, SaveConfigurationParameter parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SaveWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation validates the changes in the specified Git branch. This is a
            /// long running operation and could take several minutes to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Validate Configuration parameters.
            /// </param>
            public static OperationResultContract Validate(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, DeployConfigurationParameters parameters)
            {
                return operations.ValidateAsync(resourceGroupName, serviceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation validates the changes in the specified Git branch. This is a
            /// long running operation and could take several minutes to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Validate Configuration parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationResultContract> ValidateAsync(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the status of the most recent synchronization between the
            /// configuration database and the Git repository.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static TenantConfigurationSyncStateContract GetSyncState(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.GetSyncStateAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the status of the most recent synchronization between the
            /// configuration database and the Git repository.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TenantConfigurationSyncStateContract> GetSyncStateAsync(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSyncStateWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation applies changes from the specified Git branch to the
            /// configuration database. This is a long running operation and could take
            /// several minutes to complete.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-configuration-repository-git/#to-deploy-any-service-configuration-changes-to-the-api-management-service-instance" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Deploy Configuration parameters.
            /// </param>
            public static OperationResultContract BeginDeploy(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, DeployConfigurationParameters parameters)
            {
                return operations.BeginDeployAsync(resourceGroupName, serviceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation applies changes from the specified Git branch to the
            /// configuration database. This is a long running operation and could take
            /// several minutes to complete.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-configuration-repository-git/#to-deploy-any-service-configuration-changes-to-the-api-management-service-instance" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Deploy Configuration parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationResultContract> BeginDeployAsync(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeployWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation creates a commit with the current configuration snapshot to
            /// the specified branch in the repository. This is a long running operation
            /// and could take several minutes to complete.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-configuration-repository-git/#to-save-the-service-configuration-to-the-git-repository" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Save Configuration parameters.
            /// </param>
            public static OperationResultContract BeginSave(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, SaveConfigurationParameter parameters)
            {
                return operations.BeginSaveAsync(resourceGroupName, serviceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation creates a commit with the current configuration snapshot to
            /// the specified branch in the repository. This is a long running operation
            /// and could take several minutes to complete.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-configuration-repository-git/#to-save-the-service-configuration-to-the-git-repository" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Save Configuration parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationResultContract> BeginSaveAsync(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, SaveConfigurationParameter parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginSaveWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation validates the changes in the specified Git branch. This is a
            /// long running operation and could take several minutes to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Validate Configuration parameters.
            /// </param>
            public static OperationResultContract BeginValidate(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, DeployConfigurationParameters parameters)
            {
                return operations.BeginValidateAsync(resourceGroupName, serviceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation validates the changes in the specified Git branch. This is a
            /// long running operation and could take several minutes to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Validate Configuration parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationResultContract> BeginValidateAsync(this ITenantConfigurationOperations operations, string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginValidateWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
