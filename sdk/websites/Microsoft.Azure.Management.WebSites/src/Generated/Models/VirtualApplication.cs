// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Virtual application in an app. </summary>
    public partial class VirtualApplication
    {
        /// <summary> Initializes a new instance of VirtualApplication. </summary>
        public VirtualApplication()
        {
            VirtualDirectories = new ChangeTrackingList<VirtualDirectory>();
        }

        /// <summary> Initializes a new instance of VirtualApplication. </summary>
        /// <param name="virtualPath"> Virtual path. </param>
        /// <param name="physicalPath"> Physical path. </param>
        /// <param name="preloadEnabled"> &lt;code&gt;true&lt;/code&gt; if preloading is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="virtualDirectories"> Virtual directories for virtual application. </param>
        internal VirtualApplication(string virtualPath, string physicalPath, bool? preloadEnabled, IList<VirtualDirectory> virtualDirectories)
        {
            VirtualPath = virtualPath;
            PhysicalPath = physicalPath;
            PreloadEnabled = preloadEnabled;
            VirtualDirectories = virtualDirectories;
        }

        /// <summary> Virtual path. </summary>
        public string VirtualPath { get; set; }
        /// <summary> Physical path. </summary>
        public string PhysicalPath { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if preloading is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? PreloadEnabled { get; set; }
        /// <summary> Virtual directories for virtual application. </summary>
        public IList<VirtualDirectory> VirtualDirectories { get; }
    }
}
