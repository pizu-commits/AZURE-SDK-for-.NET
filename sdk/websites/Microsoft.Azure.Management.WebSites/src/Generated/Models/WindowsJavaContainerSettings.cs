// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Windows Java Container settings. </summary>
    public partial class WindowsJavaContainerSettings
    {
        /// <summary> Initializes a new instance of WindowsJavaContainerSettings. </summary>
        internal WindowsJavaContainerSettings()
        {
        }

        /// <summary> Initializes a new instance of WindowsJavaContainerSettings. </summary>
        /// <param name="javaContainer"> Java container (runtime only). </param>
        /// <param name="javaContainerVersion"> Java container version (runtime only). </param>
        /// <param name="isPreview"> &lt;code&gt;true&lt;/code&gt; if the stack is in preview; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isDeprecated"> &lt;code&gt;true&lt;/code&gt; if the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isHidden"> &lt;code&gt;true&lt;/code&gt; if the stack should be hidden; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="endOfLifeDate"> End-of-life date for the minor version. </param>
        /// <param name="isAutoUpdate"> &lt;code&gt;true&lt;/code&gt; if the stack version is auto-updated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isEarlyAccess"> &lt;code&gt;true&lt;/code&gt; if the minor version is early-access; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        internal WindowsJavaContainerSettings(string javaContainer, string javaContainerVersion, bool? isPreview, bool? isDeprecated, bool? isHidden, DateTimeOffset? endOfLifeDate, bool? isAutoUpdate, bool? isEarlyAccess)
        {
            JavaContainer = javaContainer;
            JavaContainerVersion = javaContainerVersion;
            IsPreview = isPreview;
            IsDeprecated = isDeprecated;
            IsHidden = isHidden;
            EndOfLifeDate = endOfLifeDate;
            IsAutoUpdate = isAutoUpdate;
            IsEarlyAccess = isEarlyAccess;
        }

        /// <summary> Java container (runtime only). </summary>
        public string JavaContainer { get; }
        /// <summary> Java container version (runtime only). </summary>
        public string JavaContainerVersion { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack is in preview; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsPreview { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDeprecated { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack should be hidden; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsHidden { get; }
        /// <summary> End-of-life date for the minor version. </summary>
        public DateTimeOffset? EndOfLifeDate { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack version is auto-updated; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsAutoUpdate { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the minor version is early-access; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsEarlyAccess { get; }
    }
}
