// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Confluent.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Confluent
{
    /// <summary>
    /// A class representing the ConfluentOrganization data model.
    /// Organization resource.
    /// </summary>
    public partial class ConfluentOrganizationData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="ConfluentOrganizationData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="offerDetail"> Confluent offer detail. </param>
        /// <param name="userDetail"> Subscriber detail. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerDetail"/> or <paramref name="userDetail"/> is null. </exception>
        public ConfluentOrganizationData(AzureLocation location, ConfluentOfferDetail offerDetail, ConfluentUserDetail userDetail) : base(location)
        {
            if (offerDetail == null)
            {
                throw new ArgumentNullException(nameof(offerDetail));
            }
            if (userDetail == null)
            {
                throw new ArgumentNullException(nameof(userDetail));
            }

            OfferDetail = offerDetail;
            UserDetail = userDetail;
        }

        /// <summary> Initializes a new instance of <see cref="ConfluentOrganizationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="createdOn"> The creation time of the resource. </param>
        /// <param name="provisioningState"> Provision states for confluent RP. </param>
        /// <param name="organizationId"> Id of the Confluent organization. </param>
        /// <param name="ssoUri"> SSO url for the Confluent organization. </param>
        /// <param name="offerDetail"> Confluent offer detail. </param>
        /// <param name="userDetail"> Subscriber detail. </param>
        /// <param name="linkOrganization"> Link an existing Confluent organization. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfluentOrganizationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DateTimeOffset? createdOn, ConfluentProvisionState? provisioningState, Guid? organizationId, Uri ssoUri, ConfluentOfferDetail offerDetail, ConfluentUserDetail userDetail, LinkOrganization linkOrganization, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            OrganizationId = organizationId;
            SsoUri = ssoUri;
            OfferDetail = offerDetail;
            UserDetail = userDetail;
            LinkOrganization = linkOrganization;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConfluentOrganizationData"/> for deserialization. </summary>
        internal ConfluentOrganizationData()
        {
        }

        /// <summary> The creation time of the resource. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Provision states for confluent RP. </summary>
        public ConfluentProvisionState? ProvisioningState { get; }
        /// <summary> Id of the Confluent organization. </summary>
        public Guid? OrganizationId { get; }
        /// <summary> SSO url for the Confluent organization. </summary>
        public Uri SsoUri { get; }
        /// <summary> Confluent offer detail. </summary>
        public ConfluentOfferDetail OfferDetail { get; set; }
        /// <summary> Subscriber detail. </summary>
        public ConfluentUserDetail UserDetail { get; set; }
        /// <summary> Link an existing Confluent organization. </summary>
        internal LinkOrganization LinkOrganization { get; set; }
        /// <summary> User auth token. </summary>
        public string LinkOrganizationToken
        {
            get => LinkOrganization is null ? default : LinkOrganization.Token;
            set => LinkOrganization = new LinkOrganization(value);
        }
    }
}
