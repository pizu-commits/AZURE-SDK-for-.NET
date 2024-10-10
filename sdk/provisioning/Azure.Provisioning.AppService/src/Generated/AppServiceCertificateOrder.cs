// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// AppServiceCertificateOrder.
/// </summary>
public partial class AppServiceCertificateOrder : Resource
{
    /// <summary>
    /// Name of the certificate order.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// State of the Key Vault secret.
    /// </summary>
    public BicepDictionary<AppServiceCertificateProperties> Certificates { get => _certificates; set => _certificates.Assign(value); }
    private readonly BicepDictionary<AppServiceCertificateProperties> _certificates;

    /// <summary>
    /// Last CSR that was created for this order.
    /// </summary>
    public BicepValue<string> Csr { get => _csr; set => _csr.Assign(value); }
    private readonly BicepValue<string> _csr;

    /// <summary>
    /// Certificate distinguished name.
    /// </summary>
    public BicepValue<string> DistinguishedName { get => _distinguishedName; set => _distinguishedName.Assign(value); }
    private readonly BicepValue<string> _distinguishedName;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if the certificate should be
    /// automatically renewed when it expires; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsAutoRenew { get => _isAutoRenew; set => _isAutoRenew.Assign(value); }
    private readonly BicepValue<bool> _isAutoRenew;

    /// <summary>
    /// Certificate key size.
    /// </summary>
    public BicepValue<int> KeySize { get => _keySize; set => _keySize.Assign(value); }
    private readonly BicepValue<int> _keySize;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Certificate product type.
    /// </summary>
    public BicepValue<CertificateProductType> ProductType { get => _productType; set => _productType.Assign(value); }
    private readonly BicepValue<CertificateProductType> _productType;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Duration in years (must be 1).
    /// </summary>
    public BicepValue<int> ValidityInYears { get => _validityInYears; set => _validityInYears.Assign(value); }
    private readonly BicepValue<int> _validityInYears;

    /// <summary>
    /// Reasons why App Service Certificate is not renewable at the current
    /// moment.
    /// </summary>
    public BicepList<AppServiceCertificateNotRenewableReason> AppServiceCertificateNotRenewableReasons { get => _appServiceCertificateNotRenewableReasons; }
    private readonly BicepList<AppServiceCertificateNotRenewableReason> _appServiceCertificateNotRenewableReasons;

    /// <summary>
    /// Contact info.
    /// </summary>
    public BicepValue<CertificateOrderContact> Contact { get => _contact; }
    private readonly BicepValue<CertificateOrderContact> _contact;

    /// <summary>
    /// Domain verification token.
    /// </summary>
    public BicepValue<string> DomainVerificationToken { get => _domainVerificationToken; }
    private readonly BicepValue<string> _domainVerificationToken;

    /// <summary>
    /// Certificate expiration time.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn { get => _expireOn; }
    private readonly BicepValue<DateTimeOffset> _expireOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Intermediate certificate.
    /// </summary>
    public BicepValue<AppServiceCertificateDetails> Intermediate { get => _intermediate; }
    private readonly BicepValue<AppServiceCertificateDetails> _intermediate;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsPrivateKeyExternal { get => _isPrivateKeyExternal; }
    private readonly BicepValue<bool> _isPrivateKeyExternal;

    /// <summary>
    /// Certificate last issuance time.
    /// </summary>
    public BicepValue<DateTimeOffset> LastCertificateIssuedOn { get => _lastCertificateIssuedOn; }
    private readonly BicepValue<DateTimeOffset> _lastCertificateIssuedOn;

    /// <summary>
    /// Time stamp when the certificate would be auto renewed next.
    /// </summary>
    public BicepValue<DateTimeOffset> NextAutoRenewTimeStamp { get => _nextAutoRenewTimeStamp; }
    private readonly BicepValue<DateTimeOffset> _nextAutoRenewTimeStamp;

    /// <summary>
    /// Status of certificate order.
    /// </summary>
    public BicepValue<ProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ProvisioningState> _provisioningState;

    /// <summary>
    /// Root certificate.
    /// </summary>
    public BicepValue<AppServiceCertificateDetails> Root { get => _root; }
    private readonly BicepValue<AppServiceCertificateDetails> _root;

