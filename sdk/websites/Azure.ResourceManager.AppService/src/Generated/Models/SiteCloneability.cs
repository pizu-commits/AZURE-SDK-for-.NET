// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Represents whether or not an app is cloneable. </summary>
    public partial class SiteCloneability
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

        /// <summary> Initializes a new instance of <see cref="SiteCloneability"/>. </summary>
        internal SiteCloneability()
        {
            BlockingFeatures = new ChangeTrackingList<SiteCloneabilityCriterion>();
            UnsupportedFeatures = new ChangeTrackingList<SiteCloneabilityCriterion>();
            BlockingCharacteristics = new ChangeTrackingList<SiteCloneabilityCriterion>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteCloneability"/>. </summary>
        /// <param name="result"> Name of app. </param>
        /// <param name="blockingFeatures"> List of features enabled on app that prevent cloning. </param>
        /// <param name="unsupportedFeatures">
        /// List of features enabled on app that are non-blocking but cannot be cloned. The app can still be cloned
        /// but the features in this list will not be set up on cloned app.
        /// </param>
        /// <param name="blockingCharacteristics"> List of blocking application characteristics. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteCloneability(CloneAbilityResult? result, IReadOnlyList<SiteCloneabilityCriterion> blockingFeatures, IReadOnlyList<SiteCloneabilityCriterion> unsupportedFeatures, IReadOnlyList<SiteCloneabilityCriterion> blockingCharacteristics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Result = result;
            BlockingFeatures = blockingFeatures;
            UnsupportedFeatures = unsupportedFeatures;
            BlockingCharacteristics = blockingCharacteristics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of app. </summary>
        public CloneAbilityResult? Result { get; }
        /// <summary> List of features enabled on app that prevent cloning. </summary>
        public IReadOnlyList<SiteCloneabilityCriterion> BlockingFeatures { get; }
        /// <summary>
        /// List of features enabled on app that are non-blocking but cannot be cloned. The app can still be cloned
        /// but the features in this list will not be set up on cloned app.
        /// </summary>
        public IReadOnlyList<SiteCloneabilityCriterion> UnsupportedFeatures { get; }
        /// <summary> List of blocking application characteristics. </summary>
        public IReadOnlyList<SiteCloneabilityCriterion> BlockingCharacteristics { get; }
    }
}
