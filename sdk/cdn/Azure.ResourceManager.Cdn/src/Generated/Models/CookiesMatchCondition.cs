// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for Cookies match conditions. </summary>
    public partial class CookiesMatchCondition
    {
        /// <summary> Initializes a new instance of CookiesMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="cookiesOperator"> Describes operator to be matched. </param>
        public CookiesMatchCondition(CookiesMatchConditionType conditionType, CookiesOperator cookiesOperator)
        {
            ConditionType = conditionType;
            CookiesOperator = cookiesOperator;
            MatchValues = new Core.ChangeTrackingList<string>();
            Transforms = new Core.ChangeTrackingList<PreTransformCategory>();
        }

        /// <summary> Initializes a new instance of CookiesMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="selector"> Name of Cookies to be matched. </param>
        /// <param name="cookiesOperator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal CookiesMatchCondition(CookiesMatchConditionType conditionType, string selector, CookiesOperator cookiesOperator, bool? negateCondition, IList<string> matchValues, IList<PreTransformCategory> transforms)
        {
            ConditionType = conditionType;
            Selector = selector;
            CookiesOperator = cookiesOperator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        /// <summary> Gets or sets the condition type. </summary>
        public CookiesMatchConditionType ConditionType { get; set; }
        /// <summary> Name of Cookies to be matched. </summary>
        public string Selector { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public CookiesOperator CookiesOperator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
    }
}
