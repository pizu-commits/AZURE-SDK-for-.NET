// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevBoxPool
    {
        /// <summary> Initializes a new instance of <see cref="DevBoxPool"/>. </summary>
        /// <param name="name"> Pool name. </param>
        /// <param name="location"> Azure region where Dev Boxes in the pool are located. </param>
        /// <param name="osType"> The operating system type of Dev Boxes in this pool. </param>
        /// <param name="hardwareProfile"> Hardware settings for the Dev Boxes created in this pool. </param>
        /// <param name="hibernateSupport"> Indicates whether hibernate is enabled/disabled or unknown. </param>
        /// <param name="storageProfile"> Storage settings for Dev Box created in this pool. </param>
        /// <param name="imageReference"> Image settings for Dev Boxes create in this pool. </param>
        /// <param name="localAdministratorStatus">
        /// Indicates whether owners of Dev Boxes in this pool are local administrators on
        /// the Dev Boxes.
        /// </param>
        /// <param name="stopOnDisconnect"> Stop on disconnect configuration settings for Dev Boxes created in this pool. </param>
        /// <param name="healthStatus">
        /// Overall health status of the Pool. Indicates whether or not the Pool is
        /// available to create Dev Boxes.
        /// </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal DevBoxPool(string name, AzureLocation location, DevBoxOSType? osType, DevBoxHardwareProfile hardwareProfile, HibernateSupport? hibernateSupport, DevBoxStorageProfile storageProfile, DevBoxImageReference imageReference, LocalAdministratorStatus? localAdministratorStatus, StopOnDisconnectConfiguration stopOnDisconnect, PoolHealthStatus healthStatus)
        {
            Name = name;
            Location = location;
            OSType = osType;
            HardwareProfile = hardwareProfile;
            HibernateSupport = hibernateSupport;
            StorageProfile = storageProfile;
            ImageReference = imageReference;
            LocalAdministratorStatus = localAdministratorStatus;
            StopOnDisconnect = stopOnDisconnect;
            HealthStatus = healthStatus;
        }
    }
}
