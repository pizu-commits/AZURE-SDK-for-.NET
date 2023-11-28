// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Updates severity, ticket status, and contact details in the support ticket. </summary>
    public partial class UpdateSupportTicket
    {
        /// <summary> Initializes a new instance of <see cref="UpdateSupportTicket"/>. </summary>
        public UpdateSupportTicket()
        {
            SecondaryConsent = new ChangeTrackingList<SecondaryConsent>();
        }

        /// <summary> Severity level. </summary>
        public SupportSeverityLevel? Severity { get; set; }
        /// <summary> Status to be updated on the ticket. </summary>
        public SupportTicketStatus? Status { get; set; }
        /// <summary> Contact details to be updated on the support ticket. </summary>
        public SupportContactProfileContent ContactDetails { get; set; }
        /// <summary> Advanced diagnostic consent to be updated on the support ticket. </summary>
        public AdvancedDiagnosticConsent? AdvancedDiagnosticConsent { get; set; }
        /// <summary> This property indicates secondary consents for the support ticket. </summary>
        public IList<SecondaryConsent> SecondaryConsent { get; }
    }
}
