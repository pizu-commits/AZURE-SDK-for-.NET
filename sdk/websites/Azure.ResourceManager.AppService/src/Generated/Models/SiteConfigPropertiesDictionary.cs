// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Site config properties dictionary. </summary>
    public partial class SiteConfigPropertiesDictionary
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteConfigPropertiesDictionary"/>. </summary>
        internal SiteConfigPropertiesDictionary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteConfigPropertiesDictionary"/>. </summary>
        /// <param name="use32BitWorkerProcess"> &lt;code&gt;true&lt;/code&gt; if use32BitWorkerProcess should be set to true for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="linuxFxVersion"> LinuxFxVersion configuration setting. </param>
        /// <param name="javaVersion"> JavaVersion configuration setting. </param>
        /// <param name="powerShellVersion"> PowerShellVersion configuration setting. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteConfigPropertiesDictionary(bool? use32BitWorkerProcess, string linuxFxVersion, string javaVersion, string powerShellVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Use32BitWorkerProcess = use32BitWorkerProcess;
            LinuxFxVersion = linuxFxVersion;
            JavaVersion = javaVersion;
            PowerShellVersion = powerShellVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; if use32BitWorkerProcess should be set to true for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? Use32BitWorkerProcess { get; }
        /// <summary> LinuxFxVersion configuration setting. </summary>
        public string LinuxFxVersion { get; }
        /// <summary> JavaVersion configuration setting. </summary>
        public string JavaVersion { get; }
        /// <summary> PowerShellVersion configuration setting. </summary>
        public string PowerShellVersion { get; }
    }
}
