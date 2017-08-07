// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Billing;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// InvoicesOperations operations.
    /// </summary>
    public partial interface IInvoicesOperations
    {
        /// <summary>
        /// Lists the available invoices for a subscription in reverse
        /// chronological order beginning with the most recent invoice. In
        /// preview, invoices are available via this API only for invoice
        /// periods which end December 1, 2016 or later.
        /// <see href="https://go.microsoft.com/fwlink/?linkid=842057" />
        /// </summary>
        /// <param name='expand'>
        /// May be used to expand the downloadUrl property within a list of
        /// invoices. This enables download links to be generated for multiple
        /// invoices at once. By default, downloadURLs are not included when
        /// listing invoices.
        /// </param>
        /// <param name='filter'>
        /// May be used to filter invoices by invoicePeriodEndDate. The filter
        /// supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not
        /// currently support 'ne', 'or', or 'not'.
        /// </param>
        /// <param name='skiptoken'>
        /// Skiptoken is only used if a previous operation returned a partial
        /// result. If a previous response contains a nextLink element, the
        /// value of the nextLink element will include a skiptoken parameter
        /// that specifies a starting point to use for subsequent calls.
        /// </param>
        /// <param name='top'>
        /// May be used to limit the number of results to the most recent N
        /// invoices.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<InvoiceInner>>> ListWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string skiptoken = default(string), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a named invoice resource. When getting a single invoice, the
        /// downloadUrl property is expanded automatically.
        /// </summary>
        /// <param name='invoiceName'>
        /// The name of an invoice resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<InvoiceInner>> GetWithHttpMessagesAsync(string invoiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the most recent invoice. When getting a single invoice, the
        /// downloadUrl property is expanded automatically.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<InvoiceInner>> GetLatestWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the available invoices for a subscription in reverse
        /// chronological order beginning with the most recent invoice. In
        /// preview, invoices are available via this API only for invoice
        /// periods which end December 1, 2016 or later.
        /// <see href="https://go.microsoft.com/fwlink/?linkid=842057" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<InvoiceInner>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
