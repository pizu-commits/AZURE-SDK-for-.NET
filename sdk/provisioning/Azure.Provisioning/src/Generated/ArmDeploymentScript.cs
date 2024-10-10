// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// ArmDeploymentScript.
/// </summary>
public partial class ArmDeploymentScript : Resource
{
    /// <summary>
    /// Name of the deployment script.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The location of the ACI and the storage account for the deployment
    /// script.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Optional property. Managed identity to be used for this deployment
    /// script. Currently, only user-assigned MSI is supported.
    /// </summary>
    public BicepValue<ArmDeploymentScriptManagedIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ArmDeploymentScriptManagedIdentity> _identity;

    /// <summary>
    /// Resource tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new ArmDeploymentScript.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ArmDeploymentScript resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ArmDeploymentScript.</param>
    public ArmDeploymentScript(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Resources/deploymentScripts", resourceVersion ?? "2023-08-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _identity = BicepValue<ArmDeploymentScriptManagedIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ArmDeploymentScript resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing ArmDeploymentScript.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ArmDeploymentScript resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ArmDeploymentScript.</param>
    /// <returns>The existing ArmDeploymentScript resource.</returns>
    public static ArmDeploymentScript FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
