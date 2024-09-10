// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// ContainerServiceMaintenanceConfiguration.
/// </summary>
public partial class ContainerServiceMaintenanceConfiguration : Resource
{
    /// <summary>
    /// The name of the maintenance configuration.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Maintenance window for the maintenance configuration.
    /// </summary>
    public BicepValue<ContainerServiceMaintenanceWindow> MaintenanceWindow { get => _maintenanceWindow; set => _maintenanceWindow.Assign(value); }
    private readonly BicepValue<ContainerServiceMaintenanceWindow> _maintenanceWindow;

    /// <summary>
    /// Time slots on which upgrade is not allowed.
    /// </summary>
    public BicepList<ContainerServiceTimeSpan> NotAllowedTimes { get => _notAllowedTimes; set => _notAllowedTimes.Assign(value); }
    private readonly BicepList<ContainerServiceTimeSpan> _notAllowedTimes;

    /// <summary>
    /// If two array entries specify the same day of the week, the applied
    /// configuration is the union of times in both entries.
    /// </summary>
    public BicepList<ContainerServiceTimeInWeek> TimesInWeek { get => _timesInWeek; set => _timesInWeek.Assign(value); }
    private readonly BicepList<ContainerServiceTimeInWeek> _timesInWeek;

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
    /// Gets or sets a reference to the parent ContainerServiceManagedCluster.
    /// </summary>
    public ContainerServiceManagedCluster? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerServiceManagedCluster> _parent;

    /// <summary>
    /// Creates a new ContainerServiceMaintenanceConfiguration.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerServiceMaintenanceConfiguration.</param>
    /// <param name="resourceVersion">Version of the ContainerServiceMaintenanceConfiguration.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public ContainerServiceMaintenanceConfiguration(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.ContainerService/managedClusters/maintenanceConfigurations", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _maintenanceWindow = BicepValue<ContainerServiceMaintenanceWindow>.DefineProperty(this, "MaintenanceWindow", ["properties", "maintenanceWindow"]);
        _notAllowedTimes = BicepList<ContainerServiceTimeSpan>.DefineProperty(this, "NotAllowedTimes", ["properties", "notAllowedTime"]);
        _timesInWeek = BicepList<ContainerServiceTimeInWeek>.DefineProperty(this, "TimesInWeek", ["properties", "timeInWeek"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerServiceManagedCluster>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ContainerServiceMaintenanceConfiguration.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerServiceMaintenanceConfiguration.</param>
    /// <param name="resourceVersion">Version of the ContainerServiceMaintenanceConfiguration.</param>
    /// <returns>The existing ContainerServiceMaintenanceConfiguration resource.</returns>
    public static ContainerServiceMaintenanceConfiguration FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
