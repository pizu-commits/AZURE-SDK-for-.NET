// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlServer.
/// </summary>
public partial class SqlServer : Resource
{
    /// <summary>
    /// The name of the server.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Administrator username for the server. Once created it cannot be
    /// changed.
    /// </summary>
    public BicepValue<string> AdministratorLogin { get => _administratorLogin; set => _administratorLogin.Assign(value); }
    private readonly BicepValue<string> _administratorLogin;

    /// <summary>
    /// The administrator login password (required for server creation).
    /// </summary>
    public BicepValue<string> AdministratorLoginPassword { get => _administratorLoginPassword; set => _administratorLoginPassword.Assign(value); }
    private readonly BicepValue<string> _administratorLoginPassword;

    /// <summary>
    /// The Azure Active Directory administrator of the server. This can only
    /// be used at server create time. If used for server update, it will be
    /// ignored or it will result in an error. For updates individual APIs
    /// will need to be used.
    /// </summary>
    public BicepValue<ServerExternalAdministrator> Administrators { get => _administrators; set => _administrators.Assign(value); }
    private readonly BicepValue<ServerExternalAdministrator> _administrators;

    /// <summary>
    /// The Client id used for cross tenant CMK scenario.
    /// </summary>
    public BicepValue<Guid> FederatedClientId { get => _federatedClientId; set => _federatedClientId.Assign(value); }
    private readonly BicepValue<Guid> _federatedClientId;

    /// <summary>
    /// The Azure Active Directory identity of the server.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// Whether or not to enable IPv6 support for this server.  Value is
    /// optional but if passed in, must be &apos;Enabled&apos; or
    /// &apos;Disabled&apos;.
    /// </summary>
    public BicepValue<ServerNetworkAccessFlag> IsIPv6Enabled { get => _isIPv6Enabled; set => _isIPv6Enabled.Assign(value); }
    private readonly BicepValue<ServerNetworkAccessFlag> _isIPv6Enabled;

    /// <summary>
    /// A CMK URI of the key to use for encryption.
    /// </summary>
    public BicepValue<Uri> KeyId { get => _keyId; set => _keyId.Assign(value); }
    private readonly BicepValue<Uri> _keyId;

    /// <summary>
    /// Minimal TLS version. Allowed values: &apos;None&apos;, 1.0&apos;,
    /// &apos;1.1&apos;, &apos;1.2&apos;, &apos;1.3&apos;.
    /// </summary>
    public BicepValue<SqlMinimalTlsVersion> MinTlsVersion { get => _minTlsVersion; set => _minTlsVersion.Assign(value); }
    private readonly BicepValue<SqlMinimalTlsVersion> _minTlsVersion;

    /// <summary>
    /// The resource id of a user assigned identity to be used by default.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrimaryUserAssignedIdentityId { get => _primaryUserAssignedIdentityId; set => _primaryUserAssignedIdentityId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _primaryUserAssignedIdentityId;

    /// <summary>
    /// Whether or not public endpoint access is allowed for this server.
    /// Value is optional but if passed in, must be &apos;Enabled&apos; or
    /// &apos;Disabled&apos; or &apos;SecuredByPerimeter&apos;.
    /// </summary>
    public BicepValue<ServerNetworkAccessFlag> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<ServerNetworkAccessFlag> _publicNetworkAccess;

    /// <summary>
    /// Whether or not to restrict outbound network access for this server.
    /// Value is optional but if passed in, must be &apos;Enabled&apos; or
    /// &apos;Disabled&apos;.
    /// </summary>
    public BicepValue<ServerNetworkAccessFlag> RestrictOutboundNetworkAccess { get => _restrictOutboundNetworkAccess; set => _restrictOutboundNetworkAccess.Assign(value); }
    private readonly BicepValue<ServerNetworkAccessFlag> _restrictOutboundNetworkAccess;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// The version of the server.
    /// </summary>
    public BicepValue<string> Version { get => _version; set => _version.Assign(value); }
    private readonly BicepValue<string> _version;

    /// <summary>
    /// Status of external governance.
    /// </summary>
    public BicepValue<ExternalGovernanceStatus> ExternalGovernanceStatus { get => _externalGovernanceStatus; }
    private readonly BicepValue<ExternalGovernanceStatus> _externalGovernanceStatus;

