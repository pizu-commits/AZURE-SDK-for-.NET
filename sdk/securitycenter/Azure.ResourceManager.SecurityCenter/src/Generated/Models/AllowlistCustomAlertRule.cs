// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// A custom alert rule that checks if a value (depends on the custom alert type) is allowed.
    /// Please note <see cref="AllowlistCustomAlertRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ConnectionFromIPNotAllowed"/>, <see cref="ConnectionToIPNotAllowed"/>, <see cref="LocalUserNotAllowed"/> and <see cref="ProcessNotAllowed"/>.
    /// </summary>
    public partial class AllowlistCustomAlertRule : ListCustomAlertRule
    {
        /// <summary> Initializes a new instance of <see cref="AllowlistCustomAlertRule"/>. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="allowlistValues"> The values to allow. The format of the values depends on the rule type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowlistValues"/> is null. </exception>
        public AllowlistCustomAlertRule(bool isEnabled, IEnumerable<string> allowlistValues) : base(isEnabled)
        {
            Argument.AssertNotNull(allowlistValues, nameof(allowlistValues));

            AllowlistValues = allowlistValues.ToList();
            RuleType = "AllowlistCustomAlertRule";
        }

        /// <summary> Initializes a new instance of <see cref="AllowlistCustomAlertRule"/>. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="valueType"> The value type of the items in the list. </param>
        /// <param name="allowlistValues"> The values to allow. The format of the values depends on the rule type. </param>
        internal AllowlistCustomAlertRule(string displayName, string description, bool isEnabled, string ruleType, IDictionary<string, BinaryData> serializedAdditionalRawData, SecurityValueType? valueType, IList<string> allowlistValues) : base(displayName, description, isEnabled, ruleType, serializedAdditionalRawData, valueType)
        {
            AllowlistValues = allowlistValues;
            RuleType = ruleType ?? "AllowlistCustomAlertRule";
        }

        /// <summary> Initializes a new instance of <see cref="AllowlistCustomAlertRule"/> for deserialization. </summary>
        internal AllowlistCustomAlertRule()
        {
        }

        /// <summary> The values to allow. The format of the values depends on the rule type. </summary>
        public IList<string> AllowlistValues { get; }
    }
}
