// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// For more information see [setting the AKS cluster auto-upgrade
/// channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel).
/// </summary>
public enum UpgradeChannel
{
    /// <summary>
    /// Automatically upgrade the cluster to the latest supported patch release
    /// on the latest supported minor version. In cases where the cluster is
    /// at a version of Kubernetes that is at an N-2 minor version where N is
    /// the latest supported minor version, the cluster first upgrades to the
    /// latest supported patch version on N-1 minor version. For example, if a
    /// cluster is running version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6,
    /// and 1.19.1 are available, your cluster first is upgraded to 1.18.6,
    /// then is upgraded to 1.19.1.
    /// </summary>
    [DataMember(Name = "rapid")]
    Rapid,

    /// <summary>
    /// Automatically upgrade the cluster to the latest supported patch release
    /// on minor version N-1, where N is the latest supported minor version.
    /// For example, if a cluster is running version 1.17.7 and versions
    /// 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are available, your cluster is
    /// upgraded to 1.18.6.
    /// </summary>
    [DataMember(Name = "stable")]
    Stable,

    /// <summary>
    /// Automatically upgrade the cluster to the latest supported patch version
    /// when it becomes available while keeping the minor version the same.
    /// For example, if a cluster is running version 1.17.7 and versions
    /// 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are available, your cluster is
    /// upgraded to 1.17.9.
    /// </summary>
    [DataMember(Name = "patch")]
    Patch,

    /// <summary>
    /// Automatically upgrade the node image to the latest version available.
    /// Consider using nodeOSUpgradeChannel instead as that allows you to
    /// configure node OS patching separate from Kubernetes version patching.
    /// </summary>
    [DataMember(Name = "node-image")]
    NodeImage,

    /// <summary>
    /// Disables auto-upgrades and keeps the cluster at its current version of
    /// Kubernetes.
    /// </summary>
    [DataMember(Name = "none")]
    None,
}
