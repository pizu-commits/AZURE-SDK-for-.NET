// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// CassandraKeyspaceThroughputSetting.
/// </summary>
public partial class CassandraKeyspaceThroughputSetting : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The standard JSON format of a resource throughput.
    /// </summary>
    public BicepValue<ThroughputSettingsResourceInfo> Resource { get => _resource; set => _resource.Assign(value); }
    private readonly BicepValue<ThroughputSettingsResourceInfo> _resource;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// Gets or sets the Tags.
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
    /// Gets or sets a reference to the parent CassandraKeyspace.
    /// </summary>
    public CassandraKeyspace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<CassandraKeyspace> _parent;

    /// <summary>
    /// Creates a new CassandraKeyspaceThroughputSetting.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the CassandraKeyspaceThroughputSetting
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CassandraKeyspaceThroughputSetting.</param>
    public CassandraKeyspaceThroughputSetting(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/throughputSettings", resourceVersion ?? "2024-08-15")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _resource = BicepValue<ThroughputSettingsResourceInfo>.DefineProperty(this, "Resource", ["properties", "resource"], isRequired: true);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<CassandraKeyspace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported CassandraKeyspaceThroughputSetting resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-09-01-preview.
        /// </summary>
        public static readonly string V2024_09_01_preview = "2024-09-01-preview";

        /// <summary>
        /// 2024-08-15.
        /// </summary>
        public static readonly string V2024_08_15 = "2024-08-15";

        /// <summary>
        /// 2024-05-15.
        /// </summary>
        public static readonly string V2024_05_15 = "2024-05-15";

        /// <summary>
        /// 2023-11-15.
        /// </summary>
        public static readonly string V2023_11_15 = "2023-11-15";

        /// <summary>
        /// 2023-09-15.
        /// </summary>
        public static readonly string V2023_09_15 = "2023-09-15";

        /// <summary>
        /// 2023-04-15.
        /// </summary>
        public static readonly string V2023_04_15 = "2023-04-15";

        /// <summary>
        /// 2023-03-15.
        /// </summary>
        public static readonly string V2023_03_15 = "2023-03-15";

        /// <summary>
        /// 2022-11-15.
        /// </summary>
        public static readonly string V2022_11_15 = "2022-11-15";

        /// <summary>
        /// 2022-08-15.
        /// </summary>
        public static readonly string V2022_08_15 = "2022-08-15";

        /// <summary>
        /// 2022-05-15.
        /// </summary>
        public static readonly string V2022_05_15 = "2022-05-15";

        /// <summary>
        /// 2021-10-15.
        /// </summary>
        public static readonly string V2021_10_15 = "2021-10-15";

        /// <summary>
        /// 2021-06-15.
        /// </summary>
        public static readonly string V2021_06_15 = "2021-06-15";

        /// <summary>
        /// 2021-05-15.
        /// </summary>
        public static readonly string V2021_05_15 = "2021-05-15";

        /// <summary>
        /// 2021-04-15.
        /// </summary>
        public static readonly string V2021_04_15 = "2021-04-15";

        /// <summary>
        /// 2021-03-15.
        /// </summary>
        public static readonly string V2021_03_15 = "2021-03-15";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-04-01.
        /// </summary>
        public static readonly string V2020_04_01 = "2020-04-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2019-12-12.
        /// </summary>
        public static readonly string V2019_12_12 = "2019-12-12";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2016-03-31.
        /// </summary>
        public static readonly string V2016_03_31 = "2016-03-31";

        /// <summary>
        /// 2016-03-19.
        /// </summary>
        public static readonly string V2016_03_19 = "2016-03-19";

        /// <summary>
        /// 2015-11-06.
        /// </summary>
        public static readonly string V2015_11_06 = "2015-11-06";

        /// <summary>
        /// 2015-04-08.
        /// </summary>
        public static readonly string V2015_04_08 = "2015-04-08";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing CassandraKeyspaceThroughputSetting.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the CassandraKeyspaceThroughputSetting
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CassandraKeyspaceThroughputSetting.</param>
    /// <returns>The existing CassandraKeyspaceThroughputSetting resource.</returns>
    public static CassandraKeyspaceThroughputSetting FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
