// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for ClientPort match conditions. </summary>
    public partial class ClientPortMatchCondition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClientPortMatchCondition"/>. </summary>
        /// <param name="conditionType"></param>
        /// <param name="clientPortOperator"> Describes operator to be matched. </param>
        public ClientPortMatchCondition(ClientPortMatchConditionType conditionType, ClientPortOperator clientPortOperator)
        {
            ConditionType = conditionType;
            ClientPortOperator = clientPortOperator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<PreTransformCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="ClientPortMatchCondition"/>. </summary>
        /// <param name="conditionType"></param>
        /// <param name="clientPortOperator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClientPortMatchCondition(ClientPortMatchConditionType conditionType, ClientPortOperator clientPortOperator, bool? negateCondition, IList<string> matchValues, IList<PreTransformCategory> transforms, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConditionType = conditionType;
            ClientPortOperator = clientPortOperator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClientPortMatchCondition"/> for deserialization. </summary>
        internal ClientPortMatchCondition()
        {
        }

        /// <summary> Gets or sets the condition type. </summary>
        public ClientPortMatchConditionType ConditionType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public ClientPortOperator ClientPortOperator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
    }
}
