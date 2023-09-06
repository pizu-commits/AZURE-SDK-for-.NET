// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for UrlFileExtension match conditions. </summary>
    public partial class UriFileExtensionMatchCondition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UriFileExtensionMatchCondition"/>. </summary>
        /// <param name="conditionType"></param>
        /// <param name="uriFileExtensionOperator"> Describes operator to be matched. </param>
        public UriFileExtensionMatchCondition(UriFileExtensionMatchConditionType conditionType, UriFileExtensionOperator uriFileExtensionOperator)
        {
            ConditionType = conditionType;
            UriFileExtensionOperator = uriFileExtensionOperator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<PreTransformCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="UriFileExtensionMatchCondition"/>. </summary>
        /// <param name="conditionType"></param>
        /// <param name="uriFileExtensionOperator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UriFileExtensionMatchCondition(UriFileExtensionMatchConditionType conditionType, UriFileExtensionOperator uriFileExtensionOperator, bool? negateCondition, IList<string> matchValues, IList<PreTransformCategory> transforms, Dictionary<string, BinaryData> rawData)
        {
            ConditionType = conditionType;
            UriFileExtensionOperator = uriFileExtensionOperator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="UriFileExtensionMatchCondition"/> for deserialization. </summary>
        internal UriFileExtensionMatchCondition()
        {
        }

        /// <summary> Gets or sets the condition type. </summary>
        public UriFileExtensionMatchConditionType ConditionType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public UriFileExtensionOperator UriFileExtensionOperator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
    }
}
