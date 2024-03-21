// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains the information necessary to perform import operation for existing database. </summary>
    public partial class ImportExistingDatabaseDefinition
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

        /// <summary> Initializes a new instance of <see cref="ImportExistingDatabaseDefinition"/>. </summary>
        /// <param name="storageKeyType"> Storage key type. </param>
        /// <param name="storageKey"> Storage key. </param>
        /// <param name="storageUri"> Storage Uri. </param>
        /// <param name="administratorLogin"> Administrator login name. </param>
        /// <param name="administratorLoginPassword"> Administrator login password. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageKey"/>, <paramref name="storageUri"/>, <paramref name="administratorLogin"/> or <paramref name="administratorLoginPassword"/> is null. </exception>
        public ImportExistingDatabaseDefinition(StorageKeyType storageKeyType, string storageKey, Uri storageUri, string administratorLogin, string administratorLoginPassword)
        {
            Argument.AssertNotNull(storageKey, nameof(storageKey));
            Argument.AssertNotNull(storageUri, nameof(storageUri));
            Argument.AssertNotNull(administratorLogin, nameof(administratorLogin));
            Argument.AssertNotNull(administratorLoginPassword, nameof(administratorLoginPassword));

            StorageKeyType = storageKeyType;
            StorageKey = storageKey;
            StorageUri = storageUri;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
        }

        /// <summary> Initializes a new instance of <see cref="ImportExistingDatabaseDefinition"/>. </summary>
        /// <param name="storageKeyType"> Storage key type. </param>
        /// <param name="storageKey"> Storage key. </param>
        /// <param name="storageUri"> Storage Uri. </param>
        /// <param name="administratorLogin"> Administrator login name. </param>
        /// <param name="administratorLoginPassword"> Administrator login password. </param>
        /// <param name="authenticationType"> Authentication type. </param>
        /// <param name="networkIsolation"> Optional resource information to enable network isolation for request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImportExistingDatabaseDefinition(StorageKeyType storageKeyType, string storageKey, Uri storageUri, string administratorLogin, string administratorLoginPassword, string authenticationType, NetworkIsolationSettings networkIsolation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageKeyType = storageKeyType;
            StorageKey = storageKey;
            StorageUri = storageUri;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            AuthenticationType = authenticationType;
            NetworkIsolation = networkIsolation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ImportExistingDatabaseDefinition"/> for deserialization. </summary>
        internal ImportExistingDatabaseDefinition()
        {
        }

        /// <summary> Storage key type. </summary>
        public StorageKeyType StorageKeyType { get; }
        /// <summary> Storage key. </summary>
        public string StorageKey { get; }
        /// <summary> Storage Uri. </summary>
        public Uri StorageUri { get; }
        /// <summary> Administrator login name. </summary>
        public string AdministratorLogin { get; }
        /// <summary> Administrator login password. </summary>
        public string AdministratorLoginPassword { get; }
        /// <summary> Authentication type. </summary>
        public string AuthenticationType { get; set; }
        /// <summary> Optional resource information to enable network isolation for request. </summary>
        public NetworkIsolationSettings NetworkIsolation { get; set; }
    }
}
