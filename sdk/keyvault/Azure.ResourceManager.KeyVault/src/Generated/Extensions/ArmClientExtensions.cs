// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region VaultKey
        /// <summary> Gets an object representing a VaultKey along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VaultKey" /> object. </returns>
        public static VaultKey GetVaultKey(this ArmClient armClient, ResourceIdentifier id)
        {
            VaultKey.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VaultKey(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VaultKeyVersion
        /// <summary> Gets an object representing a VaultKeyVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VaultKeyVersion" /> object. </returns>
        public static VaultKeyVersion GetVaultKeyVersion(this ArmClient armClient, ResourceIdentifier id)
        {
            VaultKeyVersion.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VaultKeyVersion(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Vault
        /// <summary> Gets an object representing a Vault along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Vault" /> object. </returns>
        public static Vault GetVault(this ArmClient armClient, ResourceIdentifier id)
        {
            Vault.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Vault(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DeletedVault
        /// <summary> Gets an object representing a DeletedVault along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedVault" /> object. </returns>
        public static DeletedVault GetDeletedVault(this ArmClient armClient, ResourceIdentifier id)
        {
            DeletedVault.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DeletedVault(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            PrivateEndpointConnection.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ManagedHsm
        /// <summary> Gets an object representing a ManagedHsm along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedHsm" /> object. </returns>
        public static ManagedHsm GetManagedHsm(this ArmClient armClient, ResourceIdentifier id)
        {
            ManagedHsm.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ManagedHsm(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DeletedManagedHsm
        /// <summary> Gets an object representing a DeletedManagedHsm along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedManagedHsm" /> object. </returns>
        public static DeletedManagedHsm GetDeletedManagedHsm(this ArmClient armClient, ResourceIdentifier id)
        {
            DeletedManagedHsm.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DeletedManagedHsm(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region MhsmPrivateEndpointConnection
        /// <summary> Gets an object representing a MhsmPrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MhsmPrivateEndpointConnection" /> object. </returns>
        public static MhsmPrivateEndpointConnection GetMhsmPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            MhsmPrivateEndpointConnection.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new MhsmPrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Secret
        /// <summary> Gets an object representing a Secret along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Secret" /> object. </returns>
        public static Secret GetSecret(this ArmClient armClient, ResourceIdentifier id)
        {
            Secret.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Secret(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
