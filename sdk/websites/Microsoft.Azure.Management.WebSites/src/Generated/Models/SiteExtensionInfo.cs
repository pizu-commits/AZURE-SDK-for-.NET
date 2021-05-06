// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Site Extension Information. </summary>
    public partial class SiteExtensionInfo : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SiteExtensionInfo. </summary>
        public SiteExtensionInfo()
        {
            Authors = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SiteExtensionInfo. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="extensionId"> Site extension ID. </param>
        /// <param name="title"> . </param>
        /// <param name="extensionType"> Site extension type. </param>
        /// <param name="summary"> Summary description. </param>
        /// <param name="description"> Detailed description. </param>
        /// <param name="version"> Version information. </param>
        /// <param name="extensionUrl"> Extension URL. </param>
        /// <param name="projectUrl"> Project URL. </param>
        /// <param name="iconUrl"> Icon URL. </param>
        /// <param name="licenseUrl"> License URL. </param>
        /// <param name="feedUrl"> Feed URL. </param>
        /// <param name="authors"> List of authors. </param>
        /// <param name="installerCommandLineParams"> Installer command line parameters. </param>
        /// <param name="publishedDateTime"> Published timestamp. </param>
        /// <param name="downloadCount"> Count of downloads. </param>
        /// <param name="localIsLatestVersion"> &lt;code&gt;true&lt;/code&gt; if the local version is the latest version; &lt;code&gt;false&lt;/code&gt; otherwise. </param>
        /// <param name="localPath"> Local path. </param>
        /// <param name="installedDateTime"> Installed timestamp. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="comment"> Site Extension comment. </param>
        internal SiteExtensionInfo(string id, string name, string kind, string type, string extensionId, string title, SiteExtensionType? extensionType, string summary, string description, string version, string extensionUrl, string projectUrl, string iconUrl, string licenseUrl, string feedUrl, IList<string> authors, string installerCommandLineParams, DateTimeOffset? publishedDateTime, int? downloadCount, bool? localIsLatestVersion, string localPath, DateTimeOffset? installedDateTime, string provisioningState, string comment) : base(id, name, kind, type)
        {
            ExtensionId = extensionId;
            Title = title;
            ExtensionType = extensionType;
            Summary = summary;
            Description = description;
            Version = version;
            ExtensionUrl = extensionUrl;
            ProjectUrl = projectUrl;
            IconUrl = iconUrl;
            LicenseUrl = licenseUrl;
            FeedUrl = feedUrl;
            Authors = authors;
            InstallerCommandLineParams = installerCommandLineParams;
            PublishedDateTime = publishedDateTime;
            DownloadCount = downloadCount;
            LocalIsLatestVersion = localIsLatestVersion;
            LocalPath = localPath;
            InstalledDateTime = installedDateTime;
            ProvisioningState = provisioningState;
            Comment = comment;
        }

        /// <summary> Site extension ID. </summary>
        public string ExtensionId { get; set; }
        public string Title { get; set; }
        /// <summary> Site extension type. </summary>
        public SiteExtensionType? ExtensionType { get; set; }
        /// <summary> Summary description. </summary>
        public string Summary { get; set; }
        /// <summary> Detailed description. </summary>
        public string Description { get; set; }
        /// <summary> Version information. </summary>
        public string Version { get; set; }
        /// <summary> Extension URL. </summary>
        public string ExtensionUrl { get; set; }
        /// <summary> Project URL. </summary>
        public string ProjectUrl { get; set; }
        /// <summary> Icon URL. </summary>
        public string IconUrl { get; set; }
        /// <summary> License URL. </summary>
        public string LicenseUrl { get; set; }
        /// <summary> Feed URL. </summary>
        public string FeedUrl { get; set; }
        /// <summary> List of authors. </summary>
        public IList<string> Authors { get; }
        /// <summary> Installer command line parameters. </summary>
        public string InstallerCommandLineParams { get; set; }
        /// <summary> Published timestamp. </summary>
        public DateTimeOffset? PublishedDateTime { get; set; }
        /// <summary> Count of downloads. </summary>
        public int? DownloadCount { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the local version is the latest version; &lt;code&gt;false&lt;/code&gt; otherwise. </summary>
        public bool? LocalIsLatestVersion { get; set; }
        /// <summary> Local path. </summary>
        public string LocalPath { get; set; }
        /// <summary> Installed timestamp. </summary>
        public DateTimeOffset? InstalledDateTime { get; set; }
        /// <summary> Provisioning state. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> Site Extension comment. </summary>
        public string Comment { get; set; }
    }
}
