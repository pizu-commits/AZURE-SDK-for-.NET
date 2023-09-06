// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Support contact information and instructions. </summary>
    public partial class LabPlanSupportInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LabPlanSupportInfo"/>. </summary>
        public LabPlanSupportInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabPlanSupportInfo"/>. </summary>
        /// <param name="uri"> Support web address. </param>
        /// <param name="email"> Support contact email address. </param>
        /// <param name="phone"> Support contact phone number. </param>
        /// <param name="instructions"> Support instructions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LabPlanSupportInfo(Uri uri, string email, string phone, string instructions, Dictionary<string, BinaryData> rawData)
        {
            Uri = uri;
            Email = email;
            Phone = phone;
            Instructions = instructions;
            _rawData = rawData;
        }

        /// <summary> Support web address. </summary>
        public Uri Uri { get; set; }
        /// <summary> Support contact email address. </summary>
        public string Email { get; set; }
        /// <summary> Support contact phone number. </summary>
        public string Phone { get; set; }
        /// <summary> Support instructions. </summary>
        public string Instructions { get; set; }
    }
}
