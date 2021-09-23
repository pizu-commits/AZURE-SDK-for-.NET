// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The resource model definition containing the full set of allowed
    /// properties for a resource. Except properties bag, there cannot be a top
    /// level property outside of this set.
    /// </summary>
    public partial class ResourceModelWithAllowedPropertySet : IResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceModelWithAllowedPropertySet class.
        /// </summary>
        public ResourceModelWithAllowedPropertySet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceModelWithAllowedPropertySet class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="managedBy">The fully qualified resource ID of the
        /// resource that manages this resource. Indicates if this resource is
        /// managed by another Azure resource. If this is present, complete
        /// mode deployment will not delete the resource if it is removed from
        /// the template since it is managed by another resource.</param>
        /// <param name="kind">Metadata used by portal/tooling/etc to render
        /// different UX experiences for resources of the same type; e.g.
        /// ApiApps are a kind of Microsoft.Web/sites type.  If supported, the
        /// resource provider must validate and persist this value.</param>
        /// <param name="etag">The etag field is *not* required. If it is
        /// provided in the response body, it must also be provided as a header
        /// per the normal etag convention.  Entity tags are used for comparing
        /// two or more entities from the same requested resource. HTTP/1.1
        /// uses entity tags in the etag (section 14.19), If-Match (section
        /// 14.24), If-None-Match (section 14.26), and If-Range (section 14.27)
        /// header fields. </param>
        /// <param name="tags">Resource tags.</param>
        public ResourceModelWithAllowedPropertySet(string id = default(string), string name = default(string), string type = default(string), string location = default(string), string managedBy = default(string), string kind = default(string), string etag = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceModelWithAllowedPropertySetIdentity identity = default(ResourceModelWithAllowedPropertySetIdentity), ResourceModelWithAllowedPropertySetSku sku = default(ResourceModelWithAllowedPropertySetSku), ResourceModelWithAllowedPropertySetPlan plan = default(ResourceModelWithAllowedPropertySetPlan))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            ManagedBy = managedBy;
            Kind = kind;
            Etag = etag;
            Tags = tags;
            Identity = identity;
            Sku = sku;
            Plan = plan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the geo-location where the resource lives
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the fully qualified resource ID of the resource that
        /// manages this resource. Indicates if this resource is managed by
        /// another Azure resource. If this is present, complete mode
        /// deployment will not delete the resource if it is removed from the
        /// template since it is managed by another resource.
        /// </summary>
        [JsonProperty(PropertyName = "managedBy")]
        public string ManagedBy { get; set; }

        /// <summary>
        /// Gets or sets metadata used by portal/tooling/etc to render
        /// different UX experiences for resources of the same type; e.g.
        /// ApiApps are a kind of Microsoft.Web/sites type.  If supported, the
        /// resource provider must validate and persist this value.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets the etag field is *not* required. If it is provided in the
        /// response body, it must also be provided as a header per the normal
        /// etag convention.  Entity tags are used for comparing two or more
        /// entities from the same requested resource. HTTP/1.1 uses entity
        /// tags in the etag (section 14.19), If-Match (section 14.24),
        /// If-None-Match (section 14.26), and If-Range (section 14.27) header
        /// fields.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ResourceModelWithAllowedPropertySetIdentity Identity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ResourceModelWithAllowedPropertySetSku Sku { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public ResourceModelWithAllowedPropertySetPlan Plan { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Kind != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Kind, "^[-\\w\\._,\\(\\)]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Kind", "^[-\\w\\._,\\(\\)]+$");
                }
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (Plan != null)
            {
                Plan.Validate();
            }
        }
    }
}
