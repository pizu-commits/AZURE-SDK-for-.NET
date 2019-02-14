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
    /// Compute role.
    /// </summary>
    [Newtonsoft.Json.JsonObject("IOT")]
    [Rest.Serialization.JsonTransformation]
    public partial class IoTRole : Role
    {
        /// <summary>
        /// Initializes a new instance of the IoTRole class.
        /// </summary>
        public IoTRole()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IoTRole class.
        /// </summary>
        /// <param name="hostPlatform">Host OS which IoT role support. Possible
        /// values include: 'Windows', 'Linux'</param>
        /// <param name="ioTDeviceDetails">IoT device metadata to which data
        /// box edge device needs to be connected.</param>
        /// <param name="ioTEdgeDeviceDetails">IoT edge device to which the IoT
        /// role needs to be configured.</param>
        /// <param name="roleStatus">Role status. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The name of the object.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="shareMappings">Mount points of shares in
        /// role(s).</param>
        public IoTRole(string hostPlatform, IoTDeviceInfo ioTDeviceDetails, IoTDeviceInfo ioTEdgeDeviceDetails, string roleStatus, string id = default(string), string name = default(string), string type = default(string), IList<MountPointMap> shareMappings = default(IList<MountPointMap>))
            : base(id, name, type)
        {
            HostPlatform = hostPlatform;
            IoTDeviceDetails = ioTDeviceDetails;
            IoTEdgeDeviceDetails = ioTEdgeDeviceDetails;
            ShareMappings = shareMappings;
            RoleStatus = roleStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets host OS which IoT role support. Possible values
        /// include: 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostPlatform")]
        public string HostPlatform { get; set; }

        /// <summary>
        /// Gets or sets ioT device metadata to which data box edge device
        /// needs to be connected.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ioTDeviceDetails")]
        public IoTDeviceInfo IoTDeviceDetails { get; set; }

        /// <summary>
        /// Gets or sets ioT edge device to which the IoT role needs to be
        /// configured.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ioTEdgeDeviceDetails")]
        public IoTDeviceInfo IoTEdgeDeviceDetails { get; set; }

        /// <summary>
        /// Gets or sets mount points of shares in role(s).
        /// </summary>
        [JsonProperty(PropertyName = "properties.shareMappings")]
        public IList<MountPointMap> ShareMappings { get; set; }

        /// <summary>
        /// Gets or sets role status. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleStatus")]
        public string RoleStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HostPlatform == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostPlatform");
            }
            if (IoTDeviceDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IoTDeviceDetails");
            }
            if (IoTEdgeDeviceDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IoTEdgeDeviceDetails");
            }
            if (RoleStatus == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleStatus");
            }
            if (IoTDeviceDetails != null)
            {
                IoTDeviceDetails.Validate();
            }
            if (IoTEdgeDeviceDetails != null)
            {
                IoTEdgeDeviceDetails.Validate();
            }
            if (ShareMappings != null)
            {
                foreach (var element in ShareMappings)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
