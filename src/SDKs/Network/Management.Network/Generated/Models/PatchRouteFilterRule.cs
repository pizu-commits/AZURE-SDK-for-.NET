// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Route Filter Rule Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PatchRouteFilterRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the PatchRouteFilterRule class.
        /// </summary>
        public PatchRouteFilterRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatchRouteFilterRule class.
        /// </summary>
        /// <param name="access">The access type of the rule. Possible values
        /// include: 'Allow', 'Deny'</param>
        /// <param name="communities">The collection for bgp community values
        /// to filter on. e.g. ['12076:5010','12076:5020'].</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values are: 'Updating', 'Deleting', 'Succeeded'
        /// and 'Failed'.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public PatchRouteFilterRule(string access, IList<string> communities, string id = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Access = access;
            Communities = communities;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for PatchRouteFilterRule class.
        /// </summary>
        static PatchRouteFilterRule()
        {
            RouteFilterRuleType = "Community";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the access type of the rule. Possible values include:
        /// 'Allow', 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "properties.access")]
        public string Access { get; set; }

        /// <summary>
        /// Gets or sets the collection for bgp community values to filter on.
        /// e.g. ['12076:5010','12076:5020'].
        /// </summary>
        [JsonProperty(PropertyName = "properties.communities")]
        public IList<string> Communities { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values are:
        /// 'Updating', 'Deleting', 'Succeeded' and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// The rule type of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routeFilterRuleType")]
        public static string RouteFilterRuleType { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Access == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Access");
            }
            if (Communities == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Communities");
            }
        }
    }
}
