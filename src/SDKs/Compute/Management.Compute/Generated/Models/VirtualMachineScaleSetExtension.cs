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
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine Scale Set Extension.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSetExtension : SubResourceReadOnly
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetExtension
        /// class.
        /// </summary>
        public VirtualMachineScaleSetExtension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetExtension
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">The name of the extension.</param>
        /// <param name="forceUpdateTag">If a value is provided and is
        /// different from the previous value, the extension handler will be
        /// forced to update even if the extension configuration has not
        /// changed.</param>
        /// <param name="publisher">The name of the extension handler
        /// publisher.</param>
        /// <param name="type">Specifies the type of the extension; an example
        /// is "CustomScriptExtension".</param>
        /// <param name="typeHandlerVersion">Specifies the version of the
        /// script handler.</param>
        /// <param name="autoUpgradeMinorVersion">Indicates whether the
        /// extension should use a newer minor version if one is available at
        /// deployment time. Once deployed, however, the extension will not
        /// upgrade minor versions unless redeployed, even with this property
        /// set to true.</param>
        /// <param name="settings">Json formatted public settings for the
        /// extension.</param>
        /// <param name="protectedSettings">The extension can contain either
        /// protectedSettings or protectedSettingsFromKeyVault or no protected
        /// settings at all.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        public VirtualMachineScaleSetExtension(string id = default(string), string name = default(string), string forceUpdateTag = default(string), string publisher = default(string), string type = default(string), string typeHandlerVersion = default(string), bool? autoUpgradeMinorVersion = default(bool?), object settings = default(object), object protectedSettings = default(object), string provisioningState = default(string))
            : base(id)
        {
            Name = name;
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the extension.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if a value is provided and is different from the
        /// previous value, the extension handler will be forced to update even
        /// if the extension configuration has not changed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.forceUpdateTag")]
        public string ForceUpdateTag { get; set; }

        /// <summary>
        /// Gets or sets the name of the extension handler publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets specifies the type of the extension; an example is
        /// "CustomScriptExtension".
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets specifies the version of the script handler.
        /// </summary>
        [JsonProperty(PropertyName = "properties.typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the extension should use a newer
        /// minor version if one is available at deployment time. Once
        /// deployed, however, the extension will not upgrade minor versions
        /// unless redeployed, even with this property set to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoUpgradeMinorVersion")]
        public bool? AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// Gets or sets json formatted public settings for the extension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings")]
        public object Settings { get; set; }

        /// <summary>
        /// Gets or sets the extension can contain either protectedSettings or
        /// protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [JsonProperty(PropertyName = "properties.protectedSettings")]
        public object ProtectedSettings { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
