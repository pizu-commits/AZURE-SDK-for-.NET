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
using Microsoft.WindowsAzure.Management.RecoveryServicesVaultUpgrade;
using Microsoft.WindowsAzure.Management.RecoveryServicesVaultUpgrade.Models;

namespace Microsoft.WindowsAzure.Management.RecoveryServicesVaultUpgrade
{
    public static partial class RecoveryServicesVaultUpgradeOperationsExtensions
    {
        /// <summary>
        /// Check Prerequisites for Vault Upgrade.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServicesVaultUpgrade.IRecoveryServicesVaultUpgradeOperations.
        /// </param>
        /// <param name='resourceUpgradeInput'>
        /// Required. Input required for the resource to be upgraded.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the Azure operations.
        /// </returns>
        public static AzureResponse CheckPrerequisitesForRecoveryServicesVaultUpgrade(this IRecoveryServicesVaultUpgradeOperations operations, ResourceUpgradeInput resourceUpgradeInput, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryServicesVaultUpgradeOperations)s).CheckPrerequisitesForRecoveryServicesVaultUpgradeAsync(resourceUpgradeInput, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Check Prerequisites for Vault Upgrade.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServicesVaultUpgrade.IRecoveryServicesVaultUpgradeOperations.
        /// </param>
        /// <param name='resourceUpgradeInput'>
        /// Required. Input required for the resource to be upgraded.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the Azure operations.
        /// </returns>
        public static Task<AzureResponse> CheckPrerequisitesForRecoveryServicesVaultUpgradeAsync(this IRecoveryServicesVaultUpgradeOperations operations, ResourceUpgradeInput resourceUpgradeInput, CustomRequestHeaders customRequestHeaders)
        {
            return operations.CheckPrerequisitesForRecoveryServicesVaultUpgradeAsync(resourceUpgradeInput, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Track Resource Upgrade.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServicesVaultUpgrade.IRecoveryServicesVaultUpgradeOperations.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of an output object stating the status of resource
        /// upgrade.
        /// </returns>
        public static TrackResourceUpgradeResponse TrackResourceUpgrade(this IRecoveryServicesVaultUpgradeOperations operations, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryServicesVaultUpgradeOperations)s).TrackResourceUpgradeAsync(customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Track Resource Upgrade.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServicesVaultUpgrade.IRecoveryServicesVaultUpgradeOperations.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of an output object stating the status of resource
        /// upgrade.
        /// </returns>
        public static Task<TrackResourceUpgradeResponse> TrackResourceUpgradeAsync(this IRecoveryServicesVaultUpgradeOperations operations, CustomRequestHeaders customRequestHeaders)
        {
            return operations.TrackResourceUpgradeAsync(customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Start Resource Upgrade.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServicesVaultUpgrade.IRecoveryServicesVaultUpgradeOperations.
        /// </param>
        /// <param name='resourceUpgradeInput'>
        /// Required. Input required for resource upgradation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a resource upgrade output object.
        /// </returns>
        public static ResourceUpgradeDetails UpgradeResource(this IRecoveryServicesVaultUpgradeOperations operations, ResourceUpgradeInput resourceUpgradeInput, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryServicesVaultUpgradeOperations)s).UpgradeResourceAsync(resourceUpgradeInput, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Start Resource Upgrade.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServicesVaultUpgrade.IRecoveryServicesVaultUpgradeOperations.
        /// </param>
        /// <param name='resourceUpgradeInput'>
        /// Required. Input required for resource upgradation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a resource upgrade output object.
        /// </returns>
        public static Task<ResourceUpgradeDetails> UpgradeResourceAsync(this IRecoveryServicesVaultUpgradeOperations operations, ResourceUpgradeInput resourceUpgradeInput, CustomRequestHeaders customRequestHeaders)
        {
            return operations.UpgradeResourceAsync(resourceUpgradeInput, customRequestHeaders, CancellationToken.None);
        }
    }
}
