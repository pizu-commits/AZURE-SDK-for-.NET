// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Describes the Extension Instance View. </summary>
    public partial class HciExtensionInstanceView
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HciExtensionInstanceView"/>. </summary>
        internal HciExtensionInstanceView()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciExtensionInstanceView"/>. </summary>
        /// <param name="name"> The extension name. </param>
        /// <param name="extensionInstanceViewType"> Specifies the type of the extension; an example is "MicrosoftMonitoringAgent". </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="status"> Instance view status. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HciExtensionInstanceView(string name, string extensionInstanceViewType, string typeHandlerVersion, ExtensionInstanceViewStatus status, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ExtensionInstanceViewType = extensionInstanceViewType;
            TypeHandlerVersion = typeHandlerVersion;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> The extension name. </summary>
        public string Name { get; }
        /// <summary> Specifies the type of the extension; an example is "MicrosoftMonitoringAgent". </summary>
        public string ExtensionInstanceViewType { get; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; }
        /// <summary> Instance view status. </summary>
        public ExtensionInstanceViewStatus Status { get; }
    }
}
