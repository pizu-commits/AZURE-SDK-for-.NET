// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// BlobInventoryPolicy.
/// </summary>
public partial class BlobInventoryPolicy : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The storage account blob inventory policy object. It is composed of
    /// policy rules.
    /// </summary>
    public BicepValue<BlobInventoryPolicySchema> PolicySchema { get => _policySchema; set => _policySchema.Assign(value); }
    private readonly BicepValue<BlobInventoryPolicySchema> _policySchema;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Returns the last modified date and time of the blob inventory policy.
    /// </summary>
    public BicepValue<DateTimeOffset> LastModifiedOn { get => _lastModifiedOn; }
    private readonly BicepValue<DateTimeOffset> _lastModifiedOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent StorageAccount.
    /// </summary>
    public StorageAccount? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<StorageAccount> _parent;

    /// <summary>
    /// Creates a new BlobInventoryPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the BlobInventoryPolicy.</param>
    /// <param name="resourceVersion">Version of the BlobInventoryPolicy.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public BlobInventoryPolicy(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Storage/storageAccounts/inventoryPolicies", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _policySchema = BicepValue<BlobInventoryPolicySchema>.DefineProperty(this, "PolicySchema", ["properties", "policy"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _lastModifiedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastModifiedOn", ["properties", "lastModifiedTime"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<StorageAccount>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing BlobInventoryPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the BlobInventoryPolicy.</param>
    /// <param name="resourceVersion">Version of the BlobInventoryPolicy.</param>
    /// <returns>The existing BlobInventoryPolicy resource.</returns>
    public static BlobInventoryPolicy FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
