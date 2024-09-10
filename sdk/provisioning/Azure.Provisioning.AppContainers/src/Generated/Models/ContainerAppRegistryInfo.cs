// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Container App registry information.
/// </summary>
public partial class ContainerAppRegistryInfo : ProvisioningConstruct
{
    /// <summary>
    /// registry server Url.
    /// </summary>
    public BicepValue<string> RegistryServer { get => _registryServer; set => _registryServer.Assign(value); }
    private readonly BicepValue<string> _registryServer;

    /// <summary>
    /// registry username.
    /// </summary>
    public BicepValue<string> RegistryUserName { get => _registryUserName; set => _registryUserName.Assign(value); }
    private readonly BicepValue<string> _registryUserName;

    /// <summary>
    /// registry secret.
    /// </summary>
    public BicepValue<string> RegistryPassword { get => _registryPassword; set => _registryPassword.Assign(value); }
    private readonly BicepValue<string> _registryPassword;

    /// <summary>
    /// Creates a new ContainerAppRegistryInfo.
    /// </summary>
    public ContainerAppRegistryInfo()
    {
        _registryServer = BicepValue<string>.DefineProperty(this, "RegistryServer", ["registryUrl"]);
        _registryUserName = BicepValue<string>.DefineProperty(this, "RegistryUserName", ["registryUserName"]);
        _registryPassword = BicepValue<string>.DefineProperty(this, "RegistryPassword", ["registryPassword"]);
    }
}
