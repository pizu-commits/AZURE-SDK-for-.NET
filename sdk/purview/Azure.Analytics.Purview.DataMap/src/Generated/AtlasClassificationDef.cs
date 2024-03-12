// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> class that captures details of a classification-type. </summary>
    public partial class AtlasClassificationDef
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AtlasClassificationDef"/>. </summary>
        public AtlasClassificationDef()
        {
            Options = new ChangeTrackingDictionary<string, string>();
            AttributeDefs = new ChangeTrackingList<AtlasAttributeDef>();
            EntityTypes = new ChangeTrackingList<string>();
            SubTypes = new ChangeTrackingList<string>();
            SuperTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AtlasClassificationDef"/>. </summary>
        /// <param name="category"> The enum of type category. </param>
        /// <param name="createTime"> The created time of the record. </param>
        /// <param name="createdBy"> The user who created the record. </param>
        /// <param name="dateFormatter"> The date format. </param>
        /// <param name="description"> The description of the type definition. </param>
        /// <param name="guid"> The GUID of the type definition. </param>
        /// <param name="name"> The name of the type definition. </param>
        /// <param name="options"> The options for the type definition. </param>
        /// <param name="serviceType"> The service type. </param>
        /// <param name="typeVersion"> The version of the type. </param>
        /// <param name="updateTime"> The update time of the record. </param>
        /// <param name="updatedBy"> The user who updated the record. </param>
        /// <param name="version"> The version of the record. </param>
        /// <param name="lastModifiedTS"> ETag for concurrency control. </param>
        /// <param name="attributeDefs"> An array of attribute definitions. </param>
        /// <param name="entityTypes">
        /// Specifying a list of entityType names in the classificationDef, ensures that
        /// classifications can
        /// only be applied to those entityTypes.
        ///
        /// Any subtypes of the entity types inherit the restriction.
        ///
        /// Any classificationDef subtypes inherit the parents entityTypes restrictions.
        ///
        /// Any classificationDef subtypes can further restrict the parents entityTypes
        /// restrictions by specifying a subset of the entityTypes.
        ///
        /// An empty entityTypes list when there are no parent restrictions means there are no
        /// restrictions.
        ///
        /// An empty entityTypes list when there are parent
        /// restrictions means that the subtype picks up the parents
        /// restrictions.
        ///
        /// If a list of entityTypes are supplied, where one inherits
        /// from another, this will be rejected. This should encourage cleaner
        /// classificationsDefs.
        ///
        /// </param>
        /// <param name="subTypes"> An array of sub types. </param>
        /// <param name="superTypes"> An array of super types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AtlasClassificationDef(TypeCategory? category, long? createTime, string createdBy, AtlasDateFormat dateFormatter, string description, string guid, string name, IDictionary<string, string> options, string serviceType, string typeVersion, long? updateTime, string updatedBy, long? version, string lastModifiedTS, IList<AtlasAttributeDef> attributeDefs, IList<string> entityTypes, IList<string> subTypes, IList<string> superTypes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            CreateTime = createTime;
            CreatedBy = createdBy;
            DateFormatter = dateFormatter;
            Description = description;
            Guid = guid;
            Name = name;
            Options = options;
            ServiceType = serviceType;
            TypeVersion = typeVersion;
            UpdateTime = updateTime;
            UpdatedBy = updatedBy;
            Version = version;
            LastModifiedTS = lastModifiedTS;
            AttributeDefs = attributeDefs;
            EntityTypes = entityTypes;
            SubTypes = subTypes;
            SuperTypes = superTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The enum of type category. </summary>
        public TypeCategory? Category { get; set; }
        /// <summary> The created time of the record. </summary>
        public long? CreateTime { get; set; }
        /// <summary> The user who created the record. </summary>
        public string CreatedBy { get; set; }
        /// <summary> The date format. </summary>
        public AtlasDateFormat DateFormatter { get; set; }
        /// <summary> The description of the type definition. </summary>
        public string Description { get; set; }
        /// <summary> The GUID of the type definition. </summary>
        public string Guid { get; set; }
        /// <summary> The name of the type definition. </summary>
        public string Name { get; set; }
        /// <summary> The options for the type definition. </summary>
        public IDictionary<string, string> Options { get; }
        /// <summary> The service type. </summary>
        public string ServiceType { get; set; }
        /// <summary> The version of the type. </summary>
        public string TypeVersion { get; set; }
        /// <summary> The update time of the record. </summary>
        public long? UpdateTime { get; set; }
        /// <summary> The user who updated the record. </summary>
        public string UpdatedBy { get; set; }
        /// <summary> The version of the record. </summary>
        public long? Version { get; set; }
        /// <summary> ETag for concurrency control. </summary>
        public string LastModifiedTS { get; set; }
        /// <summary> An array of attribute definitions. </summary>
        public IList<AtlasAttributeDef> AttributeDefs { get; }
        /// <summary>
        /// Specifying a list of entityType names in the classificationDef, ensures that
        /// classifications can
        /// only be applied to those entityTypes.
        ///
        /// Any subtypes of the entity types inherit the restriction.
        ///
        /// Any classificationDef subtypes inherit the parents entityTypes restrictions.
        ///
        /// Any classificationDef subtypes can further restrict the parents entityTypes
        /// restrictions by specifying a subset of the entityTypes.
        ///
        /// An empty entityTypes list when there are no parent restrictions means there are no
        /// restrictions.
        ///
        /// An empty entityTypes list when there are parent
        /// restrictions means that the subtype picks up the parents
        /// restrictions.
        ///
        /// If a list of entityTypes are supplied, where one inherits
        /// from another, this will be rejected. This should encourage cleaner
        /// classificationsDefs.
        ///
        /// </summary>
        public IList<string> EntityTypes { get; }
        /// <summary> An array of sub types. </summary>
        public IList<string> SubTypes { get; }
        /// <summary> An array of super types. </summary>
        public IList<string> SuperTypes { get; }
    }
}
