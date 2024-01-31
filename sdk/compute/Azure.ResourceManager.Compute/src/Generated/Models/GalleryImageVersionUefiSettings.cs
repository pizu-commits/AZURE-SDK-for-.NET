// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Contains UEFI settings for the image version. </summary>
    public partial class GalleryImageVersionUefiSettings
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

        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionUefiSettings"/>. </summary>
        public GalleryImageVersionUefiSettings()
        {
            SignatureTemplateNames = new ChangeTrackingList<UefiSignatureTemplateName>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionUefiSettings"/>. </summary>
        /// <param name="signatureTemplateNames"> The name of the template(s) that contains default UEFI key signatures that will be added to the image. </param>
        /// <param name="additionalSignatures"> Additional UEFI key signatures that will be added to the image in addition to the signature templates. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryImageVersionUefiSettings(IList<UefiSignatureTemplateName> signatureTemplateNames, UefiKeySignatures additionalSignatures, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SignatureTemplateNames = signatureTemplateNames;
            AdditionalSignatures = additionalSignatures;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the template(s) that contains default UEFI key signatures that will be added to the image. </summary>
        public IList<UefiSignatureTemplateName> SignatureTemplateNames { get; }
        /// <summary> Additional UEFI key signatures that will be added to the image in addition to the signature templates. </summary>
        public UefiKeySignatures AdditionalSignatures { get; set; }
    }
}