    /// <summary>
    /// The fully qualified domain name of the server.
    /// </summary>
    public BicepValue<string> FullyQualifiedDomainName { get => _fullyQualifiedDomainName; }
    private readonly BicepValue<string> _fullyQualifiedDomainName;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Kind of sql server. This is metadata used for the Azure portal
    /// experience.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// List of private endpoint connections on a server.
    /// </summary>
    public BicepList<SqlServerPrivateEndpointConnection> PrivateEndpointConnections { get => _privateEndpointConnections; }
    private readonly BicepList<SqlServerPrivateEndpointConnection> _privateEndpointConnections;

    /// <summary>
    /// The state of the server.
    /// </summary>
    public BicepValue<string> State { get => _state; }
    private readonly BicepValue<string> _state;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Whether or not existing server has a workspace created and if it allows
    /// connection from workspace.
    /// </summary>
    public BicepValue<ServerWorkspaceFeature> WorkspaceFeature { get => _workspaceFeature; }
    private readonly BicepValue<ServerWorkspaceFeature> _workspaceFeature;

    /// <summary>
    /// Creates a new SqlServer.
    /// </summary>
    /// <param name="resourceName">Name of the SqlServer.</param>
    /// <param name="resourceVersion">Version of the SqlServer.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SqlServer(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Sql/servers", resourceVersion ?? "2021-11-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _administratorLogin = BicepValue<string>.DefineProperty(this, "AdministratorLogin", ["properties", "administratorLogin"]);
        _administratorLoginPassword = BicepValue<string>.DefineProperty(this, "AdministratorLoginPassword", ["properties", "administratorLoginPassword"]);
        _administrators = BicepValue<ServerExternalAdministrator>.DefineProperty(this, "Administrators", ["properties", "administrators"]);
        _federatedClientId = BicepValue<Guid>.DefineProperty(this, "FederatedClientId", ["properties", "federatedClientId"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _isIPv6Enabled = BicepValue<ServerNetworkAccessFlag>.DefineProperty(this, "IsIPv6Enabled", ["properties", "isIPv6Enabled"]);
        _keyId = BicepValue<Uri>.DefineProperty(this, "KeyId", ["properties", "keyId"]);
        _minTlsVersion = BicepValue<SqlMinimalTlsVersion>.DefineProperty(this, "MinTlsVersion", ["properties", "minimalTlsVersion"]);
        _primaryUserAssignedIdentityId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrimaryUserAssignedIdentityId", ["properties", "primaryUserAssignedIdentityId"]);
        _publicNetworkAccess = BicepValue<ServerNetworkAccessFlag>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _restrictOutboundNetworkAccess = BicepValue<ServerNetworkAccessFlag>.DefineProperty(this, "RestrictOutboundNetworkAccess", ["properties", "restrictOutboundNetworkAccess"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _version = BicepValue<string>.DefineProperty(this, "Version", ["properties", "version"]);
        _externalGovernanceStatus = BicepValue<ExternalGovernanceStatus>.DefineProperty(this, "ExternalGovernanceStatus", ["properties", "externalGovernanceStatus"], isOutput: true);
        _fullyQualifiedDomainName = BicepValue<string>.DefineProperty(this, "FullyQualifiedDomainName", ["properties", "fullyQualifiedDomainName"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"], isOutput: true);
        _privateEndpointConnections = BicepList<SqlServerPrivateEndpointConnection>.DefineProperty(this, "PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _state = BicepValue<string>.DefineProperty(this, "State", ["properties", "state"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _workspaceFeature = BicepValue<ServerWorkspaceFeature>.DefineProperty(this, "WorkspaceFeature", ["properties", "workspaceFeature"], isOutput: true);
    }

    /// <summary>
    /// Supported SqlServer resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";

        /// <summary>
        /// 2014-01-01.
        /// </summary>
        public static readonly string V2014_01_01 = "2014-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlServer.
    /// </summary>
    /// <param name="resourceName">Name of the SqlServer.</param>
    /// <param name="resourceVersion">Version of the SqlServer.</param>
    /// <returns>The existing SqlServer resource.</returns>
    public static SqlServer FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this SqlServer resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 63, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Assign a role to a user-assigned identity that grants access to this
    /// SqlServer.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(SqlBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{ResourceName}_{identity.ResourceName}_{SqlBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Assign a role to a principal that grants access to this SqlServer.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(SqlBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId) =>
        new($"{ResourceName}_{SqlBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
