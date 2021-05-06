// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Linux Java Container settings. </summary>
    public partial class LinuxJavaContainerSettings
    {
        /// <summary> Initializes a new instance of LinuxJavaContainerSettings. </summary>
        internal LinuxJavaContainerSettings()
        {
        }

        /// <summary> Initializes a new instance of LinuxJavaContainerSettings. </summary>
        /// <param name="java11Runtime"> Java 11 version (runtime only). </param>
        /// <param name="java8Runtime"> Java 8 version (runtime only). </param>
        /// <param name="isPreview"> &lt;code&gt;true&lt;/code&gt; if the stack is in preview; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isDeprecated"> &lt;code&gt;true&lt;/code&gt; if the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isHidden"> &lt;code&gt;true&lt;/code&gt; if the stack should be hidden; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="endOfLifeDate"> End-of-life date for the minor version. </param>
        /// <param name="isAutoUpdate"> &lt;code&gt;true&lt;/code&gt; if the stack version is auto-updated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isEarlyAccess"> &lt;code&gt;true&lt;/code&gt; if the minor version is early-access; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        internal LinuxJavaContainerSettings(string java11Runtime, string java8Runtime, bool? isPreview, bool? isDeprecated, bool? isHidden, DateTimeOffset? endOfLifeDate, bool? isAutoUpdate, bool? isEarlyAccess)
        {
            Java11Runtime = java11Runtime;
            Java8Runtime = java8Runtime;
            IsPreview = isPreview;
            IsDeprecated = isDeprecated;
            IsHidden = isHidden;
            EndOfLifeDate = endOfLifeDate;
            IsAutoUpdate = isAutoUpdate;
            IsEarlyAccess = isEarlyAccess;
        }

        /// <summary> Java 11 version (runtime only). </summary>
        public string Java11Runtime { get; }
        /// <summary> Java 8 version (runtime only). </summary>
        public string Java8Runtime { get; }
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
