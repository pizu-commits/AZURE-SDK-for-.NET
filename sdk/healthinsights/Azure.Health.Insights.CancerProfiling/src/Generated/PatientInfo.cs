// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary> Patient structured information, including demographics and known structured clinical information. </summary>
    public partial class PatientInfo
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

        /// <summary> Initializes a new instance of <see cref="PatientInfo"/>. </summary>
        public PatientInfo()
        {
            ClinicalInfo = new ChangeTrackingList<ClinicalCodedElement>();
        }

        /// <summary> Initializes a new instance of <see cref="PatientInfo"/>. </summary>
        /// <param name="sex"> The patient's sex. </param>
        /// <param name="birthDate"> The patient's date of birth. </param>
        /// <param name="clinicalInfo"> Known clinical information for the patient, structured. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PatientInfo(PatientInfoSex? sex, DateTimeOffset? birthDate, IList<ClinicalCodedElement> clinicalInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sex = sex;
            BirthDate = birthDate;
            ClinicalInfo = clinicalInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The patient's sex. </summary>
        public PatientInfoSex? Sex { get; set; }
        /// <summary> The patient's date of birth. </summary>
        public DateTimeOffset? BirthDate { get; set; }
        /// <summary> Known clinical information for the patient, structured. </summary>
        public IList<ClinicalCodedElement> ClinicalInfo { get; }
    }
}
