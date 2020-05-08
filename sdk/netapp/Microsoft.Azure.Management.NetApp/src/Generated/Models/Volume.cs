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
    /// Volume resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Volume : IResource
    {
        /// <summary>
        /// Initializes a new instance of the Volume class.
        /// </summary>
        public Volume()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Volume class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="creationToken">Creation Token or File Path</param>
        /// <param name="usageThreshold">usageThreshold</param>
        /// <param name="subnetId">The Azure Resource URI for a delegated
        /// subnet. Must have the delegation Microsoft.NetApp/volumes</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="fileSystemId">FileSystem ID</param>
        /// <param name="serviceLevel">serviceLevel</param>
        /// <param name="exportPolicy">exportPolicy</param>
        /// <param name="protocolTypes">protocolTypes</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        /// <param name="snapshotId">Snapshot ID</param>
        /// <param name="baremetalTenantId">Baremetal Tenant ID</param>
        /// <param name="mountTargets">mountTargets</param>
        /// <param name="volumeType">What type of volume is this</param>
        /// <param name="dataProtection">DataProtection</param>
        /// <param name="isRestoring">Restoring</param>
        public Volume(string location, string creationToken, long usageThreshold, string subnetId, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string fileSystemId = default(string), string serviceLevel = default(string), VolumePropertiesExportPolicy exportPolicy = default(VolumePropertiesExportPolicy), IList<string> protocolTypes = default(IList<string>), string provisioningState = default(string), string snapshotId = default(string), string baremetalTenantId = default(string), IList<MountTargetProperties> mountTargets = default(IList<MountTargetProperties>), string volumeType = default(string), VolumePropertiesDataProtection dataProtection = default(VolumePropertiesDataProtection), bool? isRestoring = default(bool?))
        {
            Location = location;
            Id = id;
            Name = name;
            Type = type;
            Tags = tags;
            FileSystemId = fileSystemId;
            CreationToken = creationToken;
            ServiceLevel = serviceLevel;
            UsageThreshold = usageThreshold;
            ExportPolicy = exportPolicy;
            ProtocolTypes = protocolTypes;
            ProvisioningState = provisioningState;
            SnapshotId = snapshotId;
            BaremetalTenantId = baremetalTenantId;
            SubnetId = subnetId;
            MountTargets = mountTargets;
            VolumeType = volumeType;
            DataProtection = dataProtection;
            IsRestoring = isRestoring;
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
        /// Gets fileSystem ID
        /// </summary>
        /// <remarks>
        /// Unique FileSystem Identifier.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.fileSystemId")]
        public string FileSystemId { get; private set; }

        /// <summary>
        /// Gets or sets creation Token or File Path
        /// </summary>
        /// <remarks>
        /// A unique file path for the volume. Used when creating mount targets
        /// </remarks>
        [JsonProperty(PropertyName = "properties.creationToken")]
        public string CreationToken { get; set; }

        /// <summary>
        /// Gets or sets serviceLevel
        /// </summary>
        /// <remarks>
        /// The service level of the file system. Possible values include:
        /// 'Standard', 'Premium', 'Ultra'
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
        public long UsageThreshold { get; set; }

        /// <summary>
        /// Gets or sets exportPolicy
        /// </summary>
        /// <remarks>
        /// Set of export policy rules
        /// </remarks>
        [JsonProperty(PropertyName = "properties.exportPolicy")]
        public VolumePropertiesExportPolicy ExportPolicy { get; set; }

        /// <summary>
        /// Gets or sets protocolTypes
        /// </summary>
        /// <remarks>
        /// Set of protocol types
        /// </remarks>
        [JsonProperty(PropertyName = "properties.protocolTypes")]
        public IList<string> ProtocolTypes { get; set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets snapshot ID
        /// </summary>
        /// <remarks>
        /// UUID v4 or resource identifier used to identify the Snapshot.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.snapshotId")]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Gets baremetal Tenant ID
        /// </summary>
        /// <remarks>
        /// Unique Baremetal Tenant Identifier.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.baremetalTenantId")]
        public string BaremetalTenantId { get; private set; }

        /// <summary>
        /// Gets or sets the Azure Resource URI for a delegated subnet. Must
        /// have the delegation Microsoft.NetApp/volumes
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets mountTargets
        /// </summary>
        /// <remarks>
        /// List of mount targets
        /// </remarks>
        [JsonProperty(PropertyName = "properties.mountTargets")]
        public IList<MountTargetProperties> MountTargets { get; set; }

        /// <summary>
        /// Gets or sets what type of volume is this
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumeType")]
        public string VolumeType { get; set; }

        /// <summary>
        /// Gets or sets dataProtection
        /// </summary>
        /// <remarks>
        /// DataProtection type volumes include an object containing details of
        /// the replication
        /// </remarks>
        [JsonProperty(PropertyName = "properties.dataProtection")]
        public VolumePropertiesDataProtection DataProtection { get; set; }

        /// <summary>
        /// Gets or sets restoring
        /// </summary>
        [JsonProperty(PropertyName = "properties.isRestoring")]
        public bool? IsRestoring { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (CreationToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreationToken");
            }
            if (SubnetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubnetId");
            }
            if (FileSystemId != null)
            {
                if (FileSystemId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FileSystemId", 36);
                }
                if (FileSystemId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "FileSystemId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(FileSystemId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "FileSystemId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }
            if (CreationToken != null)
            {
                if (CreationToken.Length > 80)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "CreationToken", 80);
                }
                if (CreationToken.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "CreationToken", 1);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(CreationToken, "^[a-zA-Z][a-zA-Z0-9\\-]{0,79}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "CreationToken", "^[a-zA-Z][a-zA-Z0-9\\-]{0,79}$");
                }
            }
            if (UsageThreshold > 109951162777600)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "UsageThreshold", 109951162777600);
            }
            if (UsageThreshold < 107374182400)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "UsageThreshold", 107374182400);
            }
            if (SnapshotId != null)
            {
                if (SnapshotId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "SnapshotId", 36);
                }
                if (SnapshotId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SnapshotId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(SnapshotId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}|(\\\\?([^\\/]*[\\/])*)([^\\/]+)$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "SnapshotId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}|(\\\\?([^\\/]*[\\/])*)([^\\/]+)$");
                }
            }
            if (BaremetalTenantId != null)
            {
                if (BaremetalTenantId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "BaremetalTenantId", 36);
                }
                if (BaremetalTenantId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "BaremetalTenantId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(BaremetalTenantId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "BaremetalTenantId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }
            if (MountTargets != null)
            {
                foreach (var element in MountTargets)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (DataProtection != null)
            {
                DataProtection.Validate();
            }
        }
    }
}
