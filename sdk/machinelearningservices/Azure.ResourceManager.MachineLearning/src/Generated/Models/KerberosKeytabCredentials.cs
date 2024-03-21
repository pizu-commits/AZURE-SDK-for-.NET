// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The KerberosKeytabCredentials. </summary>
    public partial class KerberosKeytabCredentials : MachineLearningDatastoreCredentials
    {
        /// <summary> Initializes a new instance of <see cref="KerberosKeytabCredentials"/>. </summary>
        /// <param name="secrets"> [Required] Keytab secrets. </param>
        /// <param name="kerberosKdcAddress"> [Required] IP Address or DNS HostName. </param>
        /// <param name="kerberosPrincipal"> [Required] Kerberos Username. </param>
        /// <param name="kerberosRealm"> [Required] Domain over which a Kerberos authentication server has the authority to authenticate a user, host or service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secrets"/>, <paramref name="kerberosKdcAddress"/>, <paramref name="kerberosPrincipal"/> or <paramref name="kerberosRealm"/> is null. </exception>
        public KerberosKeytabCredentials(KerberosKeytabSecrets secrets, string kerberosKdcAddress, string kerberosPrincipal, string kerberosRealm)
        {
            Argument.AssertNotNull(secrets, nameof(secrets));
            Argument.AssertNotNull(kerberosKdcAddress, nameof(kerberosKdcAddress));
            Argument.AssertNotNull(kerberosPrincipal, nameof(kerberosPrincipal));
            Argument.AssertNotNull(kerberosRealm, nameof(kerberosRealm));

            Secrets = secrets;
            KerberosKdcAddress = kerberosKdcAddress;
            KerberosPrincipal = kerberosPrincipal;
            KerberosRealm = kerberosRealm;
            CredentialsType = CredentialsType.KerberosKeytab;
        }

        /// <summary> Initializes a new instance of <see cref="KerberosKeytabCredentials"/>. </summary>
        /// <param name="credentialsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="secrets"> [Required] Keytab secrets. </param>
        /// <param name="kerberosKdcAddress"> [Required] IP Address or DNS HostName. </param>
        /// <param name="kerberosPrincipal"> [Required] Kerberos Username. </param>
        /// <param name="kerberosRealm"> [Required] Domain over which a Kerberos authentication server has the authority to authenticate a user, host or service. </param>
        internal KerberosKeytabCredentials(CredentialsType credentialsType, IDictionary<string, BinaryData> serializedAdditionalRawData, KerberosKeytabSecrets secrets, string kerberosKdcAddress, string kerberosPrincipal, string kerberosRealm) : base(credentialsType, serializedAdditionalRawData)
        {
            Secrets = secrets;
            KerberosKdcAddress = kerberosKdcAddress;
            KerberosPrincipal = kerberosPrincipal;
            KerberosRealm = kerberosRealm;
            CredentialsType = credentialsType;
        }

        /// <summary> Initializes a new instance of <see cref="KerberosKeytabCredentials"/> for deserialization. </summary>
        internal KerberosKeytabCredentials()
        {
        }

        /// <summary> [Required] Keytab secrets. </summary>
        public KerberosKeytabSecrets Secrets { get; set; }
        /// <summary> [Required] IP Address or DNS HostName. </summary>
        public string KerberosKdcAddress { get; set; }
        /// <summary> [Required] Kerberos Username. </summary>
        public string KerberosPrincipal { get; set; }
        /// <summary> [Required] Domain over which a Kerberos authentication server has the authority to authenticate a user, host or service. </summary>
        public string KerberosRealm { get; set; }
    }
}
