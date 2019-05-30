// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Key Encryption Key (KEK) information.
    /// </summary>
    public partial class KeyEncryptionKeyInfo
    {
        /// <summary>
        /// Initializes a new instance of the KeyEncryptionKeyInfo class.
        /// </summary>
        public KeyEncryptionKeyInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyEncryptionKeyInfo class.
        /// </summary>
        /// <param name="keyIdentifier">The key url / identifier.</param>
        /// <param name="keyVaultResourceArmId">The KeyVault resource ARM id
        /// for key.</param>
        public KeyEncryptionKeyInfo(string keyIdentifier = default(string), string keyVaultResourceArmId = default(string))
        {
            KeyIdentifier = keyIdentifier;
            KeyVaultResourceArmId = keyVaultResourceArmId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the key url / identifier.
        /// </summary>
        [JsonProperty(PropertyName = "keyIdentifier")]
        public string KeyIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the KeyVault resource ARM id for key.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultResourceArmId")]
        public string KeyVaultResourceArmId { get; set; }

    }
}
