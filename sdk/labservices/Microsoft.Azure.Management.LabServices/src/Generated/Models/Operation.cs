// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// REST API Operation
    /// </summary>
    /// <remarks>
    /// Details of a REST API operation, returned from the Resource Provider
    /// Operations API
    /// </remarks>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">The name of the operation, as per Resource-Based
        /// Access Control (RBAC). Examples:
        /// "Microsoft.Compute/virtualMachines/write",
        /// "Microsoft.Compute/virtualMachines/capture/action"</param>
        /// <param name="isDataAction">Whether the operation applies to
        /// data-plane. This is "true" for data-plane operations and "false"
        /// for ARM/control-plane operations.</param>
        /// <param name="display">Localized display information for this
        /// particular operation.</param>
        /// <param name="origin">The intended executor of the operation; as in
        /// Resource Based Access Control (RBAC) and audit logs UX. Default
        /// value is "user,system". Possible values include: 'user', 'system',
        /// 'user,system'</param>
        /// <param name="actionType">Enum. Indicates the action type.
        /// "Internal" refers to actions that are for internal only APIs.
        /// Possible values include: 'Internal'</param>
        public Operation(string name = default(string), bool? isDataAction = default(bool?), OperationDisplay display = default(OperationDisplay), string origin = default(string), string actionType = default(string))
        {
            Name = name;
            IsDataAction = isDataAction;
            Display = display;
            Origin = origin;
            ActionType = actionType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the operation, as per Resource-Based Access
        /// Control (RBAC). Examples:
        /// "Microsoft.Compute/virtualMachines/write",
        /// "Microsoft.Compute/virtualMachines/capture/action"
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets whether the operation applies to data-plane. This is "true"
        /// for data-plane operations and "false" for ARM/control-plane
        /// operations.
        /// </summary>
        [JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction { get; private set; }

        /// <summary>
        /// Gets or sets localized display information for this particular
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; set; }

        /// <summary>
        /// Gets the intended executor of the operation; as in Resource Based
        /// Access Control (RBAC) and audit logs UX. Default value is
        /// "user,system". Possible values include: 'user', 'system',
        /// 'user,system'
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; private set; }

        /// <summary>
        /// Gets enum. Indicates the action type. "Internal" refers to actions
        /// that are for internal only APIs. Possible values include:
        /// 'Internal'
        /// </summary>
        [JsonProperty(PropertyName = "actionType")]
        public string ActionType { get; private set; }

    }
}
