// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningVirtualMachineProperties. </summary>
    public partial class MachineLearningVirtualMachineProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningVirtualMachineProperties"/>. </summary>
        public MachineLearningVirtualMachineProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningVirtualMachineProperties"/>. </summary>
        /// <param name="virtualMachineSize"> Virtual Machine size. </param>
        /// <param name="sshPort"> Port open for ssh connections. </param>
        /// <param name="notebookServerPort"> Notebook server port open for ssh connections. </param>
        /// <param name="address"> Public IP address of the virtual machine. </param>
        /// <param name="administratorAccount"> Admin credentials for virtual machine. </param>
        /// <param name="isNotebookInstanceCompute"> Indicates whether this compute will be used for running notebooks. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningVirtualMachineProperties(string virtualMachineSize, int? sshPort, int? notebookServerPort, IPAddress address, MachineLearningVmSshCredentials administratorAccount, bool? isNotebookInstanceCompute, Dictionary<string, BinaryData> rawData)
        {
            VirtualMachineSize = virtualMachineSize;
            SshPort = sshPort;
            NotebookServerPort = notebookServerPort;
            Address = address;
            AdministratorAccount = administratorAccount;
            IsNotebookInstanceCompute = isNotebookInstanceCompute;
            _rawData = rawData;
        }

        /// <summary> Virtual Machine size. </summary>
        public string VirtualMachineSize { get; set; }
        /// <summary> Port open for ssh connections. </summary>
        public int? SshPort { get; set; }
        /// <summary> Notebook server port open for ssh connections. </summary>
        public int? NotebookServerPort { get; set; }
        /// <summary> Public IP address of the virtual machine. </summary>
        public IPAddress Address { get; set; }
        /// <summary> Admin credentials for virtual machine. </summary>
        public MachineLearningVmSshCredentials AdministratorAccount { get; set; }
        /// <summary> Indicates whether this compute will be used for running notebooks. </summary>
        public bool? IsNotebookInstanceCompute { get; set; }
    }
}
