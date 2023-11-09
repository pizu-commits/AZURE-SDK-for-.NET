// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for RequestScheme match conditions. </summary>
    public partial class RequestSchemeMatchCondition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RequestSchemeMatchCondition"/>. </summary>
        /// <param name="conditionType"></param>
        /// <param name="requestSchemeOperator"> Describes operator to be matched. </param>
        public RequestSchemeMatchCondition(RequestSchemeMatchConditionType conditionType, RequestSchemeOperator requestSchemeOperator)
        {
            ConditionType = conditionType;
            RequestSchemeOperator = requestSchemeOperator;
            Transforms = new ChangeTrackingList<PreTransformCategory>();
            MatchValues = new ChangeTrackingList<RequestSchemeMatchConditionMatchValue>();
        }

        /// <summary> Initializes a new instance of <see cref="RequestSchemeMatchCondition"/>. </summary>
        /// <param name="conditionType"></param>
        /// <param name="requestSchemeOperator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="transforms"> List of transforms. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RequestSchemeMatchCondition(RequestSchemeMatchConditionType conditionType, RequestSchemeOperator requestSchemeOperator, bool? negateCondition, IList<PreTransformCategory> transforms, IList<RequestSchemeMatchConditionMatchValue> matchValues, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConditionType = conditionType;
            RequestSchemeOperator = requestSchemeOperator;
            NegateCondition = negateCondition;
            Transforms = transforms;
            MatchValues = matchValues;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RequestSchemeMatchCondition"/> for deserialization. </summary>
        internal RequestSchemeMatchCondition()
        {
        }

        /// <summary> Gets or sets the condition type. </summary>
        public RequestSchemeMatchConditionType ConditionType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public RequestSchemeOperator RequestSchemeOperator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<RequestSchemeMatchConditionMatchValue> MatchValues { get; }
    }
}
