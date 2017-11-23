// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This activity evaluates a boolean expression and executes either the
    /// activities under the ifTrueActivities property or the ifFalseActivities
    /// property depending on the result of the expression.
    /// </summary>
    [Newtonsoft.Json.JsonObject("IfCondition")]
    [Rest.Serialization.JsonTransformation]
    public partial class IfConditionActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the IfConditionActivity class.
        /// </summary>
        public IfConditionActivity()
        {
            Expression = new Expression();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IfConditionActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="expression">An expression that would evaluate to
        /// Boolean. This is used to determine the block of activities
        /// (ifTrueActivities or ifFalseActivities) that will be
        /// executed.</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="ifTrueActivities">List of activities to execute if
        /// expression is evaluated to true. This is an optional property and
        /// if not provided, the activity will exit without any action.</param>
        /// <param name="ifFalseActivities">List of activities to execute if
        /// expression is evaluated to false. This is an optional property and
        /// if not provided, the activity will exit without any action.</param>
        public IfConditionActivity(string name, Expression expression, string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<Activity> ifTrueActivities = default(IList<Activity>), IList<Activity> ifFalseActivities = default(IList<Activity>))
            : base(name, description, dependsOn)
        {
            Expression = expression;
            IfTrueActivities = ifTrueActivities;
            IfFalseActivities = ifFalseActivities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an expression that would evaluate to Boolean. This is
        /// used to determine the block of activities (ifTrueActivities or
        /// ifFalseActivities) that will be executed.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.expression")]
        public Expression Expression { get; set; }

        /// <summary>
        /// Gets or sets list of activities to execute if expression is
        /// evaluated to true. This is an optional property and if not
        /// provided, the activity will exit without any action.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.ifTrueActivities")]
        public IList<Activity> IfTrueActivities { get; set; }

        /// <summary>
        /// Gets or sets list of activities to execute if expression is
        /// evaluated to false. This is an optional property and if not
        /// provided, the activity will exit without any action.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.ifFalseActivities")]
        public IList<Activity> IfFalseActivities { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Expression == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Expression");
            }
            if (Expression != null)
            {
                Expression.Validate();
            }
            if (IfTrueActivities != null)
            {
                foreach (var element in IfTrueActivities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (IfFalseActivities != null)
            {
                foreach (var element1 in IfFalseActivities)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
