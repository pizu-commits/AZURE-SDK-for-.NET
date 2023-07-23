// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft Defender for Cloud is provided in two pricing tiers: free and
    /// standard. The standard tier offers advanced security capabilities,
    /// while the free tier offers basic security features.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Pricing : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Pricing class.
        /// </summary>
        public Pricing()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Pricing class.
        /// </summary>
        /// <param name="pricingTier">The pricing tier value. Microsoft
        /// Defender for Cloud is provided in two pricing tiers: free and
        /// standard. The standard tier offers advanced security capabilities,
        /// while the free tier offers basic security features. Possible values
        /// include: 'Free', 'Standard'</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="subPlan">The sub-plan selected for a Standard pricing
        /// configuration, when more than one sub-plan is available. Each
        /// sub-plan enables a set of security features. When not specified,
        /// full plan is applied.</param>
        /// <param name="freeTrialRemainingTime">The duration left for the
        /// subscriptions free trial period - in ISO 8601 format (e.g.
        /// P3Y6M4DT12H30M5S).</param>
        /// <param name="enablementTime">Optional. If `pricingTier` is
        /// `Standard` then this property holds the date of the last time the
        /// `pricingTier` was set to `Standard`, when available (e.g
        /// 2023-03-01T12:42:42.1921106Z).</param>
        /// <param name="deprecated">Optional. True if the plan is deprecated.
        /// If there are replacing plans they will appear in `replacedBy`
        /// property</param>
        /// <param name="replacedBy">Optional. List of plans that replace this
        /// plan. This property exists only if this plan is deprecated.</param>
        /// <param name="extensions">Optional. List of extensions offered under
        /// a plan.</param>
        public Pricing(string pricingTier, string id = default(string), string name = default(string), string type = default(string), string subPlan = default(string), System.TimeSpan? freeTrialRemainingTime = default(System.TimeSpan?), System.DateTime? enablementTime = default(System.DateTime?), bool? deprecated = default(bool?), IList<string> replacedBy = default(IList<string>), IList<Extension> extensions = default(IList<Extension>))
            : base(id, name, type)
        {
            PricingTier = pricingTier;
            SubPlan = subPlan;
            FreeTrialRemainingTime = freeTrialRemainingTime;
            EnablementTime = enablementTime;
            Deprecated = deprecated;
            ReplacedBy = replacedBy;
            Extensions = extensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the pricing tier value. Microsoft Defender for Cloud
        /// is provided in two pricing tiers: free and standard. The standard
        /// tier offers advanced security capabilities, while the free tier
        /// offers basic security features. Possible values include: 'Free',
        /// 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "properties.pricingTier")]
        public string PricingTier { get; set; }

        /// <summary>
        /// Gets or sets the sub-plan selected for a Standard pricing
        /// configuration, when more than one sub-plan is available. Each
        /// sub-plan enables a set of security features. When not specified,
        /// full plan is applied.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subPlan")]
        public string SubPlan { get; set; }

        /// <summary>
        /// Gets the duration left for the subscriptions free trial period - in
        /// ISO 8601 format (e.g. P3Y6M4DT12H30M5S).
        /// </summary>
        [JsonProperty(PropertyName = "properties.freeTrialRemainingTime")]
        public System.TimeSpan? FreeTrialRemainingTime { get; private set; }

        /// <summary>
        /// Gets optional. If `pricingTier` is `Standard` then this property
        /// holds the date of the last time the `pricingTier` was set to
        /// `Standard`, when available (e.g 2023-03-01T12:42:42.1921106Z).
        /// </summary>
        [JsonProperty(PropertyName = "properties.enablementTime")]
        public System.DateTime? EnablementTime { get; private set; }

        /// <summary>
        /// Gets optional. True if the plan is deprecated. If there are
        /// replacing plans they will appear in `replacedBy` property
        /// </summary>
        [JsonProperty(PropertyName = "properties.deprecated")]
        public bool? Deprecated { get; private set; }

        /// <summary>
        /// Gets optional. List of plans that replace this plan. This property
        /// exists only if this plan is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.replacedBy")]
        public IList<string> ReplacedBy { get; private set; }

        /// <summary>
        /// Gets or sets optional. List of extensions offered under a plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.extensions")]
        public IList<Extension> Extensions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PricingTier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PricingTier");
            }
            if (Extensions != null)
            {
                foreach (var element in Extensions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
