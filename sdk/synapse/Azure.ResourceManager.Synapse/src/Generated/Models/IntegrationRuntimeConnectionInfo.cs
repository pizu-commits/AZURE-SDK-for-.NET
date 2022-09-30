// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Connection information for encrypting the on-premises data source credentials. </summary>
    public partial class IntegrationRuntimeConnectionInfo
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeConnectionInfo. </summary>
        internal IntegrationRuntimeConnectionInfo()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeConnectionInfo. </summary>
        /// <param name="serviceToken"> The token generated in service. Callers use this token to authenticate to integration runtime. </param>
        /// <param name="identityCertThumbprint"> The integration runtime SSL certificate thumbprint. Click-Once application uses it to do server validation. </param>
        /// <param name="hostServiceUri"> The on-premises integration runtime host URL. </param>
        /// <param name="version"> The integration runtime version. </param>
        /// <param name="publicKey"> The public key for encrypting a credential when transferring the credential to the integration runtime. </param>
        /// <param name="isIdentityCertExprired"> Whether the identity certificate is expired. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IntegrationRuntimeConnectionInfo(string serviceToken, string identityCertThumbprint, Uri hostServiceUri, string version, string publicKey, bool? isIdentityCertExprired, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            ServiceToken = serviceToken;
            IdentityCertThumbprint = identityCertThumbprint;
            HostServiceUri = hostServiceUri;
            Version = version;
            PublicKey = publicKey;
            IsIdentityCertExprired = isIdentityCertExprired;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The token generated in service. Callers use this token to authenticate to integration runtime. </summary>
        public string ServiceToken { get; }
        /// <summary> The integration runtime SSL certificate thumbprint. Click-Once application uses it to do server validation. </summary>
        public string IdentityCertThumbprint { get; }
        /// <summary> The on-premises integration runtime host URL. </summary>
        public Uri HostServiceUri { get; }
        /// <summary> The integration runtime version. </summary>
        public string Version { get; }
        /// <summary> The public key for encrypting a credential when transferring the credential to the integration runtime. </summary>
        public string PublicKey { get; }
        /// <summary> Whether the identity certificate is expired. </summary>
        public bool? IsIdentityCertExprired { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
