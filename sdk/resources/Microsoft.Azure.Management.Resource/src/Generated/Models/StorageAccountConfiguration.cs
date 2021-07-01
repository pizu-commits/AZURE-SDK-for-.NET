// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Settings to use an existing storage account. Valid storage account
    /// kinds are: Storage, StorageV2 and FileStorage
    /// </summary>
    public partial class StorageAccountConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountConfiguration
        /// class.
        /// </summary>
        public StorageAccountConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountConfiguration
        /// class.
        /// </summary>
        /// <param name="storageAccountName">The storage account name.</param>
        /// <param name="storageAccountKey">The storage account access
        /// key.</param>
        public StorageAccountConfiguration(string storageAccountName = default(string), string storageAccountKey = default(string))
        {
            StorageAccountName = storageAccountName;
            StorageAccountKey = storageAccountKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the storage account name.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountName")]
        public string StorageAccountName { get; set; }

        /// <summary>
        /// Gets or sets the storage account access key.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountKey")]
        public string StorageAccountKey { get; set; }

    }
}
