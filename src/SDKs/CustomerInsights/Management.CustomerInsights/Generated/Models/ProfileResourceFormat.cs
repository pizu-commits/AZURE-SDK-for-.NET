// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The profile resource format.
    /// </summary>
    [JsonTransformation]
    public partial class ProfileResourceFormat : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ProfileResourceFormat class.
        /// </summary>
        public ProfileResourceFormat() { }

        /// <summary>
        /// Initializes a new instance of the ProfileResourceFormat class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="attributes">The attributes for the Type.</param>
        /// <param name="description">Localized descriptions for the
        /// property.</param>
        /// <param name="displayName">Localized display names for the
        /// property.</param>
        /// <param name="localizedAttributes">Any custom localized attributes
        /// for the Type.</param>
        /// <param name="smallImage">Small Image associated with the Property
        /// or EntityType.</param>
        /// <param name="mediumImage">Medium Image associated with the Property
        /// or EntityType.</param>
        /// <param name="largeImage">Large Image associated with the Property
        /// or EntityType.</param>
        /// <param name="apiEntitySetName">The api entity set name. This
        /// becomes the odata entity set name for the entity Type being refered
        /// in this object.</param>
        /// <param name="entityType">Type of entity. Possible values include:
        /// 'None', 'Profile', 'Interaction', 'Relationship'</param>
        /// <param name="fields">The properties of the Profile.</param>
        /// <param name="instancesCount">The instance count.</param>
        /// <param name="lastChangedUtc">The last changed time for the type
        /// definition.</param>
        /// <param name="provisioningState">Provisioning state. Possible values
        /// include: 'Provisioning', 'Succeeded', 'Expiring', 'Deleting',
        /// 'HumanIntervention', 'Failed'</param>
        /// <param name="schemaItemTypeLink">The schema org link. This helps
        /// ACI identify and suggest semantic models.</param>
        /// <param name="tenantId">The hub name.</param>
        /// <param name="timestampFieldName">The timestamp property name.
        /// Represents the time when the interaction or profile update
        /// happened.</param>
        /// <param name="typeName">The name of the entity.</param>
        /// <param name="strongIds">The strong IDs.</param>
        public ProfileResourceFormat(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, IList<string>> attributes = default(IDictionary<string, IList<string>>), IDictionary<string, string> description = default(IDictionary<string, string>), IDictionary<string, string> displayName = default(IDictionary<string, string>), IDictionary<string, IDictionary<string, string>> localizedAttributes = default(IDictionary<string, IDictionary<string, string>>), string smallImage = default(string), string mediumImage = default(string), string largeImage = default(string), string apiEntitySetName = default(string), EntityTypes? entityType = default(EntityTypes?), IList<PropertyDefinition> fields = default(IList<PropertyDefinition>), int? instancesCount = default(int?), System.DateTime? lastChangedUtc = default(System.DateTime?), string provisioningState = default(string), string schemaItemTypeLink = default(string), string tenantId = default(string), string timestampFieldName = default(string), string typeName = default(string), IList<StrongId> strongIds = default(IList<StrongId>))
            : base(id, name, type)
        {
            Attributes = attributes;
            Description = description;
            DisplayName = displayName;
            LocalizedAttributes = localizedAttributes;
            SmallImage = smallImage;
            MediumImage = mediumImage;
            LargeImage = largeImage;
            ApiEntitySetName = apiEntitySetName;
            EntityType = entityType;
            Fields = fields;
            InstancesCount = instancesCount;
            LastChangedUtc = lastChangedUtc;
            ProvisioningState = provisioningState;
            SchemaItemTypeLink = schemaItemTypeLink;
            TenantId = tenantId;
            TimestampFieldName = timestampFieldName;
            TypeName = typeName;
            StrongIds = strongIds;
        }

        /// <summary>
        /// Gets or sets the attributes for the Type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.attributes")]
        public IDictionary<string, IList<string>> Attributes { get; set; }

        /// <summary>
        /// Gets or sets localized descriptions for the property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public IDictionary<string, string> Description { get; set; }

        /// <summary>
        /// Gets or sets localized display names for the property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public IDictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// Gets or sets any custom localized attributes for the Type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.localizedAttributes")]
        public IDictionary<string, IDictionary<string, string>> LocalizedAttributes { get; set; }

        /// <summary>
        /// Gets or sets small Image associated with the Property or
        /// EntityType.
        /// </summary>
        [JsonProperty(PropertyName = "properties.smallImage")]
        public string SmallImage { get; set; }

        /// <summary>
        /// Gets or sets medium Image associated with the Property or
        /// EntityType.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mediumImage")]
        public string MediumImage { get; set; }

        /// <summary>
        /// Gets or sets large Image associated with the Property or
        /// EntityType.
        /// </summary>
        [JsonProperty(PropertyName = "properties.largeImage")]
        public string LargeImage { get; set; }

        /// <summary>
        /// Gets or sets the api entity set name. This becomes the odata entity
        /// set name for the entity Type being refered in this object.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiEntitySetName")]
        public string ApiEntitySetName { get; set; }

        /// <summary>
        /// Gets or sets type of entity. Possible values include: 'None',
        /// 'Profile', 'Interaction', 'Relationship'
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityType")]
        public EntityTypes? EntityType { get; set; }

        /// <summary>
        /// Gets or sets the properties of the Profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fields")]
        public IList<PropertyDefinition> Fields { get; set; }

        /// <summary>
        /// Gets or sets the instance count.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instancesCount")]
        public int? InstancesCount { get; set; }

        /// <summary>
        /// Gets the last changed time for the type definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastChangedUtc")]
        public System.DateTime? LastChangedUtc { get; protected set; }

        /// <summary>
        /// Gets provisioning state. Possible values include: 'Provisioning',
        /// 'Succeeded', 'Expiring', 'Deleting', 'HumanIntervention', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; protected set; }

        /// <summary>
        /// Gets or sets the schema org link. This helps ACI identify and
        /// suggest semantic models.
        /// </summary>
        [JsonProperty(PropertyName = "properties.schemaItemTypeLink")]
        public string SchemaItemTypeLink { get; set; }

        /// <summary>
        /// Gets the hub name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; protected set; }

        /// <summary>
        /// Gets or sets the timestamp property name. Represents the time when
        /// the interaction or profile update happened.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timestampFieldName")]
        public string TimestampFieldName { get; set; }

        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        [JsonProperty(PropertyName = "properties.typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the strong IDs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.strongIds")]
        public IList<StrongId> StrongIds { get; set; }

    }
}

