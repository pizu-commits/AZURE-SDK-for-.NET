// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// disk encryption set update resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DiskEncryptionSetUpdate
    {
        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSetUpdate class.
        /// </summary>
        public DiskEncryptionSetUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSetUpdate class.
        /// </summary>
        /// <param name="encryptionType">Possible values include:
        /// 'EncryptionAtRestWithCustomerKey',
        /// 'EncryptionAtRestWithPlatformAndCustomerKeys'</param>
        /// <param name="rotationToLatestKeyVersionEnabled">Set this flag to
        /// true to enable auto-updating of this disk encryption set to the
        /// latest key version.</param>
        /// <param name="tags">Resource tags</param>
        public DiskEncryptionSetUpdate(string encryptionType = default(string), KeyForDiskEncryptionSet activeKey = default(KeyForDiskEncryptionSet), bool? rotationToLatestKeyVersionEnabled = default(bool?), EncryptionSetIdentity identity = default(EncryptionSetIdentity), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            EncryptionType = encryptionType;
            ActiveKey = activeKey;
            RotationToLatestKeyVersionEnabled = rotationToLatestKeyVersionEnabled;
            Identity = identity;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include:
        /// 'EncryptionAtRestWithCustomerKey',
        /// 'EncryptionAtRestWithPlatformAndCustomerKeys'
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionType")]
        public string EncryptionType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeKey")]
        public KeyForDiskEncryptionSet ActiveKey { get; set; }

        /// <summary>
        /// Gets or sets set this flag to true to enable auto-updating of this
        /// disk encryption set to the latest key version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rotationToLatestKeyVersionEnabled")]
        public bool? RotationToLatestKeyVersionEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public EncryptionSetIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ActiveKey != null)
            {
                ActiveKey.Validate();
            }
        }
    }
}
