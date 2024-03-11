// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Defines whether to send email notifications from Microsoft Defender for Cloud to persons with specific RBAC roles on the subscription. </summary>
    public partial class SecurityContactPropertiesNotificationsByRole
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityContactPropertiesNotificationsByRole"/>. </summary>
        public SecurityContactPropertiesNotificationsByRole()
        {
            Roles = new ChangeTrackingList<SecurityAlertReceivingRole>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityContactPropertiesNotificationsByRole"/>. </summary>
        /// <param name="state"> Defines whether to send email notifications from AMicrosoft Defender for Cloud to persons with specific RBAC roles on the subscription. </param>
        /// <param name="roles"> Defines which RBAC roles will get email notifications from Microsoft Defender for Cloud. List of allowed RBAC roles:. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityContactPropertiesNotificationsByRole(SecurityAlertNotificationByRoleState? state, IList<SecurityAlertReceivingRole> roles, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            Roles = roles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Defines whether to send email notifications from AMicrosoft Defender for Cloud to persons with specific RBAC roles on the subscription. </summary>
        public SecurityAlertNotificationByRoleState? State { get; set; }
        /// <summary> Defines which RBAC roles will get email notifications from Microsoft Defender for Cloud. List of allowed RBAC roles:. </summary>
        public IList<SecurityAlertReceivingRole> Roles { get; }
    }
}
