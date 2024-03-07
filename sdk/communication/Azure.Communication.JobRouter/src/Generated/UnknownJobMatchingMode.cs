// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> Unknown version of JobMatchingMode. </summary>
    internal partial class UnknownJobMatchingMode : JobMatchingMode
    {
        /// <summary> Initializes a new instance of <see cref="UnknownJobMatchingMode"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of JobMatchingMode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownJobMatchingMode(JobMatchingModeKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownJobMatchingMode"/> for deserialization. </summary>
        internal UnknownJobMatchingMode()
        {
        }
    }
}
