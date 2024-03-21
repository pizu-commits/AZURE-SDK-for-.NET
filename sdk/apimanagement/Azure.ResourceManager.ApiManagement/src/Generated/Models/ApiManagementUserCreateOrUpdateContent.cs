// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> User create details. </summary>
    public partial class ApiManagementUserCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="ApiManagementUserCreateOrUpdateContent"/>. </summary>
        public ApiManagementUserCreateOrUpdateContent()
        {
            Identities = new ChangeTrackingList<UserIdentityContract>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementUserCreateOrUpdateContent"/>. </summary>
        /// <param name="state"> Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active. </param>
        /// <param name="note"> Optional note about a user set by the administrator. </param>
        /// <param name="identities"> Collection of user identities. </param>
        /// <param name="email"> Email address. Must not be empty and must be unique within the service instance. </param>
        /// <param name="firstName"> First name. </param>
        /// <param name="lastName"> Last name. </param>
        /// <param name="password"> User Password. If no value is provided, a default password is generated. </param>
        /// <param name="appType"> Determines the type of application which send the create user request. Default is legacy portal. </param>
        /// <param name="confirmation"> Determines the type of confirmation e-mail that will be sent to the newly created user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementUserCreateOrUpdateContent(ApiManagementUserState? state, string note, IList<UserIdentityContract> identities, string email, string firstName, string lastName, string password, AppType? appType, ConfirmationEmailType? confirmation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            Note = note;
            Identities = identities;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            AppType = appType;
            Confirmation = confirmation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active. </summary>
        public ApiManagementUserState? State { get; set; }
        /// <summary> Optional note about a user set by the administrator. </summary>
        public string Note { get; set; }
        /// <summary> Collection of user identities. </summary>
        public IList<UserIdentityContract> Identities { get; }
        /// <summary> Email address. Must not be empty and must be unique within the service instance. </summary>
        public string Email { get; set; }
        /// <summary> First name. </summary>
        public string FirstName { get; set; }
        /// <summary> Last name. </summary>
        public string LastName { get; set; }
        /// <summary> User Password. If no value is provided, a default password is generated. </summary>
        public string Password { get; set; }
        /// <summary> Determines the type of application which send the create user request. Default is legacy portal. </summary>
        public AppType? AppType { get; set; }
        /// <summary> Determines the type of confirmation e-mail that will be sent to the newly created user. </summary>
        public ConfirmationEmailType? Confirmation { get; set; }
    }
}
