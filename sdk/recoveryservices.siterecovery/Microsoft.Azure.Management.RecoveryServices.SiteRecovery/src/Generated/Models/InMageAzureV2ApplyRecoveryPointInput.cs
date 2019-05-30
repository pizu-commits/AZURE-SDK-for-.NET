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
    /// ApplyRecoveryPoint input specific to InMageAzureV2 provider.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageAzureV2")]
    public partial class InMageAzureV2ApplyRecoveryPointInput : ApplyRecoveryPointProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2ApplyRecoveryPointInput class.
        /// </summary>
        public InMageAzureV2ApplyRecoveryPointInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2ApplyRecoveryPointInput class.
        /// </summary>
        /// <param name="vaultLocation">The vault location where the recovery
        /// Vm resides.</param>
        public InMageAzureV2ApplyRecoveryPointInput(string vaultLocation = default(string))
        {
            VaultLocation = vaultLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the vault location where the recovery Vm resides.
        /// </summary>
        [JsonProperty(PropertyName = "vaultLocation")]
        public string VaultLocation { get; set; }

    }
}
