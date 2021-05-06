// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Key Vault container ARM resource for a certificate that is purchased through Azure. </summary>
    public partial class AppServiceCertificatePatchResource : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of AppServiceCertificatePatchResource. </summary>
        public AppServiceCertificatePatchResource()
        {
        }

        /// <summary> Initializes a new instance of AppServiceCertificatePatchResource. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="keyVaultId"> Key Vault resource Id. </param>
        /// <param name="keyVaultSecretName"> Key Vault secret name. </param>
        /// <param name="provisioningState"> Status of the Key Vault secret. </param>
        internal AppServiceCertificatePatchResource(string id, string name, string kind, string type, string keyVaultId, string keyVaultSecretName, KeyVaultSecretStatus? provisioningState) : base(id, name, kind, type)
        {
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            ProvisioningState = provisioningState;
        }

        /// <summary> Key Vault resource Id. </summary>
        public string KeyVaultId { get; set; }
        /// <summary> Key Vault secret name. </summary>
        public string KeyVaultSecretName { get; set; }
        /// <summary> Status of the Key Vault secret. </summary>
        public KeyVaultSecretStatus? ProvisioningState { get; }
    }
}
