// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the AutomationConnection data model.
    /// Definition of the connection.
    /// </summary>
    public partial class AutomationConnectionData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionData"/>. </summary>
        public AutomationConnectionData()
        {
            FieldDefinitionValues = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="connectionType"> Gets or sets the connectionType of the connection. </param>
        /// <param name="fieldDefinitionValues"> Gets the field definition values of the connection. </param>
        /// <param name="createdOn"> Gets the creation time. </param>
        /// <param name="lastModifiedOn"> Gets the last modified time. </param>
        /// <param name="description"> Gets or sets the description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ConnectionTypeAssociationProperty connectionType, IReadOnlyDictionary<string, string> fieldDefinitionValues, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string description, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ConnectionType = connectionType;
            FieldDefinitionValues = fieldDefinitionValues;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the connectionType of the connection. </summary>
        internal ConnectionTypeAssociationProperty ConnectionType { get; set; }
        /// <summary> Gets or sets the name of the connection type. </summary>
        public string ConnectionTypeName
        {
            get => ConnectionType is null ? default : ConnectionType.Name;
            set
            {
                if (ConnectionType is null)
                    ConnectionType = new ConnectionTypeAssociationProperty();
                ConnectionType.Name = value;
            }
        }

        /// <summary> Gets the field definition values of the connection. </summary>
        public IReadOnlyDictionary<string, string> FieldDefinitionValues { get; }
        /// <summary> Gets the creation time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets the last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
