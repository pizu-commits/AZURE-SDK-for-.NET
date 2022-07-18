// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// ARM resource for a certificate.
    /// Serialized Name: CertificatePatchResource
    /// </summary>
    public partial class CertificatePatch : ResourceData
    {
        /// <summary> Initializes a new instance of CertificatePatch. </summary>
        public CertificatePatch()
        {
            HostNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CertificatePatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="password">
        /// Certificate password.
        /// Serialized Name: CertificatePatchResource.properties.password
        /// </param>
        /// <param name="friendlyName">
        /// Friendly name of the certificate.
        /// Serialized Name: CertificatePatchResource.properties.friendlyName
        /// </param>
        /// <param name="subjectName">
        /// Subject name of the certificate.
        /// Serialized Name: CertificatePatchResource.properties.subjectName
        /// </param>
        /// <param name="hostNames">
        /// Host names the certificate applies to.
        /// Serialized Name: CertificatePatchResource.properties.hostNames
        /// </param>
        /// <param name="pfxBlob">
        /// Pfx blob.
        /// Serialized Name: CertificatePatchResource.properties.pfxBlob
        /// </param>
        /// <param name="siteName">
        /// App name.
        /// Serialized Name: CertificatePatchResource.properties.siteName
        /// </param>
        /// <param name="selfLink">
        /// Self link.
        /// Serialized Name: CertificatePatchResource.properties.selfLink
        /// </param>
        /// <param name="issuer">
        /// Certificate issuer.
        /// Serialized Name: CertificatePatchResource.properties.issuer
        /// </param>
        /// <param name="issueOn">
        /// Certificate issue Date.
        /// Serialized Name: CertificatePatchResource.properties.issueDate
        /// </param>
        /// <param name="expirationOn">
        /// Certificate expiration date.
        /// Serialized Name: CertificatePatchResource.properties.expirationDate
        /// </param>
        /// <param name="thumbprint">
        /// Certificate thumbprint.
        /// Serialized Name: CertificatePatchResource.properties.thumbprint
        /// </param>
        /// <param name="isValid">
        /// Is the certificate valid?.
        /// Serialized Name: CertificatePatchResource.properties.valid
        /// </param>
        /// <param name="cerBlob">
        /// Raw bytes of .cer file
        /// Serialized Name: CertificatePatchResource.properties.cerBlob
        /// </param>
        /// <param name="publicKeyHash">
        /// Public key hash.
        /// Serialized Name: CertificatePatchResource.properties.publicKeyHash
        /// </param>
        /// <param name="hostingEnvironmentProfile">
        /// Specification for the App Service Environment to use for the certificate.
        /// Serialized Name: CertificatePatchResource.properties.hostingEnvironmentProfile
        /// </param>
        /// <param name="keyVaultId">
        /// Key Vault Csm resource Id.
        /// Serialized Name: CertificatePatchResource.properties.keyVaultId
        /// </param>
        /// <param name="keyVaultSecretName">
        /// Key Vault secret name.
        /// Serialized Name: CertificatePatchResource.properties.keyVaultSecretName
        /// </param>
        /// <param name="keyVaultSecretStatus">
        /// Status of the Key Vault secret.
        /// Serialized Name: CertificatePatchResource.properties.keyVaultSecretStatus
        /// </param>
        /// <param name="serverFarmId">
        /// Resource ID of the associated App Service plan, formatted as: &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
        /// Serialized Name: CertificatePatchResource.properties.serverFarmId
        /// </param>
        /// <param name="canonicalName">
        /// CNAME of the certificate to be issued via free certificate
        /// Serialized Name: CertificatePatchResource.properties.canonicalName
        /// </param>
        /// <param name="domainValidationMethod">
        /// Method of domain validation for free cert
        /// Serialized Name: CertificatePatchResource.properties.domainValidationMethod
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal CertificatePatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string password, string friendlyName, string subjectName, IList<string> hostNames, byte[] pfxBlob, string siteName, string selfLink, string issuer, DateTimeOffset? issueOn, DateTimeOffset? expirationOn, string thumbprint, bool? isValid, byte[] cerBlob, string publicKeyHash, HostingEnvironmentProfile hostingEnvironmentProfile, string keyVaultId, string keyVaultSecretName, KeyVaultSecretStatus? keyVaultSecretStatus, string serverFarmId, string canonicalName, string domainValidationMethod, string kind) : base(id, name, resourceType, systemData)
        {
            Password = password;
            FriendlyName = friendlyName;
            SubjectName = subjectName;
            HostNames = hostNames;
            PfxBlob = pfxBlob;
            SiteName = siteName;
            SelfLink = selfLink;
            Issuer = issuer;
            IssueOn = issueOn;
            ExpirationOn = expirationOn;
            Thumbprint = thumbprint;
            IsValid = isValid;
            CerBlob = cerBlob;
            PublicKeyHash = publicKeyHash;
            HostingEnvironmentProfile = hostingEnvironmentProfile;
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            KeyVaultSecretStatus = keyVaultSecretStatus;
            ServerFarmId = serverFarmId;
            CanonicalName = canonicalName;
            DomainValidationMethod = domainValidationMethod;
            Kind = kind;
        }

        /// <summary>
        /// Certificate password.
        /// Serialized Name: CertificatePatchResource.properties.password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Friendly name of the certificate.
        /// Serialized Name: CertificatePatchResource.properties.friendlyName
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// Subject name of the certificate.
        /// Serialized Name: CertificatePatchResource.properties.subjectName
        /// </summary>
        public string SubjectName { get; }
        /// <summary>
        /// Host names the certificate applies to.
        /// Serialized Name: CertificatePatchResource.properties.hostNames
        /// </summary>
        public IList<string> HostNames { get; }
        /// <summary>
        /// Pfx blob.
        /// Serialized Name: CertificatePatchResource.properties.pfxBlob
        /// </summary>
        public byte[] PfxBlob { get; set; }
        /// <summary>
        /// App name.
        /// Serialized Name: CertificatePatchResource.properties.siteName
        /// </summary>
        public string SiteName { get; }
        /// <summary>
        /// Self link.
        /// Serialized Name: CertificatePatchResource.properties.selfLink
        /// </summary>
        public string SelfLink { get; }
        /// <summary>
        /// Certificate issuer.
        /// Serialized Name: CertificatePatchResource.properties.issuer
        /// </summary>
        public string Issuer { get; }
        /// <summary>
        /// Certificate issue Date.
        /// Serialized Name: CertificatePatchResource.properties.issueDate
        /// </summary>
        public DateTimeOffset? IssueOn { get; }
        /// <summary>
        /// Certificate expiration date.
        /// Serialized Name: CertificatePatchResource.properties.expirationDate
        /// </summary>
        public DateTimeOffset? ExpirationOn { get; }
        /// <summary>
        /// Certificate thumbprint.
        /// Serialized Name: CertificatePatchResource.properties.thumbprint
        /// </summary>
        public string Thumbprint { get; }
        /// <summary>
        /// Is the certificate valid?.
        /// Serialized Name: CertificatePatchResource.properties.valid
        /// </summary>
        public bool? IsValid { get; }
        /// <summary>
        /// Raw bytes of .cer file
        /// Serialized Name: CertificatePatchResource.properties.cerBlob
        /// </summary>
        public byte[] CerBlob { get; }
        /// <summary>
        /// Public key hash.
        /// Serialized Name: CertificatePatchResource.properties.publicKeyHash
        /// </summary>
        public string PublicKeyHash { get; }
        /// <summary>
        /// Specification for the App Service Environment to use for the certificate.
        /// Serialized Name: CertificatePatchResource.properties.hostingEnvironmentProfile
        /// </summary>
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; }
        /// <summary>
        /// Key Vault Csm resource Id.
        /// Serialized Name: CertificatePatchResource.properties.keyVaultId
        /// </summary>
        public string KeyVaultId { get; set; }
        /// <summary>
        /// Key Vault secret name.
        /// Serialized Name: CertificatePatchResource.properties.keyVaultSecretName
        /// </summary>
        public string KeyVaultSecretName { get; set; }
        /// <summary>
        /// Status of the Key Vault secret.
        /// Serialized Name: CertificatePatchResource.properties.keyVaultSecretStatus
        /// </summary>
        public KeyVaultSecretStatus? KeyVaultSecretStatus { get; }
        /// <summary>
        /// Resource ID of the associated App Service plan, formatted as: &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
        /// Serialized Name: CertificatePatchResource.properties.serverFarmId
        /// </summary>
        public string ServerFarmId { get; set; }
        /// <summary>
        /// CNAME of the certificate to be issued via free certificate
        /// Serialized Name: CertificatePatchResource.properties.canonicalName
        /// </summary>
        public string CanonicalName { get; set; }
        /// <summary>
        /// Method of domain validation for free cert
        /// Serialized Name: CertificatePatchResource.properties.domainValidationMethod
        /// </summary>
        public string DomainValidationMethod { get; set; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
