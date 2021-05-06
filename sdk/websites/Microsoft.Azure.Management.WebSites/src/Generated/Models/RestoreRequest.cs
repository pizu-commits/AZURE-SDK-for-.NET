// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Description of a restore request. </summary>
    public partial class RestoreRequest : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of RestoreRequest. </summary>
        public RestoreRequest()
        {
            Databases = new ChangeTrackingList<DatabaseBackupSetting>();
        }

        /// <summary> Initializes a new instance of RestoreRequest. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="storageAccountUrl"> SAS URL to the container. </param>
        /// <param name="blobName"> Name of a blob which contains the backup. </param>
        /// <param name="overwrite"> &lt;code&gt;true&lt;/code&gt; if the restore operation can overwrite target app; otherwise, &lt;code&gt;false&lt;/code&gt;. &lt;code&gt;true&lt;/code&gt; is needed if trying to restore over an existing app. </param>
        /// <param name="siteName"> Name of an app. </param>
        /// <param name="databases"> Collection of databases which should be restored. This list has to match the list of databases included in the backup. </param>
        /// <param name="ignoreConflictingHostNames">
        /// Changes a logic when restoring an app with custom domains. &lt;code&gt;true&lt;/code&gt; to remove custom domains automatically. If &lt;code&gt;false&lt;/code&gt;, custom domains are added to
        /// the app&apos;s object when it is being restored, but that might fail due to conflicts during the operation.
        /// </param>
        /// <param name="ignoreDatabases"> Ignore the databases and only restore the site content. </param>
        /// <param name="appServicePlan"> Specify app service plan that will own restored site. </param>
        /// <param name="operationType"> Operation type. </param>
        /// <param name="adjustConnectionStrings"> &lt;code&gt;true&lt;/code&gt; if SiteConfig.ConnectionStrings should be set in new app; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="hostingEnvironment"> App Service Environment name, if needed (only when restoring an app to an App Service Environment). </param>
        internal RestoreRequest(string id, string name, string kind, string type, string storageAccountUrl, string blobName, bool? overwrite, string siteName, IList<DatabaseBackupSetting> databases, bool? ignoreConflictingHostNames, bool? ignoreDatabases, string appServicePlan, BackupRestoreOperationType? operationType, bool? adjustConnectionStrings, string hostingEnvironment) : base(id, name, kind, type)
        {
            StorageAccountUrl = storageAccountUrl;
            BlobName = blobName;
            Overwrite = overwrite;
            SiteName = siteName;
            Databases = databases;
            IgnoreConflictingHostNames = ignoreConflictingHostNames;
            IgnoreDatabases = ignoreDatabases;
            AppServicePlan = appServicePlan;
            OperationType = operationType;
            AdjustConnectionStrings = adjustConnectionStrings;
            HostingEnvironment = hostingEnvironment;
        }

        /// <summary> SAS URL to the container. </summary>
        public string StorageAccountUrl { get; set; }
        /// <summary> Name of a blob which contains the backup. </summary>
        public string BlobName { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the restore operation can overwrite target app; otherwise, &lt;code&gt;false&lt;/code&gt;. &lt;code&gt;true&lt;/code&gt; is needed if trying to restore over an existing app. </summary>
        public bool? Overwrite { get; set; }
        /// <summary> Name of an app. </summary>
        public string SiteName { get; set; }
        /// <summary> Collection of databases which should be restored. This list has to match the list of databases included in the backup. </summary>
        public IList<DatabaseBackupSetting> Databases { get; }
        /// <summary>
        /// Changes a logic when restoring an app with custom domains. &lt;code&gt;true&lt;/code&gt; to remove custom domains automatically. If &lt;code&gt;false&lt;/code&gt;, custom domains are added to
        /// the app&apos;s object when it is being restored, but that might fail due to conflicts during the operation.
        /// </summary>
        public bool? IgnoreConflictingHostNames { get; set; }
        /// <summary> Ignore the databases and only restore the site content. </summary>
        public bool? IgnoreDatabases { get; set; }
        /// <summary> Specify app service plan that will own restored site. </summary>
        public string AppServicePlan { get; set; }
        /// <summary> Operation type. </summary>
        public BackupRestoreOperationType? OperationType { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if SiteConfig.ConnectionStrings should be set in new app; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? AdjustConnectionStrings { get; set; }
        /// <summary> App Service Environment name, if needed (only when restoring an app to an App Service Environment). </summary>
        public string HostingEnvironment { get; set; }
    }
}
