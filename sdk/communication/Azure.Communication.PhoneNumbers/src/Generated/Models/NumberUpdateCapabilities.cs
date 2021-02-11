// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers.Models
{
    /// <summary> Represents an individual number capabilities update request. </summary>
    public partial class NumberUpdateCapabilities
    {
        /// <summary> Initializes a new instance of NumberUpdateCapabilities. </summary>
        public NumberUpdateCapabilities()
        {
            Add = new ChangeTrackingList<PhoneNumberCapability>();
            Remove = new ChangeTrackingList<PhoneNumberCapability>();
        }

        /// <summary> Initializes a new instance of NumberUpdateCapabilities. </summary>
        /// <param name="add"> Capabilities to be added to a phone number. </param>
        /// <param name="remove"> Capabilities to be removed from a phone number. </param>
        internal NumberUpdateCapabilities(IList<PhoneNumberCapability> @add, IList<PhoneNumberCapability> @remove)
        {
            Add = @add;
            Remove = @remove;
        }

        /// <summary> Capabilities to be added to a phone number. </summary>
        public IList<PhoneNumberCapability> Add { get; }
        /// <summary> Capabilities to be removed from a phone number. </summary>
        public IList<PhoneNumberCapability> Remove { get; }
    }
}
