// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AgreementsOperations.
    /// </summary>
    public static partial class AgreementsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of integration account agreements.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<IntegrationAccountAgreement> ListByIntegrationAccounts(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, ODataQuery<IntegrationAccountAgreementFilter> odataQuery = default(ODataQuery<IntegrationAccountAgreementFilter>))
            {
                return operations.ListByIntegrationAccountsAsync(resourceGroupName, integrationAccountName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration account agreements.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationAccountAgreement>> ListByIntegrationAccountsAsync(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, ODataQuery<IntegrationAccountAgreementFilter> odataQuery = default(ODataQuery<IntegrationAccountAgreementFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIntegrationAccountsWithHttpMessagesAsync(resourceGroupName, integrationAccountName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an integration account agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='agreementName'>
            /// The integration account agreement name.
            /// </param>
            public static IntegrationAccountAgreement Get(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, string agreementName)
            {
                return operations.GetAsync(resourceGroupName, integrationAccountName, agreementName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an integration account agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='agreementName'>
            /// The integration account agreement name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccountAgreement> GetAsync(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, string agreementName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, integrationAccountName, agreementName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an integration account agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='agreementName'>
            /// The integration account agreement name.
            /// </param>
            /// <param name='agreement'>
            /// The integration account agreement.
            /// </param>
            public static IntegrationAccountAgreement CreateOrUpdate(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, string agreementName, IntegrationAccountAgreement agreement)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, integrationAccountName, agreementName, agreement).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an integration account agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='agreementName'>
            /// The integration account agreement name.
            /// </param>
            /// <param name='agreement'>
            /// The integration account agreement.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccountAgreement> CreateOrUpdateAsync(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, string agreementName, IntegrationAccountAgreement agreement, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, integrationAccountName, agreementName, agreement, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an integration account agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='agreementName'>
            /// The integration account agreement name.
            /// </param>
            public static void Delete(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, string agreementName)
            {
                operations.DeleteAsync(resourceGroupName, integrationAccountName, agreementName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an integration account agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='agreementName'>
            /// The integration account agreement name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, string agreementName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, integrationAccountName, agreementName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a list of integration account agreements.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IntegrationAccountAgreement> ListByIntegrationAccountsNext(this IAgreementsOperations operations, string nextPageLink)
            {
                return operations.ListByIntegrationAccountsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration account agreements.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationAccountAgreement>> ListByIntegrationAccountsNextAsync(this IAgreementsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIntegrationAccountsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

