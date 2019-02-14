// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Data Box Edge/Gateway device.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataBoxEdgeDevice : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the DataBoxEdgeDevice class.
        /// </summary>
        public DataBoxEdgeDevice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataBoxEdgeDevice class.
        /// </summary>
        /// <param name="location">The location of the device. This will be one
        /// of the supported and registered Azure Geo Regions (e.g. West US,
        /// East US, Southeast Asia, etc.). The geo region of a device cannot
        /// be changed once it is created, but if an identical geo region is
        /// specified on update the request will succeed.</param>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The name of the object.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="tags">The list of tags that describe the device. These
        /// tags can be used in viewing and grouping this device (across
        /// resource groups).</param>
        /// <param name="sku">The sku type.</param>
        /// <param name="etag">The etag of the devices.</param>
        /// <param name="dataBoxEdgeDeviceStatus">The status of the Data Box
        /// Edge/Gateway device. Possible values include: 'ReadyToSetup',
        /// 'Online', 'Offline', 'NeedsAttention', 'Disconnected',
        /// 'PartiallyDisconnected'</param>
        /// <param name="serialNumber">The Serial Number of Data Box
        /// Edge/Gateway device.</param>
        /// <param name="description">The Description of the Data Box
        /// Edge/Gateway device.</param>
        /// <param name="modelDescription">The description of the Data Box
        /// Edge/Gateway device model.</param>
        /// <param name="deviceType">The type of the Data Box Edge/Gateway
        /// device. Possible values include: 'DataBoxEdgeDevice'</param>
        /// <param name="friendlyName">The Data Box Edge/Gateway device
        /// name.</param>
        /// <param name="culture">The Data Box Edge/Gateway device
        /// culture.</param>
        /// <param name="deviceModel">The Data Box Edge/Gateway device
        /// model.</param>
        /// <param name="deviceSoftwareVersion">The Data Box Edge/Gateway
        /// device software version.</param>
        /// <param name="deviceLocalCapacity">The Data Box Edge/Gateway device
        /// local capacity in MB.</param>
        /// <param name="timeZone">The Data Box Edge/Gateway device
        /// timezone.</param>
        /// <param name="deviceHcsVersion">The device software version number
        /// of the device (eg: 1.2.18105.6).</param>
        /// <param name="configuredRoleTypes">Type of compute roles
        /// configured.</param>
        public DataBoxEdgeDevice(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), string etag = default(string), string dataBoxEdgeDeviceStatus = default(string), string serialNumber = default(string), string description = default(string), string modelDescription = default(string), string deviceType = default(string), string friendlyName = default(string), string culture = default(string), string deviceModel = default(string), string deviceSoftwareVersion = default(string), long? deviceLocalCapacity = default(long?), string timeZone = default(string), string deviceHcsVersion = default(string), IList<string> configuredRoleTypes = default(IList<string>))
            : base(id, name, type)
        {
            Location = location;
            Tags = tags;
            Sku = sku;
            Etag = etag;
            DataBoxEdgeDeviceStatus = dataBoxEdgeDeviceStatus;
            SerialNumber = serialNumber;
            Description = description;
            ModelDescription = modelDescription;
            DeviceType = deviceType;
            FriendlyName = friendlyName;
            Culture = culture;
            DeviceModel = deviceModel;
            DeviceSoftwareVersion = deviceSoftwareVersion;
            DeviceLocalCapacity = deviceLocalCapacity;
            TimeZone = timeZone;
            DeviceHcsVersion = deviceHcsVersion;
            ConfiguredRoleTypes = configuredRoleTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the device. This will be one of the
        /// supported and registered Azure Geo Regions (e.g. West US, East US,
        /// Southeast Asia, etc.). The geo region of a device cannot be changed
        /// once it is created, but if an identical geo region is specified on
        /// update the request will succeed.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the list of tags that describe the device. These tags
        /// can be used in viewing and grouping this device (across resource
        /// groups).
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the sku type.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the etag of the devices.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the status of the Data Box Edge/Gateway device.
        /// Possible values include: 'ReadyToSetup', 'Online', 'Offline',
        /// 'NeedsAttention', 'Disconnected', 'PartiallyDisconnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataBoxEdgeDeviceStatus")]
        public string DataBoxEdgeDeviceStatus { get; set; }

        /// <summary>
        /// Gets the Serial Number of Data Box Edge/Gateway device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serialNumber")]
        public string SerialNumber { get; private set; }

        /// <summary>
        /// Gets or sets the Description of the Data Box Edge/Gateway device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the description of the Data Box Edge/Gateway device
        /// model.
        /// </summary>
        [JsonProperty(PropertyName = "properties.modelDescription")]
        public string ModelDescription { get; set; }

        /// <summary>
        /// Gets the type of the Data Box Edge/Gateway device. Possible values
        /// include: 'DataBoxEdgeDevice'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceType")]
        public string DeviceType { get; private set; }

        /// <summary>
        /// Gets or sets the Data Box Edge/Gateway device name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets the Data Box Edge/Gateway device culture.
        /// </summary>
        [JsonProperty(PropertyName = "properties.culture")]
        public string Culture { get; private set; }

        /// <summary>
        /// Gets the Data Box Edge/Gateway device model.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceModel")]
        public string DeviceModel { get; private set; }

        /// <summary>
        /// Gets the Data Box Edge/Gateway device software version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceSoftwareVersion")]
        public string DeviceSoftwareVersion { get; private set; }

        /// <summary>
        /// Gets the Data Box Edge/Gateway device local capacity in MB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceLocalCapacity")]
        public long? DeviceLocalCapacity { get; private set; }

        /// <summary>
        /// Gets the Data Box Edge/Gateway device timezone.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeZone")]
        public string TimeZone { get; private set; }

        /// <summary>
        /// Gets the device software version number of the device (eg:
        /// 1.2.18105.6).
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceHcsVersion")]
        public string DeviceHcsVersion { get; private set; }

        /// <summary>
        /// Gets type of compute roles configured.
        /// </summary>
        [JsonProperty(PropertyName = "properties.configuredRoleTypes")]
        public IList<string> ConfiguredRoleTypes { get; private set; }

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
        }
    }
}
