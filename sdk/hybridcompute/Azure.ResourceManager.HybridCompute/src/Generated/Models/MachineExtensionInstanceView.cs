// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes the Machine Extension Instance View. </summary>
    public partial class MachineExtensionInstanceView
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineExtensionInstanceView"/>. </summary>
        public MachineExtensionInstanceView()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineExtensionInstanceView"/>. </summary>
        /// <param name="name"> The machine extension name. </param>
        /// <param name="machineExtensionInstanceViewType"> Specifies the type of the extension; an example is "CustomScriptExtension". </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="status"> Instance view status. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineExtensionInstanceView(string name, string machineExtensionInstanceViewType, string typeHandlerVersion, MachineExtensionInstanceViewStatus status, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            MachineExtensionInstanceViewType = machineExtensionInstanceViewType;
            TypeHandlerVersion = typeHandlerVersion;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> The machine extension name. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the type of the extension; an example is "CustomScriptExtension". </summary>
        public string MachineExtensionInstanceViewType { get; set; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; set; }
        /// <summary> Instance view status. </summary>
        public MachineExtensionInstanceViewStatus Status { get; set; }
    }
}
