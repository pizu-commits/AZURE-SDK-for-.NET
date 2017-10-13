// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.OperationalInsights;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The top level Workspace resource container.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Workspace : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        public Workspace()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">The provisioning state of the
        /// workspace. Possible values include: 'Creating', 'Succeeded',
        /// 'Failed', 'Canceled', 'Deleting', 'ProvisioningAccount'</param>
        /// <param name="source">The source of the workspace.  Source defines
        /// where the workspace was created. 'Azure' implies it was created in
        /// Azure.  'External' implies it was created via the Operational
        /// Insights Portal. This value is set on the service side and
        /// read-only on the client side.</param>
        /// <param name="customerId">The ID associated with the workspace.
        /// Setting this value at creation time allows the workspace being
        /// created to be linked to an existing workspace.</param>
        /// <param name="portalUrl">The URL of the Operational Insights portal
        /// for this workspace.  This value is set on the service side and
        /// read-only on the client side.</param>
        /// <param name="sku">The SKU of the workspace.</param>
        /// <param name="features">The Features of the workspace.</param>
        /// <param name="retentionInDays">The workspace data retention in days.
        /// -1 means Unlimited retention for the Unlimited Sku. 730 days is the
        /// maximum allowed for all other Skus. </param>
        /// <param name="eTag">The ETag of the workspace.</param>
        public Workspace(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), string source = default(string), string customerId = default(string), string portalUrl = default(string), Sku sku = default(Sku), Features features = default(Features), int? retentionInDays = default(int?), string eTag = default(string))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            Source = source;
            CustomerId = customerId;
            PortalUrl = portalUrl;
            Sku = sku;
            Features = features;
            RetentionInDays = retentionInDays;
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the provisioning state of the workspace. Possible
        /// values include: 'Creating', 'Succeeded', 'Failed', 'Canceled',
        /// 'Deleting', 'ProvisioningAccount'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the source of the workspace.  Source defines where the
        /// workspace was created. 'Azure' implies it was created in Azure.
        /// 'External' implies it was created via the Operational Insights
        /// Portal. This value is set on the service side and read-only on the
        /// client side.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the ID associated with the workspace.  Setting this
        /// value at creation time allows the workspace being created to be
        /// linked to an existing workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerId")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the URL of the Operational Insights portal for this
        /// workspace.  This value is set on the service side and read-only on
        /// the client side.
        /// </summary>
        [JsonProperty(PropertyName = "properties.portalUrl")]
        public string PortalUrl { get; set; }

        /// <summary>
        /// Gets or sets the SKU of the workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the Features of the workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.features")]
        public Features Features { get; set; }

        /// <summary>
        /// Gets or sets the workspace data retention in days. -1 means
        /// Unlimited retention for the Unlimited Sku. 730 days is the maximum
        /// allowed for all other Skus.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionInDays")]
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the workspace.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (Features != null)
            {
                Features.Validate();
            }
            if (RetentionInDays > 730)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "RetentionInDays", 730);
            }
            if (RetentionInDays < -1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "RetentionInDays", -1);
            }
        }
    }
}
