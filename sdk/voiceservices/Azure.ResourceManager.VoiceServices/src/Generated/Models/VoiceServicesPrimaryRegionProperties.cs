// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.VoiceServices.Models
{
    /// <summary> The configuration used in this region as primary, and other regions as backup. </summary>
    public partial class VoiceServicesPrimaryRegionProperties
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

        /// <summary> Initializes a new instance of <see cref="VoiceServicesPrimaryRegionProperties"/>. </summary>
        /// <param name="operatorAddresses"> IP address to use to contact the operator network from this region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operatorAddresses"/> is null. </exception>
        public VoiceServicesPrimaryRegionProperties(IEnumerable<string> operatorAddresses)
        {
            Argument.AssertNotNull(operatorAddresses, nameof(operatorAddresses));

            OperatorAddresses = operatorAddresses.ToList();
            EsrpAddresses = new ChangeTrackingList<string>();
            AllowedSignalingSourceAddressPrefixes = new ChangeTrackingList<string>();
            AllowedMediaSourceAddressPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VoiceServicesPrimaryRegionProperties"/>. </summary>
        /// <param name="operatorAddresses"> IP address to use to contact the operator network from this region. </param>
        /// <param name="esrpAddresses"> IP address to use to contact the ESRP from this region. </param>
        /// <param name="allowedSignalingSourceAddressPrefixes"> The allowed source IP address or CIDR ranges for signaling. </param>
        /// <param name="allowedMediaSourceAddressPrefixes"> The allowed source IP address or CIDR ranges for media. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VoiceServicesPrimaryRegionProperties(IList<string> operatorAddresses, IList<string> esrpAddresses, IList<string> allowedSignalingSourceAddressPrefixes, IList<string> allowedMediaSourceAddressPrefixes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OperatorAddresses = operatorAddresses;
            EsrpAddresses = esrpAddresses;
            AllowedSignalingSourceAddressPrefixes = allowedSignalingSourceAddressPrefixes;
            AllowedMediaSourceAddressPrefixes = allowedMediaSourceAddressPrefixes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VoiceServicesPrimaryRegionProperties"/> for deserialization. </summary>
        internal VoiceServicesPrimaryRegionProperties()
        {
        }

        /// <summary> IP address to use to contact the operator network from this region. </summary>
        public IList<string> OperatorAddresses { get; }
        /// <summary> IP address to use to contact the ESRP from this region. </summary>
        public IList<string> EsrpAddresses { get; }
        /// <summary> The allowed source IP address or CIDR ranges for signaling. </summary>
        public IList<string> AllowedSignalingSourceAddressPrefixes { get; }
        /// <summary> The allowed source IP address or CIDR ranges for media. </summary>
        public IList<string> AllowedMediaSourceAddressPrefixes { get; }
    }
}
