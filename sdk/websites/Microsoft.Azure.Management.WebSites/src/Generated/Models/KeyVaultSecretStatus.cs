// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Status of the Key Vault secret. </summary>
    public enum KeyVaultSecretStatus
    {
        /// <summary> Initialized. </summary>
        Initialized,
        /// <summary> WaitingOnCertificateOrder. </summary>
        WaitingOnCertificateOrder,
        /// <summary> Succeeded. </summary>
        Succeeded,
        /// <summary> CertificateOrderFailed. </summary>
        CertificateOrderFailed,
        /// <summary> OperationNotPermittedOnKeyVault. </summary>
        OperationNotPermittedOnKeyVault,
        /// <summary> AzureServiceUnauthorizedToAccessKeyVault. </summary>
        AzureServiceUnauthorizedToAccessKeyVault,
        /// <summary> KeyVaultDoesNotExist. </summary>
        KeyVaultDoesNotExist,
        /// <summary> KeyVaultSecretDoesNotExist. </summary>
        KeyVaultSecretDoesNotExist,
        /// <summary> UnknownError. </summary>
        UnknownError,
        /// <summary> ExternalPrivateKey. </summary>
        ExternalPrivateKey,
        /// <summary> Unknown. </summary>
        Unknown
    }
}
