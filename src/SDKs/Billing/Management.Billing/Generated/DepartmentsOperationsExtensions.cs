// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DepartmentsOperations.
    /// </summary>
    public static partial class DepartmentsOperationsExtensions
    {
            /// <summary>
            /// Get the department by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='departmentName'>
            /// Department Id.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the enrollmentAccounts.
            /// </param>
            /// <param name='filter'>
            /// The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not
            /// currently support 'ne', 'or', or 'not'. Tag filter is a key value pair
            /// string where key and value is separated by a colon (:).
            /// </param>
            public static Department Get(this IDepartmentsOperations operations, string billingAccountName, string departmentName, string expand = default(string), string filter = default(string))
            {
                return operations.GetAsync(billingAccountName, departmentName, expand, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the department by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='departmentName'>
            /// Department Id.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the enrollmentAccounts.
            /// </param>
            /// <param name='filter'>
            /// The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not
            /// currently support 'ne', 'or', or 'not'. Tag filter is a key value pair
            /// string where key and value is separated by a colon (:).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Department> GetAsync(this IDepartmentsOperations operations, string billingAccountName, string departmentName, string expand = default(string), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, departmentName, expand, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
