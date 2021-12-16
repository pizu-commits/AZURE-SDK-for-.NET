// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Volume patch resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VolumePatch : IResource
    {
        /// <summary>
        /// Initializes a new instance of the VolumePatch class.
        /// </summary>
        public VolumePatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VolumePatch class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="serviceLevel">serviceLevel</param>
        /// <param name="usageThreshold">usageThreshold</param>
        /// <param name="exportPolicy">exportPolicy</param>
        /// <param name="throughputMibps">Maximum throughput in Mibps that can
        /// be achieved by this volume and this will be accepted as input only
        /// for manual qosType volume</param>
        /// <param name="dataProtection">DataProtection</param>
        /// <param name="isDefaultQuotaEnabled">Specifies if default quota is
        /// enabled for the volume.</param>
        /// <param name="defaultUserQuotaInKiBs">Default user quota for volume
        /// in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4
        /// KiBs applies .</param>
        /// <param name="defaultGroupQuotaInKiBs">Default group quota for
        /// volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value
        /// of 4 KiBs applies.</param>
        public VolumePatch(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string serviceLevel = default(string), long? usageThreshold = default(long?), VolumePatchPropertiesExportPolicy exportPolicy = default(VolumePatchPropertiesExportPolicy), double? throughputMibps = default(double?), VolumePatchPropertiesDataProtection dataProtection = default(VolumePatchPropertiesDataProtection), bool? isDefaultQuotaEnabled = default(bool?), long? defaultUserQuotaInKiBs = default(long?), long? defaultGroupQuotaInKiBs = default(long?))
        {
            Location = location;
            Id = id;
            Name = name;
            Type = type;
            Tags = tags;
            ServiceLevel = serviceLevel;
            UsageThreshold = usageThreshold;
            ExportPolicy = exportPolicy;
            ThroughputMibps = throughputMibps;
            DataProtection = dataProtection;
            IsDefaultQuotaEnabled = isDefaultQuotaEnabled;
            DefaultUserQuotaInKiBs = defaultUserQuotaInKiBs;
            DefaultGroupQuotaInKiBs = defaultGroupQuotaInKiBs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets serviceLevel
        /// </summary>
        /// <remarks>
        /// Possible values include: 'Standard', 'Premium', 'Ultra',
        /// 'StandardZRS'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.serviceLevel")]
        public string ServiceLevel { get; set; }

        /// <summary>
        /// Gets or sets usageThreshold
        /// </summary>
        /// <remarks>
        /// Maximum storage quota allowed for a file system in bytes. This is a
        /// soft quota used for alerting only. Minimum size is 100 GiB. Upper
        /// limit is 100TiB. Specified in bytes.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.usageThreshold")]
        public long? UsageThreshold { get; set; }

        /// <summary>
        /// Gets or sets exportPolicy
        /// </summary>
        /// <remarks>
        /// Set of export policy rules
        /// </remarks>
        [JsonProperty(PropertyName = "properties.exportPolicy")]
        public VolumePatchPropertiesExportPolicy ExportPolicy { get; set; }

        /// <summary>
        /// Gets or sets maximum throughput in Mibps that can be achieved by
        /// this volume and this will be accepted as input only for manual
        /// qosType volume
        /// </summary>
        [JsonProperty(PropertyName = "properties.throughputMibps")]
        public double? ThroughputMibps { get; set; }

        /// <summary>
        /// Gets or sets dataProtection
        /// </summary>
        /// <remarks>
        /// DataProtection type volumes include an object containing details of
        /// the replication
        /// </remarks>
        [JsonProperty(PropertyName = "properties.dataProtection")]
        public VolumePatchPropertiesDataProtection DataProtection { get; set; }

        /// <summary>
        /// Gets or sets specifies if default quota is enabled for the volume.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDefaultQuotaEnabled")]
        public bool? IsDefaultQuotaEnabled { get; set; }

        /// <summary>
        /// Gets or sets default user quota for volume in KiBs. If
        /// isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies .
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultUserQuotaInKiBs")]
        public long? DefaultUserQuotaInKiBs { get; set; }

        /// <summary>
        /// Gets or sets default group quota for volume in KiBs. If
        /// isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultGroupQuotaInKiBs")]
        public long? DefaultGroupQuotaInKiBs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UsageThreshold != null)
            {
                if (UsageThreshold > 109951162777600)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "UsageThreshold", 109951162777600);
                }
                if (UsageThreshold < 107374182400)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "UsageThreshold", 107374182400);
                }
            }
        }
    }
}
