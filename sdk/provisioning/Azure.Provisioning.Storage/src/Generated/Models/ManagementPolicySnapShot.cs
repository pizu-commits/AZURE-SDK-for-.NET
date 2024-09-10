// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// Management policy action for snapshot.
/// </summary>
public partial class ManagementPolicySnapShot : ProvisioningConstruct
{
    /// <summary>
    /// The function to tier blob snapshot to cool storage.
    /// </summary>
    public BicepValue<DateAfterCreation> TierToCool { get => _tierToCool; set => _tierToCool.Assign(value); }
    private readonly BicepValue<DateAfterCreation> _tierToCool;

    /// <summary>
    /// The function to tier blob snapshot to archive storage.
    /// </summary>
    public BicepValue<DateAfterCreation> TierToArchive { get => _tierToArchive; set => _tierToArchive.Assign(value); }
    private readonly BicepValue<DateAfterCreation> _tierToArchive;

    /// <summary>
    /// The function to tier blobs to cold storage.
    /// </summary>
    public BicepValue<DateAfterCreation> TierToCold { get => _tierToCold; set => _tierToCold.Assign(value); }
    private readonly BicepValue<DateAfterCreation> _tierToCold;

    /// <summary>
    /// The function to tier blobs to hot storage. This action can only be used
    /// with Premium Block Blob Storage Accounts.
    /// </summary>
    public BicepValue<DateAfterCreation> TierToHot { get => _tierToHot; set => _tierToHot.Assign(value); }
    private readonly BicepValue<DateAfterCreation> _tierToHot;

    /// <summary>
    /// The function to delete the blob snapshot.
    /// </summary>
    public BicepValue<DateAfterCreation> Delete { get => _delete; set => _delete.Assign(value); }
    private readonly BicepValue<DateAfterCreation> _delete;

    /// <summary>
    /// Creates a new ManagementPolicySnapShot.
    /// </summary>
    public ManagementPolicySnapShot()
    {
        _tierToCool = BicepValue<DateAfterCreation>.DefineProperty(this, "TierToCool", ["tierToCool"]);
        _tierToArchive = BicepValue<DateAfterCreation>.DefineProperty(this, "TierToArchive", ["tierToArchive"]);
        _tierToCold = BicepValue<DateAfterCreation>.DefineProperty(this, "TierToCold", ["tierToCold"]);
        _tierToHot = BicepValue<DateAfterCreation>.DefineProperty(this, "TierToHot", ["tierToHot"]);
        _delete = BicepValue<DateAfterCreation>.DefineProperty(this, "Delete", ["delete"]);
    }
}