    /// <summary>
    /// Current serial number of the certificate.
    /// </summary>
    public BicepValue<string> SerialNumber { get => _serialNumber; }
    private readonly BicepValue<string> _serialNumber;

    /// <summary>
    /// Signed certificate.
    /// </summary>
    public BicepValue<AppServiceCertificateDetails> SignedCertificate { get => _signedCertificate; }
    private readonly BicepValue<AppServiceCertificateDetails> _signedCertificate;

    /// <summary>
    /// Current order status.
    /// </summary>
    public BicepValue<CertificateOrderStatus> Status { get => _status; }
    private readonly BicepValue<CertificateOrderStatus> _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new AppServiceCertificateOrder.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the AppServiceCertificateOrder
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppServiceCertificateOrder.</param>
    public AppServiceCertificateOrder(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.CertificateRegistration/certificateOrders", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _certificates = BicepDictionary<AppServiceCertificateProperties>.DefineProperty(this, "Certificates", ["properties", "certificates"]);
        _csr = BicepValue<string>.DefineProperty(this, "Csr", ["properties", "csr"]);
        _distinguishedName = BicepValue<string>.DefineProperty(this, "DistinguishedName", ["properties", "distinguishedName"]);
        _isAutoRenew = BicepValue<bool>.DefineProperty(this, "IsAutoRenew", ["properties", "autoRenew"]);
        _keySize = BicepValue<int>.DefineProperty(this, "KeySize", ["properties", "keySize"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _productType = BicepValue<CertificateProductType>.DefineProperty(this, "ProductType", ["properties", "productType"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _validityInYears = BicepValue<int>.DefineProperty(this, "ValidityInYears", ["properties", "validityInYears"]);
        _appServiceCertificateNotRenewableReasons = BicepList<AppServiceCertificateNotRenewableReason>.DefineProperty(this, "AppServiceCertificateNotRenewableReasons", ["properties", "appServiceCertificateNotRenewableReasons"], isOutput: true);
        _contact = BicepValue<CertificateOrderContact>.DefineProperty(this, "Contact", ["properties", "contact"], isOutput: true);
        _domainVerificationToken = BicepValue<string>.DefineProperty(this, "DomainVerificationToken", ["properties", "domainVerificationToken"], isOutput: true);
        _expireOn = BicepValue<DateTimeOffset>.DefineProperty(this, "ExpireOn", ["properties", "expirationTime"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _intermediate = BicepValue<AppServiceCertificateDetails>.DefineProperty(this, "Intermediate", ["properties", "intermediate"], isOutput: true);
        _isPrivateKeyExternal = BicepValue<bool>.DefineProperty(this, "IsPrivateKeyExternal", ["properties", "isPrivateKeyExternal"], isOutput: true);
        _lastCertificateIssuedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastCertificateIssuedOn", ["properties", "lastCertificateIssuanceTime"], isOutput: true);
        _nextAutoRenewTimeStamp = BicepValue<DateTimeOffset>.DefineProperty(this, "NextAutoRenewTimeStamp", ["properties", "nextAutoRenewalTimeStamp"], isOutput: true);
        _provisioningState = BicepValue<ProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _root = BicepValue<AppServiceCertificateDetails>.DefineProperty(this, "Root", ["properties", "root"], isOutput: true);
        _serialNumber = BicepValue<string>.DefineProperty(this, "SerialNumber", ["properties", "serialNumber"], isOutput: true);
        _signedCertificate = BicepValue<AppServiceCertificateDetails>.DefineProperty(this, "SignedCertificate", ["properties", "signedCertificate"], isOutput: true);
        _status = BicepValue<CertificateOrderStatus>.DefineProperty(this, "Status", ["properties", "status"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported AppServiceCertificateOrder resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";
    }

    /// <summary>
    /// Creates a reference to an existing AppServiceCertificateOrder.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the AppServiceCertificateOrder
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppServiceCertificateOrder.</param>
    /// <returns>The existing AppServiceCertificateOrder resource.</returns>
    public static AppServiceCertificateOrder FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
