// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> User update parameters. </summary>
    public partial class ApiManagementUserPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementUserPatch"/>. </summary>
        public ApiManagementUserPatch()
        {
            Identities = new ChangeTrackingList<UserIdentityContract>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementUserPatch"/>. </summary>
        /// <param name="state"> Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active. </param>
        /// <param name="note"> Optional note about a user set by the administrator. </param>
        /// <param name="identities"> Collection of user identities. </param>
        /// <param name="email"> Email address. Must not be empty and must be unique within the service instance. </param>
        /// <param name="password"> User Password. </param>
        /// <param name="firstName"> First name. </param>
        /// <param name="lastName"> Last name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementUserPatch(ApiManagementUserState? state, string note, IList<UserIdentityContract> identities, string email, string password, string firstName, string lastName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            Note = note;
            Identities = identities;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
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
        /// <summary> User Password. </summary>
        public string Password { get; set; }
        /// <summary> First name. </summary>
        public string FirstName { get; set; }
        /// <summary> Last name. </summary>
        public string LastName { get; set; }
    }
}
