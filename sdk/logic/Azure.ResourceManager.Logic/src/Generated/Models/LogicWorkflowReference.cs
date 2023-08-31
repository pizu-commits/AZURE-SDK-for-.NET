// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The workflow reference. </summary>
    public partial class LogicWorkflowReference : LogicResourceReference
    {
        /// <summary> Initializes a new instance of <see cref="LogicWorkflowReference"/>. </summary>
        public LogicWorkflowReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowReference"/>. </summary>
        /// <param name="id"> The resource id. </param>
        /// <param name="name"> Gets the resource name. </param>
        /// <param name="resourceType"> Gets the resource type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowReference(ResourceIdentifier id, string name, ResourceType? resourceType, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, rawData)
        {
        }
    }
}
