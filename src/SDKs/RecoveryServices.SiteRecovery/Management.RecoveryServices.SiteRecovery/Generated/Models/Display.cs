// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Contains the localized display information for this particular
    /// operation / action. These value will be used by several clients for
    /// (1) custom role definitions for RBAC;
    /// (2) complex query filters for the event service; and
    /// (3) audit history / records for management operations.
    /// </summary>
    public partial class Display
    {
        /// <summary>
        /// Initializes a new instance of the Display class.
        /// </summary>
        public Display() { }

        /// <summary>
        /// Initializes a new instance of the Display class.
        /// </summary>
        public Display(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
        }

        /// <summary>
        /// The provider.
        /// The localized friendly form of the resource provider
        /// name � it is expected to also include the publisher/company
        /// responsible.
        /// It should use Title Casing and begin with "Microsoft"
        /// for 1st party services.
        /// e.g. "Microsoft Monitoring Insights" or "Microsoft
        /// Compute."
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// The resource.
        /// The localized friendly form of the resource related to
        /// this action/operation � it should match the public documentation
        /// for the resource provider.
        /// It should use Title Casing.
        /// This value should be unique for a particular URL type
        /// (e.g. nested types should *not* reuse their parent�s
        /// display.resource field).
        /// e.g. "Virtual Machines" or "Scheduler Job
        /// Collections", or "Virtual Machine VM Sizes" or "Scheduler Jobs"
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// The operation.
        /// The localized friendly name for the operation, as it
        /// should be shown to the user.
        /// It should be concise (to fit in drop downs) but clear
        /// (i.e. self-documenting).
        /// It should use Title Casing.
        /// Prescriptive guidance: Read Create or Update Delete
        /// 'ActionName'
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// The description.
        /// The localized friendly description for the operation,
        /// as it should be shown to the user.
        /// It should be thorough, yet concise � it will be used
        /// in tool tips and detailed views.
        /// Prescriptive guidance for namespaces:
        /// Read any 'display.provider'  resource
        /// Create or Update any  'display.provider'  resource
        /// Delete any  'display.provider'  resource
        /// Perform any other action on any  'display.provider'
        /// resource
        /// Prescriptive guidance for namespaces:
        /// Read any 'display.resource' Create or Update any
        /// 'display.resource' Delete any 'display.resource' 'ActionName'
        /// any 'display.resources'
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
