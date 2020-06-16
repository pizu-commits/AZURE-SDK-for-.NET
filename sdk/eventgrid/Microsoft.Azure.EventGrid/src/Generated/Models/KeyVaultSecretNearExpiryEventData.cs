// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for an
    /// SecretNearExpiry event.
    /// </summary>
    public partial class KeyVaultSecretNearExpiryEventData
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultSecretNearExpiryEventData
        /// class.
        /// </summary>
        public KeyVaultSecretNearExpiryEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultSecretNearExpiryEventData
        /// class.
        /// </summary>
        /// <param name="id">The id of the object that triggered this
        /// event.</param>
        /// <param name="vaultName">Key vault name of the object that triggered
        /// this event.</param>
        /// <param name="objectType">The type of the object that triggered this
        /// event</param>
        /// <param name="objectName">The name of the object that triggered this
        /// event</param>
        /// <param name="version">The version of the object that triggered this
        /// event</param>
        /// <param name="nbf">Not before date of the object that triggered this
        /// event</param>
        /// <param name="exp">The expiration date of the object that triggered
        /// this event</param>
        public KeyVaultSecretNearExpiryEventData(string id = default(string), string vaultName = default(string), string objectType = default(string), string objectName = default(string), string version = default(string), double? nbf = default(double?), double? exp = default(double?))
        {
            Id = id;
            VaultName = vaultName;
            ObjectType = objectType;
            ObjectName = objectName;
            Version = version;
            Nbf = nbf;
            Exp = exp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the object that triggered this event.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets key vault name of the object that triggered this
        /// event.
        /// </summary>
        [JsonProperty(PropertyName = "vaultName")]
        public string VaultName { get; set; }

        /// <summary>
        /// Gets or sets the type of the object that triggered this event
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets the name of the object that triggered this event
        /// </summary>
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }

        /// <summary>
        /// Gets or sets the version of the object that triggered this event
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets not before date of the object that triggered this
        /// event
        /// </summary>
        [JsonProperty(PropertyName = "nbf")]
        public double? Nbf { get; set; }

        /// <summary>
        /// Gets or sets the expiration date of the object that triggered this
        /// event
        /// </summary>
        [JsonProperty(PropertyName = "exp")]
        public double? Exp { get; set; }

    }
}
