// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the RecommendationRule data model. </summary>
    public partial class RecommendationRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of RecommendationRuleData. </summary>
        public RecommendationRuleData()
        {
            CategoryTags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RecommendationRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="recommendationName"> Unique name of the rule. </param>
        /// <param name="displayName"> UI friendly name of the rule. </param>
        /// <param name="message"> Localized name of the rule (Good for UI). </param>
        /// <param name="recommendationId">
        /// Recommendation ID of an associated recommendation object tied to the rule, if exists.
        /// If such an object doesn&apos;t exist, it is set to null.
        /// </param>
        /// <param name="description"> Localized detailed description of the rule. </param>
        /// <param name="actionName"> Name of action that is recommended by this rule in string. </param>
        /// <param name="level"> Level of impact indicating how critical this rule is. </param>
        /// <param name="channels"> List of available channels that this rule applies. </param>
        /// <param name="categoryTags"> The list of category tags that this recommendation rule belongs to. </param>
        /// <param name="isDynamic"> True if this is associated with a dynamically added rule. </param>
        /// <param name="extensionName"> Extension name of the portal if exists. Applicable to dynamic rule only. </param>
        /// <param name="bladeName"> Deep link to a blade on the portal. Applicable to dynamic rule only. </param>
        /// <param name="forwardLink"> Forward link to an external document associated with the rule. Applicable to dynamic rule only. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal RecommendationRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string recommendationName, string displayName, string message, Guid? recommendationId, string description, string actionName, NotificationLevel? level, AppServiceChannel? channels, IReadOnlyList<string> categoryTags, bool? isDynamic, string extensionName, string bladeName, string forwardLink, string kind) : base(id, name, resourceType, systemData)
        {
            RecommendationName = recommendationName;
            DisplayName = displayName;
            Message = message;
            RecommendationId = recommendationId;
            Description = description;
            ActionName = actionName;
            Level = level;
            Channels = channels;
            CategoryTags = categoryTags;
            IsDynamic = isDynamic;
            ExtensionName = extensionName;
            BladeName = bladeName;
            ForwardLink = forwardLink;
            Kind = kind;
        }

        /// <summary> Unique name of the rule. </summary>
        public string RecommendationName { get; set; }
        /// <summary> UI friendly name of the rule. </summary>
        public string DisplayName { get; set; }
        /// <summary> Localized name of the rule (Good for UI). </summary>
        public string Message { get; set; }
        /// <summary>
        /// Recommendation ID of an associated recommendation object tied to the rule, if exists.
        /// If such an object doesn&apos;t exist, it is set to null.
        /// </summary>
        public Guid? RecommendationId { get; set; }
        /// <summary> Localized detailed description of the rule. </summary>
        public string Description { get; set; }
        /// <summary> Name of action that is recommended by this rule in string. </summary>
        public string ActionName { get; set; }
        /// <summary> Level of impact indicating how critical this rule is. </summary>
        public NotificationLevel? Level { get; set; }
        /// <summary> List of available channels that this rule applies. </summary>
        public AppServiceChannel? Channels { get; set; }
        /// <summary> The list of category tags that this recommendation rule belongs to. </summary>
        public IReadOnlyList<string> CategoryTags { get; }
        /// <summary> True if this is associated with a dynamically added rule. </summary>
        public bool? IsDynamic { get; set; }
        /// <summary> Extension name of the portal if exists. Applicable to dynamic rule only. </summary>
        public string ExtensionName { get; set; }
        /// <summary> Deep link to a blade on the portal. Applicable to dynamic rule only. </summary>
        public string BladeName { get; set; }
        /// <summary> Forward link to an external document associated with the rule. Applicable to dynamic rule only. </summary>
        public string ForwardLink { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
