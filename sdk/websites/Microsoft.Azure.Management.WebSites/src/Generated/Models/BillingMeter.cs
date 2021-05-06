// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> App Service billing entity that contains information about meter which the Azure billing system utilizes to charge users for services. </summary>
    public partial class BillingMeter : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of BillingMeter. </summary>
        public BillingMeter()
        {
        }

        /// <summary> Initializes a new instance of BillingMeter. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="meterId"> Meter GUID onboarded in Commerce. </param>
        /// <param name="billingLocation"> Azure Location of billable resource. </param>
        /// <param name="shortName"> Short Name from App Service Azure pricing Page. </param>
        /// <param name="friendlyName"> Friendly name of the meter. </param>
        /// <param name="resourceType"> App Service ResourceType meter used for. </param>
        /// <param name="osType"> App Service OS type meter used for. </param>
        /// <param name="multiplier"> Meter Multiplier. </param>
        internal BillingMeter(string id, string name, string kind, string type, string meterId, string billingLocation, string shortName, string friendlyName, string resourceType, string osType, double? multiplier) : base(id, name, kind, type)
        {
            MeterId = meterId;
            BillingLocation = billingLocation;
            ShortName = shortName;
            FriendlyName = friendlyName;
            ResourceType = resourceType;
            OsType = osType;
            Multiplier = multiplier;
        }

        /// <summary> Meter GUID onboarded in Commerce. </summary>
        public string MeterId { get; set; }
        /// <summary> Azure Location of billable resource. </summary>
        public string BillingLocation { get; set; }
        /// <summary> Short Name from App Service Azure pricing Page. </summary>
        public string ShortName { get; set; }
        /// <summary> Friendly name of the meter. </summary>
        public string FriendlyName { get; set; }
        /// <summary> App Service ResourceType meter used for. </summary>
        public string ResourceType { get; set; }
        /// <summary> App Service OS type meter used for. </summary>
        public string OsType { get; set; }
        /// <summary> Meter Multiplier. </summary>
        public double? Multiplier { get; set; }
    }
}
