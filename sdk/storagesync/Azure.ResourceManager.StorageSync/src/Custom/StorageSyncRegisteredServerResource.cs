// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A Class representing a StorageSyncRegisteredServer along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StorageSyncRegisteredServerResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStorageSyncRegisteredServerResource method.
    /// Otherwise you can get one from its parent resource <see cref="StorageSyncServiceResource" /> using the GetStorageSyncRegisteredServer method.
    /// </summary>
    public partial class StorageSyncRegisteredServerResource : ArmResource
    {
        /// <summary>
        /// Update registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Body of Registered Server object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual async Task<ArmOperation<StorageSyncRegisteredServerResource>> UpdateAsync(WaitUntil waitUntil, StorageSyncRegisteredServerCreateOrUpdateContent content, CancellationToken cancellationToken = default) => await UpdateAsync(waitUntil, CreateUpdatePatchData(content), cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Body of Registered Server object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ArmOperation<StorageSyncRegisteredServerResource> Update(WaitUntil waitUntil, StorageSyncRegisteredServerCreateOrUpdateContent content, CancellationToken cancellationToken = default) => Update(waitUntil, CreateUpdatePatchData(content), cancellationToken);

        internal StorageSyncRegisteredServerPatch CreateUpdatePatchData(StorageSyncRegisteredServerCreateOrUpdateContent content)
        {
            return new StorageSyncRegisteredServerPatch(content.Id, content.Name, content.ResourceType, content.SystemData, content.ApplicationId);
        }
    }
}
