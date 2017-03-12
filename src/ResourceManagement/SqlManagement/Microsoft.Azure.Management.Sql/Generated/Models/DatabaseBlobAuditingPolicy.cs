// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains information about a database Blob Auditing policy.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DatabaseBlobAuditingPolicy : SqlTypedSubResource
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseBlobAuditingPolicy class.
        /// </summary>
        public DatabaseBlobAuditingPolicy() { }

        /// <summary>
        /// Initializes a new instance of the DatabaseBlobAuditingPolicy class.
        /// </summary>
        /// <param name="state">Specifies the state of the policy. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="type">Resource type</param>
        /// <param name="storageEndpoint">Specifies the blob storage endpoint
        /// (e.g. https://MyAccount.blob.core.windows.net)</param>
        /// <param name="storageAccountAccessKey">Specifies the identifier key
        /// of the auditing storage account.</param>
        /// <param name="retentionDays">Specifies the number of days to keep in
        /// the audit logs.</param>
        /// <param name="auditActionsAndGroups">Specifies the Actions and
        /// Actions-Groups to audit.</param>
        /// <param name="storageAccountSubscriptionId">Specifies the blob
        /// storage subscription Id.</param>
        /// <param name="isStorageSecondaryKeyInUse">Specifies whether
        /// storageAccountAccessKey value is the storage’s secondary
        /// key.</param>
        public DatabaseBlobAuditingPolicy(BlobAuditingPolicyState state, string name = default(string), string id = default(string), string type = default(string), string storageEndpoint = default(string), string storageAccountAccessKey = default(string), int? retentionDays = default(int?), IList<string> auditActionsAndGroups = default(IList<string>), string storageAccountSubscriptionId = default(string), bool? isStorageSecondaryKeyInUse = default(bool?))
            : base(name, id, type)
        {
            State = state;
            StorageEndpoint = storageEndpoint;
            StorageAccountAccessKey = storageAccountAccessKey;
            RetentionDays = retentionDays;
            AuditActionsAndGroups = auditActionsAndGroups;
            StorageAccountSubscriptionId = storageAccountSubscriptionId;
            IsStorageSecondaryKeyInUse = isStorageSecondaryKeyInUse;
        }

        /// <summary>
        /// Gets or sets specifies the state of the policy. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public BlobAuditingPolicyState State { get; set; }

        /// <summary>
        /// Gets or sets specifies the blob storage endpoint (e.g.
        /// https://MyAccount.blob.core.windows.net)
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageEndpoint")]
        public string StorageEndpoint { get; set; }

        /// <summary>
        /// Gets or sets specifies the identifier key of the auditing storage
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountAccessKey")]
        public string StorageAccountAccessKey { get; set; }

        /// <summary>
        /// Gets or sets specifies the number of days to keep in the audit
        /// logs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionDays")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Gets or sets specifies the Actions and Actions-Groups to audit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.auditActionsAndGroups")]
        public IList<string> AuditActionsAndGroups { get; set; }

        /// <summary>
        /// Gets or sets specifies the blob storage subscription Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountSubscriptionId")]
        public string StorageAccountSubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets specifies whether storageAccountAccessKey value is the
        /// storage’s secondary key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isStorageSecondaryKeyInUse")]
        public bool? IsStorageSecondaryKeyInUse { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
