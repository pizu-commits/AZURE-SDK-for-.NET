// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> A rule that return the same labels as the input labels. </summary>
    public partial class DirectMapRouterRule : RouterRule
    {
        /// <summary> Initializes a new instance of <see cref="DirectMapRouterRule"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of RouterRule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DirectMapRouterRule(RouterRuleKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, serializedAdditionalRawData)
        {
        }
    }
}
