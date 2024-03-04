// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Maps;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> Parameters used to create an account Shared Access Signature (SAS) token. The REST API access control is provided by Azure Maps Role Based Access (RBAC) identity and access. </summary>
    public partial class MapsAccountSasContent
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

        /// <summary> Initializes a new instance of <see cref="MapsAccountSasContent"/>. </summary>
        /// <param name="signingKey"> The Map account key to use for signing. </param>
        /// <param name="principalId"> The principal Id also known as the object Id of a User Assigned Managed Identity currently assigned to the Map Account. To assign a Managed Identity of the account, use operation Create or Update an assign a User Assigned Identity resource Id. </param>
        /// <param name="maxRatePerSecond"> Required parameter which represents the desired maximum request per second to allowed for the given SAS token. This does not guarantee perfect accuracy in measurements but provides application safe guards of abuse with eventual enforcement. </param>
        /// <param name="start"> The date time offset of when the token validity begins. For example "2017-05-24T10:42:03.1567373Z". </param>
        /// <param name="expiry"> The date time offset of when the token validity expires. For example "2017-05-24T10:42:03.1567373Z". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="principalId"/>, <paramref name="start"/> or <paramref name="expiry"/> is null. </exception>
        public MapsAccountSasContent(MapsSigningKey signingKey, string principalId, int maxRatePerSecond, string start, string expiry)
        {
            if (principalId == null)
            {
                throw new ArgumentNullException(nameof(principalId));
            }
            if (start == null)
            {
                throw new ArgumentNullException(nameof(start));
            }
            if (expiry == null)
            {
                throw new ArgumentNullException(nameof(expiry));
            }

            SigningKey = signingKey;
            PrincipalId = principalId;
            Regions = new ChangeTrackingList<string>();
            MaxRatePerSecond = maxRatePerSecond;
            Start = start;
            Expiry = expiry;
        }

        /// <summary> Initializes a new instance of <see cref="MapsAccountSasContent"/>. </summary>
        /// <param name="signingKey"> The Map account key to use for signing. </param>
        /// <param name="principalId"> The principal Id also known as the object Id of a User Assigned Managed Identity currently assigned to the Map Account. To assign a Managed Identity of the account, use operation Create or Update an assign a User Assigned Identity resource Id. </param>
        /// <param name="regions"> Optional, allows control of which region locations are permitted access to Azure Maps REST APIs with the SAS token. Example: "eastus", "westus2". Omitting this parameter will allow all region locations to be accessible. </param>
        /// <param name="maxRatePerSecond"> Required parameter which represents the desired maximum request per second to allowed for the given SAS token. This does not guarantee perfect accuracy in measurements but provides application safe guards of abuse with eventual enforcement. </param>
        /// <param name="start"> The date time offset of when the token validity begins. For example "2017-05-24T10:42:03.1567373Z". </param>
        /// <param name="expiry"> The date time offset of when the token validity expires. For example "2017-05-24T10:42:03.1567373Z". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MapsAccountSasContent(MapsSigningKey signingKey, string principalId, IList<string> regions, int maxRatePerSecond, string start, string expiry, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SigningKey = signingKey;
            PrincipalId = principalId;
            Regions = regions;
            MaxRatePerSecond = maxRatePerSecond;
            Start = start;
            Expiry = expiry;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MapsAccountSasContent"/> for deserialization. </summary>
        internal MapsAccountSasContent()
        {
        }

        /// <summary> The Map account key to use for signing. </summary>
        public MapsSigningKey SigningKey { get; }
        /// <summary> The principal Id also known as the object Id of a User Assigned Managed Identity currently assigned to the Map Account. To assign a Managed Identity of the account, use operation Create or Update an assign a User Assigned Identity resource Id. </summary>
        public string PrincipalId { get; }
        /// <summary> Optional, allows control of which region locations are permitted access to Azure Maps REST APIs with the SAS token. Example: "eastus", "westus2". Omitting this parameter will allow all region locations to be accessible. </summary>
        public IList<string> Regions { get; }
        /// <summary> Required parameter which represents the desired maximum request per second to allowed for the given SAS token. This does not guarantee perfect accuracy in measurements but provides application safe guards of abuse with eventual enforcement. </summary>
        public int MaxRatePerSecond { get; }
        /// <summary> The date time offset of when the token validity begins. For example "2017-05-24T10:42:03.1567373Z". </summary>
        public string Start { get; }
        /// <summary> The date time offset of when the token validity expires. For example "2017-05-24T10:42:03.1567373Z". </summary>
        public string Expiry { get; }
    }
}
