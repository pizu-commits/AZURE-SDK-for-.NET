// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Certificate resource specific properties. </summary>
    public partial class ContainerAppCertificateProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppCertificateProperties"/>. </summary>
        public ContainerAppCertificateProperties()
        {
            SubjectAlternativeNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCertificateProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the certificate. </param>
        /// <param name="password"> Certificate password. </param>
        /// <param name="subjectName"> Subject name of the certificate. </param>
        /// <param name="subjectAlternativeNames"> Subject alternative names the certificate applies to. </param>
        /// <param name="value"> PFX or PEM blob. </param>
        /// <param name="issuer"> Certificate issuer. </param>
        /// <param name="issueOn"> Certificate issue Date. </param>
        /// <param name="expireOn"> Certificate expiration date. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="isValid"> Is the certificate valid?. </param>
        /// <param name="publicKeyHash"> Public key hash. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppCertificateProperties(ContainerAppCertificateProvisioningState? provisioningState, string password, string subjectName, IReadOnlyList<string> subjectAlternativeNames, byte[] value, string issuer, DateTimeOffset? issueOn, DateTimeOffset? expireOn, string thumbprint, bool? isValid, string publicKeyHash, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Password = password;
            SubjectName = subjectName;
            SubjectAlternativeNames = subjectAlternativeNames;
            Value = value;
            Issuer = issuer;
            IssueOn = issueOn;
            ExpireOn = expireOn;
            Thumbprint = thumbprint;
            IsValid = isValid;
            PublicKeyHash = publicKeyHash;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provisioning state of the certificate. </summary>
        public ContainerAppCertificateProvisioningState? ProvisioningState { get; }
        /// <summary> Certificate password. </summary>
        public string Password { get; set; }
        /// <summary> Subject name of the certificate. </summary>
        public string SubjectName { get; }
        /// <summary> Subject alternative names the certificate applies to. </summary>
        public IReadOnlyList<string> SubjectAlternativeNames { get; }
        /// <summary> PFX or PEM blob. </summary>
        public byte[] Value { get; set; }
        /// <summary> Certificate issuer. </summary>
        public string Issuer { get; }
        /// <summary> Certificate issue Date. </summary>
        public DateTimeOffset? IssueOn { get; }
        /// <summary> Certificate expiration date. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> Certificate thumbprint. </summary>
        public string Thumbprint { get; }
        /// <summary> Is the certificate valid?. </summary>
        public bool? IsValid { get; }
        /// <summary> Public key hash. </summary>
        public string PublicKeyHash { get; }
    }
}
