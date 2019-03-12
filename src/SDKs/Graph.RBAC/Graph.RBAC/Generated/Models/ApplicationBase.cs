// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Active Directive Application common properties shared among GET, POST
    /// and PATCH
    /// </summary>
    public partial class ApplicationBase
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationBase class.
        /// </summary>
        public ApplicationBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationBase class.
        /// </summary>
        /// <param name="allowGuestsSignIn">A property on the application to
        /// indicate if the application accepts other IDPs or not or partially
        /// accepts.</param>
        /// <param name="allowPassthroughUsers">Indicates that the application
        /// supports pass through users who have no presence in the resource
        /// tenant.</param>
        /// <param name="appLogoUrl">The url for the application logo image
        /// stored in a CDN.</param>
        /// <param name="appRoles">The collection of application roles that an
        /// application may declare. These roles can be assigned to users,
        /// groups or service principals.</param>
        /// <param name="appPermissions">The application permissions.</param>
        /// <param name="availableToOtherTenants">Whether the application is
        /// available to other tenants.</param>
        /// <param name="errorUrl">A URL provided by the author of the
        /// application to report errors when using the application.</param>
        /// <param name="groupMembershipClaims">Configures the groups claim
        /// issued in a user or OAuth 2.0 access token that the app
        /// expects.</param>
        /// <param name="homepage">The home page of the application.</param>
        /// <param name="informationalUrls">urls with more informations of the
        /// application.</param>
        /// <param name="isDeviceOnlyAuthSupported">Specifies whether this
        /// application supports device authentication without a user. The
        /// default is false.</param>
        /// <param name="keyCredentials">A collection of KeyCredential
        /// objects.</param>
        /// <param name="knownClientApplications">Client applications that are
        /// tied to this resource application. Consent to any of the known
        /// client applications will result in implicit consent to the resource
        /// application through a combined consent dialog (showing the OAuth
        /// permission scopes required by the client and the resource).</param>
        /// <param name="logoutUrl">the url of the logout page</param>
        /// <param name="oauth2AllowImplicitFlow">Whether to allow implicit
        /// grant flow for OAuth2</param>
        /// <param name="oauth2AllowUrlPathMatching">Specifies whether during a
        /// token Request Azure AD will allow path matching of the redirect URI
        /// against the applications collection of replyURLs. The default is
        /// false.</param>
        /// <param name="oauth2Permissions">The collection of OAuth 2.0
        /// permission scopes that the web API (resource) application exposes
        /// to client applications. These permission scopes may be granted to
        /// client applications during consent.</param>
        /// <param name="oauth2RequirePostResponse">Specifies whether, as part
        /// of OAuth 2.0 token requests, Azure AD will allow POST requests, as
        /// opposed to GET requests. The default is false, which specifies that
        /// only GET requests will be allowed.</param>
        /// <param name="orgRestrictions">A list of tenants allowed to access
        /// application.</param>
        /// <param name="passwordCredentials">A collection of
        /// PasswordCredential objects</param>
        /// <param name="preAuthorizedApplications">list of pre-authorizaed
        /// applications.</param>
        /// <param name="publicClient">Specifies whether this application is a
        /// public client (such as an installed application running on a mobile
        /// device). Default is false.</param>
        /// <param name="publisherDomain">Reliable domain which can be used to
        /// identify an application.</param>
        /// <param name="replyUrls">A collection of reply URLs for the
        /// application.</param>
        /// <param name="requiredResourceAccess">Specifies resources that this
        /// application requires access to and the set of OAuth permission
        /// scopes and application roles that it needs under each of those
        /// resources. This pre-configuration of required resource access
        /// drives the consent experience.</param>
        /// <param name="samlMetadataUrl">The URL to the SAML metadata for the
        /// application.</param>
        /// <param name="signInAudience">Audience for signing in to the
        /// application (AzureADMyOrganizatio, AzureADAllorganizations,
        /// AzureADAndMicrosofAccounts).</param>
        /// <param name="wwwHomepage">The primary Web page.</param>
        public ApplicationBase(bool? allowGuestsSignIn = default(bool?), bool? allowPassthroughUsers = default(bool?), string appLogoUrl = default(string), IList<AppRole> appRoles = default(IList<AppRole>), IList<string> appPermissions = default(IList<string>), bool? availableToOtherTenants = default(bool?), string errorUrl = default(string), object groupMembershipClaims = default(object), string homepage = default(string), InformationalUrl informationalUrls = default(InformationalUrl), bool? isDeviceOnlyAuthSupported = default(bool?), IList<KeyCredential> keyCredentials = default(IList<KeyCredential>), IList<string> knownClientApplications = default(IList<string>), string logoutUrl = default(string), bool? oauth2AllowImplicitFlow = default(bool?), bool? oauth2AllowUrlPathMatching = default(bool?), IList<OAuth2Permission> oauth2Permissions = default(IList<OAuth2Permission>), bool? oauth2RequirePostResponse = default(bool?), IList<string> orgRestrictions = default(IList<string>), OptionalClaims optionalClaims = default(OptionalClaims), IList<PasswordCredential> passwordCredentials = default(IList<PasswordCredential>), IList<PreAuthorizedApplication> preAuthorizedApplications = default(IList<PreAuthorizedApplication>), bool? publicClient = default(bool?), string publisherDomain = default(string), IList<string> replyUrls = default(IList<string>), IList<RequiredResourceAccess> requiredResourceAccess = default(IList<RequiredResourceAccess>), string samlMetadataUrl = default(string), string signInAudience = default(string), string wwwHomepage = default(string))
        {
            AllowGuestsSignIn = allowGuestsSignIn;
            AllowPassthroughUsers = allowPassthroughUsers;
            AppLogoUrl = appLogoUrl;
            AppRoles = appRoles;
            AppPermissions = appPermissions;
            AvailableToOtherTenants = availableToOtherTenants;
            ErrorUrl = errorUrl;
            GroupMembershipClaims = groupMembershipClaims;
            Homepage = homepage;
            InformationalUrls = informationalUrls;
            IsDeviceOnlyAuthSupported = isDeviceOnlyAuthSupported;
            KeyCredentials = keyCredentials;
            KnownClientApplications = knownClientApplications;
            LogoutUrl = logoutUrl;
            Oauth2AllowImplicitFlow = oauth2AllowImplicitFlow;
            Oauth2AllowUrlPathMatching = oauth2AllowUrlPathMatching;
            Oauth2Permissions = oauth2Permissions;
            Oauth2RequirePostResponse = oauth2RequirePostResponse;
            OrgRestrictions = orgRestrictions;
            OptionalClaims = optionalClaims;
            PasswordCredentials = passwordCredentials;
            PreAuthorizedApplications = preAuthorizedApplications;
            PublicClient = publicClient;
            PublisherDomain = publisherDomain;
            ReplyUrls = replyUrls;
            RequiredResourceAccess = requiredResourceAccess;
            SamlMetadataUrl = samlMetadataUrl;
            SignInAudience = signInAudience;
            WwwHomepage = wwwHomepage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a property on the application to indicate if the
        /// application accepts other IDPs or not or partially accepts.
        /// </summary>
        [JsonProperty(PropertyName = "allowGuestsSignIn")]
        public bool? AllowGuestsSignIn { get; set; }

        /// <summary>
        /// Gets or sets indicates that the application supports pass through
        /// users who have no presence in the resource tenant.
        /// </summary>
        [JsonProperty(PropertyName = "allowPassthroughUsers")]
        public bool? AllowPassthroughUsers { get; set; }

        /// <summary>
        /// Gets or sets the url for the application logo image stored in a
        /// CDN.
        /// </summary>
        [JsonProperty(PropertyName = "appLogoUrl")]
        public string AppLogoUrl { get; set; }

        /// <summary>
        /// Gets or sets the collection of application roles that an
        /// application may declare. These roles can be assigned to users,
        /// groups or service principals.
        /// </summary>
        [JsonProperty(PropertyName = "appRoles")]
        public IList<AppRole> AppRoles { get; set; }

        /// <summary>
        /// Gets or sets the application permissions.
        /// </summary>
        [JsonProperty(PropertyName = "appPermissions")]
        public IList<string> AppPermissions { get; set; }

        /// <summary>
        /// Gets or sets whether the application is available to other tenants.
        /// </summary>
        [JsonProperty(PropertyName = "availableToOtherTenants")]
        public bool? AvailableToOtherTenants { get; set; }

        /// <summary>
        /// Gets or sets a URL provided by the author of the application to
        /// report errors when using the application.
        /// </summary>
        [JsonProperty(PropertyName = "errorUrl")]
        public string ErrorUrl { get; set; }

        /// <summary>
        /// Gets or sets configures the groups claim issued in a user or OAuth
        /// 2.0 access token that the app expects.
        /// </summary>
        [JsonProperty(PropertyName = "groupMembershipClaims")]
        public object GroupMembershipClaims { get; set; }

        /// <summary>
        /// Gets or sets the home page of the application.
        /// </summary>
        [JsonProperty(PropertyName = "homepage")]
        public string Homepage { get; set; }

        /// <summary>
        /// Gets or sets urls with more informations of the application.
        /// </summary>
        [JsonProperty(PropertyName = "informationalUrls")]
        public InformationalUrl InformationalUrls { get; set; }

        /// <summary>
        /// Gets or sets specifies whether this application supports device
        /// authentication without a user. The default is false.
        /// </summary>
        [JsonProperty(PropertyName = "isDeviceOnlyAuthSupported")]
        public bool? IsDeviceOnlyAuthSupported { get; set; }

        /// <summary>
        /// Gets or sets a collection of KeyCredential objects.
        /// </summary>
        [JsonProperty(PropertyName = "keyCredentials")]
        public IList<KeyCredential> KeyCredentials { get; set; }

        /// <summary>
        /// Gets or sets client applications that are tied to this resource
        /// application. Consent to any of the known client applications will
        /// result in implicit consent to the resource application through a
        /// combined consent dialog (showing the OAuth permission scopes
        /// required by the client and the resource).
        /// </summary>
        [JsonProperty(PropertyName = "knownClientApplications")]
        public IList<string> KnownClientApplications { get; set; }

        /// <summary>
        /// Gets or sets the url of the logout page
        /// </summary>
        [JsonProperty(PropertyName = "logoutUrl")]
        public string LogoutUrl { get; set; }

        /// <summary>
        /// Gets or sets whether to allow implicit grant flow for OAuth2
        /// </summary>
        [JsonProperty(PropertyName = "oauth2AllowImplicitFlow")]
        public bool? Oauth2AllowImplicitFlow { get; set; }

        /// <summary>
        /// Gets or sets specifies whether during a token Request Azure AD will
        /// allow path matching of the redirect URI against the applications
        /// collection of replyURLs. The default is false.
        /// </summary>
        [JsonProperty(PropertyName = "oauth2AllowUrlPathMatching")]
        public bool? Oauth2AllowUrlPathMatching { get; set; }

        /// <summary>
        /// Gets or sets the collection of OAuth 2.0 permission scopes that the
        /// web API (resource) application exposes to client applications.
        /// These permission scopes may be granted to client applications
        /// during consent.
        /// </summary>
        [JsonProperty(PropertyName = "oauth2Permissions")]
        public IList<OAuth2Permission> Oauth2Permissions { get; set; }

        /// <summary>
        /// Gets or sets specifies whether, as part of OAuth 2.0 token
        /// requests, Azure AD will allow POST requests, as opposed to GET
        /// requests. The default is false, which specifies that only GET
        /// requests will be allowed.
        /// </summary>
        [JsonProperty(PropertyName = "oauth2RequirePostResponse")]
        public bool? Oauth2RequirePostResponse { get; set; }

        /// <summary>
        /// Gets or sets a list of tenants allowed to access application.
        /// </summary>
        [JsonProperty(PropertyName = "orgRestrictions")]
        public IList<string> OrgRestrictions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "optionalClaims")]
        public OptionalClaims OptionalClaims { get; set; }

        /// <summary>
        /// Gets or sets a collection of PasswordCredential objects
        /// </summary>
        [JsonProperty(PropertyName = "passwordCredentials")]
        public IList<PasswordCredential> PasswordCredentials { get; set; }

        /// <summary>
        /// Gets or sets list of pre-authorizaed applications.
        /// </summary>
        [JsonProperty(PropertyName = "preAuthorizedApplications")]
        public IList<PreAuthorizedApplication> PreAuthorizedApplications { get; set; }

        /// <summary>
        /// Gets or sets specifies whether this application is a public client
        /// (such as an installed application running on a mobile device).
        /// Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "publicClient")]
        public bool? PublicClient { get; set; }

        /// <summary>
        /// Gets or sets reliable domain which can be used to identify an
        /// application.
        /// </summary>
        [JsonProperty(PropertyName = "publisherDomain")]
        public string PublisherDomain { get; set; }

        /// <summary>
        /// Gets or sets a collection of reply URLs for the application.
        /// </summary>
        [JsonProperty(PropertyName = "replyUrls")]
        public IList<string> ReplyUrls { get; set; }

        /// <summary>
        /// Gets or sets specifies resources that this application requires
        /// access to and the set of OAuth permission scopes and application
        /// roles that it needs under each of those resources. This
        /// pre-configuration of required resource access drives the consent
        /// experience.
        /// </summary>
        [JsonProperty(PropertyName = "requiredResourceAccess")]
        public IList<RequiredResourceAccess> RequiredResourceAccess { get; set; }

        /// <summary>
        /// Gets or sets the URL to the SAML metadata for the application.
        /// </summary>
        [JsonProperty(PropertyName = "samlMetadataUrl")]
        public string SamlMetadataUrl { get; set; }

        /// <summary>
        /// Gets or sets audience for signing in to the application
        /// (AzureADMyOrganizatio, AzureADAllorganizations,
        /// AzureADAndMicrosofAccounts).
        /// </summary>
        [JsonProperty(PropertyName = "signInAudience")]
        public string SignInAudience { get; set; }

        /// <summary>
        /// Gets or sets the primary Web page.
        /// </summary>
        [JsonProperty(PropertyName = "wwwHomepage")]
        public string WwwHomepage { get; set; }

    }
}
