// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes a matching mode where matching worker to a job is automatically started after job is queued successfully. </summary>
    public partial class QueueAndMatchMode : JobMatchingMode
    {
        /// <summary> Initializes a new instance of <see cref="QueueAndMatchMode"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of JobMatchingMode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueueAndMatchMode(JobMatchingModeKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, serializedAdditionalRawData)
        {
        }
    }
}
