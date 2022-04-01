// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for RequestScheme match conditions. </summary>
    public partial class RequestSchemeMatchConditionParameters
    {
        /// <summary> Initializes a new instance of RequestSchemeMatchConditionParameters. </summary>
        /// <param name="typeName"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        public RequestSchemeMatchConditionParameters(RequestSchemeMatchConditionParametersTypeName typeName, RequestSchemeMatchConditionParametersOperator @operator)
        {
            TypeName = typeName;
            Operator = @operator;
            Transforms = new ChangeTrackingList<TransformCategory>();
            MatchValues = new ChangeTrackingList<RequestSchemeMatchConditionParametersMatchValuesItem>();
        }

        /// <summary> Initializes a new instance of RequestSchemeMatchConditionParameters. </summary>
        /// <param name="typeName"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="transforms"> List of transforms. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        internal RequestSchemeMatchConditionParameters(RequestSchemeMatchConditionParametersTypeName typeName, RequestSchemeMatchConditionParametersOperator @operator, bool? negateCondition, IList<TransformCategory> transforms, IList<RequestSchemeMatchConditionParametersMatchValuesItem> matchValues)
        {
            TypeName = typeName;
            Operator = @operator;
            NegateCondition = negateCondition;
            Transforms = transforms;
            MatchValues = matchValues;
        }

        /// <summary> Gets or sets the type name. </summary>
        public RequestSchemeMatchConditionParametersTypeName TypeName { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public RequestSchemeMatchConditionParametersOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> List of transforms. </summary>
        public IList<TransformCategory> Transforms { get; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<RequestSchemeMatchConditionParametersMatchValuesItem> MatchValues { get; }
    }
}
