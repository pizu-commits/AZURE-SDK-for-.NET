// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.CallingServer
{
    /// <summary> The CollectTonesResult. </summary>
    public partial class CollectTonesResult
    {
        /// <summary> Initializes a new instance of <see cref="CollectTonesResult"/>. </summary>
        internal CollectTonesResult()
        {
            Tones = new ChangeTrackingList<DtmfTone>();
        }

        /// <summary> Initializes a new instance of <see cref="CollectTonesResult"/>. </summary>
        /// <param name="tones"></param>
        internal CollectTonesResult(IReadOnlyList<DtmfTone> tones)
        {
            Tones = tones;
        }
    }
}
