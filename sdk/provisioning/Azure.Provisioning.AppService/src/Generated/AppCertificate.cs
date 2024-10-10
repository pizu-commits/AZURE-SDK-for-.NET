// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.AppService;

/// <summary>
/// AppCertificate.
/// </summary>
public partial class AppCertificate : Resource
{
    /// <summary>
    /// Name of the certificate.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// CNAME of the certificate to be issued via free certificate.
    /// </summary>
    public BicepValue<string> CanonicalName { get => _canonicalName; set => _canonicalName.Assign(value); }
    private readonly BicepValue<string> _canonicalName;

    /// <summary>
    /// Method of domain validation for free cert.
    /// </summary>
    public BicepValue<string> DomainValidationMethod { get => _domainValidationMethod; set => _domainValidationMethod.Assign(value); }
    private readonly BicepValue<string> _domainValidationMethod;

    /// <summary>
    /// Host names the certificate applies to.
    /// </summary>
    public BicepList<string> HostNames { get => _hostNames; set => _hostNames.Assign(value); }
    private readonly BicepList<string> _hostNames;

    /// <summary>
    /// Key Vault Csm resource Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> KeyVaultId { get => _keyVaultId; set => _keyVaultId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _keyVaultId;

    /// <summary>
    /// Key Vault secret name.
    /// </summary>
    public BicepValue<string> KeyVaultSecretName { get => _keyVaultSecretName; set => _keyVaultSecretName.Assign(value); }
    private readonly BicepValue<string> _keyVaultSecretName;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Certificate password.
    /// </summary>
    public BicepValue<string> Password { get => _password; set => _password.Assign(value); }
    private readonly BicepValue<string> _password;

    /// <summary>
    /// Pfx blob.
    /// </summary>
    public BicepValue<BinaryData> PfxBlob { get => _pfxBlob; set => _pfxBlob.Assign(value); }
    private readonly BicepValue<BinaryData> _pfxBlob;

