// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Advisor.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Advisor
{
    /// <summary>
    /// A class representing the MetadataEntity data model.
    /// The metadata entity contract.
    /// </summary>
    public partial class MetadataEntityData : ResourceData
    {
        /// <summary> Initializes a new instance of MetadataEntityData. </summary>
        internal MetadataEntityData()
        {
            DependsOn = new Core.ChangeTrackingList<string>();
            ApplicableScenarios = new Core.ChangeTrackingList<Scenario>();
            SupportedValues = new Core.ChangeTrackingList<MetadataSupportedValueDetail>();
        }

        /// <summary> Initializes a new instance of MetadataEntityData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> The display name. </param>
        /// <param name="dependsOn"> The list of keys on which this entity depends on. </param>
        /// <param name="applicableScenarios"> The list of scenarios applicable to this metadata entity. </param>
        /// <param name="supportedValues"> The list of supported values. </param>
        internal MetadataEntityData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, IReadOnlyList<string> dependsOn, IReadOnlyList<Scenario> applicableScenarios, IReadOnlyList<MetadataSupportedValueDetail> supportedValues) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            DependsOn = dependsOn;
            ApplicableScenarios = applicableScenarios;
            SupportedValues = supportedValues;
        }

        /// <summary> The display name. </summary>
        public string DisplayName { get; }
        /// <summary> The list of keys on which this entity depends on. </summary>
        public IReadOnlyList<string> DependsOn { get; }
        /// <summary> The list of scenarios applicable to this metadata entity. </summary>
        public IReadOnlyList<Scenario> ApplicableScenarios { get; }
        /// <summary> The list of supported values. </summary>
        public IReadOnlyList<MetadataSupportedValueDetail> SupportedValues { get; }
    }
}
