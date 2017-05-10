// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Recovery plan group details.
    /// </summary>
    public partial class RecoveryPlanGroup
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanGroup class.
        /// </summary>
        public RecoveryPlanGroup() { }

        /// <summary>
        /// Initializes a new instance of the RecoveryPlanGroup class.
        /// </summary>
        public RecoveryPlanGroup(RecoveryPlanGroupType groupType, IList<RecoveryPlanProtectedItem> replicationProtectedItems = default(IList<RecoveryPlanProtectedItem>), IList<RecoveryPlanAction> startGroupActions = default(IList<RecoveryPlanAction>), IList<RecoveryPlanAction> endGroupActions = default(IList<RecoveryPlanAction>))
        {
            GroupType = groupType;
            ReplicationProtectedItems = replicationProtectedItems;
            StartGroupActions = startGroupActions;
            EndGroupActions = endGroupActions;
        }

        /// <summary>
        /// The group type. Possible values include: 'Shutdown', 'Boot',
        /// 'Failover'
        /// </summary>
        [JsonProperty(PropertyName = "groupType")]
        public RecoveryPlanGroupType GroupType { get; set; }

        /// <summary>
        /// The list of protected items.
        /// </summary>
        [JsonProperty(PropertyName = "replicationProtectedItems")]
        public IList<RecoveryPlanProtectedItem> ReplicationProtectedItems { get; set; }

        /// <summary>
        /// The start group actions.
        /// </summary>
        [JsonProperty(PropertyName = "startGroupActions")]
        public IList<RecoveryPlanAction> StartGroupActions { get; set; }

        /// <summary>
        /// The end group actions.
        /// </summary>
        [JsonProperty(PropertyName = "endGroupActions")]
        public IList<RecoveryPlanAction> EndGroupActions { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.StartGroupActions != null)
            {
                foreach (var element in this.StartGroupActions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.EndGroupActions != null)
            {
                foreach (var element1 in this.EndGroupActions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
