// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Tenant.
/// </summary>
public partial class Tenant : Resource
{
    /// <summary>
    /// Country/region name of the address for the tenant.
    /// </summary>
    public BicepValue<string> Country { get => _country; }
    private readonly BicepValue<string> _country;

    /// <summary>
    /// Country/region abbreviation for the tenant.
    /// </summary>
    public BicepValue<string> CountryCode { get => _countryCode; }
    private readonly BicepValue<string> _countryCode;

    /// <summary>
    /// The default domain for the tenant.
    /// </summary>
    public BicepValue<string> DefaultDomain { get => _defaultDomain; }
    private readonly BicepValue<string> _defaultDomain;

    /// <summary>
    /// The display name of the tenant.
    /// </summary>
    public BicepValue<string> DisplayName { get => _displayName; }
    private readonly BicepValue<string> _displayName;

    /// <summary>
    /// The list of domains for the tenant.
    /// </summary>
    public BicepList<string> Domains { get => _domains; }
    private readonly BicepList<string> _domains;

    /// <summary>
    /// The fully qualified ID of the tenant. For example,
    /// /tenants/8d65815f-a5b6-402f-9298-045155da7d74.
    /// </summary>
    public BicepValue<string> Id { get => _id; }
    private readonly BicepValue<string> _id;

    /// <summary>
    /// The tenant&apos;s branding logo URL. Only available for
    /// &apos;Home&apos; tenant category.
    /// </summary>
    public BicepValue<Uri> TenantBrandingLogoUri { get => _tenantBrandingLogoUri; }
    private readonly BicepValue<Uri> _tenantBrandingLogoUri;

    /// <summary>
    /// Category of the tenant.
    /// </summary>
    public BicepValue<TenantCategory> TenantCategory { get => _tenantCategory; }
    private readonly BicepValue<TenantCategory> _tenantCategory;

    /// <summary>
    /// The tenant ID. For example, 8d65815f-a5b6-402f-9298-045155da7d74.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// The tenant type. Only available for &apos;Home&apos; tenant category.
    /// </summary>
    public BicepValue<string> TenantType { get => _tenantType; }
    private readonly BicepValue<string> _tenantType;

    /// <summary>
    /// Creates a new Tenant.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the Tenant resource.  This can be used
    /// to refer to the resource in expressions, but is not the Azure name of
    /// the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the Tenant.</param>
    public Tenant(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Resources/tenants", resourceVersion ?? "2020-01-01")
    {
        _country = BicepValue<string>.DefineProperty(this, "Country", ["country"], isOutput: true);
        _countryCode = BicepValue<string>.DefineProperty(this, "CountryCode", ["countryCode"], isOutput: true);
        _defaultDomain = BicepValue<string>.DefineProperty(this, "DefaultDomain", ["defaultDomain"], isOutput: true);
        _displayName = BicepValue<string>.DefineProperty(this, "DisplayName", ["displayName"], isOutput: true);
        _domains = BicepList<string>.DefineProperty(this, "Domains", ["domains"], isOutput: true);
        _id = BicepValue<string>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _tenantBrandingLogoUri = BicepValue<Uri>.DefineProperty(this, "TenantBrandingLogoUri", ["tenantBrandingLogoUrl"], isOutput: true);
        _tenantCategory = BicepValue<TenantCategory>.DefineProperty(this, "TenantCategory", ["tenantCategory"], isOutput: true);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"], isOutput: true);
        _tenantType = BicepValue<string>.DefineProperty(this, "TenantType", ["tenantType"], isOutput: true);
    }

    /// <summary>
    /// Supported Tenant resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2020-01-01.
        /// </summary>
        public static readonly string V2020_01_01 = "2020-01-01";

        /// <summary>
        /// 2019-09-01.
        /// </summary>
        public static readonly string V2019_09_01 = "2019-09-01";

        /// <summary>
        /// 2019-05-01.
        /// </summary>
        public static readonly string V2019_05_01 = "2019-05-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2019-03-01.
        /// </summary>
        public static readonly string V2019_03_01 = "2019-03-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-09-01.
        /// </summary>
        public static readonly string V2018_09_01 = "2018-09-01";

        /// <summary>
        /// 2018-08-01.
        /// </summary>
        public static readonly string V2018_08_01 = "2018-08-01";

        /// <summary>
        /// 2018-07-01.
        /// </summary>
        public static readonly string V2018_07_01 = "2018-07-01";

        /// <summary>
        /// 2018-05-01.
        /// </summary>
        public static readonly string V2018_05_01 = "2018-05-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2018-01-01.
        /// </summary>
        public static readonly string V2018_01_01 = "2018-01-01";

        /// <summary>
        /// 2017-08-01.
        /// </summary>
        public static readonly string V2017_08_01 = "2017-08-01";

        /// <summary>
        /// 2017-06-01.
        /// </summary>
        public static readonly string V2017_06_01 = "2017-06-01";

        /// <summary>
        /// 2017-05-10.
        /// </summary>
        public static readonly string V2017_05_10 = "2017-05-10";

        /// <summary>
        /// 2017-05-01.
        /// </summary>
        public static readonly string V2017_05_01 = "2017-05-01";

        /// <summary>
        /// 2017-03-01.
        /// </summary>
        public static readonly string V2017_03_01 = "2017-03-01";

        /// <summary>
        /// 2016-09-01.
        /// </summary>
        public static readonly string V2016_09_01 = "2016-09-01";

        /// <summary>
        /// 2016-07-01.
        /// </summary>
        public static readonly string V2016_07_01 = "2016-07-01";

        /// <summary>
        /// 2016-06-01.
        /// </summary>
        public static readonly string V2016_06_01 = "2016-06-01";

        /// <summary>
        /// 2016-02-01.
        /// </summary>
        public static readonly string V2016_02_01 = "2016-02-01";

        /// <summary>
        /// 2015-11-01.
        /// </summary>
        public static readonly string V2015_11_01 = "2015-11-01";

        /// <summary>
        /// 2015-01-01.
        /// </summary>
        public static readonly string V2015_01_01 = "2015-01-01";
    }

    /// <summary>
    /// Creates a new Tenant resource from a Bicep expression that evaluates to
    /// a Tenant.
    /// </summary>
    /// <param name="expression">
    /// A Bicep expression that evaluates to a Tenant resource.
    /// </param>
    /// <returns>A Tenant resource.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static Tenant FromExpression(Expression expression)
    {
        Tenant resource = new(nameof(Tenant));
        resource.OverrideWithExpression(expression);
        return resource;
    }
}
