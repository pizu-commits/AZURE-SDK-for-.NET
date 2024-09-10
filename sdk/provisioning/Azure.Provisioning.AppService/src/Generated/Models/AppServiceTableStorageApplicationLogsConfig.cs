// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Application logs to Azure table storage configuration.
/// </summary>
public partial class AppServiceTableStorageApplicationLogsConfig : ProvisioningConstruct
{
    /// <summary>
    /// Log level.
    /// </summary>
    public BicepValue<WebAppLogLevel> Level { get => _level; set => _level.Assign(value); }
    private readonly BicepValue<WebAppLogLevel> _level;

    /// <summary>
    /// SAS URL to an Azure table with add/query/delete permissions.
    /// </summary>
    public BicepValue<string> SasUriString { get => _sasUriString; set => _sasUriString.Assign(value); }
    private readonly BicepValue<string> _sasUriString;

    /// <summary>
    /// Creates a new AppServiceTableStorageApplicationLogsConfig.
    /// </summary>
    public AppServiceTableStorageApplicationLogsConfig()
    {
        _level = BicepValue<WebAppLogLevel>.DefineProperty(this, "Level", ["level"]);
        _sasUriString = BicepValue<string>.DefineProperty(this, "SasUriString", ["sasUrl"]);
    }
}