    /// <summary>
    /// Resource ID of the associated App Service plan, formatted as:
    /// &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
    /// </summary>
    public BicepValue<ResourceIdentifier> ServerFarmId { get => _serverFarmId; set => _serverFarmId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _serverFarmId;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Raw bytes of .cer file.
    /// </summary>
    public BicepValue<BinaryData> CerBlob { get => _cerBlob; }
    private readonly BicepValue<BinaryData> _cerBlob;

    /// <summary>
    /// Certificate expiration date.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn { get => _expireOn; }
    private readonly BicepValue<DateTimeOffset> _expireOn;

    /// <summary>
    /// Friendly name of the certificate.
    /// </summary>
    public BicepValue<string> FriendlyName { get => _friendlyName; }
    private readonly BicepValue<string> _friendlyName;

    /// <summary>
    /// Specification for the App Service Environment to use for the
    /// certificate.
    /// </summary>
    public BicepValue<HostingEnvironmentProfile> HostingEnvironmentProfile { get => _hostingEnvironmentProfile; }
    private readonly BicepValue<HostingEnvironmentProfile> _hostingEnvironmentProfile;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Certificate issue Date.
    /// </summary>
    public BicepValue<DateTimeOffset> IssueOn { get => _issueOn; }
    private readonly BicepValue<DateTimeOffset> _issueOn;

    /// <summary>
    /// Certificate issuer.
    /// </summary>
    public BicepValue<string> Issuer { get => _issuer; }
    private readonly BicepValue<string> _issuer;

    /// <summary>
    /// Is the certificate valid?.
    /// </summary>
    public BicepValue<bool> IsValid { get => _isValid; }
    private readonly BicepValue<bool> _isValid;

    /// <summary>
    /// Status of the Key Vault secret.
    /// </summary>
    public BicepValue<KeyVaultSecretStatus> KeyVaultSecretStatus { get => _keyVaultSecretStatus; }
    private readonly BicepValue<KeyVaultSecretStatus> _keyVaultSecretStatus;

    /// <summary>
    /// Public key hash.
    /// </summary>
    public BicepValue<string> PublicKeyHash { get => _publicKeyHash; }
    private readonly BicepValue<string> _publicKeyHash;

    /// <summary>
    /// Self link.
    /// </summary>
    public BicepValue<string> SelfLink { get => _selfLink; }
    private readonly BicepValue<string> _selfLink;

    /// <summary>
    /// App name.
    /// </summary>
    public BicepValue<string> SiteName { get => _siteName; }
    private readonly BicepValue<string> _siteName;

    /// <summary>
    /// Subject name of the certificate.
    /// </summary>
    public BicepValue<string> SubjectName { get => _subjectName; }
    private readonly BicepValue<string> _subjectName;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Certificate thumbprint.
    /// </summary>
    public BicepValue<string> ThumbprintString { get => _thumbprintString; }
    private readonly BicepValue<string> _thumbprintString;

    /// <summary>
    /// Creates a new AppCertificate.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the AppCertificate resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppCertificate.</param>
    public AppCertificate(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Web/certificates", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _canonicalName = BicepValue<string>.DefineProperty(this, "CanonicalName", ["properties", "canonicalName"]);
        _domainValidationMethod = BicepValue<string>.DefineProperty(this, "DomainValidationMethod", ["properties", "domainValidationMethod"]);
        _hostNames = BicepList<string>.DefineProperty(this, "HostNames", ["properties", "hostNames"]);
        _keyVaultId = BicepValue<ResourceIdentifier>.DefineProperty(this, "KeyVaultId", ["properties", "keyVaultId"]);
        _keyVaultSecretName = BicepValue<string>.DefineProperty(this, "KeyVaultSecretName", ["properties", "keyVaultSecretName"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _password = BicepValue<string>.DefineProperty(this, "Password", ["properties", "password"]);
        _pfxBlob = BicepValue<BinaryData>.DefineProperty(this, "PfxBlob", ["properties", "pfxBlob"]);
        _serverFarmId = BicepValue<ResourceIdentifier>.DefineProperty(this, "ServerFarmId", ["properties", "serverFarmId"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _cerBlob = BicepValue<BinaryData>.DefineProperty(this, "CerBlob", ["properties", "cerBlob"], isOutput: true);
        _expireOn = BicepValue<DateTimeOffset>.DefineProperty(this, "ExpireOn", ["properties", "expirationDate"], isOutput: true);
        _friendlyName = BicepValue<string>.DefineProperty(this, "FriendlyName", ["properties", "friendlyName"], isOutput: true);
        _hostingEnvironmentProfile = BicepValue<HostingEnvironmentProfile>.DefineProperty(this, "HostingEnvironmentProfile", ["properties", "hostingEnvironmentProfile"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _issueOn = BicepValue<DateTimeOffset>.DefineProperty(this, "IssueOn", ["properties", "issueDate"], isOutput: true);
        _issuer = BicepValue<string>.DefineProperty(this, "Issuer", ["properties", "issuer"], isOutput: true);
        _isValid = BicepValue<bool>.DefineProperty(this, "IsValid", ["properties", "valid"], isOutput: true);
        _keyVaultSecretStatus = BicepValue<KeyVaultSecretStatus>.DefineProperty(this, "KeyVaultSecretStatus", ["properties", "keyVaultSecretStatus"], isOutput: true);
        _publicKeyHash = BicepValue<string>.DefineProperty(this, "PublicKeyHash", ["properties", "publicKeyHash"], isOutput: true);
        _selfLink = BicepValue<string>.DefineProperty(this, "SelfLink", ["properties", "selfLink"], isOutput: true);
        _siteName = BicepValue<string>.DefineProperty(this, "SiteName", ["properties", "siteName"], isOutput: true);
        _subjectName = BicepValue<string>.DefineProperty(this, "SubjectName", ["properties", "subjectName"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _thumbprintString = BicepValue<string>.DefineProperty(this, "ThumbprintString", ["properties", "thumbprint"], isOutput: true);
    }

    /// <summary>
    /// Supported AppCertificate resource versions.
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
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2016-03-01.
        /// </summary>
        public static readonly string V2016_03_01 = "2016-03-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-07-01.
        /// </summary>
        public static readonly string V2015_07_01 = "2015-07-01";

        /// <summary>
        /// 2015-06-01.
        /// </summary>
        public static readonly string V2015_06_01 = "2015-06-01";

        /// <summary>
        /// 2015-05-01.
        /// </summary>
        public static readonly string V2015_05_01 = "2015-05-01";

        /// <summary>
        /// 2015-04-01.
        /// </summary>
        public static readonly string V2015_04_01 = "2015-04-01";

        /// <summary>
        /// 2015-02-01.
        /// </summary>
        public static readonly string V2015_02_01 = "2015-02-01";

        /// <summary>
        /// 2014-11-01.
        /// </summary>
        public static readonly string V2014_11_01 = "2014-11-01";

        /// <summary>
        /// 2014-06-01.
        /// </summary>
        public static readonly string V2014_06_01 = "2014-06-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing AppCertificate.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the AppCertificate resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppCertificate.</param>
    /// <returns>The existing AppCertificate resource.</returns>
    public static AppCertificate FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this AppCertificate resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 260, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period);
}
