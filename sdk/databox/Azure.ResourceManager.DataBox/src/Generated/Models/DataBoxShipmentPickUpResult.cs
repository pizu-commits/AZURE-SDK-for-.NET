// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Shipment pick up response. </summary>
    public partial class DataBoxShipmentPickUpResult
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxShipmentPickUpResult"/>. </summary>
        internal DataBoxShipmentPickUpResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxShipmentPickUpResult"/>. </summary>
        /// <param name="confirmationNumber"> Confirmation number for the pick up request. </param>
        /// <param name="readyBy"> Time by which shipment should be ready for pick up, this is in local time of pick up area. </param>
        internal DataBoxShipmentPickUpResult(string confirmationNumber, DateTimeOffset? readyBy)
        {
            ConfirmationNumber = confirmationNumber;
            ReadyBy = readyBy;
        }

        /// <summary> Confirmation number for the pick up request. </summary>
        public string ConfirmationNumber { get; }
        /// <summary> Time by which shipment should be ready for pick up, this is in local time of pick up area. </summary>
        public DateTimeOffset? ReadyBy { get; }
    }
}
