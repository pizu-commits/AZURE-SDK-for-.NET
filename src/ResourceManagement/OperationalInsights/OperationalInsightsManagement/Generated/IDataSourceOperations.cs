// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.OperationalInsights.Models;

namespace Microsoft.Azure.Management.OperationalInsights
{
    /// <summary>
    /// Operations for managing DataSources under Workspaces.
    /// </summary>
    public partial interface IDataSourceOperations
    {
        /// <summary>
        /// Create or update a datasource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the datasource.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the parent workspace that will contain the datasource
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a datasource.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update workspace operation response.
        /// </returns>
        Task<DataSourceCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string workspaceName, DataSourceCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a datasource instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the datasource.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace that contains the datasource.
        /// </param>
        /// <param name='datasourceName'>
        /// The name of the datasource.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string workspaceName, string datasourceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets a dataSource instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the dataSource.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace that contains the dataSource.
        /// </param>
        /// <param name='dataSourceName'>
        /// The name of the dataSource
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The get workspace operation response.
        /// </returns>
        Task<DataSourceGetResponse> GetAsync(string resourceGroupName, string workspaceName, string dataSourceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the first page of dataSource instances in a workspace with the
        /// link to the next page.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the dataSources.
        /// </param>
        /// <param name='workspaceName'>
        /// The workspace that contains the dataSources.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list workspaces operation response.
        /// </returns>
        Task<DataSourceListResponse> ListInWorkspaceAsync(string resourceGroupName, string workspaceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of dataSource instances with the link to the
        /// next page.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next dataSource page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list workspaces operation response.
        /// </returns>
        Task<DataSourceListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
    }
}
