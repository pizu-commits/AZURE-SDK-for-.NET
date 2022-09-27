// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Replication provider specific settings.
    /// Please note <see cref="ConfigurationSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="HyperVVirtualMachineDetails"/>, <see cref="ReplicationGroupDetails"/>, <see cref="VMwareVirtualMachineDetails"/> and <see cref="VmmVirtualMachineDetails"/>.
    /// </summary>
    public abstract partial class ConfigurationSettings
    {
        /// <summary> Initializes a new instance of ConfigurationSettings. </summary>
        protected ConfigurationSettings()
        {
        }

        /// <summary> Initializes a new instance of ConfigurationSettings. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal ConfigurationSettings(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets the class type. Overridden in derived classes. </summary>
        internal string InstanceType { get; set; }
    }
}
