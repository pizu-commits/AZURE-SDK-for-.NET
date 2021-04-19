// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Calculate exchange request properties
    /// </summary>
    public partial class CalculateExchangeRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CalculateExchangeRequestProperties class.
        /// </summary>
        public CalculateExchangeRequestProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CalculateExchangeRequestProperties class.
        /// </summary>
        /// <param name="reservationsToPurchase">List of reservations that are
        /// being purchased in this exchange.</param>
        /// <param name="reservationsToExchange">List of reservations that are
        /// being returned in this exchange.</param>
        public CalculateExchangeRequestProperties(IList<PurchaseRequest> reservationsToPurchase = default(IList<PurchaseRequest>), IList<ReservationToReturn> reservationsToExchange = default(IList<ReservationToReturn>))
        {
            ReservationsToPurchase = reservationsToPurchase;
            ReservationsToExchange = reservationsToExchange;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of reservations that are being purchased in this
        /// exchange.
        /// </summary>
        [JsonProperty(PropertyName = "reservationsToPurchase")]
        public IList<PurchaseRequest> ReservationsToPurchase { get; set; }

        /// <summary>
        /// Gets or sets list of reservations that are being returned in this
        /// exchange.
        /// </summary>
        [JsonProperty(PropertyName = "reservationsToExchange")]
        public IList<ReservationToReturn> ReservationsToExchange { get; set; }

    }
}
